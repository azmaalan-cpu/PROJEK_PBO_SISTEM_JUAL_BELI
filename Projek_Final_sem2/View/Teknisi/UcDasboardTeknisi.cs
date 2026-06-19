using Npgsql;
using Projek_Final_sem2.DAO;
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
    public partial class UcDasboardTeknisi : UserControl
    {
        public UcDasboardTeknisi()
        {
            InitializeComponent();
            this.Load += UcDasboardTeknisi_Load;
        }

        private bool IsInDesignMode()
        {
            return System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime
                   || (this.Site != null && this.Site.DesignMode);
        }

        private void UcDasboardTeknisi_Load(object? sender, EventArgs e)
        {
            if (IsInDesignMode())
                return;
            LoadStatistik();
            LoadDataServisDGV();
        }

        private void LbSelamatDatangAdmin_Click(object sender, EventArgs e)
        {

        }

        private void PanelPenjualan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LbDataBarang_Click(object sender, EventArgs e)
        {

        }

        private void LbPenjualan_Click(object sender, EventArgs e)
        {

        }

        private void LbServis_Click(object sender, EventArgs e)
        {

        }
        private void LoadStatistik()
        {
            using (var connection = new DatabaseHelper().GetConnection())
            {
                connection.Open();
                string sql = @"
                   SELECT 
                   count(*) total,
                   count(*) FILTER(WHERE status_servis = 'Proses') Proses,
                   count(*) FILTER(WHERE status_servis = 'Selesai') Selesai,
                   count(*) FILTER(WHERE status_servis = 'Menunggu') Menunggu
                   from servis";
                NpgsqlCommand command = new NpgsqlCommand(sql, connection);
                NpgsqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    LbAngkaTotalServis.Text = reader["total"].ToString();
                    LbAngkaProsesServis.Text = reader["proses"].ToString();
                    LbAngkaSelesai.Text = reader["selesai"].ToString();
                    LbAngkaMenunggu.Text = reader["menunggu"].ToString();
                }
            }
        }
        private void DgvServisTerbaru_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDataServisDGV();
        }

        private void LoadDataServisDGV()
        {
            var dt = new ServiceDAO().DataServisTerbaruLengkap();
            DgvServisTerbaru.DataSource = null;
            DgvServisTerbaru.AutoGenerateColumns = false;
            try
            {
                if (dt.Columns.Count >= 5)
                {
                    Column_Id_servis.DataPropertyName = dt.Columns[0].ColumnName;
                    Column_tanggal_servis.DataPropertyName = dt.Columns[1].ColumnName;
                    Column_nama_alat.DataPropertyName = dt.Columns[2].ColumnName;
                    Column_kerusakan_servis.DataPropertyName = dt.Columns[3].ColumnName;
                    Status.DataPropertyName = dt.Columns[4].ColumnName;
                }
                else
                {
                    DgvServisTerbaru.AutoGenerateColumns = true;
                }
            }
            catch
            {
                DgvServisTerbaru.AutoGenerateColumns = true;
            }

            DgvServisTerbaru.DataSource = dt;
        }

        private void LbAngkaTotalServis_Click(object sender, EventArgs e)
        {

        }
    }
}
