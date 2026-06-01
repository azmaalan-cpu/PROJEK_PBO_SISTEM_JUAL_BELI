namespace Projek_Final_sem2.UserControls
{
    partial class UcDataUser
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
            LbJudulDataUser = new Label();
            PanelDataUser = new Panel();
            TbIdUser = new TextBox();
            LbIdUser = new Label();
            CbxRole = new ComboBox();
            PanelDaftarUser = new Panel();
            DgvDaftarUser = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            username = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            nama_role = new DataGridViewTextBoxColumn();
            LbDaftarUser = new Label();
            BtnReset = new Button();
            BtnHapus = new Button();
            BtnEdit = new Button();
            BtnTambah = new Button();
            LbRole = new Label();
            TbPassword = new TextBox();
            LbPassword = new Label();
            TbUsername = new TextBox();
            LbUsername = new Label();
            PanelDataUser.SuspendLayout();
            PanelDaftarUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvDaftarUser).BeginInit();
            SuspendLayout();
            // 
            // LbJudulDataUser
            // 
            LbJudulDataUser.AutoSize = true;
            LbJudulDataUser.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbJudulDataUser.Location = new Point(14, 1);
            LbJudulDataUser.Name = "LbJudulDataUser";
            LbJudulDataUser.Size = new Size(115, 26);
            LbJudulDataUser.TabIndex = 0;
            LbJudulDataUser.Text = "Data User";
            // 
            // PanelDataUser
            // 
            PanelDataUser.BackColor = Color.White;
            PanelDataUser.Controls.Add(TbIdUser);
            PanelDataUser.Controls.Add(LbIdUser);
            PanelDataUser.Controls.Add(CbxRole);
            PanelDataUser.Controls.Add(PanelDaftarUser);
            PanelDataUser.Controls.Add(BtnReset);
            PanelDataUser.Controls.Add(BtnHapus);
            PanelDataUser.Controls.Add(BtnEdit);
            PanelDataUser.Controls.Add(BtnTambah);
            PanelDataUser.Controls.Add(LbRole);
            PanelDataUser.Controls.Add(TbPassword);
            PanelDataUser.Controls.Add(LbPassword);
            PanelDataUser.Controls.Add(TbUsername);
            PanelDataUser.Controls.Add(LbUsername);
            PanelDataUser.Controls.Add(LbJudulDataUser);
            PanelDataUser.Dock = DockStyle.Fill;
            PanelDataUser.Location = new Point(0, 0);
            PanelDataUser.Name = "PanelDataUser";
            PanelDataUser.Size = new Size(580, 636);
            PanelDataUser.TabIndex = 14;
            PanelDataUser.Paint += PanelDataUser_Paint;
            // 
            // TbIdUser
            // 
            TbIdUser.BorderStyle = BorderStyle.FixedSingle;
            TbIdUser.Location = new Point(210, 31);
            TbIdUser.Name = "TbIdUser";
            TbIdUser.ReadOnly = true;
            TbIdUser.Size = new Size(271, 31);
            TbIdUser.TabIndex = 17;
            // 
            // LbIdUser
            // 
            LbIdUser.AutoSize = true;
            LbIdUser.Location = new Point(7, 38);
            LbIdUser.Name = "LbIdUser";
            LbIdUser.Size = new Size(70, 25);
            LbIdUser.TabIndex = 16;
            LbIdUser.Text = "Id_User";
            // 
            // CbxRole
            // 
            CbxRole.FormattingEnabled = true;
            CbxRole.Location = new Point(210, 166);
            CbxRole.Name = "CbxRole";
            CbxRole.Size = new Size(271, 33);
            CbxRole.TabIndex = 15;
            // 
            // PanelDaftarUser
            // 
            PanelDaftarUser.Controls.Add(DgvDaftarUser);
            PanelDaftarUser.Controls.Add(LbDaftarUser);
            PanelDaftarUser.Location = new Point(4, 268);
            PanelDaftarUser.Name = "PanelDaftarUser";
            PanelDaftarUser.Size = new Size(550, 155);
            PanelDaftarUser.TabIndex = 14;
            // 
            // DgvDaftarUser
            // 
            DgvDaftarUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvDaftarUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDaftarUser.Columns.AddRange(new DataGridViewColumn[] { Column1, username, password, nama_role });
            DgvDaftarUser.Dock = DockStyle.Fill;
            DgvDaftarUser.Location = new Point(0, 0);
            DgvDaftarUser.Name = "DgvDaftarUser";
            DgvDaftarUser.RowHeadersWidth = 62;
            DgvDaftarUser.Size = new Size(550, 155);
            DgvDaftarUser.TabIndex = 14;
            DgvDaftarUser.CellClick += DgvDaftarUser_CellClick;
            
            // 
            // Column1
            // 
            Column1.DataPropertyName = "id_user";
            Column1.HeaderText = "ID User";
            Column1.MinimumWidth = 8;
            Column1.Name = "id_user";
            // 
            // username
            // 
            username.DataPropertyName = "username";
            username.HeaderText = "Username";
            username.MinimumWidth = 8;
            username.Name = "username";
            // 
            // password
            // 
            password.DataPropertyName = "password";
            password.HeaderText = "Password";
            password.MinimumWidth = 8;
            password.Name = "password";
            // 
            // nama_role
            // 
            nama_role.DataPropertyName = "nama_role";
            nama_role.HeaderText = "Role";
            nama_role.MinimumWidth = 8;
            nama_role.Name = "nama_role";
            // 
            // LbDaftarUser
            // 
            LbDaftarUser.AutoSize = true;
            LbDaftarUser.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbDaftarUser.Location = new Point(3, 4);
            LbDaftarUser.Name = "LbDaftarUser";
            LbDaftarUser.Size = new Size(133, 26);
            LbDaftarUser.TabIndex = 13;
            LbDaftarUser.Text = "Daftar User";
            // 
            // BtnReset
            // 
            BtnReset.BackColor = Color.Gray;
            BtnReset.ForeColor = Color.White;
            BtnReset.Location = new Point(399, 217);
            BtnReset.Name = "BtnReset";
            BtnReset.Size = new Size(112, 34);
            BtnReset.TabIndex = 12;
            BtnReset.Text = "Reset";
            BtnReset.UseVisualStyleBackColor = false;
            BtnReset.Click += BtnReset_Click;
            // 
            // BtnHapus
            // 
            BtnHapus.BackColor = Color.Red;
            BtnHapus.ForeColor = Color.White;
            BtnHapus.Location = new Point(267, 217);
            BtnHapus.Name = "BtnHapus";
            BtnHapus.Size = new Size(112, 34);
            BtnHapus.TabIndex = 11;
            BtnHapus.Text = "Hapus";
            BtnHapus.UseVisualStyleBackColor = false;
            BtnHapus.Click += BtnHapus_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.BackColor = Color.DeepSkyBlue;
            BtnEdit.ForeColor = Color.White;
            BtnEdit.Location = new Point(134, 217);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(112, 34);
            BtnEdit.TabIndex = 10;
            BtnEdit.Text = "Edit";
            BtnEdit.UseVisualStyleBackColor = false;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnTambah
            // 
            BtnTambah.BackColor = Color.Green;
            BtnTambah.ForeColor = Color.White;
            BtnTambah.Location = new Point(7, 217);
            BtnTambah.Name = "BtnTambah";
            BtnTambah.Size = new Size(112, 34);
            BtnTambah.TabIndex = 9;
            BtnTambah.Text = "Tambah";
            BtnTambah.UseVisualStyleBackColor = false;
            BtnTambah.Click += BtnTambah_Click;
            // 
            // LbRole
            // 
            LbRole.AutoSize = true;
            LbRole.Location = new Point(7, 173);
            LbRole.Name = "LbRole";
            LbRole.Size = new Size(46, 25);
            LbRole.TabIndex = 7;
            LbRole.Text = "Role";
            // 
            // TbPassword
            // 
            TbPassword.BorderStyle = BorderStyle.FixedSingle;
            TbPassword.Location = new Point(210, 116);
            TbPassword.Name = "TbPassword";
            TbPassword.Size = new Size(271, 31);
            TbPassword.TabIndex = 4;
            // 
            // LbPassword
            // 
            LbPassword.AutoSize = true;
            LbPassword.Location = new Point(7, 122);
            LbPassword.Name = "LbPassword";
            LbPassword.Size = new Size(87, 25);
            LbPassword.TabIndex = 3;
            LbPassword.Text = "Password";
            // 
            // TbUsername
            // 
            TbUsername.BorderStyle = BorderStyle.FixedSingle;
            TbUsername.Location = new Point(210, 70);
            TbUsername.Name = "TbUsername";
            TbUsername.Size = new Size(271, 31);
            TbUsername.TabIndex = 2;
            // 
            // LbUsername
            // 
            LbUsername.AutoSize = true;
            LbUsername.Location = new Point(7, 79);
            LbUsername.Name = "LbUsername";
            LbUsername.Size = new Size(91, 25);
            LbUsername.TabIndex = 1;
            LbUsername.Text = "Username";
            // 
            // UcDataUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelDataUser);
            Margin = new Padding(0);
            Name = "UcDataUser";
            Size = new Size(580, 636);
            Load += UcDataUser_Load;
            PanelDataUser.ResumeLayout(false);
            PanelDataUser.PerformLayout();
            PanelDaftarUser.ResumeLayout(false);
            PanelDaftarUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvDaftarUser).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label LbJudulDataUser;
        private Panel PanelDataUser;
        private TextBox TbUsername;
        private Label LbUsername;
        private Label LbRole;
        private TextBox TbPassword;
        private Label LbPassword;
        private Button BtnReset;
        private Button BtnHapus;
        private Button BtnEdit;
        private Button BtnTambah;
        private Label LbDaftarUser;
        private Panel PanelDaftarUser;
        private Panel panel2;
        private DataGridView DgvDaftarUser;
        private ComboBox CbxRole;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn nama_role;
        private TextBox TbIdUser;
        private Label LbIdUser;
    }
}
