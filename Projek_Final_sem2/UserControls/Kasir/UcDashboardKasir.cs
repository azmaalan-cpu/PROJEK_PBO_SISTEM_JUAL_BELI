using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using System.Data;

namespace Projek_Final_sem2.UserControls.Kasir
{
    public partial class UcDashboardKasir : UserControl
    {
        public UcDashboardKasir()
        {
            InitializeComponent();
        }

        private void LoadDashboardKasir()
        {
            //LoadTotalBarang();
            //LoadTotalTransaksi();
            //LoadTotalPendapatan();
            //LoadStokBarang();
            //LoadTransaksiTerbaru();
        }

        private void UcDashboardKasir_Load(object sender, EventArgs e)
        {
            LoadDashboardKasir();
        }
    }
}
