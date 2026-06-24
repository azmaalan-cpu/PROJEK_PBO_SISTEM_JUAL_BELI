using System;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Projek_Final_sem2.UserControls.Admin
{
    public partial class UcDashboard : UserControl
    {
        private object? _dashboardController;

        public UcDashboard()
        {
            InitializeComponent();
        }

        private void UcDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                InitController();
                LoadMetrics();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal inisialisasi dashboard admin: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitController()
        {
            if (_dashboardController != null) return;
            Type? ctrlType = null;
            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                try
                {
                    ctrlType = asm.GetType("Projek_Final_sem2.Control.Admin.DashboardControl");
                    if (ctrlType != null) break;
                    ctrlType = asm.GetTypes().FirstOrDefault(t => string.Equals(t.Name, "DashboardControl", StringComparison.OrdinalIgnoreCase) && t.Namespace != null && t.Namespace.Contains("Admin"));
                    if (ctrlType != null) break;
                }
                catch { }
            }
            if (ctrlType == null) return;
            _dashboardController = Activator.CreateInstance(ctrlType);
        }

        private void LoadMetrics()
        {
            if (_dashboardController == null) return;
            var t = _dashboardController.GetType();
            try
            {
                var mPendapatan = t.GetMethod("DapatkanTotalPendapatan", BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase)
                                    ?? t.GetMethod("GetTotalRevenue", BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                if (mPendapatan != null)
                {
                    var r = mPendapatan.Invoke(_dashboardController, null);
                    if (r != null) LbAngkaPendapatan.Text = r.ToString();
                }

                var mPenjualan = t.GetMethod("DapatkanTotalPenjualan", BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase)
                                    ?? t.GetMethod("GetTotalPenjualan", BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                if (mPenjualan != null)
                {
                    var r = mPenjualan.Invoke(_dashboardController, null);
                    if (r != null) LbAngkaPenjualan.Text = r.ToString();
                }

                var mServis = t.GetMethod("DapatkanTotalServis", BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase)
                                    ?? t.GetMethod("GetTotalServis", BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                if (mServis != null)
                {
                    var r = mServis.Invoke(_dashboardController, null);
                    if (r != null) LbAngkaServis.Text = r.ToString();
                }

                var mBarang = t.GetMethod("DapatkanTotalBarang", BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase)
                                    ?? t.GetMethod("GetTotalBarang", BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                if (mBarang != null)
                {
                    var r = mBarang.Invoke(_dashboardController, null);
                    if (r != null) LbAngkaBarang.Text = r.ToString();
                }
            }
            catch { }
        }
    }
}
