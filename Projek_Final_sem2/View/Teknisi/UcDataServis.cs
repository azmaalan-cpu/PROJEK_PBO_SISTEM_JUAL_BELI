using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Projek_Final_sem2.Koneksi;
using Projek_Final_sem2.DAO;

namespace Projek_Final_sem2.UserControls.Teknisi
{
    public partial class UcDataServis : UserControl
    {
        private List<Projek_Final_sem2.Models.Service> _allServices = new List<Projek_Final_sem2.Models.Service>();
        private BindingSource _bs = new BindingSource();
        public UcDataServis()
        {
            InitializeComponent();
            this.Load += UcDataServis_Load;
        }
        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            // Filter in-memory list and rebind
            string q = TextCariDataServis.Text?.Trim() ?? string.Empty;
            if (string.IsNullOrEmpty(q))
            {
                _bs.DataSource = new BindingList<Projek_Final_sem2.Models.Service>(_allServices);
                DgvDataServis.DataSource = _bs;
                return;
            }

            var filtered = _allServices.FindAll(s => !string.IsNullOrEmpty(s.nama_alat) && s.nama_alat.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0);

            _bs.DataSource = new BindingList<Projek_Final_sem2.Models.Service>(filtered);
            DgvDataServis.DataSource = _bs;
        }
        private Panel panelUtama;

        public UcDataServis(Panel panel)
        {
            InitializeComponent();

            panelUtama = panel;
        }

        private void DgvDataServis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadDataServis()
        {
            var control = new Projek_Final_sem2.Control.Teknisi.DataServisControl();
            _allServices = control.GetAllServices();

            DgvDataServis.DataSource = null;
            DgvDataServis.AutoGenerateColumns = false;

            // map columns to model properties
            ColumnIdServis.DataPropertyName = "id_servis";
            ColumnTanggalServis.DataPropertyName = "tanggal_servis";
            ColumnNamaAlat.DataPropertyName = "nama_alat";
            ColumnKerusakan.DataPropertyName = "kerusakan";
            ColumnBiayaServis.DataPropertyName = "biaya_servis";
            ColumnStatus.DataPropertyName = "status_servis";

            _bs.DataSource = new BindingList<Projek_Final_sem2.Models.Service>(_allServices);
            DgvDataServis.DataSource = _bs;
        }
        private void UcDataServis_Load(object sender, EventArgs e)
        {
            LoadDataServis();
        }
    }
}
