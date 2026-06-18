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
            id_user = new DataGridViewTextBoxColumn();
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
            LbJudulDataUser.Location = new Point(11, 1);
            LbJudulDataUser.Margin = new Padding(2, 0, 2, 0);
            LbJudulDataUser.Name = "LbJudulDataUser";
            LbJudulDataUser.Size = new Size(96, 23);
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
            PanelDataUser.Margin = new Padding(2, 2, 2, 2);
            PanelDataUser.Name = "PanelDataUser";
            PanelDataUser.Size = new Size(464, 509);
            PanelDataUser.TabIndex = 14;
            PanelDataUser.Paint += PanelDataUser_Paint;
            // 
            // TbIdUser
            // 
            TbIdUser.BorderStyle = BorderStyle.FixedSingle;
            TbIdUser.Location = new Point(168, 25);
            TbIdUser.Margin = new Padding(2, 2, 2, 2);
            TbIdUser.Name = "TbIdUser";
            TbIdUser.ReadOnly = true;
            TbIdUser.Size = new Size(217, 27);
            TbIdUser.TabIndex = 17;
            // 
            // LbIdUser
            // 
            LbIdUser.AutoSize = true;
            LbIdUser.Location = new Point(6, 30);
            LbIdUser.Margin = new Padding(2, 0, 2, 0);
            LbIdUser.Name = "LbIdUser";
            LbIdUser.Size = new Size(57, 20);
            LbIdUser.TabIndex = 16;
            LbIdUser.Text = "Id_User";
            // 
            // CbxRole
            // 
            CbxRole.FormattingEnabled = true;
            CbxRole.Location = new Point(168, 133);
            CbxRole.Margin = new Padding(2, 2, 2, 2);
            CbxRole.Name = "CbxRole";
            CbxRole.Size = new Size(218, 28);
            CbxRole.TabIndex = 15;
            CbxRole.SelectedIndexChanged += CbxRole_SelectedIndexChanged;
            // 
            // PanelDaftarUser
            // 
            PanelDaftarUser.Controls.Add(DgvDaftarUser);
            PanelDaftarUser.Controls.Add(LbDaftarUser);
            PanelDaftarUser.Location = new Point(3, 214);
            PanelDaftarUser.Margin = new Padding(2, 2, 2, 2);
            PanelDaftarUser.Name = "PanelDaftarUser";
            PanelDaftarUser.Size = new Size(440, 124);
            PanelDaftarUser.TabIndex = 14;
            // 
            // DgvDaftarUser
            // 
            DgvDaftarUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvDaftarUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDaftarUser.Columns.AddRange(new DataGridViewColumn[] { id_user, username, password, nama_role });
            DgvDaftarUser.Dock = DockStyle.Fill;
            DgvDaftarUser.Location = new Point(0, 0);
            DgvDaftarUser.Margin = new Padding(2, 2, 2, 2);
            DgvDaftarUser.Name = "DgvDaftarUser";
            DgvDaftarUser.RowHeadersWidth = 62;
            DgvDaftarUser.Size = new Size(440, 124);
            DgvDaftarUser.TabIndex = 14;
            DgvDaftarUser.CellClick += DgvDaftarUser_CellClick;
            DgvDaftarUser.CellContentClick += DgvDaftarUser_CellContentClick;
            // 
            // id_user
            // 
            id_user.DataPropertyName = "id_user";
            id_user.HeaderText = "ID ";
            id_user.MinimumWidth = 8;
            id_user.Name = "id_user";
            id_user.Visible = false;
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
            LbDaftarUser.Location = new Point(2, 3);
            LbDaftarUser.Margin = new Padding(2, 0, 2, 0);
            LbDaftarUser.Name = "LbDaftarUser";
            LbDaftarUser.Size = new Size(111, 23);
            LbDaftarUser.TabIndex = 13;
            LbDaftarUser.Text = "Daftar User";
            // 
            // BtnReset
            // 
            BtnReset.BackColor = Color.Gray;
            BtnReset.ForeColor = Color.White;
            BtnReset.Location = new Point(319, 174);
            BtnReset.Margin = new Padding(2, 2, 2, 2);
            BtnReset.Name = "BtnReset";
            BtnReset.Size = new Size(90, 27);
            BtnReset.TabIndex = 12;
            BtnReset.Text = "Reset";
            BtnReset.UseVisualStyleBackColor = false;
            BtnReset.Click += BtnReset_Click;
            // 
            // BtnHapus
            // 
            BtnHapus.BackColor = Color.Red;
            BtnHapus.ForeColor = Color.White;
            BtnHapus.Location = new Point(214, 174);
            BtnHapus.Margin = new Padding(2, 2, 2, 2);
            BtnHapus.Name = "BtnHapus";
            BtnHapus.Size = new Size(90, 27);
            BtnHapus.TabIndex = 11;
            BtnHapus.Text = "Hapus";
            BtnHapus.UseVisualStyleBackColor = false;
            BtnHapus.Click += BtnHapus_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.BackColor = Color.DeepSkyBlue;
            BtnEdit.ForeColor = Color.White;
            BtnEdit.Location = new Point(107, 174);
            BtnEdit.Margin = new Padding(2, 2, 2, 2);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(90, 27);
            BtnEdit.TabIndex = 10;
            BtnEdit.Text = "Edit";
            BtnEdit.UseVisualStyleBackColor = false;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnTambah
            // 
            BtnTambah.BackColor = Color.Green;
            BtnTambah.ForeColor = Color.White;
            BtnTambah.Location = new Point(6, 174);
            BtnTambah.Margin = new Padding(2, 2, 2, 2);
            BtnTambah.Name = "BtnTambah";
            BtnTambah.Size = new Size(90, 27);
            BtnTambah.TabIndex = 9;
            BtnTambah.Text = "Tambah";
            BtnTambah.UseVisualStyleBackColor = false;
            BtnTambah.Click += BtnTambah_Click;
            // 
            // LbRole
            // 
            LbRole.AutoSize = true;
            LbRole.Location = new Point(6, 138);
            LbRole.Margin = new Padding(2, 0, 2, 0);
            LbRole.Name = "LbRole";
            LbRole.Size = new Size(39, 20);
            LbRole.TabIndex = 7;
            LbRole.Text = "Role";
            // 
            // TbPassword
            // 
            TbPassword.BorderStyle = BorderStyle.FixedSingle;
            TbPassword.Location = new Point(168, 93);
            TbPassword.Margin = new Padding(2, 2, 2, 2);
            TbPassword.Name = "TbPassword";
            TbPassword.Size = new Size(217, 27);
            TbPassword.TabIndex = 4;
            // 
            // LbPassword
            // 
            LbPassword.AutoSize = true;
            LbPassword.Location = new Point(6, 98);
            LbPassword.Margin = new Padding(2, 0, 2, 0);
            LbPassword.Name = "LbPassword";
            LbPassword.Size = new Size(70, 20);
            LbPassword.TabIndex = 3;
            LbPassword.Text = "Password";
            // 
            // TbUsername
            // 
            TbUsername.BorderStyle = BorderStyle.FixedSingle;
            TbUsername.Location = new Point(168, 56);
            TbUsername.Margin = new Padding(2, 2, 2, 2);
            TbUsername.Name = "TbUsername";
            TbUsername.Size = new Size(217, 27);
            TbUsername.TabIndex = 2;
            // 
            // LbUsername
            // 
            LbUsername.AutoSize = true;
            LbUsername.Location = new Point(6, 63);
            LbUsername.Margin = new Padding(2, 0, 2, 0);
            LbUsername.Name = "LbUsername";
            LbUsername.Size = new Size(75, 20);
            LbUsername.TabIndex = 1;
            LbUsername.Text = "Username";
            // 
            // UcDataUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelDataUser);
            Margin = new Padding(0);
            Name = "UcDataUser";
            Size = new Size(464, 509);
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
        private TextBox TbIdUser;
        private Label LbIdUser;
        private DataGridViewTextBoxColumn id_user;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn nama_role;
    }
}
