using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Projek_Final_sem2.Control.Admin;

namespace Projek_Final_sem2.UserControls.Admin
{
    public partial class UcDashboard : UserControl
    {
        private IDashboardController _dashboardController;

        // Event raised when a low-stock item is selected from the dashboard
        public event Action<int> BarangStokMenipisDipilih;

        // Designer needs parameterless ctor. It chains to the main ctor with a default controller.
        public UcDashboard() : this(new DashboardControl()) { }

        public UcDashboard(IDashboardController controller)
        {
            _dashboardController = controller ?? throw new ArgumentNullException(nameof(controller));
            InitializeComponent();
        }

        private void UcDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                LoadMetrics();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal inisialisasi dashboard admin: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMetrics()
        {
            try
            {
                var metrics = _dashboardController.LoadDashboardMetrics();
                if (metrics != null)
                {
                    LbAngkaPenjualan.Text = metrics.TotalPenjualan.ToString();
                    LbAngkaServis.Text = metrics.TotalServis.ToString();
                    LbAngkaPendapatan.Text = _dashboardController.GetPendapatanPenjualan().ToString("C0", new CultureInfo("id-ID"));
                    LbAngkaBarang.Text = _dashboardController.GetTotalBarang().ToString();
                    // bind recent transactions and low-stock items
                    try { DgvServisTerbaru.AutoGenerateColumns = true ; } catch { }
                    try { DgvServisTerbaru.DataSource = metrics.RecentTransactions; } catch { }
                    try {id_servis.DataPropertyName = "id_servis"; } catch { }
                    try {nama_alat.DataPropertyName = "nama_alat"; } catch { }
                    try {status_servis.DataPropertyName = "status_servis "; } catch { }

                    try { DgvBarangStokMenipis.DataSource = _dashboardController.GetBarangStokMenipis(); } catch { }
                    //try { DgvBarangStokMenipis.Columns["id_alat"].Visible= false; } catch { }
                    try { DgvBarangStokMenipis.AutoGenerateColumns = true; } catch { }
                    try { id_alat.DataPropertyName = "id_alat";  } catch { }
                    try { Column2.DataPropertyName = "nama_alat";  } catch { }
                    try { stok.DataPropertyName = "stok"; } catch { }
                }

            }
            catch { }
        }

        // Designer references these handlers. Provide stubs so compilation succeeds.
        private void DgvServisTerbaru_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // optional: handle cell clicks for service grid
        }

        private void DgvBarangStokMenipis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // When user double-clicks a low-stock item, attempt to raise the selection event with the item id
            try
            {
                if (sender is DataGridView dgv && dgv.CurrentRow != null)
                {
                    var val = dgv.CurrentRow.Cells[0].Value;
                    if (val != null && int.TryParse(val.ToString(), out int idBarang))
                    {
                        BarangStokMenipisDipilih?.Invoke(idBarang);
                    }
                }
            }
            catch { }
        }

        private void PanelDataBarang_Paint(object sender, PaintEventArgs e)
        {
            // optional custom painting
        }

        private void LbAngkaBarang_Click(object sender, EventArgs e)
        {
            // optional click handler
        }

        private void PanelPendapatan_Paint(object sender, PaintEventArgs e)

        {

        }
    }
}
