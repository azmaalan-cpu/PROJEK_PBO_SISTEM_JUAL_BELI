using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Projek_Final_sem2.DAO;
using Projek_Final_sem2.Models;

namespace Projek_Final_sem2.UserControls
{
    public partial class UcDataUser : UserControl
    {
        private UserDAO userDAO;
        private RoleDAO roleDAO;
        private int selectedUserId = 0;
        public UcDataUser()
        {
            InitializeComponent();
            TbIdUser.ReadOnly = true;

            DgvDaftarUser.AutoGenerateColumns = false;

            userDAO = new UserDAO();
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
            DgvDaftarUser.DataSource = userDAO.GettAll();

        }

        private void UcDataUser_Load(object sender, EventArgs e)
        {

        }

        private void PanelDataUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.Username = TbUsername.Text;
            user.Password = TbPassword.Text;
            user.IdRole = Convert.ToInt32(CbxRole.SelectedValue);
            userDAO.Insert(user);
            LoadData();
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
            User user = new User();

            user.IdUser = selectedUserId;
            user.Username = TbUsername.Text;
            user.Password = TbPassword.Text;
            user.IdRole = Convert.ToInt32(CbxRole.SelectedValue);
            userDAO.Update(user);
            MessageBox.Show("Data berhasil diubah!");
            LoadData();
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
                userDAO.Delete(selectedUserId);
                MessageBox.Show("Data berhasil dihapus!");
                LoadData();

                selectedUserId = 0;
                TbUsername.Clear();
                TbPassword.Clear();
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TbUsername.Clear();
            TbPassword.Clear();
            CbxRole.SelectedIndex = 0;
            selectedUserId = 0;
        }

        private void DgvDaftarUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CbxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
