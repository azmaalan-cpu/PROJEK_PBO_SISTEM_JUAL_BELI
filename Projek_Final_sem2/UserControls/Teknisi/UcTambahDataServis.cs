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
    public partial class UcTambahDataServis : UserControl
    {
        public UcTambahDataServis()
        {
            InitializeComponent();
        }
        private void KembaliKeDataServis()
        {
            FmUtamaTeknisi fm = (FmUtamaTeknisi)this.FindForm();

            fm.LoadUserControl(new UcDataServis());
        }
        private bool ValidasiInput()
        {
            if (string.IsNullOrWhiteSpace(TbxNamaAlat.Text))
            {
                MessageBox.Show("Nama alat wajib diisi!");
                TbxNamaAlat.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TbxKerusakan.Text))
            {
                MessageBox.Show("Kerusakan wajib diisi!");
                TbxKerusakan.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TbxBiayaServis.Text))
            {
                MessageBox.Show("Biaya servis wajib diisi!");
                TbxBiayaServis.Focus();
                return false;
            }

            if (!decimal.TryParse(TbxBiayaServis.Text, out _))
            {
                MessageBox.Show("Biaya servis harus berupa angka!");
                TbxBiayaServis.Focus();
                return false;
            }

            return true;
        }
        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput())
                return;

            try
            {
                using (var conn = new DatabaseHelper().GetConnection())
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
                CURRENT_DATE,
                @id_user,
                @nama_alat,
                @kerusakan,
                @biaya,
                'Proses'
            )";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@nama_alat",
                            TbxNamaAlat.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@kerusakan",
                            TbxKerusakan.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@biaya",
                            Convert.ToDecimal(TbxBiayaServis.Text));

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Data servis berhasil ditambahkan!",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                KembaliKeDataServis();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void BtnBatal_Click(object sender, EventArgs e)
        {
            KembaliKeDataServis();
        }
        private void TbxBiayaServis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void UcTambahDataServis_Load(object sender, EventArgs e)
        {

        }
    }
}
