using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using Projek_Final_sem2.Koneksi;
using Projek_Final_sem2.UserControls.Kasir.DAO;

namespace Projek_Final_sem2.UserControls.Kasir
{
    public partial class UcDataBarangKasir : UserControl
    {
        private BarangDAO barangDAO = new BarangDAO();

        public UcDataBarangKasir()
        {
            InitializeComponent();
            DgvBarang.AutoGenerateColumns = true;
        }

        private void UcDataBarangKasir_Load(object sender, EventArgs e)
        {
            LoadDataBarang();
        }

        private void LoadDataBarang()
        {
            DataTable dt = barangDAO.GetAllBarang();
            DgvBarang.DataSource = dt;
        }

        private void TbCariID_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCariID_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbCariID.Text))
            {
                MessageBox.Show("Masukkan ID Barang terlebih dahulu!");
                return;
            }

            int idBarang = Convert.ToInt32(TbCariID.Text);

            DgvBarang.DataSource = barangDAO.CariBarangById(idBarang);
        }
    }
}
