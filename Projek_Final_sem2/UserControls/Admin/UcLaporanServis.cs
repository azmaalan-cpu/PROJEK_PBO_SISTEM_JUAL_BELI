using Projek_Final_sem2.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using Projek_Final_sem2.Models;

namespace Projek_Final_sem2.UserControls
{
    public partial class UcLaporanServis : UserControl
    {
        public UcLaporanServis()
        {
            InitializeComponent();

        }

        private void UcLaporanServis_Load(object sender, EventArgs e)
        { 
            loaddataservis();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LbJudulLaporanServis_Click(object sender, EventArgs e)
        {

        }

        private void DgvDataServis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loaddataservis();
        }

        private void loaddataservis()
        {
            var dt = new ServiceDAO().ShowreportService();
            DgvDataServis.DataSource = null;
            DgvDataServis.AutoGenerateColumns = false;
            Column2.DataPropertyName = "tanggal"; 
            Column1.DataPropertyName = "id_servis"; 
            Column4.DataPropertyName = "jenis_alat"; 
            Column5.DataPropertyName = "biaya"; 
            Column6.DataPropertyName = "status";
            DgvDataServis.DataSource = dt;
        }
    }
}
