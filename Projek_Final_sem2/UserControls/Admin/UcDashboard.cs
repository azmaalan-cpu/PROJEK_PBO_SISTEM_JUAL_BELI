using Npgsql;
using Projek_Final_sem2.DAO;
using Projek_Final_sem2.UserControls.Kasir.DAO;
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
        private DashboardAdminDAO dashboardAdminDAO = new DashboardAdminDAO();
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
            if(e.RowIndex >= 0)
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
            LbAngkaBarang.Text = dashboardAdminDAO.GetTotalBarang().ToString();
            LbAngkaPenjualan.Text = dashboardAdminDAO.GetTotalPenjualan().ToString();
            LbAngkaServis.Text = dashboardAdminDAO.GetTotalServis().ToString();
            LbAngkaPendapatan.Text = "Rp." + dashboardAdminDAO.GetPendapatanPenjualan().ToString("N0", new CultureInfo("id-ID"));
            DgvBarangStokMenipis.DataSource = dashboardAdminDAO.GetBarangStokMenipis();

        }
    }
}
