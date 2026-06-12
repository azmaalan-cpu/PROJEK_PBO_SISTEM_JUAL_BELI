using Projek_Final_sem2.Examples.OOPExample.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projek_Final_sem2.UserControls
{
    public partial class UcLaporanPenjualan : UserControl
    {
        private TransaksiDAO transaksiDAO = new TransaksiDAO();
        public UcLaporanPenjualan()
        {
            InitializeComponent();
        }

        private void LoadGrafik()
        {
            DataTable dt = transaksiDAO.GetDataGrafikPenjualan(DtmPickerTanggalAwal.Value, DtmPickerTanggalAkhir.Value);
            double[] values = dt.AsEnumerable().Select(row => Convert.ToDouble(row["total_penjualan"])).ToArray();
            string[] labels = dt.AsEnumerable().Select(row => ((DateOnly)row["tanggal"]).ToString("dd/MM/yyyy")).ToArray();
            double[] positions = Enumerable.Range(0, labels.Length).Select(x => (double)x).ToArray();
            FmPlotPenjualan.Plot.Axes.Bottom.SetTicks(positions, labels);
            FmPlotPenjualan.Plot.Clear();
            FmPlotPenjualan.Plot.Title("Grafik Penjualan");
            FmPlotPenjualan.Plot.XLabel("Tanggal");
            FmPlotPenjualan.Plot.YLabel("Total Penjualan(Rp)");
            FmPlotPenjualan.Plot.Add.Bars(values);
            FmPlotPenjualan.Plot.Axes.AutoScale();
            FmPlotPenjualan.Refresh();

            decimal totalPenjualan = dt.AsEnumerable().Sum(row => Convert.ToDecimal(row["total_penjualan"]));
            LbTotalPenjualan.Text = $"Total Penjualan: Rp {totalPenjualan:N0}";

        }

        private void BtnTampilkan_Click(object sender, EventArgs e)
        {
            LoadGrafik();
        }
    }
}
