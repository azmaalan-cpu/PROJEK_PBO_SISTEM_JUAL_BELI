using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using System.Data;
using Projek_Final_sem2.Koneksi;

namespace Projek_Final_sem2.DAO
{   
    public class BarangDAO
    {
        // Field encapsulation: helper koneksi privat
        // OOP pillars: Encapsulation (digunakan)
        private DatabaseHelper db = new DatabaseHelper();

        // Ambil semua barang (DataTable)
        // OOP pillars:
        // - Abstraction: (digunakan) menyajikan DataTable siap pakai untuk UI
        // - Encapsulation: (digunakan) detail query dan adapter tersembunyi
        // - Inheritance: (tidak digunakan)
        // - Polymorphism: (tidak digunakan)
        public DataTable GetAllBarang()
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string sql = "SELECT * from v_data_barang;";
                using (var da = new NpgsqlDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }


        // Cari barang berdasarkan ID
        // OOP pillars:
        // - Abstraction: (digunakan) menyediakan cara mudah untuk mencari barang tanpa mengekspos SQL
        // - Encapsulation: (digunakan) parameter dan eksekusi query dibungkus di sini
        // - Inheritance: (tidak digunakan)
        // - Polymorphism: (tidak digunakan)
        public DataTable CariBarangById(int idBarang)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string sql = @"
                select * from fn_get_data_barang_by_id(@id_alat);";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id_alat", idBarang);

                    using (var da = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

    }
}
