using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Projek_Final_sem2.Koneksi;
using Projek_Final_sem2.DAO;

namespace Projek_Final_sem2.UserControls.Teknisi
{
    public partial class UcDataServis : UserControl
    {
        public UcDataServis()
        {
            InitializeComponent();
            this.Load += UcDataServis_Load;
        }
        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            DataView dv =
            ((DataTable)DgvDataServis.DataSource)
            .DefaultView;

            dv.RowFilter =
            $"nama_alat LIKE '%{TextCariDataServis.Text}%'";
        }
        private Panel panelUtama;

        public UcDataServis(Panel panel)
        {
            InitializeComponent();

            panelUtama = panel;
        }

        private void DgvDataServis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadDataServis()
        {
            var dt = new ServiceDAO().DataUcDataServis();
            DgvDataServis.DataSource = null;
            DgvDataServis.AutoGenerateColumns = false;
            try
            {
                if (dt.Columns.Count >= 6)
                {
                    ColumnIdServis.DataPropertyName = dt.Columns[0].ColumnName;
                    ColumnTanggalServis.DataPropertyName = dt.Columns[1].ColumnName;
                    ColumnNamaAlat.DataPropertyName = dt.Columns[2].ColumnName;
                    ColumnKerusakan.DataPropertyName = dt.Columns[3].ColumnName;
                    ColumnBiayaServis.DataPropertyName = dt.Columns[4].ColumnName;
                    ColumnStatus.DataPropertyName = dt.Columns[5].ColumnName;
                }
                else
                {
                    DgvDataServis.AutoGenerateColumns = true;
                }
            }
            catch
            {
                DgvDataServis.AutoGenerateColumns = true;
            }

            DgvDataServis.DataSource = dt;
        }
        private void UcDataServis_Load(object sender, EventArgs e)
        {
            LoadDataServis();
        }
    }
}
