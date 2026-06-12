using Npgsql;
using Projek_Final_sem2.Koneksi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projek_Final_sem2.UserControls.Teknisi
{
    public partial class UcRiwayat : UserControl
    {
        public UcRiwayat()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UcRiwayat_Load(object sender, EventArgs e)
        {
            DtpRiwayatAwal.Value = DateTime.Today.AddMonths(-1);
            DtpRiwayatAkhir.Value = DateTime.Today;

            LoadRiwayatServis();
            LoadSummary();
        }
        private void HitungRingkasan(DataTable dt)
        {
            LblTotalSevis.Text =
                dt.Rows.Count.ToString();

            decimal totalPendapatan = 0;

            foreach (DataRow row in dt.Rows)
            {
                totalPendapatan +=
                    Convert.ToDecimal(
                        row["biaya_servis"]);
            }

            LblTotalPendapatan.Text =
                totalPendapatan.ToString("N0");
        }

        private void BtnTampilkanRiwayat_Click(object sender, EventArgs e)
        {
            if (DtpRiwayatAwal.Value.Date > DtpRiwayatAkhir.Value.Date)
            {
                MessageBox.Show(
                    "Tanggal awal tidak boleh lebih besar dari tanggal akhir!");

                return;
            }

            LoadRiwayatServis();
        }
        private void LoadRiwayatServis()
        {
            DatabaseHelper db = new DatabaseHelper();
            try
            {
                using (NpgsqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                SELECT
                    id_servis,
                    tanggal_servis,
                    nama_alat,
                    kerusakan,
                    biaya_servis,
                    status_servis
                FROM servis
                WHERE tanggal_servis
                BETWEEN @awal AND @akhir
                ORDER BY tanggal_servis DESC";

                    NpgsqlDataAdapter da =
                        new NpgsqlDataAdapter(sql, conn);

                    da.SelectCommand.Parameters.AddWithValue(
                        "@awal",
                        DtpRiwayatAwal.Value.Date);

                    da.SelectCommand.Parameters.AddWithValue(
                        "@akhir",
                        DtpRiwayatAkhir.Value.Date);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    DgvRiwayat.DataSource = dt;

                    HitungRingkasan(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DgvRiwayat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadSummary()
        {
            DatabaseHelper db = new DatabaseHelper();
            try
            {
                using (NpgsqlConnection conn =
                    db.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                SELECT
                    COUNT(*) AS total_servis,
                    COALESCE(SUM(biaya_servis),0) AS total_pendapatan
                FROM servis
                WHERE tanggal_servis
                BETWEEN @awal AND @akhir";

                    using (NpgsqlCommand cmd =
                        new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@awal",
                            DtpRiwayatAwal.Value.Date);

                        cmd.Parameters.AddWithValue(
                            "@akhir",
                            DtpRiwayatAkhir.Value.Date);

                        NpgsqlDataReader rd =
                            cmd.ExecuteReader();

                        if (rd.Read())
                        {
                            LblAngkaTotalServis.Text =
                                rd["total_servis"].ToString();

                            decimal totalPendapatan =
                                Convert.ToDecimal(
                                    rd["total_pendapatan"]);

                            LblAngkaPendapatan.Text =
                                "Rp " +
                                totalPendapatan.ToString("N0");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
