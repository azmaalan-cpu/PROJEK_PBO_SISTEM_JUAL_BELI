using System;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Collections;
using Projek_Final_sem2.DAO;

namespace Projek_Final_sem2.Control.Admin
{
    // Controller untuk dashboard Admin: kumpulkan metrik dan data ringkasan
    // Metode asli tetap dipertahankan untuk kompatibilitas.
    // Tambahan metode dengan nama Bahasa Indonesia disediakan agar mudah dibaca.
    public class DashboardControl
    {
        private readonly object _adminDao = new DashboardAdminDAO();
        private readonly object _transaksiDao = new DashboardTransaksiKasirDAO();
        private readonly object _serviceDao = new Projek_Final_sem2.DAO.ServiceDAO();

        // Total user terdaftar (metode asli)
        public int GetTotalUsers()
        {
            try
            {
                // coba beberapa nama metode yang mungkin ada di DAO
                var candidates = new[] { "CountUsers", "GetTotalUsers", "GetUsersCount", "Get", "Count" };
                return InvokeIntDao(_adminDao, candidates);
            }
            catch
            {
                return 0;
            }
        }

        // Alias Bahasa Indonesia: Hitung total user
        public int HitungTotalUser() => GetTotalUsers();

        // Total penjualan di rentang tanggal (metode asli)
        public decimal GetTotalPenjualan(DateTime awal, DateTime akhir)
        {
            try
            {
                var candidates = new[] { "GetTotalPenjualan", "SumPenjualan", "GetTotalSales", "GetTotalTransaksi", "Sum" };
                return InvokeDecimalDao(_transaksiDao, candidates, awal, akhir);
            }
            catch
            {
                return 0m;
            }
        }

        // Alias Bahasa Indonesia: Hitung total penjualan
        public decimal HitungTotalPenjualan(DateTime awal, DateTime akhir) => GetTotalPenjualan(awal, akhir);

        // Total pendapatan servis di rentang tanggal (metode asli)
        public decimal GetTotalServis(DateTime awal, DateTime akhir)
        {
            try
            {
                var candidates = new[] { "GetTotalServis", "SumServis", "GetTotalService", "GetTotalServcie", "Sum" };
                return InvokeDecimalDao(_adminDao, candidates, awal, akhir);
            }
            catch
            {
                return 0m;
            }
        }

        // Alias Bahasa Indonesia: Hitung total servis
        public decimal HitungTotalServis(DateTime awal, DateTime akhir) => GetTotalServis(awal, akhir);

        // Ambil transaksi terbaru untuk ditampilkan di dashboard (metode asli)
        public DataTable GetRecentTransactions(int limit = 10)
        {
            try
            {
                var candidates = new[] { "GetRecentTransactions", "GetRecent", "GetLatestTransactions", "GetRecentTx", "GetRecentOrders" };
                return InvokeDataTableDao(_transaksiDao, candidates, limit);
            }
            catch
            {
                return new DataTable();
            }
        }

        // Alias Bahasa Indonesia: Ambil transaksi terbaru
        public DataTable AmbilTransaksiTerbaru(int limit = 10) => GetRecentTransactions(limit);

        // Load semua metrik sekaligus (metode asli)
        public DashboardMetrics LoadDashboardMetrics(DateTime? awal = null, DateTime? akhir = null, int recentLimit = 10)
        {
            var from = awal ?? DateTime.Today;
            var to = akhir ?? DateTime.Today;
            return new DashboardMetrics
            {
                TotalUsers = GetTotalUsers(),
                TotalPenjualan = GetTotalPenjualan(from, to),
                TotalServis = GetTotalServis(from, to),
                RecentTransactions = GetRecentTransactions(recentLimit)
            };
        }

        // Additional wrappers to expose other DashboardAdminDAO helpers
        public int GetTotalBarang()
        {
            try { return InvokeIntDao(_adminDao, new[] { "GetTotalBarang", "GetTotalItems", "GetTotalAlat", "CountBarang" }); }
            catch { return 0; }
        }

