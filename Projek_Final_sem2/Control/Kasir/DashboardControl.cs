using System;
using System.Data;
using System.Linq;
using System.Reflection;

namespace Projek_Final_sem2.Control.Kasir
{
    // Controller ringan untuk metrik dashboard kasir.
    // Menggunakan reflection untuk memanggil DAO yang tersedia (DashboardTransaksiKasirDAO / TransaksiDAO)
    public class DashboardControl
    {
        private readonly object _dashboardDao;
        private readonly object _transaksiDao;

        public DashboardControl()
        {
            _dashboardDao = CreateIfExists("DashboardTransaksiKasirDAO");
            _transaksiDao = CreateIfExists("TransaksiDAO");
        }

        // Dapatkan total penjualan dalam rentang tanggal (mulai - sampai)
        // OOP pillars: Abstraction, Encapsulation
        public decimal DapatkanTotalPenjualan(DateTime? mulai = null, DateTime? sampai = null)
        {
            var args = new object[] { mulai ?? DateTime.MinValue, sampai ?? DateTime.MaxValue };
            var candidate = InvokeDecimalDao(_dashboardDao, new[] { "GetTotalPenjualan", "GetTotalSales", "TotalPenjualan" }, args);
            if (candidate.HasValue) return candidate.Value;
            candidate = InvokeDecimalDao(_transaksiDao, new[] { "GetTotalPenjualan", "GetTotalSales", "TotalSales" }, args);
            return candidate ?? 0m;
        }

        // Dapatkan jumlah total transaksi
        // OOP pillars: Abstraction, Encapsulation
        public int DapatkanTotalTransaksi()
        {
            var candidate = InvokeIntDao(_dashboardDao, new[] { "GetTotalTransaksi", "GetTotalTransactions", "CountTransactions" }, null);
            if (candidate.HasValue) return candidate.Value;
            candidate = InvokeIntDao(_transaksiDao, new[] { "GetCount", "Count", "GetTotal" }, null);
            return candidate ?? 0;
        }

        // Dapatkan daftar transaksi terbaru (limit default 10)
        // OOP pillars: Abstraction, Encapsulation
        public DataTable DapatkanTransaksiTerbaru(int limit = 10)
        {
            var dt = InvokeDataTableDao(_dashboardDao, new[] { "GetRecentTransactions", "GetRecent", "GetLatestTransactions" }, new object[] { limit });
            if (dt != null && dt.Rows.Count > 0) return dt;
            dt = InvokeDataTableDao(_transaksiDao, new[] { "GetRecentTransactions", "GetRecent", "GetLatest" }, new object[] { limit });
            return dt ?? new DataTable();
        }

        // --- helpers ---
        private static object? CreateIfExists(string typeName)
        {
            try
            {
                var asm = Assembly.GetEntryAssembly() ?? Assembly.GetExecutingAssembly();
                var t = asm.GetTypes().FirstOrDefault(x => string.Equals(x.Name, typeName, StringComparison.OrdinalIgnoreCase));
                if (t == null) return null;
                return Activator.CreateInstance(t);
            }
            catch
            {
                return null;
            }
        }

        private static decimal? InvokeDecimalDao(object? dao, string[] methodNames, object[]? args)
        {
            if (dao == null) return null;
            var type = dao.GetType();
            foreach (var name in methodNames)
            {
                var m = type.GetMethod(name);
                if (m == null) continue;
                try
                {
                    var res = m.Invoke(dao, args);
                    if (res == null) continue;
                    if (res is decimal d) return d;
                    if (res is double db) return Convert.ToDecimal(db);
                    if (res is float f) return Convert.ToDecimal(f);
                    if (res is int i) return Convert.ToDecimal(i);
                    if (decimal.TryParse(res.ToString(), out var parsed)) return parsed;
                }
                catch { }
            }
            return null;
        }

