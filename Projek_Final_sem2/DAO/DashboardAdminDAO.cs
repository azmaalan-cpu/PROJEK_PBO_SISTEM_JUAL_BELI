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
        public int GetTotalBarang()
        {

            using (var connection = db.GetConnection())
            {
                connection.Open();
                string sql = @"SELECT COUNT(*) FROM alat_pertanian";
                using (var cmd = new NpgsqlCommand(sql, connection))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

        }

        public int GetTotalPenjualan()
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string sql = @"SELECT COUNT(*) FROM transaksi";
                using (var cmd = new NpgsqlCommand(sql, connection))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public int GetTotalServis()
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string sql = @"SELECT COUNT(*) FROM servis";
                using (var cmd = new NpgsqlCommand(sql, connection))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public decimal GetPendapatanPenjualan()
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string sql = @"SELECT COALESCE(SUM(subtotal), 0) FROM detail_transaksi";
                using (var cmd = new NpgsqlCommand(sql, connection))
                {
                    return Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }
        }
        public decimal GetPendapatanServis()
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string sql = @"SELECT COALESCE(SUM(biaya_servis), 0) FROM servis WHERE status_servis = 'Selesai'";
                using (var cmd = new NpgsqlCommand(sql, connection))
                {
                    return Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }
        }

        public DataTable GetBarangStokMenipis()
        {
            DataTable dt = new DataTable();
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string sql = @"SELECT id_alat, nama_alat, stok FROM alat_pertanian WHERE stok <= 5 ORDER BY stok ASC";
                using (var adapter = new NpgsqlDataAdapter(sql, connection))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        public decimal GetTotalPendapatan(DateTime awal, DateTime akhir)
        {
            using (var connection = db.GetConnection())
            {
              return GetPendapatanPenjualan() + GetPendapatanServis();
            }
        }
    }
}
