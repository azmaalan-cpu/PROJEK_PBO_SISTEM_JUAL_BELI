using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using System.Data;
using Projek_Final_sem2.Koneksi;

namespace Projek_Final_sem2.UserControls.Kasir.DAO
{   
    public class BarangDAO
    {
        private DatabaseHelper db = new DatabaseHelper();
        
        public DataTable GetAllBarang()
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string sql = "SELECT id_alat, nama_alat, harga, stok FROM alat_pertanian ORDER BY id_alat";
                using (var da = new NpgsqlDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }


        public DataTable CariBarangById(int idBarang)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string sql = @"
                SELECT id_alat, nama_alat, harga, stok
                FROM alat_pertanian
                WHERE id_alat = @id_alat";

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
