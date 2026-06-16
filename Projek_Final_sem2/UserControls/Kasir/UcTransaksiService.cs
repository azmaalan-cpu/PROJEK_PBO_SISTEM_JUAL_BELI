using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Projek_Final_sem2.UserControls.Kasir.DAO.TransaksiDAO;
using Projek_Final_sem2.DAO;

namespace Projek_Final_sem2.UserControls.Kasir
{
    public partial class UcTransaksiService : UserControl
    {
        private ServiceDAO serviceDAO;
        public UcTransaksiService()
        {
            InitializeComponent();
            serviceDAO = new ServiceDAO();
        }

        private void PanelMainService_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btnbatal_Click(object sender, EventArgs e)
        {
            if (currentIdServis == 0)
            {
                MessageBox.Show("Tidak ada data servis yang aktif.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                ClearLabels();
                TbCariIdService.Clear();
                TbCariIdService.Focus();

        }

        private void BtnBayarService_Click(object sender, EventArgs e)
        {
            if (currentIdServis == 0)
            {
                MessageBox.Show("Cari ID Servis terlebih dahulu.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            serviceDAO.BayarServis(currentIdServis);

            string pesan = $"Pembayaran Berhasil!\n\n" +
                           $"ID Servis  : {label1.Text}\n" +
                           $"Nama Alat  : {label2.Text}\n" +
                           $"Kerusakan  : {label3.Text}\n" +
                           $"Sparepart  : {label4.Text}\n" +
                           $"Total Bayar: {label5.Text}";

            MessageBox.Show(pesan, "Pembayaran Berhasil",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Setelah msgbox ditutup, clear otomatis
            ClearLabels();
            TbCariIdService.Clear();
            TbCariIdService.Focus();

        }
        private void BtnCariIdServis_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TbCariIdService.Text.Trim(), out int idServis))
            {
                MessageBox.Show("Masukkan ID Servis yang valid.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadDataServis(idServis);
        }


        private readonly BayarServisRepo repo = new BayarServisRepo();
        private int currentIdServis = 0;

        private void ClearLabels()
        {
            label1.Text = "-";
            label2.Text = "-";
            label3.Text = "-";
            label4.Text = "-";
            label5.Text = "-";
            currentIdServis = 0;
        }

        private void LoadDataServis(int idServis)
        {
            var row = repo.GetServisById(idServis);

            if (row == null)
            {
                MessageBox.Show("ID Servis tidak ditemukan.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearLabels();
                return;
            }

            if(row["status_servis"].ToString() == "Selesai")
            {
                MessageBox.Show("Servis ini sudah dibayar.", "Infomasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearLabels();
                return;
            }

            currentIdServis = idServis;
            label1.Text = row["id_servis"].ToString();
            label2.Text = row["nama_alat"].ToString();
            label3.Text = row["kerusakan"].ToString();
            label4.Text = row["sparepart"].ToString();
            label5.Text = $"Rp {Convert.ToDecimal(row["biaya_servis"]):N0}";
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TbCariIdService.Text.Trim(), out int idServis))
            {
                MessageBox.Show("Masukkan ID Servis yang valid.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadDataServis(idServis);
        }
    }
}
