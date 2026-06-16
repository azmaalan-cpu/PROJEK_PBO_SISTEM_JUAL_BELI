using System;
using Projek_Final_sem2.Examples.OOPExample.DAO;
using Npgsql;
using System.Data;

namespace Projek_Final_sem2.Examples.OOPExample.DAO
{
    public class TransaksiDAO : BaseDAO, ITransaksiDAO
    {
        public int InsertTransaksi(int idUser, decimal totalHarga)
        {
            string sql = @"INSERT INTO transaksi (tanggal,id_user, total_harga) VALUES ( CURRENT_DATE, @id_user, @total_harga) RETURNING id_transaksi";
            var result = ExecuteScalar(sql, cmd =>
            {
                cmd.Parameters.AddWithValue("@id_user", idUser);
                cmd.Parameters.AddWithValue("@total_harga", totalHarga);
            });

            return result == null ? -1 : Convert.ToInt32(result);
        }

        public void InsertDetail(int idTransaksi, int idAlat, int jumlah, decimal subtotal)
        {
            string sql = @"INSERT INTO detail_transaksi (id_transaksi, id_alat, jumlah, subtotal) VALUES (@id_transaksi, @id_alat, @jumlah, @subtotal)";
            ExecuteNonQuery(sql, cmd =>
            {
                cmd.Parameters.AddWithValue("@id_transaksi", idTransaksi);
                cmd.Parameters.AddWithValue("@id_alat", idAlat);
                cmd.Parameters.AddWithValue("@jumlah", jumlah);
                cmd.Parameters.AddWithValue("@subtotal", subtotal);
            });
        }

        public int CekStok(int idAlat)
        {
            string sql = @"SELECT stok FROM alat_pertanian WHERE id_alat = @id_alat";
            var result = ExecuteScalar(sql, cmd => cmd.Parameters.AddWithValue("@id_alat", idAlat));
            return result == null ? 0 : Convert.ToInt32(result);
        }

        public void KurangiStok(int idAlat, int jumlah)
        {
            string sql = @"UPDATE alat_pertanian SET stok = stok - @jumlah WHERE id_alat = @id_alat";
            ExecuteNonQuery(sql, cmd =>
            {
                cmd.Parameters.AddWithValue("@jumlah", jumlah);
                cmd.Parameters.AddWithValue("@id_alat", idAlat);
            });
        }

        public DataTable GetDataGrafikPenjualan(DateTime tanggalawal, DateTime tanggalakhir)
        {
            DataTable dt = new DataTable();
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string sql = @"SELECT t.tanggal, SUM(dt.subtotal) AS total_penjualan
                         FROM transaksi t
                         JOIN detail_transaksi dt ON t.id_transaksi = dt.id_transaksi
                         WHERE t.tanggal BETWEEN @tanggalawal AND @tanggalakhir
                         GROUP BY t.tanggal
                         ORDER BY t.tanggal";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@tanggalawal", tanggalawal.Date);
                    cmd.Parameters.AddWithValue("@tanggalakhir", tanggalakhir.Date);
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }
    }
}
