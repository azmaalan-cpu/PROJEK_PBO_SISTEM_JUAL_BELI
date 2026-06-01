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


        //CRUD USER
        //TAMBAH USER
        public void Insert(User user)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string sql = "INSERT INTO users (username, password, id_role) VALUES (@username, @password, @id_role)";
                using (var command = new Npgsql.NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@username", user.Username);
                    command.Parameters.AddWithValue("@password", user.Password);
                    command.Parameters.AddWithValue("@id_role", user.IdRole);
                    command.ExecuteNonQuery();
                }
            }
        }
        //TAMPIL DATA USER
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

        //EDIT USER
        public void Update(User user)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string sql = "UPDATE users SET username = @username, password = @password, id_role = @id_role WHERE id_user = @id_user";
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
        //HAPUS USER
        public void Delete(int idUser)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string sql = "DELETE FROM users WHERE id_user = @id_user";
                using (var command = new Npgsql.NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id_user", idUser);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
