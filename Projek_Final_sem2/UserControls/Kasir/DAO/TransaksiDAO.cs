using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using System.Data;
using Projek_Final_sem2.Koneksi;

namespace Projek_Final_sem2.UserControls.Kasir.DAO
{
    public class TransaksiDAO
    {
        private DatabaseHelper db = new DatabaseHelper();

        public bool InsertTransaksi(int idUser, int idAlat, int jumlah)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string sql = @"
                     INSERT INTO transaksi
                    (
                        id_alat,
                        tanggal,
                        id_user,
                        jumlah
                    )
                        VALUES
                    (
                        @id_alat,
                        @tanggal,
                        @id_user,
                        @jumlah
                    )";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id_alat", idAlat);
                    cmd.Parameters.AddWithValue("@tanggal", DateTime.Now);
                    cmd.Parameters.AddWithValue("@id_user", idUser);
                    cmd.Parameters.AddWithValue("@jumlah", jumlah);

                    return cmd.ExecuteNonQuery() > 0;
                }

            }
        }
        public void KurangiStok(int idAlat, int jumlah)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string sql = @"
                UPDATE alat_pertanian
                SET stok = stok - @jumlah
                WHERE id_alat = @id_alat";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@jumlah",
                         jumlah);

                    cmd.Parameters.AddWithValue("@id_alat",
                        idAlat);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public int CekStok(int idAlat)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string sql = @"
                    SELECT stok 
                    FROM alat_pertanian
                    WHERE id_alat = @id_alat";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id_alat", idAlat);

                    object result = cmd.ExecuteScalar();

                    if (result == null)
                        return 0;

                    return Convert.ToInt32(result);
                }
            }
        }
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

        public decimal GetTotalPendapatan()
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string sql =
                    "SELECT total_pendapatan FROM v_total_pendapatan_dashboard";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    object result = cmd.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                        return 0;

                    return Convert.ToDecimal(result);
                }
            }
        }

        public int GetTotalBarangTerjual()
        {

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string sql =
                    "SELECT total_barang_terjual FROM v_total_barang_terjual_dashboard";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    object result = cmd.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                        return 0;

                    return Convert.ToInt32(result);
                }
            }
        }

        public int GetTotalTransaksi()
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string sql =
                    "SELECT total_transaksi FROM v_total_transaksi_dashboard";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    object result = cmd.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                        return 0;

                    return Convert.ToInt32(result);
                }
            }
        }

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
                    string sql = @"
                SELECT 
                    s.id_servis,
                    s.nama_alat,
                    s.kerusakan,
                    s.status_servis,
                    COALESCE(STRING_AGG(sp.nama_sparepart, ', '), '-') AS sparepart,
                    s.biaya_servis
                FROM servis s
                LEFT JOIN detail_servis ds ON s.id_servis = ds.id_servis
                LEFT JOIN sparepart sp     ON ds.id_sparepart = sp.id_sparepart
                WHERE s.id_servis = @id
                GROUP BY s.id_servis, s.nama_alat, s.kerusakan, s.status_servis, s.biaya_servis";

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
