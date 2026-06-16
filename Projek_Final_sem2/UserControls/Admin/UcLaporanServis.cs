using Projek_Final_sem2.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using Projek_Final_sem2.Models;
using Projek_Final_sem2.DAO;

namespace Projek_Final_sem2.UserControls
{
    public partial class UcLaporanServis : UserControl
    {
        private ServiceDAO serviceDAO = new ServiceDAO();
        public UcLaporanServis()
        {
            InitializeComponent();

        }
        private void LoadGrafikServis()
        {
            DataTable dt = serviceDAO.GetGrafikServis(DtmPickerTanggalAwal.Value, DtmPickerTanggalAkhir.Value);
            double[] values = dt.AsEnumerable().Select(row => Convert.ToDouble(row["total_servis"])).ToArray();
            string[] labels = dt.AsEnumerable().Select(row => ((DateOnly)row["tanggal_servis"]).ToString("dd/MM/yyyy")).ToArray();
            double[] positions = Enumerable.Range(0, labels.Length).Select(x => (double)x).ToArray();
            FmPlotServis.Plot.Clear();
            FmPlotServis.Plot.Axes.Bottom.SetTicks(positions, labels);
            FmPlotServis.Plot.Title("Grafik Servis");
            FmPlotServis.Plot.XLabel("Tanggal");
            FmPlotServis.Plot.YLabel("Total Servis(Rp)");
            FmPlotServis.Plot.Add.Bars(values);
            FmPlotServis.Plot.Axes.AutoScale();
            FmPlotServis.Refresh();
            decimal totalServis = dt.AsEnumerable().Sum(row => Convert.ToDecimal(row["total_servis"]));
            LbTotalService.Text = $"Total Servis: Rp {totalServis:N0}";
            LbTotalPendapatanServis.Text = $"Total Pendapatan Servis: Rp {totalServis:N0}";

        }

        private void UcLaporanServis_Load(object sender, EventArgs e)
        {
            loaddataservis();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LbJudulLaporanServis_Click(object sender, EventArgs e)
        {

        }

        private void DgvDataServis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loaddataservis();
        }

        private void loaddataservis()
        {
            LoadGrafikServis();
        }

        private void FmPlotServis_Load(object sender, EventArgs e)
        {

        }

        private void BtnTampilkan_Click(object sender, EventArgs e)
        {
          LoadGrafikServis();
        }
    }
}
