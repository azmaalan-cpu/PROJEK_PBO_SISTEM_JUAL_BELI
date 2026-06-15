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
                string sql = "SELECT a.id_alat,a.nama_alat,a.harga, a.stok, k.nama_kategori FROM alat_pertanian a JOIN kategori_alat k ON a.id_kategori = k.id_kategori;";
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
                SELECT a.id_alat,a.nama_alat,a.harga, a.stok, k.nama_kategori FROM alat_pertanian a JOIN kategori_alat k ON a.id_kategori = k.id_kategori;";

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
