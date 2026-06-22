using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Projek_Final_sem2.Koneksi;
using Projek_Final_sem2.Control.Teknisi;
using Projek_Final_sem2.DAO;

namespace Projek_Final_sem2.UserControls.Teknisi
{
    public partial class UcKerusakan : UserControl
    {
        private readonly KerusakanControl controller = new KerusakanControl();

        public UcKerusakan()
        {
            InitializeComponent();
        }

        private bool IsInDesignMode()
        {
            return System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime
                   || (this.Site != null && this.Site.DesignMode);
        }

        private void LblDetailKerusakan_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnSimpanKerusakan_Click_1(object sender, EventArgs e)
        {
            var controller = new KerusakanControl();
            if (string.IsNullOrWhiteSpace(TbxNamaALatKerusakan.Text))
            {
                MessageBox.Show("Nama alat harus diisi!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TbxNamaALatKerusakan.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(RtbxKerusakan.Text))
            {
                MessageBox.Show("Kerusakan alat harus diisi!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                RtbxKerusakan.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(TbxBiayaServisKerusakan.Text))
            {
                MessageBox.Show("Biaya servis harus diisi!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TbxBiayaServisKerusakan.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(TbxSparepart.Text))
            {
                MessageBox.Show("Sparepart harus diisi!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TbxSparepart.Focus();
                return;
            }

            if (!decimal.TryParse(
                TbxBiayaServisKerusakan.Text,
                out decimal biayaServis))
            {
                MessageBox.Show("Biaya servis harus berupa angka!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TbxBiayaServisKerusakan.Focus();
                TbxBiayaServisKerusakan.SelectAll();
                return;
            }

            try
            {
                bool ok = controller.CreateServis(3, TbxNamaALatKerusakan.Text, RtbxKerusakan.Text, biayaServis, TbxSparepart.Text);

                if (ok)
                {
                    MessageBox.Show(
                        "Data servis berhasil disimpan!",
                        "Informasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    TbxNamaALatKerusakan.Clear();
                    RtbxKerusakan.Clear();
                    TbxBiayaServisKerusakan.Clear();
                    TbxSparepart.Clear();
                    DtpKerusakan.Value = DateTime.Today;

                    TbxNamaALatKerusakan.Focus();
                }
                else
                {
                    MessageBox.Show("Gagal menyimpan data servis.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Terjadi kesalahan : " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void UcKerusakan_Load(object sender, EventArgs e)
        {
            if (IsInDesignMode())
                return;
            DtpKerusakan.Value = DateTime.Today;

            // Jika tanggal tidak boleh diubah
            DtpKerusakan.Enabled = false;

            TbxNamaALatKerusakan.Focus();

            // Load teknisi list into combobox
            try
            {
                var dtTeknisi = controller.GetUsersByRole("teknisi");
                Cbx_teknisi.DisplayMember = "username";
                Cbx_teknisi.ValueMember = "id_user";
                Cbx_teknisi.DataSource = dtTeknisi;
                Cbx_teknisi.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat daftar teknisi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TbxBiayaServisKerusakan_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(TbxBiayaServisKerusakan.Text,out decimal biaya))
            {
                TbxBiayaServisKerusakan.Text =
                    biaya.ToString("N0");
            }
        }

        private void BtnBatalKerusakan_Click(object sender, EventArgs e)
        {
            TbxNamaALatKerusakan.Clear();

            RtbxKerusakan.Clear();

            TbxBiayaServisKerusakan.Clear();

            DtpKerusakan.Value = DateTime.Today;

            TbxNamaALatKerusakan.Focus();
        }

        private void TbxBiayaServisKerusakan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
