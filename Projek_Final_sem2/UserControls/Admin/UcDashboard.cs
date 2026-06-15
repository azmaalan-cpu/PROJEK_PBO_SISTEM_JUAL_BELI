using Npgsql;
using Projek_Final_sem2.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Projek_Final_sem2.UserControls
{
    public partial class UcDashboard : UserControl
    {
        public UcDashboard()
        {
            InitializeComponent();

        }
        private void UcDashboard_Load(object sender, EventArgs e)
        {

        }

        private void DgvBarangStokMenipis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LbAngkaBarang_Click(object sender, EventArgs e)
        {
            loadDashboard();
        }
        private void loadDashboard()
        {
            //LbAngkaBarang.
        }
    }
}
