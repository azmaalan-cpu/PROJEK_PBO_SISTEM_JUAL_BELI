using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using Projek_Final_sem2.Koneksi;
using Projek_Final_sem2.DAO;
using Projek_Final_sem2.Control.Kasir;

namespace Projek_Final_sem2.UserControls.Kasir
{
    public partial class UcDataBarangKasir : UserControl
    {
        private BarangService barangService = new BarangService();
        private TransaksiService transaksiService = new TransaksiService();

        public UcDataBarangKasir()
        {
            InitializeComponent();
            DgvBarang.AutoGenerateColumns = true;
        }

        private void UcDataBarangKasir_Load(object sender, EventArgs e)
        {
            LoadDataBarang();
            LoadTotalBarang();
        }

        private void LoadDataBarang()
        {
            DgvBarang.DataSource =
         transaksiService.GetDataBarang();
        }

        private void LoadTotalBarang()
        {



        }

        private void TbCariID_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCariID_Click(object sender, EventArgs e)
        {
            try
            {
                int idBarang = Convert.ToInt32(TbCariID.Text);

                DataTable dt = barangService.CariBarangById(idBarang);

                DgvBarang.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Data barang tidak ditemukan!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DgvBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
