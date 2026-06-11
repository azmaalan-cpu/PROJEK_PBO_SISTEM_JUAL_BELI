using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using System.Data;
using Projek_Final_sem2.Koneksi;
using System.Security.Cryptography.X509Certificates;

namespace Projek_Final_sem2.UserControls.Kasir.DAO
{
    public class TransaksiDAO
    {
        private DatabaseHelper db = new DatabaseHelper();

        public int InsertTransaksi(int idUser, decimal totalHarga)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string sql = @"
            INSERT INTO transaksi
            (
                id_user,
                total_harga
                
            )
            VALUES
            (
                @id_user,
                @total_harga
            )
            RETURNING id_transaksi";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id_user", idUser);
                    cmd.Parameters.AddWithValue("@total_harga", totalHarga);

                    object result = cmd.ExecuteScalar();
                    if (result == null)
                    {
                        return -1;

                       
                    }
                    return Convert.ToInt32(result);
                }
            }
        }
        public void InsertDetail(int idTransaksi, int idAlat, int jumlah, decimal subtotal)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string sql = @"
                INSERT INTO detail_transaksi
                (
                    id_transaksi,
                    id_alat,
                    jumlah,
                    subtotal
                )
                VALUES
                (
                    @id_transaksi,
                    @id_alat,
                    @jumlah,
                    @subtotal
                )";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id_transaksi",
                        idTransaksi);

                    cmd.Parameters.AddWithValue("@id_alat",
                        idAlat);

                    cmd.Parameters.AddWithValue("@jumlah",
                        jumlah);

                    cmd.Parameters.AddWithValue("@subtotal",
                        subtotal);

                    cmd.ExecuteNonQuery();
                }
            }

        }
        public void KurangiStok(int idAlat,int jumlah)
        {
            using (var conn = db.GetConnection()) 
            {
                conn.Open();

                string sql = @"
                UPDATE alat_pertanian
                SET stok = stok - @jumlah
                WHERE id_alat = @id_alat";

                using(var cmd = new NpgsqlCommand(sql, conn))
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

    }
}
