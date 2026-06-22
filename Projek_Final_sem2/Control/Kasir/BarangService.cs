using System.Data;
using Projek_Final_sem2.DAO;

namespace Projek_Final_sem2.Control.Kasir
{
    public class BarangService
    {
        private readonly BarangDAO _barangDao = new BarangDAO();
        private readonly DashboardTransaksiKasirDAO _transaksiDao = new DashboardTransaksiKasirDAO();

        public DataTable GetAllBarang() => _barangDao.GetAllBarang();

        public DataTable CariBarangById(int id) => _barangDao.CariBarangById(id);

        public DataTable GetDataBarang() => _transaksiDao.GetDataBarang();
    }
}
