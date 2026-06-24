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
        // Ambil semua servis sebagai model list
        // OOP pillars:
        // - Abstraction: (digunakan) menyajikan model Service yang mudah digunakan oleh lapisan atas
        // - Encapsulation: (digunakan) detail query dan pembentukan objek dibungkus di sini
        // - Inheritance: (tidak digunakan)
        // - Polymorphism: (tidak digunakan)
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

        // Ambil satu servis berdasarkan ID dan konversi ke model
        // OOP pillars:
        // - Abstraction: (digunakan) metode ini menyederhanakan akses data menjadi model tunggal
        // - Encapsulation: (digunakan) implementasi SQL dan mapping tersembunyi
        // - Inheritance: (tidak digunakan)
        // - Polymorphism: (tidak digunakan)
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

        // Perbarui status servis (memanggil stored procedure)
        // OOP pillars:
        // - Abstraction: (digunakan) operasi update dibungkus menjadi method tunggal
        // - Encapsulation: (digunakan) parameter dan eksekusi SP disembunyikan
        // - Inheritance: (tidak digunakan)
        // - Polymorphism: (tidak digunakan)
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
                    // Note: CALL to stored procedure may return -1 (no rows affected reported)
                    // even when the procedure executed successfully. Treat -1 as success
                    // unless an exception is thrown.
                    int affected = cmd.ExecuteNonQuery();
                    if (affected > 0) return true;
                    if (affected == -1) return true;
                    return false;
                }
            }
        }


        // Ambil data report servis (DataTable)
        // OOP pillars:
        // - Abstraction: (digunakan) menyediakan bentuk data yang siap untuk laporan
        // - Encapsulation: (digunakan) SQL dan adapter dibungkus
        // - Inheritance: (tidak digunakan)
        // - Polymorphism: (tidak digunakan)
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
        // Ambil data servis terbaru lengkap sebagai DataTable
        // OOP pillars:
        // - Abstraction: (digunakan)
        // - Encapsulation: (digunakan)
        // - Inheritance: (tidak digunakan)
        // - Polymorphism: (tidak digunakan)
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
        // Ambil data untuk UserControl DataServis (DataTable)
        // OOP pillars:
        // - Abstraction: (digunakan)
        // - Encapsulation: (digunakan)
        // - Inheritance: (tidak digunakan)
        // - Polymorphism: (tidak digunakan)
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
        // OOP pillars:
        // - Abstraction: (digunakan) menyajikan histori servis tanpa detail implementasi
        // - Encapsulation: (digunakan)
        // - Inheritance: (tidak digunakan)
        // - Polymorphism: (tidak digunakan)
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
        // OOP pillars:
        // - Abstraction: (digunakan) menyederhanakan pencarian user berdasarkan role
        // - Encapsulation: (digunakan) SQL dan parameter dibungkus di sini
        // - Inheritance: (tidak digunakan)
        // - Polymorphism: (tidak digunakan)
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

        // Menandai servis sebagai dibayar (menggunakan fungsi DB bayar_servis)
        // OOP pillars:
        // - Abstraction: (digunakan) operasi pembayaran disediakan sebagai method boolean sederhana
        // - Encapsulation: (digunakan)
        // - Inheritance: (tidak digunakan)
        // - Polymorphism: (tidak digunakan)
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

        // Ambil data untuk grafik servis antara dua tanggal
        // OOP pillars:
        // - Abstraction: (digunakan) mengubah fungsi DB menjadi DataTable siap plot
        // - Encapsulation: (digunakan)
        // - Inheritance: (tidak digunakan)
        // - Polymorphism: (tidak digunakan)
        public DataTable GetGrafikServis(DateTime tanggalAwal, DateTime tanggalAkhir)
        {
            DataTable dt = new DataTable();

            using (var connection = db.GetConnection())
            {
                connection.Open();

                string sql = @"select  * from fn_grafik_servis(@awal::date, @akhir::date)";

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
        
        // Ambil data untuk DataGridView dashboard servis admin
        // OOP pillars:
        // - Abstraction: (digunakan)
        // - Encapsulation: (digunakan)
        // - Inheritance: (tidak digunakan)
        // - Polymorphism: (tidak digunakan)
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
        // Small repository class to fetch service row for payment UI
        // OOP pillars:
        // - Abstraction: (digunakan)
        // - Encapsulation: (digunakan)
        // - Inheritance: (tidak digunakan)
        // - Polymorphism: (tidak digunakan)
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
        // OOP pillars:
        // - Abstraction: (digunakan) menyembunyikan detail panggilan stored procedure
        // - Encapsulation: (digunakan)
        // - Inheritance: (tidak digunakan)
        // - Polymorphism: (tidak digunakan)
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

        // Higher-level create method: delegates to InsertServis
        // OOP pillars:
        // - Abstraction: (digunakan) menyediakan public API untuk pembuatan servis
        // - Encapsulation: (digunakan)
        // - Inheritance: (tidak digunakan)
        // - Polymorphism: (tidak digunakan)
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
