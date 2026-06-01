using Projek_Final_sem2.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using Projek_Final_sem2.Models;

namespace Projek_Final_sem2.UserControls
{
    public partial class UcDataBarang : UserControl
    {
        private SupplierDAO supplierDAO;
        private KategoriDAO kategoriDAO;
        private AlatDAO alatDAO;
        private int selectedAlatId = 0;
        public UcDataBarang()
        {
            InitializeComponent();
            DgvDaftarBarang.AutoGenerateColumns = false;
            supplierDAO = new SupplierDAO();
            kategoriDAO = new KategoriDAO();
            alatDAO = new AlatDAO();

            LoadKategori();
            LoadSupplier();
            LoadData();
        }

        private void LoadKategori()
        {
            CbxKategori.DataSource = kategoriDAO.GetAllKategori();
            CbxKategori.DisplayMember = "NamaKategori";
            CbxKategori.ValueMember = "IdKategori";
        }

        private void LoadSupplier()
        {
            CbxSupplier.DataSource = supplierDAO.GetAllSupplier();
            CbxSupplier.DisplayMember = "NamaSupplier";
            CbxSupplier.ValueMember = "IdSupplier";
        }

        private void LoadData()
        {
            DgvDaftarBarang.DataSource = new AlatDAO().GetAll();
            
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            Alat alat = new Alat();

            alat.NamaAlat = TbNamaAlat.Text;
            alat.Harga = Convert.ToDecimal(TbHarga.Text);
            alat.Stok = Convert.ToInt32(TbStok.Text);
            alat.IdKategori = Convert.ToInt32(CbxKategori.SelectedValue);
            alat.IdSupplier = Convert.ToInt32(CbxSupplier.SelectedValue);
            alatDAO.Insert(alat);
            MessageBox.Show("Data berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void DgvDaftarBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedAlatId = Convert.ToInt32(DgvDaftarBarang.Rows[e.RowIndex].Cells["id_alat"].Value);
                TbNamaAlat.Text = DgvDaftarBarang.Rows[e.RowIndex].Cells["nama_alat"].Value.ToString();
                TbHarga.Text = DgvDaftarBarang.Rows[e.RowIndex].Cells["harga"].Value.ToString();
                TbStok.Text = DgvDaftarBarang.Rows[e.RowIndex].Cells["stok"].Value.ToString();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if(selectedAlatId == 0)
            {
                MessageBox.Show("Pilih data yang ingin diupdate!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Alat alat = new Alat();
            alat.IdAlat = selectedAlatId;
            alat.NamaAlat = TbNamaAlat.Text;
            alat.Harga = Convert.ToDecimal(TbHarga.Text);
            alat.Stok = Convert.ToInt32(TbStok.Text);
            alat.IdKategori = Convert.ToInt32(CbxKategori.SelectedValue);
            alat.IdSupplier = Convert.ToInt32(CbxSupplier.SelectedValue);

            alatDAO.Update(alat);
            MessageBox.Show("Data berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if(selectedAlatId == 0)
            {
                MessageBox.Show("Pilih data yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                alatDAO.Delete(selectedAlatId);
                MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                selectedAlatId = 0;
            }
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            TbNamaAlat.Clear();
            TbHarga.Clear();
            TbStok.Clear();
            CbxKategori.SelectedIndex = 0;
            CbxSupplier.SelectedIndex = 0;
        }
    }




}
