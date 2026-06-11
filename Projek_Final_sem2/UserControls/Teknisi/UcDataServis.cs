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
    public partial class UcDataServis : UserControl
    {
        public UcDataServis()
        {
            InitializeComponent();
        }

        private void LoadServis()
        {
            using (var conn = new DatabaseHelper().GetConnection())
            {
                conn.Open();

                string sql =
                @"SELECT *
                FROM servis
                ORDER BY id_servis DESC";

                DataTable dt = new DataTable();

                new NpgsqlDataAdapter(sql, conn)
                    .Fill(dt);

                DgvDataServis.DataSource = dt;
            }
        }
        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            DataView dv =
            ((DataTable)DgvDataServis.DataSource)
            .DefaultView;

            dv.RowFilter =
            $"nama_alat LIKE '%{TextCariDataServis.Text}%'";
        }

        private void BtnTambahDataServis_Click(object sender, EventArgs e)
        {
            FmUtamaTeknisi frm = (FmUtamaTeknisi)this.FindForm();

            frm.LoadUserControl(new UcTambahDataServis());
        }
        private Panel panelUtama;

        public UcDataServis(Panel panel)
        {
            InitializeComponent();

            panelUtama = panel;
        }
    }
}
