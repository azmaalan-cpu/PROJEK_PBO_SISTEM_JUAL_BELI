using Projek_Final_sem2.UserControls.Kasir.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using Projek_Final_sem2.Koneksi;
using System.Linq.Expressions;
using Projek_Final_sem2.DAO;


namespace Projek_Final_sem2.UserControls.Kasir
{
    public partial class UcTransaksiPenjualan : UserControl
    {
        private TransaksiDAO transaksiDAO;
        private DatabaseHelper db = new DatabaseHelper();


        public UcTransaksiPenjualan()
        {
            InitializeComponent();
            transaksiDAO = new TransaksiDAO();


        }
        private void LoadBarang()
        {
            using (var conn = new NpgsqlConnection(db.GetConnection().ConnectionString))
            {


            }
        }

        private void HitungTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in DgvKeranjang.Rows)
            {
                if (row.IsNewRow)
                    continue;

                total += Convert.ToDecimal(
                    row.Cells["ColSubTotal"].Value);
            }

            LblTotalBayar.Text =
                "Rp " + total.ToString("N0");
        }

        private void LoadStokBarang()
        {
            LbStok1.Text = "Stok: " + transaksiDAO.CekStok(1);
            LbStok2.Text = "Stok: " + transaksiDAO.CekStok(2);
            LbStok3.Text = "Stok: " + transaksiDAO.CekStok(3);
            LbStok4.Text = "Stok: " + transaksiDAO.CekStok(4);
            LbStok5.Text = "Stok: " + transaksiDAO.CekStok(5);

        }

        private void LbLID1_Click(object sender, EventArgs e)
        {

        }

        private void UcTransaksiPenjualan_Load(object sender, EventArgs e)
        {
            LoadStokBarang();
        }

        private void BtnChekOutTransaksiPenjualan_Click(object sender, EventArgs e)
        {
            if (DgvKeranjang.Rows.Count == 0)
            {
                MessageBox.Show("Keranjang masih kosong!");
                return;
            }

            decimal totalharga =
                Convert.ToDecimal
                (
                   LblTotalBayar.Text
                   .Replace("Rp", "")
                   .Replace(".", "")
                   .Trim()
                );

            int idUser = 1;

            int idTransaksi =
                transaksiDAO.InsertTransaksi
                (
                    idUser,
                    totalharga
                );
            if (idTransaksi <= 0)
            {
                MessageBox.Show("Transaksi gagal dibuat!");
                return;
            }

            try
            {

                foreach (DataGridViewRow row in DgvKeranjang.Rows)
                {
                    if (row.IsNewRow)
                        continue;


                    int idAlat =
                    Convert.ToInt32(
                         row.Cells["ColIdBarang"].Value);

                    int jumlah =
                        Convert.ToInt32(
                            row.Cells["ColJumlah"].Value);

                    decimal subtotal =
                        Convert.ToDecimal(
                            row.Cells["ColSubTotal"].Value);

                    int stokSekarang =
                        transaksiDAO.CekStok(idAlat);

                    if (stokSekarang < jumlah)
                    {
                        MessageBox.Show
                        (
                            "Stok tidak cukup untuk Id Barang: " + idAlat +
                            "\nStok tersedia: " + stokSekarang +
                            "\nDiminta: " + jumlah


                        );
                        return;
                    }
                    transaksiDAO.InsertDetail(idTransaksi, idAlat, jumlah, subtotal);
                    transaksiDAO.KurangiStok(idAlat, jumlah);
                    LoadStokBarang();
                }
                MessageBox.Show("Transaksi berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DgvKeranjang.Rows.Clear();
                LblTotalBayar.Text = "Rp 0";
                LoadStokBarang();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Eror: " + ex.Message);
                return;
            }
        }

        private void DgvKeranjang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnTambah1_Click(object sender, EventArgs e)
        {
            bool ditemukan = false;
            foreach (DataGridViewRow row in DgvKeranjang.Rows)
            {
                if (row.IsNewRow)
                    continue;
                if (Convert.ToInt32(row.Cells["ColIdBarang"].Value) == 1)
                {
                    int jumlah = Convert.ToInt32(row.Cells["ColJumlah"].Value);
                    jumlah++;
                    row.Cells["ColJumlah"].Value = jumlah;
                    row.Cells["ColSubTotal"].Value = jumlah * 75000;
                    ditemukan = true;
                    break;
                }
            }

            if (!ditemukan)
            {
                int no = DgvKeranjang.Rows.Count;

                DgvKeranjang.Rows.Add
                (
                    no + 1,
                    1,
                    "Cangkul",
                    75000,
                    1,
                    75000
                );

                HitungTotal();
            }
        }

        private void BtnTambah2_Click(object sender, EventArgs e)
        {
            bool ditemukan = false;
            foreach (DataGridViewRow row in DgvKeranjang.Rows)
            {
                if (row.IsNewRow)
                    continue;
                if (Convert.ToInt32(row.Cells["ColIdBarang"].Value) == 2)
                {
                    int jumlah = Convert.ToInt32(row.Cells["ColJumlah"].Value);
                    jumlah++;
                    row.Cells["ColJumlah"].Value = jumlah;
                    row.Cells["ColSubTotal"].Value = jumlah * 800000;
                    ditemukan = true;
                    break;
                }
            }
            if (!ditemukan)
            {
                int no = DgvKeranjang.Rows.Count;

                DgvKeranjang.Rows.Add
                (
                    no + 1,
                    2,
                    "Pompa Air",
                    800000,
                    1,
                    800000
                );

                HitungTotal();
            }
        }

        private void BtnTambah3_Click(object sender, EventArgs e)
        {
            bool ditemukan = false;
            foreach (DataGridViewRow row in DgvKeranjang.Rows)
            {
                if (row.IsNewRow)
                    continue;
                if (Convert.ToInt32(row.Cells["ColIdBarang"].Value) == 3)
                {
                    int jumlah = Convert.ToInt32(row.Cells["ColJumlah"].Value);
                    jumlah++;
                    row.Cells["ColJumlah"].Value = jumlah;
                    row.Cells["ColSubTotal"].Value = jumlah * 350000;
                    ditemukan = true;
                    break;
                }
            }

            if (!ditemukan)
            {
                int no = DgvKeranjang.Rows.Count;

                DgvKeranjang.Rows.Add
                (
                    no + 1,
                    3,
                    "Mesin Semprot",
                    350000,
                    1,
                    350000
                );

                HitungTotal();
            }
        }

        private void BtnTambah4_Click(object sender, EventArgs e)
        {
            bool ditemukan = false;
            foreach (DataGridViewRow row in DgvKeranjang.Rows)
            {
                if (row.IsNewRow)
                    continue;
                if (Convert.ToInt32(row.Cells["ColIdBarang"].Value) == 4)
                {
                    int jumlah = Convert.ToInt32(row.Cells["ColJumlah"].Value);
                    jumlah++;
                    row.Cells["ColJumlah"].Value = jumlah;
                    row.Cells["ColSubTotal"].Value = jumlah * 250000;
                    ditemukan = true;
                    break;
                }
            }

            if (!ditemukan)
            {
                int no = DgvKeranjang.Rows.Count;

                DgvKeranjang.Rows.Add
                (
                    no + 1,
                    4,
                    "Selang Pompa Air",
                    250000,
                    1,
                    250000
                );

                HitungTotal();
            }
        }

        private void BtnTambah5_Click(object sender, EventArgs e)
        {
            bool ditemukan = false;
            foreach (DataGridViewRow row in DgvKeranjang.Rows)
            {
                if (row.IsNewRow)
                    continue;
                if (Convert.ToInt32(row.Cells["ColIdBarang"].Value) == 5)
                {
                    int jumlah = Convert.ToInt32(row.Cells["ColJumlah"].Value);
                    jumlah++;
                    row.Cells["ColJumlah"].Value = jumlah;
                    row.Cells["ColSubTotal"].Value = jumlah * 150000;
                    ditemukan = true;
                    break;
                }
            }
            if (!ditemukan)
            {
                int no = DgvKeranjang.Rows.Count;

                DgvKeranjang.Rows.Add
                (
                    no + 1,
                    5,
                    "Pupuk Organik",
                    150000,
                    1,
                    150000
                );

                HitungTotal();
            }
        }

        private void BtnBersihTransaksi_Click(object sender, EventArgs e)
        {
            if (DgvKeranjang.Rows.Count == 0)
            {
                MessageBox.Show("Keranjang sudah kosong!");
                return;
            }
            DialogResult hasil = MessageBox.Show("Apakah Anda yakin ingin membersihkan keranjang?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hasil == DialogResult.Yes)
            {
                DgvKeranjang.Rows.Clear();
                LbTotalBayar.Text = "Rp 0";

                MessageBox.Show("Keranjang berhasil dibersihkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
