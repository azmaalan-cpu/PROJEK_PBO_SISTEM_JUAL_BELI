namespace Projek_Final_sem2.UserControls
{
    partial class UcLogin
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcLogin));
            PcxBoxLoginAdmin = new PictureBox();
            PanelLogin = new Panel();
            BtnLogin = new Button();
            ChxBoxPasswordAdmin = new CheckBox();
            TbPassword = new TextBox();
            LbPassword = new Label();
            TbUsername = new TextBox();
            LbUsername = new Label();
            LoginAdmin = new Label();
            ((System.ComponentModel.ISupportInitialize)PcxBoxLoginAdmin).BeginInit();
            PanelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // PcxBoxLoginAdmin
            // 
            PcxBoxLoginAdmin.BackgroundImage = (Image)resources.GetObject("PcxBoxLoginAdmin.BackgroundImage");
            PcxBoxLoginAdmin.BackgroundImageLayout = ImageLayout.Stretch;
            PcxBoxLoginAdmin.Dock = DockStyle.Left;
            PcxBoxLoginAdmin.Location = new Point(0, 0);
            PcxBoxLoginAdmin.Margin = new Padding(2);
            PcxBoxLoginAdmin.Name = "PcxBoxLoginAdmin";
            PcxBoxLoginAdmin.Size = new Size(471, 448);
            PcxBoxLoginAdmin.TabIndex = 1;
            PcxBoxLoginAdmin.TabStop = false;
            // 
            // PanelLogin
            // 
            PanelLogin.BackColor = Color.White;
            PanelLogin.Controls.Add(BtnLogin);
            PanelLogin.Controls.Add(ChxBoxPasswordAdmin);
            PanelLogin.Controls.Add(TbPassword);
            PanelLogin.Controls.Add(LbPassword);
            PanelLogin.Controls.Add(TbUsername);
            PanelLogin.Controls.Add(LbUsername);
            PanelLogin.Controls.Add(LoginAdmin);
            PanelLogin.ForeColor = Color.Black;
            PanelLogin.Location = new Point(469, 0);
            PanelLogin.Margin = new Padding(2);
            PanelLogin.Name = "PanelLogin";
            PanelLogin.Size = new Size(428, 448);
            PanelLogin.TabIndex = 2;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.OliveDrab;
            BtnLogin.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLogin.ForeColor = Color.White;
            BtnLogin.Location = new Point(83, 287);
            BtnLogin.Margin = new Padding(2);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(90, 27);
            BtnLogin.TabIndex = 6;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // ChxBoxPasswordAdmin
            // 
            ChxBoxPasswordAdmin.AutoSize = true;
            ChxBoxPasswordAdmin.Location = new Point(25, 234);
            ChxBoxPasswordAdmin.Margin = new Padding(2);
            ChxBoxPasswordAdmin.Name = "ChxBoxPasswordAdmin";
            ChxBoxPasswordAdmin.Size = new Size(163, 24);
            ChxBoxPasswordAdmin.TabIndex = 5;
            ChxBoxPasswordAdmin.Text = "Tampilkan Password";
            ChxBoxPasswordAdmin.UseVisualStyleBackColor = true;
            // 
            // TbPassword
            // 
            TbPassword.BorderStyle = BorderStyle.FixedSingle;
            TbPassword.Location = new Point(25, 191);
            TbPassword.Margin = new Padding(2);
            TbPassword.Name = "TbPassword";
            TbPassword.Size = new Size(189, 27);
            TbPassword.TabIndex = 4;
            // 
            // LbPassword
            // 
            LbPassword.AutoSize = true;
            LbPassword.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbPassword.Location = new Point(25, 162);
            LbPassword.Margin = new Padding(2, 0, 2, 0);
            LbPassword.Name = "LbPassword";
            LbPassword.RightToLeft = RightToLeft.Yes;
            LbPassword.Size = new Size(81, 19);
            LbPassword.TabIndex = 3;
            LbPassword.Text = "Password";
            // 
            // TbUsername
            // 
            TbUsername.BorderStyle = BorderStyle.FixedSingle;
            TbUsername.Location = new Point(25, 108);
            TbUsername.Margin = new Padding(2);
            TbUsername.Name = "TbUsername";
            TbUsername.Size = new Size(189, 27);
            TbUsername.TabIndex = 2;
            // 
            // LbUsername
            // 
            LbUsername.AutoSize = true;
            LbUsername.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbUsername.Location = new Point(25, 82);
            LbUsername.Margin = new Padding(2, 0, 2, 0);
            LbUsername.Name = "LbUsername";
            LbUsername.RightToLeft = RightToLeft.Yes;
            LbUsername.Size = new Size(83, 19);
            LbUsername.TabIndex = 1;
            LbUsername.Text = "Username";
            // 
            // LoginAdmin
            // 
            LoginAdmin.AutoSize = true;
            LoginAdmin.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginAdmin.Location = new Point(25, 22);
            LoginAdmin.Margin = new Padding(2, 0, 2, 0);
            LoginAdmin.Name = "LoginAdmin";
            LoginAdmin.Size = new Size(116, 23);
            LoginAdmin.TabIndex = 0;
            LoginAdmin.Text = "Login Admin";
            // 
            // UcLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelLogin);
            Controls.Add(PcxBoxLoginAdmin);
            Margin = new Padding(2);
            Name = "UcLogin";
            Size = new Size(897, 448);
            ((System.ComponentModel.ISupportInitialize)PcxBoxLoginAdmin).EndInit();
            PanelLogin.ResumeLayout(false);
            PanelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PcxBoxLoginAdmin;
        private Panel PanelLogin;
        private Button BtnLogin;
        private CheckBox ChxBoxPasswordAdmin;
        private TextBox TbPassword;
        private Label LbPassword;
        private TextBox TbUsername;
        private Label LbUsername;
        private Label LoginAdmin;
    }
}
