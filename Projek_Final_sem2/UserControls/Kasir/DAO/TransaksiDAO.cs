using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using System.Data;
using Projek_Final_sem2.Koneksi;

namespace Projek_Final_sem2.UserControls.Kasir.DAO
{
    public class TransaksiDAO
    {
        private DatabaseHelper db = new DatabaseHelper();

        public bool InsertTransaksi(int idUser, int idAlat, int jumlah)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string sql = @"
                     INSERT INTO transaksi
                    (
                        id_alat,
                        tanggal,
                        id_user,
                        jumlah
                    )
                        VALUES
                    (
                        @id_alat,
                        @tanggal,
                        @id_user,
                        @jumlah
                    )";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id_alat", idAlat);
                    cmd.Parameters.AddWithValue("@tanggal", DateTime.Now);
                    cmd.Parameters.AddWithValue("@id_user", idUser);
                    cmd.Parameters.AddWithValue("@jumlah", jumlah);

                    return cmd.ExecuteNonQuery() > 0;
                }

            }
        }
        public void KurangiStok(int idAlat, int jumlah)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string sql = @"
                UPDATE alat_pertanian
                SET stok = stok - @jumlah
                WHERE id_alat = @id_alat";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@jumlah",
                         jumlah);

                    cmd.Parameters.AddWithValue("@id_alat",
                        idAlat);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public int CekStok(int idAlat)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string sql = @"
                    SELECT stok 
                    FROM alat_pertanian
                    WHERE id_alat = @id_alat";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id_alat", idAlat);

                    object result = cmd.ExecuteScalar();

                    if (result == null)
                        return 0;

                    return Convert.ToInt32(result);
                }
            }
        }

        public DataTable GetDataTransaksi()
        {

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string sql = @"
                SELECT
                t.id_transaksi,
                t.tanggal,
                u.username,
                a.id_alat,
                a.nama_alat,
                a.harga,
                t.jumlah,
                    (a.harga * t.jumlah) AS subtotal
                FROM transaksi t
                INNER JOIN alat_pertanian a
                    ON t.id_alat = a.id_alat
                INNER JOIN users u
                    ON t.id_user = u.id_user
                ORDER BY t.id_transaksi DESC";

                using (var da = new NpgsqlDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }

        }

        public DataTable GetDataBarang()
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string sql = @"
                SELECT id_alat, nama_alat, harga, stok
                FROM alat_pertanian
                ORDER BY id_alat";
                using (var da = new NpgsqlDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public int GetTotalSemuaBarangTerjual()
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT COALESCE(SUM(jumlah), 0) 
                    FROM transaksi";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {   
                   
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
    }
}
