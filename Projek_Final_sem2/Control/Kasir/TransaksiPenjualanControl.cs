using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace Projek_Final_sem2.Control.Kasir
{
    // Controller ringan untuk transaksi penjualan (kasir)
    // Bertanggung jawab untuk: memuat daftar barang, mengelola keranjang sementara, menghitung total,
    // dan memanggil DAO untuk menyimpan transaksi.
    public class TransaksiPenjualanControl
    {
        private readonly object? _barangDao;
        private readonly object? _transaksiDao;
        private readonly List<CartItem> _cart = new();

        public TransaksiPenjualanControl()
        {
            _barangDao = CreateIfExists("BarangDAO");
            _transaksiDao = CreateIfExists("TransaksiDAO");
        }

        // Ambil semua produk untuk ditampilkan (DataTable)
        // OOP pillars:
        // - Abstraction: (digunakan) menyediakan DataTable siap pakai
        // - Encapsulation: (digunakan) pencarian method DAO dan pemanggilan dibungkus
        // - Inheritance: (tidak digunakan)
        // - Polymorphism: (digunakan) method mencoba beberapa nama method DAO yang berbeda
        public DataTable LoadProducts()
        {
            if (_barangDao == null) return new DataTable();
            var type = _barangDao.GetType();
            var m = type.GetMethod("GetAll") ?? type.GetMethod("GetAllProducts") ?? type.GetMethod("Get") ?? type.GetMethod("GetAllBarang");
            if (m == null) return new DataTable();
            try
            {
                var res = m.Invoke(_barangDao, null);
                if (res is DataTable dt) return dt;
                if (res is System.Collections.IEnumerable ie) return EnumerableToDataTable(ie);
            }
            catch { }
            return new DataTable();
        }

        // Tambah item ke keranjang
        // OOP pillars:
        // - Abstraction: (digunakan)
        // - Encapsulation: (digunakan)
        // - Inheritance: (tidak digunakan)
        // - Polymorphism: (tidak digunakan)
        public bool AddToCart(int productId, int quantity)
        {
            if (quantity <= 0) return false;
            // try to get product details from DAO
            var product = GetProductById(productId);
            if (product is not (string name, decimal price)) return false;
            var existing = _cart.FirstOrDefault(c => c.ProductId == productId);
            if (existing != null)
            {
                existing.Quantity += quantity;
                return true;
            }
            _cart.Add(new CartItem { ProductId = productId, Name = name, Price = price, Quantity = quantity });
            return true;
        }

        // Hapus item dari keranjang
        // OOP pillars: Abstraction, Encapsulation
        public bool RemoveFromCart(int productId)
        {
            var existing = _cart.FirstOrDefault(c => c.ProductId == productId);
            if (existing == null) return false;
            _cart.Remove(existing);
            return true;
        }

        // Kembalikan representasi DataTable dari keranjang
        // OOP pillars: Abstraction, Encapsulation
        public DataTable GetCartTable()
        {
            var dt = new DataTable();
            dt.Columns.Add("product_id", typeof(int));
            dt.Columns.Add("name", typeof(string));
            dt.Columns.Add("price", typeof(decimal));
            dt.Columns.Add("quantity", typeof(int));
            dt.Columns.Add("subtotal", typeof(decimal));
            foreach (var c in _cart)
            {
                dt.Rows.Add(c.ProductId, c.Name, c.Price, c.Quantity, c.Price * c.Quantity);
            }
            return dt;
        }

        // Hitung total keranjang
        // OOP pillars: Abstraction, Encapsulation
        public decimal GetTotal() => _cart.Sum(c => c.Price * c.Quantity);

        // Finalize transaksi: bangun model/argumen dan panggil DAO
        // OOP pillars:
        // - Abstraction: (digunakan) menyederhanakan proses finalize menjadi satu method
        // - Encapsulation: (digunakan) pembuatan model dan mapping dibungkus
        // - Inheritance: (tidak digunakan)
        // - Polymorphism: (digunakan) mencoba banyak signature method pada DAO
        public bool FinalizeTransaction(string cashier, string? note = null)
        {
            if (_cart.Count == 0) return false;
            try
            {
                if (_transaksiDao == null) return false;
                var type = _transaksiDao.GetType();
                // Try common method names: CreateTransaction, Insert, Add
                var m = type.GetMethod("CreateTransaction") ?? type.GetMethod("Insert") ?? type.GetMethod("Add") ?? type.GetMethod("Save");
                if (m == null) return false;
                var p = m.GetParameters();
                object? res;
                if (p.Length == 1)
                {
                    var modelType = p[0].ParameterType;
                    var model = Activator.CreateInstance(modelType);
                    if (model == null) return false;
                    // try set properties: cashier, note, total, items
                    SetIfExists(model, "cashier", cashier);
                    SetIfExists(model, "note", note ?? string.Empty);
                    SetIfExists(model, "total", GetTotal());
                    // build items list as simple anonymous objects or array of models if possible
                    var itemsProp = modelType.GetProperty("items") ?? modelType.GetProperty("Items") ?? modelType.GetProperty("Detail") ?? null;
                    if (itemsProp != null)
                    {
                        // create list of simple item models if element type known
                        var itemType = itemsProp.PropertyType.IsArray ? itemsProp.PropertyType.GetElementType() : itemsProp.PropertyType.IsGenericType ? itemsProp.PropertyType.GetGenericArguments().FirstOrDefault() : null;
                        if (itemType != null)
                        {
                            // buat list generik secara aman
                            var listType = typeof(List<>).MakeGenericType(itemType);
                            var listObj = Activator.CreateInstance(listType);
                            if (listObj is System.Collections.IList list)
                            {
                                foreach (var c in _cart)
                                {
                                    var itemModel = Activator.CreateInstance(itemType);
                                    if (itemModel == null) continue;
                                    SetIfExists(itemModel, "product_id", c.ProductId);
                                    SetIfExists(itemModel, "quantity", c.Quantity);
                                    SetIfExists(itemModel, "price", c.Price);
                                    list.Add(itemModel);
                                }
                                // convert list to array if needed
                                object toAssign = list;
                                if (itemsProp.PropertyType.IsArray)
                                {
                                    var arr = Array.CreateInstance(itemType, list.Count);
                                    list.CopyTo(arr, 0);
                                    toAssign = arr;
                                }
                                itemsProp.SetValue(model, toAssign);
                            }
                        }
                    }
                    res = m.Invoke(_transaksiDao, new object[] { model });
                }
                else
                {
                    // try passing primitive parameters: cashier, total, items (as DataTable)
                    var itemsTable = GetCartTable();
                    var args = p.Select(pr => MapParameterForFinalize(pr.ParameterType, cashier, GetTotal(), itemsTable)).ToArray();
                    res = m.Invoke(_transaksiDao, args);
                }
                var ok = InterpretResult(res);
                if (ok) _cart.Clear();
                return ok;
            }
            catch { return false; }
        }

        // --- helpers ---
        // Map parameter secara heuristik untuk memanggil method DAO yang berbeda-beda
        // OOP pillars: Polymorphism (digunakan), Abstraction
        private static object MapParameterForFinalize(Type paramType, string cashier, decimal total, DataTable itemsTable)
        {
            if (paramType == typeof(string)) return cashier;
            if (paramType == typeof(decimal)) return total;
            if (paramType == typeof(int)) return Convert.ToInt32(total);
            if (paramType == typeof(DataTable)) return itemsTable;
            if (paramType.IsAssignableFrom(typeof(DataTable))) return itemsTable;
            return null;
        }

        // Interpret hasil pemanggilan DAO menjadi boolean sukses/gagal
        // OOP pillars: Abstraction, Encapsulation
        private static bool InterpretResult(object? res)
        {
            if (res == null) return false;
            if (res is bool b) return b;
            if (res is int i) return i > 0;
            if (res is long l) return l > 0;
            return true;
        }

        // Dapatkan nama dan harga produk melalui DAO (berbagai fallback)
        // OOP pillars: Abstraction, Encapsulation, Polymorphism (mencoba tipe hasil berbeda)
        private (string, decimal)? GetProductById(int id)
        {
            if (_barangDao == null) return null;
            var type = _barangDao.GetType();
            var m = type.GetMethod("GetById") ?? type.GetMethod("Find") ?? type.GetMethod("Get") ?? null;
            if (m == null) return null;
            try
            {
                var res = m.Invoke(_barangDao, new object[] { id });
                if (res == null) return null;
                if (res is DataTable dt && dt.Rows.Count > 0)
                {
                    var row = dt.Rows[0];
                    var name = row.Table.Columns.Contains("name") ? row["name"].ToString() ?? string.Empty : row[0].ToString() ?? string.Empty;
                    var priceCol = row.Table.Columns.Contains("price") ? row["price"] : row.Table.Columns.Contains("harga") ? row["harga"] : null;
                    var price = priceCol != null ? Convert.ToDecimal(priceCol) : 0m;
                    return (name, price);
                }
                // if returned an object model
                var props = res.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
                var nameProp = props.FirstOrDefault(p => string.Equals(p.Name, "name", StringComparison.OrdinalIgnoreCase) || string.Equals(p.Name, "nama", StringComparison.OrdinalIgnoreCase));
                var priceProp = props.FirstOrDefault(p => string.Equals(p.Name, "price", StringComparison.OrdinalIgnoreCase) || string.Equals(p.Name, "harga", StringComparison.OrdinalIgnoreCase));
                var nameVal = nameProp != null ? nameProp.GetValue(res)?.ToString() ?? string.Empty : string.Empty;
                var priceVal = priceProp != null ? Convert.ToDecimal(priceProp.GetValue(res) ?? 0m) : 0m;
                return (nameVal, priceVal);
            }
            catch { return null; }
        }

        // Buat instance tipe jika ada di assembly (fallback dynamic)
        // OOP pillars: Polymorphism, Abstraction
        private static object? CreateIfExists(string typeName)
        {
            try
            {
                var asm = Assembly.GetEntryAssembly() ?? Assembly.GetExecutingAssembly();
                var t = asm.GetTypes().FirstOrDefault(x => string.Equals(x.Name, typeName, StringComparison.OrdinalIgnoreCase));
                if (t == null) return null;
                return Activator.CreateInstance(t);
            }
            catch { return null; }
        }

        // Set property pada model jika ada, aman terhadap tipe
        // OOP pillars: Encapsulation, Polymorphism
        private static void SetIfExists(object model, string propName, object? value)
        {
            if (model == null) return;
            var prop = model.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance)
                        .FirstOrDefault(p => string.Equals(p.Name, propName, StringComparison.OrdinalIgnoreCase));
            if (prop == null) return;
            try { prop.SetValue(model, Convert.ChangeType(value, prop.PropertyType)); }
            catch { try { prop.SetValue(model, value); } catch { } }
        }

        // Konversi enumerable ke DataTable (digunakan saat DAO mengembalikan IEnumerable)
        // OOP pillars: Abstraction, Encapsulation
        private static DataTable EnumerableToDataTable(System.Collections.IEnumerable items)
        {
            var dt = new DataTable();
            var en = items.GetEnumerator();
            if (!en.MoveNext()) return dt;
            var first = en.Current;
            if (first == null) return dt;
            var props = first.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var p in props) dt.Columns.Add(p.Name, Nullable.GetUnderlyingType(p.PropertyType) ?? p.PropertyType);
            void AddRow(object item)
            {
                var values = props.Select(p => p.GetValue(item) ?? DBNull.Value).ToArray();
                dt.Rows.Add(values);
            }
            AddRow(first);
            while (en.MoveNext()) AddRow(en.Current);
            return dt;
        }

        private class CartItem
        {
            public int ProductId { get; set; }
            public string Name { get; set; } = string.Empty;
            public decimal Price { get; set; }
            public int Quantity { get; set; }
        }
    }
}
