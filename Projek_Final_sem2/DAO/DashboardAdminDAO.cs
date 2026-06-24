using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using System.Data;
using Projek_Final_sem2.Koneksi;

namespace Projek_Final_sem2.DAO
{
    public class DashboardAdminDAO
    {
        private DatabaseHelper db = new DatabaseHelper();

        // Ambil total barang
        // OOP pillars:
        // - Abstraction: (digunakan)
        // - Encapsulation: (digunakan)
        // - Inheritance: (tidak digunakan)
        // - Polymorphism: (tidak digunakan)
        public int GetTotalBarang()
        {

            using (var connection = db.GetConnection())
            {
                connection.Open();
                string sql = @"SELECT total_barang FROM v_jumlah_data_barang";
                using (var cmd = new NpgsqlCommand(sql, connection))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

        }

        // Ambil total penjualan
        // OOP pillars: Abstraction, Encapsulation
        public int GetTotalPenjualan()
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string sql = @"select * from view_total_penjualan";
                using (var cmd = new NpgsqlCommand(sql, connection))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        // Ambil total servis
        // OOP pillars: Abstraction, Encapsulation
        public int GetTotalServis()
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string sql = @"select * from v_jumlah_servis_selesai";
                using (var cmd = new NpgsqlCommand(sql, connection))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        // Ambil pendapatan penjualan
        // OOP pillars: Abstraction, Encapsulation
        public decimal GetPendapatanPenjualan()
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string sql = @"select * from v_total_pendapatan";
                using (var cmd = new NpgsqlCommand(sql, connection))
                {
                    return Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }
        }
        //public decimal GetPendapatanServis()
        //{
        //    using (var connection = db.GetConnection())
        //    {
        //        connection.Open();
        //        string sql = @"SELECT * from v_ringkasan_servis'";
        //        using (var cmd = new NpgsqlCommand(sql, connection))
        //        {
        //            return Convert.ToDecimal(cmd.ExecuteScalar());
        //        }
        //    }
        //}

        // Ambil daftar barang dengan stok menipis
        // OOP pillars: Abstraction, Encapsulation
        public DataTable GetBarangStokMenipis()
        {
            DataTable dt = new DataTable();
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string sql = @"select * from v_stok_menipis";
                using (var adapter = new NpgsqlDataAdapter(sql, connection))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

    }
}
