using Npgsql;
using Projek_Final_sem2.Koneksi;
using Projek_Final_sem2.UserControls;
using Projek_Final_sem2.UserControls.Kasir;
using Projek_Final_sem2.UserControls.Teknisi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projek_Final_sem2
{
    public partial class FmLogin : Form
    {
        public FmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UcLogin login = new UcLogin();
            login.Dock = DockStyle.Fill;
            this.Controls.Add(login);
        }

        //private void BtnLogin_click(object sender, EventArgs e)
        //{
        //    var db = new DatabaseHelper();

        //    using (var conn = db.GetConnection())
        //    {
        //        conn.Open();

        //        string sql = @"SELECT u.id_user, r.nama_role
        //               FROM users u
        //               JOIN roles r ON u.id_role = r.id_role
        //               WHERE TRIM(u.username) = @username
        //               AND TRIM(u.password) = @password";

        //        using (var cmd = new NpgsqlCommand(sql, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@username", TbUsername.Text.Trim());
        //            cmd.Parameters.AddWithValue("@password", TbPassword.Text.Trim());

        //            using (var reader = cmd.ExecuteReader())
        //            {
        //                if (reader.Read())
        //                {
        //                    string role = reader.GetString(1);

        //                    Form dashboard = null;

        //                    if (role == "Admin")
        //                    {
        //                        dashboard = new FmUtamaAdmin();
        //                    }
        //                    else if (role == "Kasir")
        //                    {
        //                        dashboard = new FmUtamaKasir();
        //                    }
        //                    else if (role == "Teknisi")
        //                    {
        //                        dashboard = new FmUtamaTeknisi();
        //                    }

        //                    if (dashboard != null)
        //                    {
        //                        dashboard.Show();

        //                        // Tutup form login
        //                        this.FindForm().Hide();
        //                    }
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Username atau Password salah");
        //                }
        //            }
        //        }
        //    }
        //}
    }
}
