using Npgsql;
using Projek_Final_sem2.Examples.OOPExample.DAO;
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


        public class BayarServisRepo
        {
            private readonly DatabaseHelper db = new DatabaseHelper();

            public DataRow GetServisById(int idServis)
            {
                DataTable dt = new DataTable();
                using (var conn = db.GetConnection())
                {
                    conn.Open();
                    string sql = @"SELECT id_servis,nama_alat, kerusakan, COALESCE(sparepart, '-') AS sparepart, biaya_servis, status_servis FROM servis WHERE id_servis = @id;";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idServis);
                        using (var adapter = new NpgsqlDataAdapter(cmd))
                            adapter.Fill(dt);
                    }
                }
                return dt.Rows.Count > 0 ? dt.Rows[0] : null;
            }

            public void UpdateStatusSelesai(int idServis)
            {
                using (var conn = db.GetConnection())
                {
                    conn.Open();
                    string sql = "CALL sp_update_status_servis(@id, @status)";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idServis);
                        cmd.Parameters.AddWithValue("@status", "Selesai");
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
