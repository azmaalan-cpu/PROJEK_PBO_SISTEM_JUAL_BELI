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
            PanelMenu.Visible = true;
            PanelContent.Controls.Clear();
            UcDashboard uc = new UcDashboard();
            uc.BarangStokMenipisDipilih += BukanBarangDariDashboard;
            uc.Dock = DockStyle.Fill;
            PanelContent.Controls.Add(uc);

        }

        private void BukanBarangDariDashboard(int idBarang)
        {
            PanelContent.Controls.Clear();
            UcDataBarang uc = new UcDataBarang();
            uc.Dock = DockStyle.Fill;
            PanelContent.Controls.Add(uc);
            uc.LoadBarangById(idBarang);
        }

        public void TampilLogin()
        {
            PanelMenu.Visible = false;
            PanelContent.Controls.Clear();
            UcLogin uc = new UcLogin();
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

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult hasil = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hasil == DialogResult.Yes)
            {
                FmLogin login = new FmLogin();
                login.Show();
                this.Close();
            }
        }
    }
}
