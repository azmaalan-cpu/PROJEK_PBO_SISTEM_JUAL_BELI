using System;
using System.Data;
using Projek_Final_sem2.Koneksi;

namespace Projek_Final_sem2.DAO
{
    // Minimal TransaksiDAO to satisfy existing callers; implement real DB logic later.
    public class TransaksiDAO
    {
        private readonly DatabaseHelper _db = new DatabaseHelper();

        public int InsertTransaksi(int idUser, decimal totalHarga)
        {
            using (var conn = _db.GetConnection())
            {
                conn.Open();
                string sql = @"INSERT INTO transaksi (id_user, total_harga, tanggal) VALUES (@idUser, @totalHarga, CURRENT_TIMESTAMP)RETURNING id_transaksi";
                using (var cmd = new Npgsql.NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idUser", idUser);
                    cmd.Parameters.AddWithValue("@totalHarga", totalHarga);
                    object result = cmd.ExecuteScalar();
                    if (result == null || result == DBNull.Value)
                        return -1;
                    return Convert.ToInt32(result);
                }
            }
        }

        public int CekStok(int idAlat)
        {
            
            using (var conn = _db.GetConnection())
            {
                conn.Open();
                string sql = @"SELECT stok FROM alat_pertanian WHERE id_alat = @id";
                using (var cmd = new Npgsql.NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idAlat);
                    object result = cmd.ExecuteScalar();
                    if (result == null || result == DBNull.Value)
                        return 0;
                    return Convert.ToInt32(result);
                }
            }
        }

        public void InsertDetail(int idTransaksi, int idAlat, int jumlah, decimal subtotal)

        {
           using(var conn = _db.GetConnection())
            {
                conn.Open();
                string sql = @"INSERT INTO detail_transaksi (id_transaksi, id_alat, jumlah, subtotal) VALUES (@idTransaksi, @idAlat, @jumlah, @subtotal)";
                using (var cmd = new Npgsql.NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idTransaksi", idTransaksi);
                    cmd.Parameters.AddWithValue("@idAlat", idAlat);
                    cmd.Parameters.AddWithValue("@jumlah", jumlah);
                    cmd.Parameters.AddWithValue("@subtotal", subtotal);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void KurangiStok(int idAlat, int jumlah)
        {
            using(var conn = _db.GetConnection())
            {
                conn.Open();
                string sql = @"UPDATE alat_pertanian SET stok = stok - @jumlah WHERE id_alat = @id_Alat";
                using (var cmd = new Npgsql.NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@jumlah", jumlah);
                    cmd.Parameters.AddWithValue("@id_Alat", idAlat);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetDataGrafikPenjualan(DateTime awal, DateTime akhir)
        {
            DataTable dt = new DataTable();
            using (var conn = _db.GetConnection())
            {
                conn.Open();
                // Try to read aggregated penjualan per date from a view or function.
                // Expecting columns: tanggal, total_penjualan
                string sql = @"SELECT * FROM fn_grafik_penjualan(@awal::date, @akhir::date)";
                using (var cmd = new Npgsql.NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@awal", awal.Date);
                    cmd.Parameters.AddWithValue("@akhir", akhir.Date);
                    using (var adapter = new Npgsql.NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        // Wrapper for laporan penjualan used by admin control.
        public DataTable GetLaporanPenjualan(DateTime awal, DateTime akhir)
        {
            // For now delegate to GetDataGrafikPenjualan. Implement real query as needed.
            return GetDataGrafikPenjualan(awal, akhir);
        }
    }
}
