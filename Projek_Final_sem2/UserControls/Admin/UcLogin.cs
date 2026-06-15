using Projek_Final_sem2.Koneksi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using Projek_Final_sem2.UserControls.Kasir;

namespace Projek_Final_sem2.UserControls
{
    public partial class UcLogin : UserControl
    {
        public UcLogin()
        {
            InitializeComponent();
            TbPassword.UseSystemPasswordChar = true;

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(TbUsername.Text) && string.IsNullOrWhiteSpace(TbPassword.Text))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!","Peringatan",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            else if(string.IsNullOrWhiteSpace(TbUsername.Text))
            {
                MessageBox.Show("Username tidak boleh kosong!","Peringatan",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            else if(string.IsNullOrWhiteSpace(TbPassword.Text))
            {
                MessageBox.Show("Password tidak boleh kosong!","Peringatan",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            var db = new DatabaseHelper();
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string sql = @"SELECT u.id_user, r.nama_role FROM users u JOIN roles r ON u.id_role = r.id_role WHERE TRIM(u.username) = @username AND TRIM(u.password) = @password";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@username", TbUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", TbPassword.Text.Trim());

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idUser = reader.GetInt32(0);
                            string role = reader.GetString(1);

                            MessageBox.Show("Login berhasil");

                            if (role == "Admin")
                            {
                                FmUtamaAdmin admin = new FmUtamaAdmin();
                                admin.Show();

                                this.FindForm().Hide();
                            }
                            else if (role == "Kasir")
                            {
                                FmUtamaKasir kasir = new FmUtamaKasir();
                                kasir.Show();

                                this.FindForm().Hide();
                            }
                            else if (role == "Teknisi")
                            {

                            }

                        }
                        else
                        {
                            MessageBox.Show("Login gagal, pastikan username dan password benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }


        }

        private void ChxBoxPasswordAdmin_CheckedChanged(object sender, EventArgs e)
        {
            TbPassword.UseSystemPasswordChar = !ChxBoxPasswordAdmin.Checked;
        }
    }
}
