using Projek_Final_sem2.Examples.OOPExample.DAO;
using System.Linq;
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
            // clear plot first
            FmPlotPenjualan.Plot.Clear();

            if (dt.Rows.Count == 0)
            {
                // no data
                FmPlotPenjualan.Refresh();
                LbTotalPenjualan.Text = "Total Penjualan: Rp 0";
                return;
            }

            double[] values = dt.AsEnumerable().Select(row => Convert.ToDouble(row["total_penjualan"])).ToArray();
            string[] labels = dt.AsEnumerable().Select(row =>
            {
                if (row.IsNull("tanggal"))
                    return string.Empty;

                var val = row["tanggal"];

                // handle DateOnly (new in .NET 6+) and DateTime
                if (val is DateOnly dateOnly)
                    return dateOnly.ToString("dd/MM/yyyy");

                if (val is DateTime dateTime)
                    return dateTime.ToString("dd/MM/yyyy");

                // fallback: try parse string representation
                if (DateTime.TryParse(val?.ToString(), out var parsed))
                    return parsed.ToString("dd/MM/yyyy");

                return val?.ToString() ?? string.Empty;
            }).ToArray();
            double[] positions = Enumerable.Range(0, labels.Length).Select(x => (double)x).ToArray();

            // add bars then set tick labels so they align
            FmPlotPenjualan.Plot.Add.Bars(values);
            FmPlotPenjualan.Plot.Title("Grafik Penjualan");
            FmPlotPenjualan.Plot.XLabel("Tanggal");
            FmPlotPenjualan.Plot.YLabel("Total Penjualan(Rp)");
            FmPlotPenjualan.Plot.Axes.Bottom.SetTicks(positions, labels);
            FmPlotPenjualan.Plot.Axes.AutoScale();
            FmPlotPenjualan.Refresh();

            decimal totalPenjualan = dt.AsEnumerable().Sum(row => Convert.ToDecimal(row["total_penjualan"]));
            LbTotalPenjualan.Text = $"Total Penjualan: Rp {totalPenjualan:N0}";

        }

        private void BtnTampilkan_Click(object sender, EventArgs e)
        {
            LoadGrafik();
        }

        private void FmPlotPenjualan_Load(object sender, EventArgs e)
        {

        }
    }
}
