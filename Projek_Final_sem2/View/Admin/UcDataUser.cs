using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Projek_Final_sem2.DAO;
using Projek_Final_sem2.Control.Admin;
using Projek_Final_sem2.Models;

namespace Projek_Final_sem2.UserControls
{
    public partial class UcDataUser : UserControl
    {
        private RoleDAO roleDAO;
        private readonly DataUserControl _dataUserControl = new DataUserControl();
        private int selectedUserId = 0;
        public UcDataUser()
        {
            InitializeComponent();
            TbIdUser.ReadOnly = true;

            DgvDaftarUser.AutoGenerateColumns = false;

            roleDAO = new RoleDAO();

            LoadRole();
            LoadData();
        }

        private void LoadRole()
        {

            var roles = roleDAO.GetAllRole();
            CbxRole.DataSource = roles;
            CbxRole.DisplayMember = "NamaRole";
            CbxRole.ValueMember = "IdRole";

        }

        private void LoadData()
        {
            // bind via controller directly
            var dt = _dataUserControl.MuatUsers();
            DgvDaftarUser.DataSource = dt;

        }

        private void UcDataUser_Load(object sender, EventArgs e)
        {

        }

        private void PanelDataUser_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ClearForm()
        {
            TbIdUser.Clear();
            TbUsername.Clear();
            TbPassword.Clear();
            CbxRole.SelectedIndex = -1;
            selectedUserId = 0;
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            var username = TbUsername.Text;
            var password = TbPassword.Text;
            var role = CbxRole.SelectedValue?.ToString() ?? "0";
            var ok = _dataUserControl.AddUser(username, password, role);
            if (ok)
            {
                MessageBox.Show("Data berhasil ditambahkan!");
                LoadData();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Gagal menambahkan data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvDaftarUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedUserId = Convert.ToInt32(DgvDaftarUser.Rows[e.RowIndex].Cells["id_user"].Value);
                TbIdUser.Text = DgvDaftarUser.Rows[e.RowIndex].Cells["id_user"].Value.ToString();
                TbUsername.Text = DgvDaftarUser.Rows[e.RowIndex].Cells["username"].Value.ToString();
                TbPassword.Text = DgvDaftarUser.Rows[e.RowIndex].Cells["password"].Value.ToString();

            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0)
            {
                MessageBox.Show("Pilih data yang ingin diubah!");
                return;
            }
            var username = TbUsername.Text;
            var password = TbPassword.Text;
            var role = CbxRole.SelectedValue?.ToString() ?? "0";
            var ok = _dataUserControl.EditUser(selectedUserId, username, password, role);
            if (ok)
            {
                MessageBox.Show("Data berhasil diubah!");
                LoadData();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Gagal mengubah data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0)
            {
                MessageBox.Show("Pilih data yang ingin dihapus!");
                return;
            }

            DialogResult hasil = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (hasil == DialogResult.Yes)
            {
                var ok = _dataUserControl.DeleteUser(selectedUserId);
                if (ok)
                {
                    MessageBox.Show("Data berhasil dihapus!");
                    LoadData();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Gagal menghapus data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                selectedUserId = 0;
                TbUsername.Clear();
                TbPassword.Clear();
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
         ClearForm();
        }

        private void DgvDaftarUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CbxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
