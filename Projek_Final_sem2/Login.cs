namespace Projek_Final_sem2
{
    public partial class FmLogin : Form
    {
        public FmLogin()
        {
            InitializeComponent();
        }

        private void TbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChxBoxPasswordAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();    
        }
    }
}
