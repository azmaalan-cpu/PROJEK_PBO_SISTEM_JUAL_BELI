using System.Data;
using Projek_Final_sem2.DAO;

namespace Projek_Final_sem2.Services
{
    public class TransaksiService
    {
        private readonly TransaksiDAO _transaksiDao = new TransaksiDAO();

        public bool InsertTransaksi(int idUser, int idAlat, int jumlah) => _transaksiDao.InsertTransaksi(idUser, idAlat, jumlah);
        public void KurangiStok(int idAlat, int jumlah) => _transaksiDao.KurangiStok(idAlat, jumlah);
        public int CekStok(int idAlat) => _transaksiDao.CekStok(idAlat);
        public DataTable GetDataBarang() => _transaksiDao.GetDataBarang();
        public decimal GetTotalPendapatan() => _transaksiDao.GetTotalPendapatan();
        public int GetTotalBarangTerjual() => _transaksiDao.GetTotalBarangTerjual();
        public int GetTotalTransaksi() => _transaksiDao.GetTotalTransaksi();
        public DataTable GetInformasiTransaksi() => _transaksiDao.GetInformasiTransaksi();
        public DataTable GetTransaksiPenjualan() => _transaksiDao.GetTransaksiPenjualan();
    }
}
