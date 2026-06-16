using Npgsql;
using Projek_Final_sem2.Koneksi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Projek_Final_sem2.DAO
{
    public class ServiceDAO
    {
        private DatabaseHelper db = new DatabaseHelper();
        

        public DataTable ShowreportService()
        {
            DataTable dt = new DataTable();
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string sql = @"select * from v_data_servis";
                using (var adapter = new Npgsql.NpgsqlDataAdapter(sql, connection))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
        public DataTable DataServisTerbaruLengkap()
        {
            DataTable dt = new DataTable();
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string sql = @"select * from v_servis_terbaru_lengkap";
                using (var adapter = new Npgsql.NpgsqlDataAdapter(sql, connection))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
        public DataTable DataUcDataServis()
        {
            DataTable dt = new DataTable();
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string sql = @"select * from v_data_servis";
                using (var adapter = new Npgsql.NpgsqlDataAdapter(sql, connection))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        public void BayarServis(int id_servis)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string sql = @"UPDATE servis SET status_servis = 'Selesai' WHERE id_servis = @id_servis";
                using (var cmd = new NpgsqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@id_servis", id_servis);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetGrafikServis(DateTime tanggalAwal, DateTime tanggalAkhir)
        {
            DataTable dt = new DataTable();

            using (var connection = db.GetConnection())
            {
                connection.Open();

                string sql = @"SELECT tanggal_servis,SUM(biaya_servis) AS total_servis
                               FROM servis
                               WHERE status_servis = 'Selesai'
                               AND tanggal_servis BETWEEN @awal AND @akhir
                               GROUP BY tanggal_servis
                               ORDER BY tanggal_servis";

                using (var cmd = new NpgsqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@awal", tanggalAwal.Date);
                    cmd.Parameters.AddWithValue("@akhir", tanggalAkhir.Date);

                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }


        public decimal GetTotalPendapatanServis(DateTime awal, DateTime akhir)
        {
            using(var connection = db.GetConnection())
            {
                connection.Open();
                string sql = @"SELECT COALESCE(SUM(biaya_servis),0) FROM servis WHERE status_servis = 'Selesai' AND tanggal_servis BEETWEN @awal AND @akhir";

                using(var cmd = new NpgsqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@awal", awal.Date);
                    cmd.Parameters.AddWithValue("@akhir", akhir.Date);

                    return Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }
        }
        public DataTable DataServisRiwayat()
        {
            DataTable dt = new DataTable();
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string sql = @"select * from v_servis_riwayat";
                using (var adapter = new Npgsql.NpgsqlDataAdapter(sql, connection))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
        
    }
}
