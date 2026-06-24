using Projek_Final_sem2.Koneksi;
using System;
using System.Collections.Generic;
using System.Text;
using Projek_Final_sem2.Models;

namespace Projek_Final_sem2.DAO
{
    public class KategoriDAO
    {
        private DatabaseHelper db = new DatabaseHelper();

        // Ambil semua kategori sebagai list model
        // OOP pillars:
        // - Abstraction: (digunakan)
        // - Encapsulation: (digunakan)
        // - Inheritance: (tidak digunakan)
        // - Polymorphism: (tidak digunakan)
        public List<Kategori> GetAllKategori()
        {
            List<Kategori> kategori = new List<Kategori>();
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string sql = "SELECT * FROM kategori_alat";
                using (var command = new Npgsql.NpgsqlCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            kategori.Add(new Kategori()
                            {
                                IdKategori = Convert.ToInt32(reader["id_kategori"]),
                                NamaKategori = reader["nama_kategori"].ToString(),
                            });
                        }
                    }
                }
            }
            return kategori;
        }
    }
}
