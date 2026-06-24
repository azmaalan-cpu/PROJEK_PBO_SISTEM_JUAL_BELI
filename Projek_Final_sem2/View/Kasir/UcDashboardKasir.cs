using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using Projek_Final_sem2.Control.Kasir;
using Projek_Final_sem2.DAO;
using Projek_Final_sem2.Koneksi;

namespace Projek_Final_sem2.UserControls.Kasir
{
    public partial class UcDashboardKasir : UserControl
    {
        private DashboardTransaksiKasirDAO transaksiDAO = new DashboardTransaksiKasirDAO();
        private TransaksiServiceControl transaksiService = new TransaksiServiceControl();

        public UcDashboardKasir()
        {
            InitializeComponent();
        }

        private void LoadDashboardKasir()
        {
            DataTable dt = transaksiService.GetDashboardKasir();

            if (dt.Rows.Count > 0)
            {
                LbPendapatan.Text = "Total Pendapatan";

                LabelTotalBarang.Text =
                dt.Rows[0]["total_barang"].ToString();

                LabelTotalTransaksi.Text =
                dt.Rows[0]["total_transaksi"].ToString();

                LabelTotalPendapatan.Text = Convert.ToDecimal(dt.Rows[0]["total_pendapatan"])
                 .ToString("N0");
            }
        }

        private void UcDashboardKasir_Load(object sender, EventArgs e)
        {
            LoadDashboardKasir();
            LoadTransaksi();
        }

        private void LoadTransaksi()
        {
            DgvTransaksi.RowHeadersVisible = false;
            DgvTransaksi.AutoGenerateColumns = false;
            DgvTransaksi.DataSource =
                transaksiService.GetTransaksiPenjualan();

            DataRow row =
            transaksiService.GetInformasiTransaksById(1);

            if (row != null)
            {
                LbIdTransaksi.Text =
                    row["id_transaksi"].ToString();

                LbPendapatanDashboard.Text = Convert.ToDecimal(row["total_harga"]).ToString("NO");

                LbJumlahBarang.Text = row["jumlah_barang"].ToString();

            }
        }

        private void DgvTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;

            int idTransaksi =
                Convert.ToInt32(
                DgvTransaksi.Rows[e.RowIndex]
                .Cells[0].Value);
       

            DataRow row = transaksiService.GetInformasiTransaksById(idTransaksi);
          

            if(row != null)
            {
                LbIdTransaksi.Text =
                    row["id_transaksi"].ToString();
                LbPendapatanDashboard.Text =
                    Convert.ToDecimal(row["total_harga"])
                    .ToString("N0");
                LbJumlahBarang.Text =
                    row["jumlah_barang"].ToString();
            }


        }

        private void DgvTransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PanelInfo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

