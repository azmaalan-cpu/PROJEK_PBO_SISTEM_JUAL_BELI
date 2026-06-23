using Npgsql;
using Projek_Final_sem2.DAO;
// using Projek_Final_sem2.UserControls.Kasir.DAO; (moved to Projek_Final_sem2.DAO)
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;


namespace Projek_Final_sem2.UserControls
{
    public partial class UcDashboard : UserControl
    {
        public event Action<int> BarangStokMenipisDipilih;
        private readonly Projek_Final_sem2.Control.Admin.DashboardControl _dashboardControl = new Projek_Final_sem2.Control.Admin.DashboardControl();

        public UcDashboard()
        {
            InitializeComponent();
        }

        private void UcDashboard_Load(object sender, EventArgs e)
        {
            loadDashboard();
        }


        private void DgvBarangStokMenipis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idBarang = Convert.ToInt32(DgvBarangStokMenipis.Rows[e.RowIndex].Cells["id_alat"].Value);
                BarangStokMenipisDipilih?.Invoke(idBarang);
            }
        }



        private void LbAngkaBarang_Click(object sender, EventArgs e)
        {
            loadDashboard();
        }
        private void loadDashboard()
        {
            LbAngkaBarang.Text = _dashboardControl.GetTotalBarang().ToString();
            LbAngkaPenjualan.Text = _dashboardControl.GetTotalPenjualan(DateTime.Today, DateTime.Today).ToString();
            LbAngkaServis.Text = _dashboardControl.GetTotalServis(DateTime.Today, DateTime.Today).ToString();
            LbAngkaPendapatan.Text = "Rp." + _dashboardControl.GetPendapatanPenjualan().ToString("N0", new CultureInfo("id-ID"));
            DgvBarangStokMenipis.DataSource = _dashboardControl.GetBarangStokMenipis();

            // ensure the latest service data is loaded on dashboard load
            var svc = _dashboardControl.GetDashboardServis();
            DgvServisTerbaru.AutoGenerateColumns = true;
            DgvServisTerbaru.DataSource = svc;

        }

        private void DgvServisTerbaru_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            load_data_servis_terbaru();
        }
        private void load_data_servis_terbaru()
        {
            var svc = _dashboardControl.GetDashboardServis();
            DgvServisTerbaru.AutoGenerateColumns = true;
            DgvServisTerbaru.DataSource = svc;
        }

        private void PanelDataBarang_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
