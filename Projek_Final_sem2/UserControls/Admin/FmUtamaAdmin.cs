using Projek_Final_sem2.Models;
using Projek_Final_sem2.UserControls;
using Projek_Final_sem2.UserControls.Kasir;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projek_Final_sem2
{
    public partial class FmUtamaAdmin : Form
    {
     
        public FmUtamaAdmin()
        {
            InitializeComponent();

        }

        private void FmUtama_Load(object sender, EventArgs e)
        {
            TampilDashboard();
        }


        public void TampilDashboard()
        {
          PanelMenu.Visible=true;
          PanelContent.Controls.Clear();
          UcDashboard uc = new UcDashboard();
          uc.Dock = DockStyle.Fill;
            PanelContent.Controls.Add(uc);

        }


        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            TampilDashboard();
        }

        private void BtnDataUser_Click(object sender, EventArgs e)
        {
            PanelContent.Controls.Clear();
            UcDataUser uc = new UcDataUser();
            uc.Dock = DockStyle.Fill;
            PanelContent.Controls.Add(uc);
        }

        private void BtnLaporanServis_Click(object sender, EventArgs e)
        {

            PanelContent.Controls.Clear();
            UcLaporanServis uc = new UcLaporanServis();
            uc.Dock = DockStyle.Fill;
            PanelContent.Controls.Add(uc);

        }

        private void PanelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnDataBarang_Click(object sender, EventArgs e)
        {
            PanelContent.Controls.Clear();
            UcDataBarang uc = new UcDataBarang();
            uc.Dock = DockStyle.Fill;
            PanelContent.Controls.Add(uc);
        }

        private void BtnLaporanPenjualan_Click(object sender, EventArgs e)
        {
            PanelContent.Controls.Clear();
            UcLaporanPenjualan uc = new UcLaporanPenjualan();
            uc.Dock = DockStyle.Fill;
            PanelContent.Controls.Add(uc);
        }
    }
}
