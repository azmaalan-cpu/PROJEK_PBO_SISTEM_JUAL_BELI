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
            PanelDaftarUser = new Panel();
            DgvDaftarUser = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            LbDaftarUser = new Label();
            BtnReset = new Button();
            BtnHapus = new Button();
            BtnEdit = new Button();
            BtnTambah = new Button();
            TbRole = new TextBox();
            LbRole = new Label();
            textBox1 = new TextBox();
            LbNamaLengkap = new Label();
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
            PanelDataUser.Controls.Add(PanelDaftarUser);
            PanelDataUser.Controls.Add(BtnReset);
            PanelDataUser.Controls.Add(BtnHapus);
            PanelDataUser.Controls.Add(BtnEdit);
            PanelDataUser.Controls.Add(BtnTambah);
            PanelDataUser.Controls.Add(TbRole);
            PanelDataUser.Controls.Add(LbRole);
            PanelDataUser.Controls.Add(textBox1);
            PanelDataUser.Controls.Add(LbNamaLengkap);
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
            DgvDaftarUser.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            DgvDaftarUser.Dock = DockStyle.Fill;
            DgvDaftarUser.Location = new Point(0, 0);
            DgvDaftarUser.Name = "DgvDaftarUser";
            DgvDaftarUser.RowHeadersWidth = 62;
            DgvDaftarUser.Size = new Size(550, 155);
            DgvDaftarUser.TabIndex = 14;
            // 
            // Column1
            // 
            Column1.HeaderText = "No";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Username";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Nama Lengkap";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Role";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
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
            BtnReset.Location = new Point(389, 229);
            BtnReset.Name = "BtnReset";
            BtnReset.Size = new Size(112, 34);
            BtnReset.TabIndex = 12;
            BtnReset.Text = "Reset";
            BtnReset.UseVisualStyleBackColor = false;
            // 
            // BtnHapus
            // 
            BtnHapus.BackColor = Color.Red;
            BtnHapus.ForeColor = Color.White;
            BtnHapus.Location = new Point(264, 229);
            BtnHapus.Name = "BtnHapus";
            BtnHapus.Size = new Size(112, 34);
            BtnHapus.TabIndex = 11;
            BtnHapus.Text = "Hapus";
            BtnHapus.UseVisualStyleBackColor = false;
            // 
            // BtnEdit
            // 
            BtnEdit.BackColor = Color.DeepSkyBlue;
            BtnEdit.ForeColor = Color.White;
            BtnEdit.Location = new Point(136, 229);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(112, 34);
            BtnEdit.TabIndex = 10;
            BtnEdit.Text = "Edit";
            BtnEdit.UseVisualStyleBackColor = false;
            // 
            // BtnTambah
            // 
            BtnTambah.BackColor = Color.Green;
            BtnTambah.ForeColor = Color.White;
            BtnTambah.Location = new Point(3, 230);
            BtnTambah.Name = "BtnTambah";
            BtnTambah.Size = new Size(112, 34);
            BtnTambah.TabIndex = 9;
            BtnTambah.Text = "Tambah";
            BtnTambah.UseVisualStyleBackColor = false;
            // 
            // TbRole
            // 
            TbRole.BorderStyle = BorderStyle.FixedSingle;
            TbRole.Location = new Point(210, 189);
            TbRole.Name = "TbRole";
            TbRole.Size = new Size(271, 31);
            TbRole.TabIndex = 8;
            // 
            // LbRole
            // 
            LbRole.AutoSize = true;
            LbRole.Location = new Point(3, 193);
            LbRole.Name = "LbRole";
            LbRole.Size = new Size(46, 25);
            LbRole.TabIndex = 7;
            LbRole.Text = "Role";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(210, 143);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(271, 31);
            textBox1.TabIndex = 6;
            // 
            // LbNamaLengkap
            // 
            LbNamaLengkap.AutoSize = true;
            LbNamaLengkap.Location = new Point(0, 139);
            LbNamaLengkap.Name = "LbNamaLengkap";
            LbNamaLengkap.Size = new Size(131, 25);
            LbNamaLengkap.TabIndex = 5;
            LbNamaLengkap.Text = "Nama Lengkap";
            // 
            // TbPassword
            // 
            TbPassword.BorderStyle = BorderStyle.FixedSingle;
            TbPassword.Location = new Point(210, 91);
            TbPassword.Name = "TbPassword";
            TbPassword.Size = new Size(271, 31);
            TbPassword.TabIndex = 4;
            // 
            // LbPassword
            // 
            LbPassword.AutoSize = true;
            LbPassword.Location = new Point(0, 90);
            LbPassword.Name = "LbPassword";
            LbPassword.Size = new Size(87, 25);
            LbPassword.TabIndex = 3;
            LbPassword.Text = "Password";
            // 
            // TbUsername
            // 
            TbUsername.BorderStyle = BorderStyle.FixedSingle;
            TbUsername.Location = new Point(210, 41);
            TbUsername.Name = "TbUsername";
            TbUsername.Size = new Size(271, 31);
            TbUsername.TabIndex = 2;
            // 
            // LbUsername
            // 
            LbUsername.AutoSize = true;
            LbUsername.Location = new Point(3, 42);
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
        private TextBox TbRole;
        private Label LbRole;
        private TextBox textBox1;
        private Label LbNamaLengkap;
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
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
