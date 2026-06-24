using Projek_Final_sem2.Koneksi;
using Projek_Final_sem2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projek_Final_sem2.DAO
{
    public class RoleDAO
    {
        private DatabaseHelper db = new DatabaseHelper();

        // Ambil semua role sebagai list model
        // OOP pillars: Abstraction, Encapsulation
        public List<Role> GetAllRole()
        {
            List<Role> roles = new List<Role>();
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string sql = "SELECT * FROM roles";
                using (var command = new Npgsql.NpgsqlCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            roles.Add(new Role()
                            {
                                IdRole = Convert.ToInt32(reader["id_role"]),
                                NamaRole = reader["nama_role"].ToString()
                            });

                        }
                    }

                    return roles;
                }
            }
        }
    }
}
