using Projek_Final_sem2.DAO;
using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Projek_Final_sem2.Control.Admin;

namespace Projek_Final_sem2.UserControls
{
    public partial class UcLaporanPenjualan : UserControl
    {
        private readonly LaporanPenjualanControl _control = new LaporanPenjualanControl();
        public UcLaporanPenjualan()
        {
            InitializeComponent();
        }

        private void LoadGrafik()
        {
            DataTable dt = _control.GetLaporanPenjualan(DtmPickerTanggalAwal.Value, DtmPickerTanggalAkhir.Value);
            // clear plot first
            FmPlotPenjualan.Plot.Clear();

            if (dt.Rows.Count == 0)
            {
                // no data
                FmPlotPenjualan.Refresh();
                LbTotalPenjualan.Text = "Total Penjualan: Rp 0";
                return;
            }

            // ensure expected value column exists; try to find a sensible fallback
            string valueColumn = "total_penjualan";
            if (!dt.Columns.Contains(valueColumn))
            {
                var fallback = dt.Columns.Cast<DataColumn>()
                                .Select(c => c.ColumnName)
                                .FirstOrDefault(n => n.IndexOf("total", StringComparison.OrdinalIgnoreCase) >= 0
                                                     || n.IndexOf("penjualan", StringComparison.OrdinalIgnoreCase) >= 0);

                if (!string.IsNullOrEmpty(fallback))
                    valueColumn = fallback;
                else
                {
                    // no appropriate column found -> show empty plot and zero total
                    FmPlotPenjualan.Refresh();
                    LbTotalPenjualan.Text = "Total Penjualan: Rp 0";
                    return;
                }
            }

            // group rows by transaction date and sum totals per date
            var groups = dt.AsEnumerable()
                .Select(row =>
                {
                    DateTime? date = null;
                    if (!row.IsNull("tanggal"))
                    {
                        var v = row["tanggal"];
                        if (v is DateOnly d)
                            date = d.ToDateTime(TimeOnly.MinValue).Date;
                        else if (v is DateTime dtv)
                            date = dtv.Date;
                        else if (DateTime.TryParse(v?.ToString(), out var parsed))
                            date = parsed.Date;
                    }

                    return new { Row = row, Date = date };
                })
                .Where(x => x.Date.HasValue)
                .GroupBy(x => x.Date.Value)
                .OrderBy(g => g.Key)
                .Select(g => new
                {
                    Date = g.Key,
                    Total = g.Sum(x =>
                    {
                        var v = x.Row[valueColumn];
                        return v == null || v == DBNull.Value ? 0m : Convert.ToDecimal(v);
                    })
                })
                .ToList();

            if (groups.Count == 0)
            {
                // no valid tanggal values to plot
                FmPlotPenjualan.Refresh();
                LbTotalPenjualan.Text = "Total Penjualan: Rp 0";
                return;
            }

            double[] values = groups.Select(g => (double)g.Total).ToArray();
            // labels show day and month, e.g. "15 June"
            string[] labels = groups.Select(g => g.Date.ToString("dd MMMM")).ToArray();
            double[] positions = Enumerable.Range(0, labels.Length).Select(x => (double)x).ToArray();

            // add bars then set tick labels so they align
            FmPlotPenjualan.Plot.Add.Bars(values);
            FmPlotPenjualan.Plot.Title("Grafik Penjualan");
            FmPlotPenjualan.Plot.XLabel("Tanggal");
            FmPlotPenjualan.Plot.YLabel("Total Penjualan(Rp)");
            FmPlotPenjualan.Plot.Axes.Bottom.SetTicks(positions, labels);
            FmPlotPenjualan.Plot.Axes.AutoScale();
            FmPlotPenjualan.Refresh();

            decimal totalPenjualan = groups.Sum(g => g.Total);
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
