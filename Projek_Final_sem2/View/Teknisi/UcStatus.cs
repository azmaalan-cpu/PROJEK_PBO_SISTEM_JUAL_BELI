using Npgsql;
using Projek_Final_sem2.DAO;
using Projek_Final_sem2.Koneksi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projek_Final_sem2.UserControls.Teknisi
{
    public partial class UcStatus : UserControl
    {
        private readonly Projek_Final_sem2.Control.Teknisi.StatusControl _statusControl = new Projek_Final_sem2.Control.Teknisi.StatusControl();

        public UcStatus()
        {
            InitializeComponent();
        }

        private bool IsInDesignMode()
        {
            return System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime
                   || (this.Site != null && this.Site.DesignMode);
        }

        private void UcStatus_Load(object sender, EventArgs e)
        {
            if (IsInDesignMode())
                return;
            CmbUbahStatus.Items.Clear();

            CmbUbahStatus.Items.Add("Menunggu");
            CmbUbahStatus.Items.Add("Proses");

            CmbUbahStatus.SelectedIndex = 0;

            LoadDataServis(0, "", "Menunggu");
        }
        public void LoadDataServis(int idServis, string namaAlat, string statusSaatIni)
        {
            TbxIDServisStatus.Text = idServis.ToString();

            TbxNamaAlatStatus.Text = namaAlat;

            LblStatusSaatIni.Text = statusSaatIni;

            CmbUbahStatus.Text = statusSaatIni;
        }

        private void BtnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput())
                return;

            if (!int.TryParse(TbxIDServisStatus.Text, out int id))
            {
                MessageBox.Show("ID servis tidak valid!");
                return;
            }

            try
            {
                bool ok = _statusControl.UpdateStatus(id, CmbUbahStatus.Text);
                if (ok)
                {
                    MessageBox.Show("Status servis berhasil diperbarui!");
                    LblStatusSaatIni.Text = CmbUbahStatus.Text;
                }
                else
                {
                    MessageBox.Show("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private bool ValidasiInput()
        {
            if (string.IsNullOrWhiteSpace(TbxIDServisStatus.Text))
            {
                MessageBox.Show("Data servis belum dipilih!");

                return false;
            }

            if (CmbUbahStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih status servis!");

                return false;
            }

            return true;
        }

        private void BtnBatalStatus_Click(object sender, EventArgs e)
        {
            TbxIDServisStatus.Clear();

            TbxNamaAlatStatus.Clear();

            LblStatusSaatIni.Text = "-";

            CmbUbahStatus.SelectedIndex = -1;
        }

        private void BtnCariStatus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbxIDServisStatus.Text))
            {
                MessageBox.Show(
                    "Masukkan ID Servis!");

                TbxIDServisStatus.Focus();

                return;
            }
            try
            {
                int id = Convert.ToInt32(TbxIDServisStatus.Text);
                var service = _statusControl.GetServiceById(id);
                if (service != null)
                {
                    TbxNamaAlatStatus.Text = service.nama_alat;
                    LblStatusSaatIni.Text = service.status_servis;
                    CmbUbahStatus.Text = service.status_servis;
                }
                else
                {
                    MessageBox.Show("ID Servis tidak ditemukan!");
                    TbxNamaAlatStatus.Clear();
                    LblStatusSaatIni.Text = "-";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LblStatusSaatIni_Click(object sender, EventArgs e)
        {

        }

        private void TbxIDServisStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmbUbahStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