        public decimal GetPendapatanPenjualan()
        {
            try { return InvokeDecimalDao(_adminDao, new[] { "GetPendapatanPenjualan", "GetPendapatan", "GetPendapatanPenjualan", "GetPendapatanPenjualan" }); }
            catch { return 0m; }
        }

        public DataTable GetBarangStokMenipis()
        {
            try { return InvokeDataTableDao(_adminDao, new[] { "GetBarangStokMenipis", "GetBarangStokMenipis", "GetBarangStokMenipis", "GetBarangStokMenipis" }); }
            catch { return new DataTable(); }
        }

        // service related helper
        public DataTable GetDashboardServis()
        {
            try { return InvokeDataTableDao(_serviceDao, new[] { "DgvDashboardServisAdmin", "GetGrafikServis", "GetDashboardServis", "GetServisDashboard" }); }
            catch { return new DataTable(); }
        }

        // Alias Bahasa Indonesia: Muat metrik dashboard
        public DashboardMetrics MuatMetrikDashboard(DateTime? awal = null, DateTime? akhir = null, int recentLimit = 10) => LoadDashboardMetrics(awal, akhir, recentLimit);

        // --- Helper reflection untuk memanggil DAO ---
        private static int InvokeIntDao(object dao, string[] candidates)
        {
            foreach (var name in candidates)
            {
                var m = dao.GetType().GetMethod(name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                if (m == null) continue;
                var res = m.Invoke(dao, null);
                if (res == null) continue;
                try { return Convert.ToInt32(res); } catch { continue; }
            }
            return 0;
        }

        private static decimal InvokeDecimalDao(object dao, string[] candidates, params object[] args)
        {
            foreach (var name in candidates)
            {
                var methods = dao.GetType().GetMethods().Where(x => string.Equals(x.Name, name, StringComparison.OrdinalIgnoreCase));
                foreach (var m in methods)
                {
                    try
                    {
                        var res = m.Invoke(dao, args.Length == 0 ? null : args);
                        if (res == null) continue;
                        return Convert.ToDecimal(res);
                    }
                    catch { continue; }
                }
            }
            return 0m;
        }

        private static DataTable InvokeDataTableDao(object dao, string[] candidates, params object[] args)
        {
            foreach (var name in candidates)
            {
                var methods = dao.GetType().GetMethods().Where(x => string.Equals(x.Name, name, StringComparison.OrdinalIgnoreCase));
                foreach (var m in methods)
                {
                    try
                    {
                        var res = m.Invoke(dao, args.Length == 0 ? null : args);
                        if (res == null) continue;
                        if (res is DataTable dt) return dt;
                        if (res is IEnumerable ie) return EnumerableToDataTable(ie);
                    }
                    catch { continue; }
                }
            }
            return new DataTable();
        }

        private static DataTable EnumerableToDataTable(IEnumerable items)
        {
            var dt = new DataTable();
            var enumerator = items.GetEnumerator();
            if (!enumerator.MoveNext()) return dt;
            var first = enumerator.Current;
            if (first == null) return dt;
            var props = first.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var p in props) dt.Columns.Add(p.Name, Nullable.GetUnderlyingType(p.PropertyType) ?? p.PropertyType);
            void AddRow(object item)
            {
                var values = props.Select(p => p.GetValue(item) ?? DBNull.Value).ToArray();
                dt.Rows.Add(values);
            }
            AddRow(first);
            while (enumerator.MoveNext()) AddRow(enumerator.Current);
            return dt;
        }
    }

    // DTO sederhana untuk menampung metrik dashboard
    public class DashboardMetrics
    {
        public int TotalUsers { get; set; }
        public decimal TotalPenjualan { get; set; }
        public decimal TotalServis { get; set; }
        public DataTable RecentTransactions { get; set; } = new DataTable();
    }
}
