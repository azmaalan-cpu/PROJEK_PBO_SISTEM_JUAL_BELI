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
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
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
                            }
                            else if(role == "Kasir")
                            {
                                FmUtamaKasir kasir = new FmUtamaKasir();
                                kasir.Show();
                            }
                            else if( role == "Teknisi")
                            {

                            }
                            
                        }
                      
                    }
                }
            }


        }
    }
}
