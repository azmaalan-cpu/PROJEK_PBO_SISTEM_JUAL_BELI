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

        public string role;
        private SupplierDAO supplierDAO;
        private KategoriDAO kategoriDAO;
        private AlatDAO alatDAO;
        private int selectedAlatId = 0;
        public UcDataBarang()
        {
            InitializeComponent();
            this.Load += UcDataBarang_Load;
            DgvDaftarBarang.AutoGenerateColumns = false;
            supplierDAO = new SupplierDAO();
            kategoriDAO = new KategoriDAO();
            alatDAO = new AlatDAO();

            LoadKategori();
            LoadSupplier();
            LoadData();
        }

        public void LoadBarangById(int idBarang)
        {
            selectedAlatId = idBarang;

            foreach (DataGridViewRow row in DgvDaftarBarang.Rows)
            {
                if (row.Cells["id_alat"].Value != null &&
                    Convert.ToInt32(row.Cells["id_alat"].Value) == idBarang)
                {
                    TbNamaAlat.Text =
                        row.Cells["nama_alat"].Value.ToString();

                    TbHarga.Text =
                        row.Cells["harga"].Value.ToString();

                    TbStok.Text =
                        row.Cells["stok"].Value.ToString();

                    CbxKategori.Text =
                        row.Cells["nama_kategori"].Value.ToString();

                    CbxSupplier.Text =
                        row.Cells["nama_supplier"].Value.ToString();

                    break;
                }
            }
        }

        private void UcDataBarang_Load(object sender, EventArgs e)
        {
            if(role == "kasir")
            {
                BtnTambah.Visible = false;
                BtnEdit.Visible = false;
                BtnHapus.Visible = false;
                LoadData();
            }
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

        private void ClearForm()
        {
            TbNamaAlat.Clear();
            TbHarga.Clear();
            TbStok.Clear();
            CbxKategori.SelectedIndex = -1;
            CbxSupplier.SelectedIndex = -1;
            selectedAlatId = 0;
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
            ClearForm();

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
            ClearForm();
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
                ClearForm();

                selectedAlatId = 0;
                TbNamaAlat.Clear();
                TbHarga.Clear();
                TbStok.Clear();
            }
    }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }




}
