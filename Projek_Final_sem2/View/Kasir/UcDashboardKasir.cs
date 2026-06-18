using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using System.Data;
using Projek_Final_sem2.Koneksi;
using Projek_Final_sem2.DAO;

namespace Projek_Final_sem2.UserControls.Kasir
{
    public partial class UcDashboardKasir : UserControl
    {
        private TransaksiDAO transaksiDAO = new TransaksiDAO();
        public UcDashboardKasir()
        {
            InitializeComponent();
        }

        private void LoadDashboardKasir()
        {

            LbPendapatanDashboard.Text =
                transaksiDAO.GetTotalPendapatan()
                .ToString("N0");

            LbJumlahBarang.Text =
                transaksiDAO.GetTotalBarangTerjual()
                .ToString();

            LbIdTransaksi.Text =
                transaksiDAO.GetTotalTransaksi()
                .ToString();


            LabelTotalBarang.Text =
                transaksiDAO.GetTotalBarangTerjual().ToString();

            LabelTotalTransaksi.Text =
                transaksiDAO.GetTotalTransaksi().ToString();

            LabelTotalPendapatan.Text =
                "Rp " +
                transaksiDAO.GetTotalPendapatan().ToString("N0");
        }

        private void UcDashboardKasir_Load(object sender, EventArgs e)
        {
            LoadDashboardKasir();
            LoadTransaksi();
        }

        private void LoadTransaksi()
        {
            DgvTransaksi.AutoGenerateColumns = false;
            DgvTransaksi.DataSource =
                transaksiDAO.GetTransaksiPenjualan();
        }

        private void DgvTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex < 0)
                return;

            int idTransaksi =
                Convert.ToInt32(
                DgvTransaksi.Rows[e.RowIndex]
                .Cells["No Transaksi"].Value);

            DataTable dt =
                transaksiDAO.GetInformasiTransaksi();

            DataRow[] row =
                dt.Select(
                "id_transaksi = " + idTransaksi);

            if (row.Length > 0)
            {
                LbIdTransaksi.Text =
                    row[0]["id_transaksi"].ToString();

                LbPendapatan.Text =
                    "Rp " +
                    Convert.ToDecimal(
                    row[0]["pendapatan"])
                    .ToString("N0");

                LbJumlahBarang.Text =
                    row[0]["jumlah_barang"].ToString();
            }
        }

    }
}

