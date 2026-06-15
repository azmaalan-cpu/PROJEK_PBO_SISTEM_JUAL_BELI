using Projek_Final_sem2.Koneksi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Projek_Final_sem2.Models;
using Npgsql;   

namespace Projek_Final_sem2.DAO
{
    public class AlatDAO
    {
        private DatabaseHelper db = new DatabaseHelper();

        public void KurangiStok(int idAlat, int jumlah)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string sql = @"UPDATE alat_pertanian SET stok = stok - @jumlah WHERE id_alat = @id_alat";
                using (var command = new Npgsql.NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@jumlah", jumlah);
                    command.Parameters.AddWithValue("@id_alat", idAlat);
                    command.ExecuteNonQuery();
                }
            }
        }
        //READ ALAT
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string sql = @"select * from v_data_barang";
                using (var adapter = new Npgsql.NpgsqlDataAdapter(sql, connection))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        //Tambah Alat
        public void Insert(Models.Alat alat)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string sql = "Call sp_tambah_alat(@nama_alat, @harga, @stok, @id_kategori, @id_supplier)";
                using (var command = new Npgsql.NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@nama_alat", alat.NamaAlat);
                    command.Parameters.AddWithValue("@harga", alat.Harga);
                    command.Parameters.AddWithValue("@stok", alat.Stok);
                    command.Parameters.AddWithValue("@id_kategori", alat.IdKategori);
                    command.Parameters.AddWithValue("@id_supplier", alat.IdSupplier);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Update Alat
        public void Update(Alat alat)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string sql = @"CALL sp_update_alat(@id_alat, @nama_alat, @harga, @stok, @id_kategori, @id_supplier)";
                using (var command = new Npgsql.NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id_alat", alat.IdAlat);
                    command.Parameters.AddWithValue("@nama_alat", alat.NamaAlat);
                    command.Parameters.AddWithValue("@harga", alat.Harga);
                    command.Parameters.AddWithValue("@stok", alat.Stok);
                    command.Parameters.AddWithValue("@id_kategori", alat.IdKategori);
                    command.Parameters.AddWithValue("@id_supplier", alat.IdSupplier);
                    command.ExecuteNonQuery();
                }
            }
        }

        //Delete Alat
        public void Delete(int idAlat)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string sql = "DELETE FROM alat_pertanian WHERE id_alat = @id_alat";
                using (var command = new Npgsql.NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id_alat", idAlat);
                    command.ExecuteNonQuery();
                }
            }
        }
        public DataTable DashboardDataBarang()
        {
            DataTable dt = new DataTable();
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string sql = "select * from v_jumlah_data_barang";
                using (var adapter = new Npgsql.NpgsqlDataAdapter(sql, connection))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
        public void LoadStatistik()
        {
            using (var connection = new DatabaseHelper().GetConnection())
            {
                connection.Open();
                string sql = @"
                    SELECT
                    (SELECT COUNT(*) FROM alat_pertanian) AS total_items,
                    (SELECT COUNT(*) FROM transaksi)    AS total_transaksi,
                    (SELECT COUNT(*) FROM servis)       AS total_servis,
                    COALESCE((SELECT SUM(total_harga)   FROM transaksi), 0) AS revenue_transaksi,
                    COALESCE((SELECT SUM(biaya_servis)  FROM servis),      0) AS revenue_servis,
                    COALESCE((SELECT SUM(total_harga)   FROM transaksi), 0)
                    + COALESCE((SELECT SUM(biaya_servis) FROM servis),     0) AS total_revenue;;";
                NpgsqlCommand command = new NpgsqlCommand(sql, connection);
                NpgsqlDataReader reader = command.ExecuteReader();
            }
        }
    }
}
