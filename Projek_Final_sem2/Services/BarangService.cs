using System.Data;
using Projek_Final_sem2.DAO;

namespace Projek_Final_sem2.Services
{
    public class BarangService
    {
        private readonly BarangDAO _barangDao = new BarangDAO();
        private readonly TransaksiDAO _transaksiDao = new TransaksiDAO();

        public DataTable GetAllBarang() => _barangDao.GetAllBarang();

        public DataTable CariBarangById(int id) => _barangDao.CariBarangById(id);

        public DataTable GetDataBarang() => _transaksiDao.GetDataBarang();
    }
}
