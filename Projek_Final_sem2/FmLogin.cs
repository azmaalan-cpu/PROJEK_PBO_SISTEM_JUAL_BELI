using Projek_Final_sem2.UserControls;
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
    }
}