        private static int? InvokeIntDao(object? dao, string[] methodNames, object[]? args)
        {
            if (dao == null) return null;
            var type = dao.GetType();
            foreach (var name in methodNames)
            {
                var m = type.GetMethod(name);
                if (m == null) continue;
                try
                {
                    var res = m.Invoke(dao, args);
                    if (res == null) continue;
                    if (res is int i) return i;
                    if (res is long l) return Convert.ToInt32(l);
                    if (int.TryParse(res.ToString(), out var parsed)) return parsed;
                }
                catch { }
            }
            return null;
        }

        private static DataTable? InvokeDataTableDao(object? dao, string[] methodNames, object[]? args)
        {
            if (dao == null) return null;
            var type = dao.GetType();
            foreach (var name in methodNames)
            {
                var m = type.GetMethod(name);
                if (m == null) continue;
                try
                {
                    var res = m.Invoke(dao, args);
                    if (res is DataTable dt) { NormalizeDataTableDates(dt); return dt; }
                    if (res is System.Collections.IEnumerable ie) { var ndt = EnumerableToDataTable(ie); NormalizeDataTableDates(ndt); return ndt; }
                }
                catch { }
            }
            return null;
        }

        private static DataTable EnumerableToDataTable(System.Collections.IEnumerable items)
        {
            var dt = new DataTable();
            var en = items.GetEnumerator();
            if (!en.MoveNext()) return dt;
            var first = en.Current;
            if (first == null) return dt;
            var props = first.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var p in props)
            {
                var propType = Nullable.GetUnderlyingType(p.PropertyType) ?? p.PropertyType;
                // Map System.DateOnly to DateTime in DataTable
                if (propType.FullName == "System.DateOnly") propType = typeof(DateTime);
                dt.Columns.Add(p.Name, propType);
            }
            void AddRow(object item)
            {
                var values = props.Select(p =>
                {
                    var v = p.GetValue(item);
                    if (v == null) return DBNull.Value;
                    var t = Nullable.GetUnderlyingType(p.PropertyType) ?? p.PropertyType;
                    if (t.FullName == "System.DateOnly")
                    {
                        // convert DateOnly to DateTime at midnight
                        var dateOnly = (dynamic)v; // DateOnly
                        return dateOnly.ToDateTime(System.TimeOnly.MinValue);
                    }
                    return v;
                }).ToArray();
                dt.Rows.Add(values);
            }
            AddRow(first);
            while (en.MoveNext()) AddRow(en.Current);
            return dt;
        }

        // Normalize DataTable columns/values: convert DateOnly columns/values to DateTime
        private static void NormalizeDataTableDates(DataTable dt)
        {
            if (dt == null) return;
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                var col = dt.Columns[i];
                if (col.DataType.FullName == "System.DateOnly")
                {
                    // replace column with DateTime type
                    var newCol = new DataColumn(col.ColumnName + "__tmp", typeof(DateTime));
                    dt.Columns.Add(newCol);
                    foreach (DataRow row in dt.Rows)
                    {
                        var v = row[col.ColumnName];
                        if (v == DBNull.Value || v == null) row[newCol.ColumnName] = DBNull.Value;
                        else
                        {
                            try { var dateOnly = (dynamic)v; row[newCol.ColumnName] = dateOnly.ToDateTime(System.TimeOnly.MinValue); }
                            catch { row[newCol.ColumnName] = DBNull.Value; }
                        }
                    }
                    // remove old column and rename new
                    var oldName = col.ColumnName;
                    dt.Columns.Remove(oldName);
                    newCol.ColumnName = oldName;
                }
                else
                {
                    // Also handle values that are DateOnly even if column type is object
                    if (col.DataType == typeof(object))
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            var v = row[col];
                            if (v == DBNull.Value || v == null) continue;
                            var vt = v.GetType();
                            if (vt.FullName == "System.DateOnly")
                            {
                                try { var dateOnly = (dynamic)v; row[col] = dateOnly.ToDateTime(System.TimeOnly.MinValue); }
                                catch { row[col] = DBNull.Value; }
                            }
                        }
                    }
                }
            }
        }
    }
}
