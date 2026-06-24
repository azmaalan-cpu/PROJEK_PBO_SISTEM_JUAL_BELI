using System;
using System.Data;
using Projek_Final_sem2.DAO;
using Projek_Final_sem2.Models;

namespace Projek_Final_sem2.Control.Admin
{
    // Controller untuk dashboard Admin: kumpulkan metrik dan data ringkasan
    // Metode asli tetap dipertahankan untuk kompatibilitas.
    // Tambahan metode dengan nama Bahasa Indonesia disediakan agar mudah dibaca.
    public class DashboardControl : IDashboardController
    {
        private readonly DashboardAdminDAO _adminDao = new DashboardAdminDAO();
        private readonly DashboardTransaksiKasirDAO _transaksiDao = new DashboardTransaksiKasirDAO();
        private readonly Projek_Final_sem2.DAO.ServiceDAO _serviceDao = new Projek_Final_sem2.DAO.ServiceDAO();
        private readonly UserDAO _userDao = new UserDAO();
        private readonly AlatDAO _alatDao = new AlatDAO();
        // Total penjualan di rentang tanggal (metode asli)
        public decimal GetTotalPenjualan(DateTime awal, DateTime akhir)
        {
            try
            {
                // DashboardTransaksiKasirDAO does not expose a date-filtered total in current implementation.
                // Use DashboardAdminDAO's GetTotalPenjualan which returns an int (summary), convert to decimal.
                var val = _adminDao.GetTotalPenjualan();
                return Convert.ToDecimal(val);
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
                // DashboardAdminDAO exposes GetTotalServis returning int; convert to decimal.
                var val = _adminDao.GetTotalServis();
                return Convert.ToDecimal(val);
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
                // Use available transaksi DAO to fetch transactions and return up to 'limit' rows.
                var dt = _transaksiDao.GetTransaksiPenjualan() ?? new DataTable();
                if (limit <= 0 || dt.Rows.Count <= limit) return dt;
                var top = dt.Clone();
                for (int i = 0; i < Math.Min(limit, dt.Rows.Count); i++) top.ImportRow(dt.Rows[i]);
                return top;
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
                TotalPenjualan = GetTotalPenjualan(from, to),
                TotalServis = GetTotalServis(from, to),
                RecentTransactions = GetRecentTransactions(recentLimit)
            };
        }

        // Additional wrappers to expose other DashboardAdminDAO helpers
        public int GetTotalBarang()
        {
            try { return _adminDao.GetTotalBarang(); }
            catch { return 0; }
        }

        public decimal GetPendapatanPenjualan()
        {
            try { return _adminDao.GetPendapatanPenjualan(); }
            catch { return 0m; }
        }

        public DataTable GetBarangStokMenipis()
        {
            try { return _adminDao.GetBarangStokMenipis(); }
            catch { return new DataTable(); }
        }

        // service related helper
        public DataTable GetDashboardServis()
        {
            try { return _serviceDao.DgvDashboardServisAdmin(); }
            catch { return new DataTable(); }
        }

        // Alias Bahasa Indonesia: Muat metrik dashboard
        public DashboardMetrics MuatMetrikDashboard(DateTime? awal = null, DateTime? akhir = null, int recentLimit = 10) => LoadDashboardMetrics(awal, akhir, recentLimit);

        // User management wrappers (calls into UserDAO)
        public DataTable GetAllUsers()
        {
            try { return _userDao.GettAll(); }
            catch { return new DataTable(); }
        }

        public void InsertUser(User user)
        {
            try { _userDao.Insert(user); }
            catch { }
        }

        public void UpdateUser(User user)
        {
            try { _userDao.Update(user); }
            catch { }
        }

        public void DeleteUser(int idUser)
        {
            try { _userDao.Delete(idUser); }
            catch { }
        }

        // Alat management wrappers (calls into AlatDAO)
        public DataTable GetAllAlat()
        {
            try { return _alatDao.GetAll(); }
            catch { return new DataTable(); }
        }

        public void InsertAlat(Alat alat)
        {
            try { _alatDao.Insert(alat); }
            catch { }
        }

        public void UpdateAlat(Alat alat)
        {
            try { _alatDao.Update(alat); }
            catch { }
        }

        public void DeleteAlat(int idAlat)
        {
            try { _alatDao.Delete(idAlat); }
            catch { }
        }

        // Reflection helpers removed: calling DAOs directly for strong typing and clarity.
    }

    // DTO sederhana untuk menampung metrik dashboard
    public class DashboardMetrics
    {
        public decimal TotalPenjualan { get; set; }
        public decimal TotalServis { get; set; }
        public DataTable RecentTransactions { get; set; } = new DataTable();
    }
}
