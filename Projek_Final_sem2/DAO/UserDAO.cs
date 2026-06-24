using Projek_Final_sem2.Koneksi;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Projek_Final_sem2.Models;

namespace Projek_Final_sem2.DAO
{
    public class UserDAO
    {
        private DatabaseHelper db = new DatabaseHelper();


        // CRUD USER
        // Tambah User
        // OOP pillars:
        // - Abstraction: (digunakan) menyederhanakan pembuatan user menjadi satu method
        // - Encapsulation: (digunakan) mapping model ke parameter disembunyikan
        // - Inheritance: (tidak digunakan)
        // - Polymorphism: (tidak digunakan)
        public void Insert(User user)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string sql = "call sp_tambah_user (@username, @password, @id_role)";
                using (var command = new Npgsql.NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@username", user.Username);
                    command.Parameters.AddWithValue("@password", user.Password);
                    command.Parameters.AddWithValue("@id_role", user.IdRole);
                    command.ExecuteNonQuery();
                }
            }
        }
        // Tampil data user
        // OOP pillars:
        // - Abstraction: (digunakan)
        // - Encapsulation: (digunakan)
        // - Inheritance: (tidak digunakan)
        // - Polymorphism: (tidak digunakan)
        public DataTable GettAll()
        {
            DataTable dt = new DataTable();
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string sql = @"SELECT u.id_user,u.username,u.password,u.id_role,r.nama_role FROM users u JOIN roles r ON u.id_role = r.id_role";
                using (var adapter = new Npgsql.NpgsqlDataAdapter(sql, connection))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        // Edit user
        // OOP pillars:
        // - Abstraction: (digunakan)
        // - Encapsulation: (digunakan)
        // - Inheritance: (tidak digunakan)
        // - Polymorphism: (tidak digunakan)
        public void Update(User user)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string sql = "call sp_update_user(@id_user, @username, @password, @id_role)";
                using (var command = new Npgsql.NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@username", user.Username);
                    command.Parameters.AddWithValue("@password", user.Password);
                    command.Parameters.AddWithValue("@id_role", user.IdRole);
                    command.Parameters.AddWithValue("@id_user", user.IdUser);
                    command.ExecuteNonQuery();
                }
            }
        }
        // Hapus user
        // OOP pillars:
        // - Abstraction: (digunakan)
        // - Encapsulation: (digunakan)
        // - Inheritance: (tidak digunakan)
        // - Polymorphism: (tidak digunakan)
        public void Delete(int idUser)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string sql = "call sp_hapus_user(@id_user)";
                using (var command = new Npgsql.NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id_user", idUser);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
