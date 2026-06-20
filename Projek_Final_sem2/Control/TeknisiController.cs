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

        public bool CreateServis(int idUser, string namaAlat, string kerusakan, decimal biayaServis, string sparepart)
        {
            if (string.IsNullOrWhiteSpace(namaAlat))
                throw new ArgumentException("Nama alat harus diisi", nameof(namaAlat));

            if (string.IsNullOrWhiteSpace(kerusakan))
                throw new ArgumentException("Kerusakan harus diisi", nameof(kerusakan));

            if (biayaServis < 0)
                throw new ArgumentException("Biaya servis tidak valid", nameof(biayaServis));

            using (var conn = _db.GetConnection())
            {
                conn.Open();

                string sql = "call sp_tambah_servis(@id_user, @nama_alat, @kerusakan, @biaya_servis, @sparepart)";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id_user", idUser);
                    cmd.Parameters.AddWithValue("@nama_alat", namaAlat);
                    cmd.Parameters.AddWithValue("@kerusakan", kerusakan);
                    cmd.Parameters.AddWithValue("@biaya_servis", biayaServis);
                    cmd.Parameters.AddWithValue("@sparepart", sparepart);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }
        public DataTable GetLatestServis() => _serviceDao.DataServisTerbaruLengkap();

        public DataTable GetServisHistory() => _serviceDao.DataServisRiwayat();
    }
}
