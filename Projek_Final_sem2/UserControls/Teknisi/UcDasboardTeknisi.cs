using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Projek_Final_sem2.Koneksi;

namespace Projek_Final_sem2.UserControls.Teknisi
{
    public partial class UcDasboardTeknisi : UserControl
    {
        public UcDasboardTeknisi()
        {
            InitializeComponent();
        }

        private void LbSelamatDatangAdmin_Click(object sender, EventArgs e)
        {

        }

        private void PanelPenjualan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                   count(*) FILTER(WHERE status_servis = 'proses') proses,
                   count(*) FILTER(WHERE status_servis = 'selesai') selesai,
                   count(*) FILTER(WHERE status_servis = 'menunggu') menunggu
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
        private void LoadDataTerbaru()
        {
            using (var connection = new DatabaseHelper().GetConnection())
            {
                connection.Open();
                string sql = @"SELECT *
                    FROM servis
                    ORDER BY tanggal_servis DESC
                    LIMIT 5";

                 NpgsqlDataAdapter da =
                    new NpgsqlDataAdapter(sql, connection);

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                DgvServisTerbaru.DataSource = dt;
            }
                
        }
    }
}
