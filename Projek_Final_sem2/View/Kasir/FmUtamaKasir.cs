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
            LoadUserControl(new UcDataBarangKasir());
        }

        private void BtnTransaksiPenjualan_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UcTransaksiPenjualan());
        }
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            DialogResult hasil = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hasil == DialogResult.Yes)
            {
                FmLogin login = new FmLogin();
                login.Show();
                this.Close();
            }
        }

        private void BtnTransaksiService_Click(object sender, EventArgs e)
        {
            PanelContainer.Controls.Clear();

            UcTransaksiService uc =
                new UcTransaksiService();

            uc.Dock = DockStyle.Fill;

            PanelContainer.Controls.Add(uc);
        }
    }       // update kasir yang terbaru 
}
