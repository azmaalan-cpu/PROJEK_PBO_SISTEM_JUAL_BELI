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
using Projek_Final_sem2.Control.Admin;
using Projek_Final_sem2.DAO;

    public partial class UcLaporanServis : UserControl
    {
        private LaporanServisControl laporanServisControl = new LaporanServisControl();
        // Keep a ServiceDAO instance to preserve any remaining direct calls (temporary compatibility)
        private readonly ServiceDAO serviceDAO = new ServiceDAO();
        public UcLaporanServis()
        {
            InitializeComponent();

        }
        private void LoadGrafikServis()
        {
            var (values, labels, positions, total) = laporanServisControl.LoadGrafikServis(DtmPickerTanggalAwal.Value, DtmPickerTanggalAkhir.Value);

            FmPlotServis.Plot.Clear();
            FmPlotServis.Plot.Axes.Bottom.SetTicks(positions, labels);
            FmPlotServis.Plot.Title("Grafik Servis");
            FmPlotServis.Plot.XLabel("Tanggal");
            FmPlotServis.Plot.YLabel("Total Servis(Rp)");
            FmPlotServis.Plot.Add.Bars(values);
            FmPlotServis.Plot.Axes.AutoScale();
            FmPlotServis.Refresh();

            LbTotalService.Text = $"Total Servis: Rp {total:N0}";
            LbTotalPendapatanServis.Text = $"Total Pendapatan Servis: Rp {total:N0}";

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

        private void PanelTotalTransaksi_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
