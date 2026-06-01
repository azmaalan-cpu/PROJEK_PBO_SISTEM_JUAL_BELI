using Projek_Final_sem2.Koneksi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Projek_Final_sem2.Models;

namespace Projek_Final_sem2.DAO
{
    public class AlatDAO
    {
        private DatabaseHelper db = new DatabaseHelper();

        //READ ALAT
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string sql = @"SELECT a.id_alat, a.nama_alat, k.nama_kategori, a.harga, a.stok, s.nama_supplier FROM alat_pertanian a JOIN kategori_alat k ON a.id_kategori = k.id_kategori JOIN supplier s ON a.id_supplier = s.id_supplier";
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
                string sql = "INSERT INTO alat_pertanian (nama_alat,harga, stok, id_kategori, id_supplier) VALUES (@nama_alat, @harga, @stok, @id_kategori, @id_supplier)";
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
                string sql = @"UPDATE alat_pertanian SET nama_alat = @nama_alat, harga = @harga, stok = @stok, id_kategori = @id_kategori, id_supplier = @id_supplier WHERE id_alat = @id_alat";
                using (var command = new Npgsql.NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@nama_alat", alat.NamaAlat);
                    command.Parameters.AddWithValue("@harga", alat.Harga);
                    command.Parameters.AddWithValue("@stok", alat.Stok);
                    command.Parameters.AddWithValue("@id_kategori", alat.IdKategori);
                    command.Parameters.AddWithValue("@id_supplier", alat.IdSupplier);
                    command.Parameters.AddWithValue("@id_alat", alat.IdAlat);
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
    }
}
