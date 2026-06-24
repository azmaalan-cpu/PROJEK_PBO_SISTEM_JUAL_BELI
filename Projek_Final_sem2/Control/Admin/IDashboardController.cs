using System;
using System.Data;

namespace Projek_Final_sem2.Control.Admin
{
    public interface IDashboardController
    {
        decimal GetTotalPenjualan(DateTime awal, DateTime akhir);
        decimal GetTotalServis(DateTime awal, DateTime akhir);
        DataTable GetRecentTransactions(int limit = 10);
        DashboardMetrics LoadDashboardMetrics(DateTime? awal = null, DateTime? akhir = null, int recentLimit = 10);
        int GetTotalBarang();
        decimal GetPendapatanPenjualan();
        DataTable GetBarangStokMenipis();
    }
}
