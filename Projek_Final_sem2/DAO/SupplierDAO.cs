using System;
using System.Collections.Generic;
using System.Text;
using Projek_Final_sem2.Models;
using Projek_Final_sem2.Koneksi;

namespace Projek_Final_sem2.DAO
{
    public class SupplierDAO
    {
       private DatabaseHelper db = new DatabaseHelper();
        public List<Supplier> GetAllSupplier()
        {
            List<Supplier> suppliers = new List<Supplier>();
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string sql = "SELECT * FROM supplier";
                using (var command = new Npgsql.NpgsqlCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            suppliers.Add(new Supplier()
                            {
                                IdSupplier = Convert.ToInt32(reader["id_supplier"]),
                                NamaSupplier = reader["nama_supplier"].ToString(),

                            });
                        }
                    }
                }
            }
            return suppliers;
        }
    }
}
