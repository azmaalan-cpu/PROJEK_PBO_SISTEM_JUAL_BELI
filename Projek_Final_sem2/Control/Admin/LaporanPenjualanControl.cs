using System;
using System.Data;
using System.Linq;
using Projek_Final_sem2.DAO;

namespace Projek_Final_sem2.Control.Admin
{
    public class LaporanPenjualanControl
    {
        // Field encapsulation: menyimpan TransaksiDAO sebagai field privat — menunjukkan prinsip Encapsulation
        // OOP pillars: Encapsulation (digunakan, dikonfirmasi)
        private readonly TransaksiDAO _transaksiDao = new TransaksiDAO();

        // Ambil laporan penjualan sebagai DataTable
        // OOP pillars: Abstraction, Encapsulation (digunakan, dikonfirmasi)
        public DataTable GetLaporanPenjualan(DateTime awal, DateTime akhir)
        {
            // assuming TransaksiDAO has a method to get laporan penjualan; adapt as needed
            return _transaksiDao.GetLaporanPenjualan(awal, akhir);
        }

        // Prepare data untuk plotting (dipanggil oleh UI)
        // OOP pillars: Abstraction, Encapsulation (digunakan, dikonfirmasi)
        public (double[] values, string[] labels, double[] positions, decimal total) BtnTampilkan_Click(DateTime awal, DateTime akhir)
        {
            var dt = GetLaporanPenjualan(awal, akhir);

            double[] values = dt.AsEnumerable().Select(r => Convert.ToDouble(r["total"])).ToArray();
            string[] labels = dt.AsEnumerable().Select(r => Convert.ToDateTime(r["tanggal"]).ToString("dd/MM/yyyy")).ToArray();
            double[] positions = Enumerable.Range(0, labels.Length).Select(x => (double)x).ToArray();
            decimal total = dt.AsEnumerable().Sum(r => Convert.ToDecimal(r["total"]));
            return (values, labels, positions, total);
        }
    }
}
