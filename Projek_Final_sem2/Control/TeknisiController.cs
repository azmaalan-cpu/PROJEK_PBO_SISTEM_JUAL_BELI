using System;
using System.Data;
using Npgsql;
using Projek_Final_sem2.Koneksi;
using Projek_Final_sem2.DAO;

namespace Projek_Final_sem2.Control
{
    public class TeknisiController
    {
        private readonly DatabaseHelper _db = new DatabaseHelper();
        private readonly ServiceDAO _serviceDao = new ServiceDAO();
        public DataTable GetLatestServis() => _serviceDao.DataServisTerbaruLengkap();
        public DataTable GetServisHistory() => _serviceDao.DataServisRiwayat();
        public DataTable GetUsersByRole(string role) => _serviceDao.GetUsersByRole(role);

        // Create a new servis entry. Performs basic business validation and delegates to DAO.
        public bool CreateServis(int idUser, string namaAlat, string kerusakan, decimal biayaServis, string sparepart)
        {
            // Business validations
            if (string.IsNullOrWhiteSpace(namaAlat))
                throw new ArgumentException("Nama alat harus diisi.", nameof(namaAlat));

            if (string.IsNullOrWhiteSpace(kerusakan))
                throw new ArgumentException("Kerusakan harus diisi.", nameof(kerusakan));

            if (biayaServis < 0)
                throw new ArgumentException("Biaya servis tidak boleh negatif.", nameof(biayaServis));

            try
            {
                return _serviceDao.CreateServis(idUser, namaAlat, kerusakan, biayaServis, sparepart);
            }
            catch (Exception ex)
            {
                // Re-throw as InvalidOperationException to make intent explicit; UI code can catch and display message.
                throw new InvalidOperationException("Gagal menyimpan data servis: " + ex.Message, ex);
            }
        }
    }
}
