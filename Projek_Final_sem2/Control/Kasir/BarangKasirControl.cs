using System.Data;
using Projek_Final_sem2.DAO;

namespace Projek_Final_sem2.Control.Kasir
{
    public class BarangKasirControl
    {
        // Field encapsulation: DAO disimpan sebagai field privat
        // OOP pillars: Encapsulation (digunakan)
        private readonly BarangDAO _barangDao = new BarangDAO();
        private readonly DashboardTransaksiKasirDAO _transaksiDao = new DashboardTransaksiKasirDAO();

        // Ambil semua barang
        // OOP pillars: Abstraction, Encapsulation
        public DataTable GetAllBarang() => _barangDao.GetAllBarang();

        // Cari barang berdasarkan id
        // OOP pillars: Abstraction, Encapsulation
        public DataTable CariBarangById(int id) => _barangDao.CariBarangById(id);

        // Ambil data barang untuk kasir
        // OOP pillars: Abstraction, Encapsulation
        public DataTable GetDataBarang() => _transaksiDao.GetDataBarang();
    }
}
