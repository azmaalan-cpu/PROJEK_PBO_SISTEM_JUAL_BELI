using Npgsql;
using Projek_Final_sem2.Koneksi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Projek_Final_sem2.DAO
{
    public class DashboardTransaksiKasirDAO
    {
        private DatabaseHelper db = new DatabaseHelper();

        // Ambil data barang untuk kasir
        // OOP pillars: Abstraction, Encapsulation
        public DataTable GetDataBarang()
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string sql = @"
                select * from v_Get_Data_Barang;";
                using (var da = new NpgsqlDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        // Ambil data ringkasan dashboard kasir
        // OOP pillars: Abstraction, Encapsulation
        public DataTable GetDashboardKasir()
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string sql = "SELECT * FROM v_dashboard_kasir";

                using (var da = new NpgsqlDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        //public decimal GetTotalPendapatan()
        //{
        //    using (var conn = db.GetConnection())
        //    {
        //        conn.Open();

        //        string sql =
        //            "SELECT total_pendapatan FROM v_total_pendapatan_dashboard";

        //        using (var cmd = new NpgsqlCommand(sql, conn))
        //        {
        //            object result = cmd.ExecuteScalar();

        //            if (result == null || result == DBNull.Value)
        //                return 0;

        //            return Convert.ToDecimal(result);
        //        }
        //    }
        //}

        //public int GetTotalBarangTerjual()
        //{

        //    using (var conn = db.GetConnection())
        //    {
        //        conn.Open();

        //        string sql =
        //            "SELECT total_barang_terjual FROM v_total_barang_terjual_dashboard";

        //        using (var cmd = new NpgsqlCommand(sql, conn))
        //        {
        //            object result = cmd.ExecuteScalar();

        //            if (result == null || result == DBNull.Value)
        //                return 0;

        //            return Convert.ToInt32(result);
        //        }
        //    }
        //}
        //public int GetTotalTransaksi()
        //{
        //    using (var conn = db.GetConnection())
        //    {
        //        conn.Open();

        //        string sql =
        //            "SELECT total_transaksi FROM v_total_transaksi_dashboard";

        //        using (var cmd = new NpgsqlCommand(sql, conn))
        //        {
        //            object result = cmd.ExecuteScalar();

        //            if (result == null || result == DBNull.Value)
        //                return 0;

        //            return Convert.ToInt32(result);
        //        }
        //    }
        //}

        // Ambil informasi transaksi (detail kecil) untuk dashboard
        // OOP pillars: Abstraction, Encapsulation
        public DataTable GetInformasiTransaksi()
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string sql =
                    "SELECT * FROM v_informasi_transaksi";

                using (var da = new NpgsqlDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }

        }

        // Ambil daftar transaksi penjualan
        // OOP pillars: Abstraction, Encapsulation
        public DataTable GetTransaksiPenjualan()
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string sql =
                    "SELECT * FROM v_transaksi_penjualan";

                using (var da = new NpgsqlDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
