using Projek_Final_sem2.Services;
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
        private TransaksiService transaksiService;
        private DatabaseHelper db;

        private bool IsInDesignMode()
        {
            return System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime
                   || (this.Site != null && this.Site.DesignMode);
        }


        int[] idBarang = new int[10];
        string[] nama = new string[10];
        decimal[] harga = new decimal[10];
        int[] stok = new int[10];

        public UcTransaksiPenjualan()
        {
            InitializeComponent();
            if (!IsInDesignMode())
            {
                transaksiService = new TransaksiService();
                db = new DatabaseHelper();
            }


        }

        private void LoadBarang()
        {
            DataTable dt = transaksiService.GetDataBarang();

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Data barang kosong!");
                return;
            }

            for (int i = 0; i < dt.Rows.Count && i < 6; i++)
            {
                idBarang[i + 1] = Convert.ToInt32(dt.Rows[i]["id_alat"]);
                nama[i + 1] = dt.Rows[i]["nama_alat"].ToString();
                harga[i + 1] = Convert.ToDecimal(dt.Rows[i]["harga"]);
                stok[i + 1] = Convert.ToInt32(dt.Rows[i]["stok"]);

                // tampil ke label (INI YANG KAMU HILANGKAN TADI)
                switch (i + 1)
                {
                    case 1:
                        LbID1.Text = idBarang[1].ToString();
                        LbNamaBarang1.Text = nama[1];
                        LbHarga1.Text = "Rp " + harga[1].ToString("N0");
                        LbStok1.Text = "Stok: " + stok[1];
                        break;

                    case 2:
                        LbID2.Text = idBarang[2].ToString();
                        LbNamaBarang2.Text = nama[2];
                        LbHarga2.Text = "Rp " + harga[2].ToString("N0");
                        LbStok2.Text = "Stok: " + stok[2];
                        break;

                    case 3:
                        LbID3.Text = idBarang[3].ToString();
                        LbNamaBarang3.Text = nama[3];
                        LbHarga3.Text = "Rp " + harga[3].ToString("N0");
                        LbStok3.Text = "Stok: " + stok[3];
                        break;

                    case 4:
                        LbID4.Text = idBarang[4].ToString();
                        LbNamaBarang4.Text = nama[4];
                        LbHarga4.Text = "Rp " + harga[4].ToString("N0");
                        LbStok4.Text = "Stok: " + stok[4];
                        break;

                    case 5:
                        LbID5.Text = idBarang[5].ToString();
                        LbNamaBarang5.Text = nama[5];
                        LbHarga5.Text = "Rp " + harga[5].ToString("N0");
                        LbStok5.Text = "Stok: " + stok[5];
                        break;

                    case 6:
                        LbID6.Text = idBarang[6].ToString();
                        LbNamaBarang6.Text = nama[6];
                        LbHarga6.Text = "Rp " + harga[6].ToString("N0");
                        LbStok6.Text = "Stok: " + stok[6];
                        break;
                }
            }
        }

        private void HitungTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in DgvKeranjang.Rows)
            {
                if (row.Cells["ColSubTotal"].Value != null) 
                {
                    total += Convert.ToDecimal(
                   row.Cells["ColSubTotal"].Value);
                }
                    

      
            }

            LblTotalBayar.Text =
                "Rp " + total.ToString("N0");
        }

        private void LoadStokBarang()
        {
            LbStok1.Text = "Stok: " + transaksiService.CekStok(1);
            LbStok2.Text = "Stok: " + transaksiService.CekStok(2);
            LbStok3.Text = "Stok: " + transaksiService.CekStok(3);
            LbStok4.Text = "Stok: " + transaksiService.CekStok(4);
            LbStok5.Text = "Stok: " + transaksiService.CekStok(5);
            LbStok6.Text = "Stok: " + transaksiService.CekStok(6);

        }

        private void LbLID1_Click(object sender, EventArgs e)
        {

        }

        private void UcTransaksiPenjualan_Load(object sender, EventArgs e)
        {
            LoadBarang();
            LoadStokBarang();
        }

        private void BtnChekOutTransaksiPenjualan_Click(object sender, EventArgs e)
        {
            if (DgvKeranjang.Rows.Count == 0)
            {
                MessageBox.Show("Keranjang masih kosong!");
                return;
            }

            int idUser = 1;

            try
            {
                foreach (DataGridViewRow row in DgvKeranjang.Rows)
                {
                    if (row.IsNewRow)
                        continue;

                    int idAlat = Convert.ToInt32(row.Cells["ColIDBarang"].Value);
                    int jumlah = Convert.ToInt32(row.Cells["ColJumlah"].Value);

                    int stokSekarang = transaksiService.CekStok(idAlat);

                    if (stokSekarang < jumlah)
                    {
                        MessageBox.Show
                        (
                            "Stok tidak cukup untuk ID: " + idAlat +
                            "\nStok: " + stokSekarang +
                            "\nDiminta: " + jumlah
                        );
                        return;
                    }

                    bool sukses = transaksiService.InsertTransaksi(
                        idUser,
                        idAlat,
                        jumlah);

                    if (!sukses)
                    {
                        MessageBox.Show("Gagal simpan transaksi!");
                        return;
                    }

                    transaksiService.KurangiStok(idAlat, jumlah);
                }

                LoadStokBarang();
                DgvKeranjang.Rows.Clear();
                LblTotalBayar.Text = "Rp 0";


                MessageBox.Show("Transaksi berhasil!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
                if (Convert.ToInt32(row.Cells["ColIDBarang"].Value) == 1)
                {
                    int jumlah = Convert.ToInt32(row.Cells["ColJumlah"].Value);
                    jumlah++;
                    row.Cells["ColJumlah"].Value = jumlah;
                    row.Cells["ColSubTotal"].Value = jumlah * harga[1];
                    HitungTotal();
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
                    harga[1],
                    1,
                    harga[1]
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
                if (Convert.ToInt32(row.Cells["ColIDBarang"].Value) == 2)
                {
                    int jumlah = Convert.ToInt32(row.Cells["ColJumlah"].Value);
                    jumlah++;
                    row.Cells["ColJumlah"].Value = jumlah;
                    row.Cells["ColSubTotal"].Value = jumlah * harga[2];
                    HitungTotal();
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
                    harga[2],
                    1,
                    harga[2]
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
                if (Convert.ToInt32(row.Cells["ColIDBarang"].Value) == 3)
                {
                    int jumlah = Convert.ToInt32(row.Cells["ColJumlah"].Value);
                    jumlah++;
                    row.Cells["ColJumlah"].Value = jumlah;
                    row.Cells["ColSubTotal"].Value = jumlah * harga[3];
                    HitungTotal();
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
                    harga[3],
                    1,
                    harga[3]
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
                if (Convert.ToInt32(row.Cells["ColIDBarang"].Value) == 4)
                {
                    int jumlah = Convert.ToInt32(row.Cells["ColJumlah"].Value);
                    jumlah++;
                    row.Cells["ColJumlah"].Value = jumlah;
                    row.Cells["ColSubTotal"].Value = jumlah * harga[4];
                    HitungTotal();
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
                    harga[4],
                    1,
                    harga[4]
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
                if (Convert.ToInt32(row.Cells["ColIDBarang"].Value) == 5)
                {
                    int jumlah = Convert.ToInt32(row.Cells["ColJumlah"].Value);
                    jumlah++;
                    row.Cells["ColJumlah"].Value = jumlah;
                    row.Cells["ColSubTotal"].Value = jumlah * harga[5];
                    HitungTotal();
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
                    harga[5],
                    1,
                    harga[5]
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
                LblTotalBayar.Text = "Rp 0";

                MessageBox.Show
                 (
                    "Keranjang berhasil dibersihkan!",
                     "Informasi",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information
                );
            }
        }

        private void BtnTambah6_Click(object sender, EventArgs e)
        {
            bool ditemukan = false;
            foreach (DataGridViewRow row in DgvKeranjang.Rows)
            {
                if (row.IsNewRow)
                    continue;
                if (Convert.ToInt32(row.Cells["ColIDBarang"].Value) == 6)
                {
                    int jumlah = Convert.ToInt32(row.Cells["ColJumlah"].Value);
                    jumlah++;
                    row.Cells["ColJumlah"].Value = jumlah;
                    row.Cells["ColSubTotal"].Value = jumlah * harga[6];
                    HitungTotal();
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
                    6,
                    "Traktor Mini",
                    harga[6],
                    1,
                    harga[6]
                );
                HitungTotal();
            }
        }

 

        private void LblTotalBayar_Click(object sender, EventArgs e)
        {
           
            decimal totalBayar = 0;

            foreach (DataGridViewRow row in DgvKeranjang.Rows)
            {
                if (row.Cells["subtotal"].Value != null)
                {
                    totalBayar += Convert.ToDecimal(
                        row.Cells["subtotal"].Value
                    );
                }
            }

        }
    }
        // diperbarui 
    
}
