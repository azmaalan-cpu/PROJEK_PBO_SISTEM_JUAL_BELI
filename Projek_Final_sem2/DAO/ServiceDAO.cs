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

        // New model-based methods
        public List<Projek_Final_sem2.Models.Service> GetAllServices()
        {
            var list = new List<Projek_Final_sem2.Models.Service>();
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string sql = @"select * from v_data_servis";
                using (var cmd = new NpgsqlCommand(sql, conn))
                using (var rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        var s = new Projek_Final_sem2.Models.Service()
                        {
                            id_servis = rd["id_servis"] == DBNull.Value ? 0 : Convert.ToInt32(rd["id_servis"]),
                            tanggal_servis = rd["tanggal_servis"] == DBNull.Value
                                ? DateTime.MinValue
                                : (rd["tanggal_servis"] is DateOnly d
                                    ? d.ToDateTime(TimeOnly.MinValue)
                                    : Convert.ToDateTime(rd["tanggal_servis"])),
                            nama_alat_servis = rd["nama_alat"]?.ToString(),
                            kerusakan = rd["kerusakan"]?.ToString(),
                            biaya_servis = rd["biaya_servis"] == DBNull.Value ? 0 : Convert.ToInt32(rd["biaya_servis"]),
                            status_servis = rd["status_servis"]?.ToString()
                        };

                        list.Add(s);
                    }
                }
            }

            return list;
        }

        public Projek_Final_sem2.Models.Service GetServiceById(int id)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string sql = @"SELECT id_servis, tanggal_servis, nama_alat, kerusakan, biaya_servis, status_servis, sparepart FROM servis WHERE id_servis = @id";
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            return new Projek_Final_sem2.Models.Service
                            {
                                id_servis = rd["id_servis"] == DBNull.Value ? 0 : Convert.ToInt32(rd["id_servis"]),
                                tanggal_servis = rd["tanggal_servis"] == DBNull.Value
                                    ? DateTime.MinValue : (rd["tanggal_servis"] is DateOnly d ? d.ToDateTime(TimeOnly.MinValue) : Convert.ToDateTime(rd["tanggal_servis"])),
                                nama_alat_servis = rd["nama_alat"]?.ToString(),
                                kerusakan = rd["kerusakan"]?.ToString(),
                                biaya_servis = rd["biaya_servis"] == DBNull.Value ? 0 : Convert.ToInt32(rd["biaya_servis"]),
                                status_servis = rd["status_servis"]?.ToString(),
                                sparepart = rd["sparepart"]?.ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }

        public bool UpdateStatus(int id_servis, string status)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string updateSql = "CALL sp_update_status_servis(@id_servis, @status)";
                using (var cmd = new NpgsqlCommand(updateSql, connection))
                {
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@id_servis", id_servis);
                    int affected = cmd.ExecuteNonQuery();
                    return affected > 0;
                }
            }
        }


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

        // History for servis - returns full servis history. Adjust the query/view name if a different source is desired.
        public DataTable DataServisRiwayat()
        {
            DataTable dt = new DataTable();
            using (var connection = db.GetConnection())
            {
                connection.Open();
                // Use a view or table that represents service history. Change v_data_servis to the appropriate view if needed.
                string sql = @"select * from v_data_servis";
                using (var adapter = new Npgsql.NpgsqlDataAdapter(sql, connection))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        // Returns users filtered by role (e.g. 'teknisi'). Caller binds result to UI controls.
        public DataTable GetUsersByRole(string role)
        {
            DataTable dt = new DataTable();
            using (var connection = db.GetConnection())
            {
                connection.Open();
                // Join roles to support role lookup by role name; use ILIKE for case-insensitive match
                string sql = @"
                    SELECT u.id_user,
                           u.username
                    FROM users u
                    JOIN roles r ON u.id_role = r.id_role
                    WHERE r.nama_role ILIKE @role
                    ORDER BY u.username";

                using (var cmd = new Npgsql.NpgsqlCommand(sql, connection))
                {
                    // Use exact name (e.g. 'teknisi') or pattern '%teknisi%'
                    cmd.Parameters.AddWithValue("@role", role);
                    using (var adapter = new Npgsql.NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public bool BayarServis(int id_servis)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();

                string sql = "SELECT bayar_servis(@id_servis)";

                using (var cmd = new Npgsql.NpgsqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@id_servis", id_servis);

                    return Convert.ToBoolean(
                        cmd.ExecuteScalar()
                    );
                }
            }
        }

        public DataTable GetGrafikServis(DateTime tanggalAwal, DateTime tanggalAkhir)
        {
            DataTable dt = new DataTable();

            using (var connection = db.GetConnection())
            {
                connection.Open();

                string sql = @"select * from grafik_servis(@awal::date, @akhir::date)";

                using (var cmd = new Npgsql.NpgsqlCommand(sql, connection))
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


        //public decimal GetTotalPendapatanServis(DateTime awal, DateTime akhir)
        //{
        //    using (var connection = db.GetConnection())
        //    {
        //        connection.Open();
        //        string sql = @"SELECT COALESCE(SUM(biaya_servis),0) FROM servis WHERE status_servis = 'Selesai' AND tanggal_servis BEETWEN @awal AND @akhir";

        //        using (var cmd = new NpgsqlCommand(sql, connection))
        //        {
        //            cmd.Parameters.AddWithValue("@awal", awal.Date);
        //            cmd.Parameters.AddWithValue("@akhir", akhir.Date);

        //            return Convert.ToDecimal(cmd.ExecuteScalar());
        //        }
        //    }
        //}
        
        public DataTable DgvDashboardServisAdmin()
        {
            DataTable dt = new DataTable();
            using (var connection = db.GetConnection())
            {
                connection.Open();
                string sql = @"select * from v_servis_terbaru";
                using (var adapter = new Npgsql.NpgsqlDataAdapter(sql, connection))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
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
                        using (var adapter = new Npgsql.NpgsqlDataAdapter(cmd))
                            adapter.Fill(dt);
                    }
                }
                return dt.Rows.Count > 0 ? dt.Rows[0] : null;
            }
        }

        // New low-level insert method: performs only DB operation.
        public bool InsertServis(int idUser, string namaAlat, string kerusakan, decimal biayaServis, string sparepart)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                // Call stored procedure with correct parameter order/names
                string sql = "call sp_tambah_servis(@id_user, @nama_alat, @kerusakan, @biaya_servis, @sparepart)";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id_user", idUser);
                    cmd.Parameters.AddWithValue("@nama_alat", namaAlat);
                    cmd.Parameters.AddWithValue("@kerusakan", kerusakan);
                    cmd.Parameters.AddWithValue("@biaya_servis", biayaServis);
                    cmd.Parameters.AddWithValue("@sparepart", sparepart);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }

        public bool CreateServis(int idUser, string namaAlat, string kerusakan, decimal biayaServis, string sparepart)
        {
            /*
            Original validation logic and DB call were kept here for reference.
            During refactor the validation and orchestration should live in a service layer
            (Projek_Final_sem2.Services.ServiceService). The DAO should focus on low-level
            DB operations (see InsertServis).

            if (string.IsNullOrWhiteSpace(namaAlat))
                throw new ArgumentException("Nama alat harus diisi", nameof(namaAlat));

            if (string.IsNullOrWhiteSpace(kerusakan))
                throw new ArgumentException("Kerusakan harus diisi", nameof(kerusakan));

            if (biayaServis < 0)
                throw new ArgumentException("Biaya servis tidak valid", nameof(biayaServis));

            using (var conn = db.GetConnection())
            {
                conn.Open();

                // Call stored procedure with correct parameter order/names
                string sql = "call sp_tambah_servis(@id_user, @nama_alat, @kerusakan, @biaya_servis, @sparepart)";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id_user", idUser);
                    cmd.Parameters.AddWithValue("@nama_alat", namaAlat);
                    cmd.Parameters.AddWithValue("@kerusakan", kerusakan);
                    cmd.Parameters.AddWithValue("@biaya_servis", biayaServis);
                    cmd.Parameters.AddWithValue("@sparepart", sparepart);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            */

            // New behaviour: delegate to the explicit InsertServis DB-only method.
            return InsertServis(idUser, namaAlat, kerusakan, biayaServis, sparepart);
        }
    }
}
