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

        private bool IsInDesignMode()
        {
            return System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime
                   || (this.Site != null && this.Site.DesignMode);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UcRiwayat_Load(object sender, EventArgs e)
        {
            if (IsInDesignMode())
                return;
            DtpRiwayatAwal.Value = DateTime.Today.AddMonths(-1);
            DtpRiwayatAkhir.Value = DateTime.Today;
            LoadRiwayatServis();
            LoadSummary();
        }
        private void HitungRingkasan(DataTable dt)
        {
            TotalServis.Text =
                dt.Rows.Count.ToString();

            decimal totalPendapatan = 0;

            foreach (DataRow row in dt.Rows)
            {
                totalPendapatan +=
                    Convert.ToDecimal(
                        row["biaya_servis"]);
            }

            TotalPendapatan.Text =
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
            // Show records within the selected date range
            FilterRiwayatByRange(DtpRiwayatAwal.Value.Date, DtpRiwayatAkhir.Value.Date);
        }
        private void FilterRiwayatByRange(DateTime awal, DateTime akhir)
        {
            try
            {
                var control = new Projek_Final_sem2.Control.Teknisi.RiwayatControl();
                DataTable dt = control.GetRiwayatByRange(awal, akhir);
                DgvRiwayat.DataSource = dt;

                HitungRingkasan(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadRiwayatServis()
        {
            try
            {
                var control = new Projek_Final_sem2.Control.Teknisi.RiwayatControl();
                DataTable dt = control.GetAllRiwayat();
                DgvRiwayat.DataSource = dt;

                HitungRingkasan(dt);
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
            try
            {
                var control = new Projek_Final_sem2.Control.Teknisi.RiwayatControl();
                var (count, sum) = control.GetSummary(DtpRiwayatAwal.Value.Date, DtpRiwayatAkhir.Value.Date);

                TotalServis.Text = count.ToString();
                TotalPendapatan.Text = "Rp " + sum.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TotalPendapatan_Click(object sender, EventArgs e)
        {

        }
    }
}
