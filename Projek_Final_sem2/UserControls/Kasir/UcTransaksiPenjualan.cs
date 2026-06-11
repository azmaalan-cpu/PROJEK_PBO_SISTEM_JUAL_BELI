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

        private void LbLID1_Click(object sender, EventArgs e)
        {

        }

        private void UcTransaksiPenjualan_Load(object sender, EventArgs e)
        {
            
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

                    int stokSekarang = transaksiDAO.CekStok(idAlat);

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
                }
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

        private void BtnTambah2_Click(object sender, EventArgs e)
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

        private void BtnTambah3_Click(object sender, EventArgs e)
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

        private void BtnTambah4_Click(object sender, EventArgs e)
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

        private void BtnTambah5_Click(object sender, EventArgs e)
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
}
