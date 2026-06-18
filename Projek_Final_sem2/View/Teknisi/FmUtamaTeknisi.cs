using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projek_Final_sem2.UserControls.Teknisi
{
    public partial class FmUtamaTeknisi : Form
    {
        public FmUtamaTeknisi()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnDataServis_Click(object sender, EventArgs e)
        {
            loadControl(new UcDataServis());
        }

        private void BtnKerusakan_Click(object sender, EventArgs e)
        {
            loadControl(new UcKerusakan());
        }

        private void BtnStatus_Click(object sender, EventArgs e)
        {
            loadControl(new UcStatus());
        }

        private void BtnRiwayat_Click(object sender, EventArgs e)
        {
            loadControl(new UcRiwayat());
        }

        private void BtnLogoutTeknisi_Click(object sender, EventArgs e)
        {
            DialogResult hasil = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hasil == DialogResult.Yes)
            {
                FmLogin login = new FmLogin();
                login.Show();
                this.Close();
            }
        }

        private void panelcontent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FmUtamaTeknisi_Load(object sender, EventArgs e)
        {

        }
        public Panel MainPanel
        {
            get { return panelcontent; }
        }
        public void LoadUserControl(UserControl uc)
        {
            panelcontent.Controls.Clear();

            uc.Dock = DockStyle.Fill;

            panelcontent.Controls.Add(uc);
        }
    }
}
