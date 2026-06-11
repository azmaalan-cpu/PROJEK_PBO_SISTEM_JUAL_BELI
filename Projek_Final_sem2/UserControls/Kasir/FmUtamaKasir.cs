using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Projek_Final_sem2.UserControls.Kasir;


namespace Projek_Final_sem2.UserControls.Kasir
{
    public partial class FmUtamaKasir : Form
    {
        public FmUtamaKasir()
        {
            InitializeComponent();
            LoadUserControl(new UcDashboardKasir());
        }

        private void LoadUserControl(UserControl uc)
        {
            PanelContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            PanelContainer.Controls.Add(uc);
        }

        private void FmUtamaKasir_load(object sender, EventArgs eventArgs)
        {
            LoadUserControl(new UcDashboardKasir());
        }

        private void BtnDashboardKasir_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UcDashboardKasir());
        }
        

        private void ButtonDataBarang_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UcDataBarang());
        }

        private void BtnTransaksiPenjualan_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UcTransaksiPenjualan());
        }
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //FormLogin Login = new FormLogin();
            //Login.Show();
        }
    }       // update kasir yang terbaru 
}
