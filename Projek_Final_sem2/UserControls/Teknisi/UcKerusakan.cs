using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Projek_Final_sem2.Koneksi;

namespace Projek_Final_sem2.UserControls.Teknisi
{
    public partial class UcKerusakan : UserControl
    {
        public UcKerusakan()
        {
            InitializeComponent();
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
            DatabaseHelper db = new DatabaseHelper();
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
                using (NpgsqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                INSERT INTO servis
                (
                    tanggal_servis,
                    id_user,
                    nama_alat,
                    kerusakan,
                    biaya_servis,
                    status_servis
                )
                VALUES
                (
                    @tanggal,
                    @id_user,
                    @nama_alat,
                    @kerusakan,
                    @biaya_servis,
                    'Proses'
                )";

                    using (NpgsqlCommand cmd =
                        new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@tanggal",
                            DtpKerusakan.Value.Date);

                        cmd.Parameters.AddWithValue(
                            "@nama_alat",
                            TbxNamaALatKerusakan.Text);

                        cmd.Parameters.AddWithValue(
                            "@kerusakan",
                            RtbxKerusakan.Text);

                        cmd.Parameters.AddWithValue(
                            "@biaya_servis",
                            biayaServis);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Data servis berhasil disimpan!",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                TbxNamaALatKerusakan.Clear();
                RtbxKerusakan.Clear();
                TbxBiayaServisKerusakan.Clear();
                DtpKerusakan.Value = DateTime.Today;

                TbxNamaALatKerusakan.Focus();
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
            DtpKerusakan.Value = DateTime.Today;

            // Jika tanggal tidak boleh diubah
            DtpKerusakan.Enabled = false;

            TbxNamaALatKerusakan.Focus();
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
        private bool ValidasiInput()
        {
            if (TbxNamaALatKerusakan.Text == "")
            {
                MessageBox.Show(
                    "Nama alat harus diisi");

                TbxNamaALatKerusakan.Focus();

                return false;
            }

            if (RtbxKerusakan.Text == "")
            {
                MessageBox.Show(
                    "Kerusakan harus diisi");

                RtbxKerusakan.Focus();

                return false;
            }

            if (TbxBiayaServisKerusakan.Text == "")
            {
                MessageBox.Show(
                    "Biaya servis harus diisi");

                TbxBiayaServisKerusakan.Focus();

                return false;
            }

            return true;
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
