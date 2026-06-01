namespace Projek_Final_sem2.UserControls
{
    partial class UcDataBarang
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
            PaneDataBarang = new Panel();
            PanelDaftarBarang = new Panel();
            DgvDaftarBarang = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            LbDaftarBarang = new Label();
            BtnReset = new Button();
            BtnHapus = new Button();
            BtnEdit = new Button();
            BtnTambah = new Button();
            TbSatuan = new TextBox();
            LbSatuan = new Label();
            TbStok = new TextBox();
            LbStok = new Label();
            TbHarga = new TextBox();
            LbHarga = new Label();
            TbKategori = new TextBox();
            LbKategori = new Label();
            TbNamaBarang = new TextBox();
            LbNamaBarang = new Label();
            LbDataBarang = new Label();
            PaneDataBarang.SuspendLayout();
            PanelDaftarBarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvDaftarBarang).BeginInit();
            SuspendLayout();
            // 
            // PaneDataBarang
            // 
            PaneDataBarang.BackColor = Color.White;
            PaneDataBarang.Controls.Add(PanelDaftarBarang);
            PaneDataBarang.Controls.Add(BtnReset);
            PaneDataBarang.Controls.Add(BtnHapus);
            PaneDataBarang.Controls.Add(BtnEdit);
            PaneDataBarang.Controls.Add(BtnTambah);
            PaneDataBarang.Controls.Add(TbSatuan);
            PaneDataBarang.Controls.Add(LbSatuan);
            PaneDataBarang.Controls.Add(TbStok);
            PaneDataBarang.Controls.Add(LbStok);
            PaneDataBarang.Controls.Add(TbHarga);
            PaneDataBarang.Controls.Add(LbHarga);
            PaneDataBarang.Controls.Add(TbKategori);
            PaneDataBarang.Controls.Add(LbKategori);
            PaneDataBarang.Controls.Add(TbNamaBarang);
            PaneDataBarang.Controls.Add(LbNamaBarang);
            PaneDataBarang.Controls.Add(LbDataBarang);
            PaneDataBarang.Dock = DockStyle.Fill;
            PaneDataBarang.Location = new Point(0, 0);
            PaneDataBarang.Name = "PaneDataBarang";
            PaneDataBarang.Size = new Size(814, 548);
            PaneDataBarang.TabIndex = 0;
            // 
            // PanelDaftarBarang
            // 
            PanelDaftarBarang.Controls.Add(DgvDaftarBarang);
            PanelDaftarBarang.Controls.Add(LbDaftarBarang);
            PanelDaftarBarang.Location = new Point(29, 310);
            PanelDaftarBarang.Name = "PanelDaftarBarang";
            PanelDaftarBarang.Size = new Size(581, 178);
            PanelDaftarBarang.TabIndex = 15;
            // 
            // DgvDaftarBarang
            // 
            DgvDaftarBarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvDaftarBarang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDaftarBarang.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            DgvDaftarBarang.Location = new Point(3, 26);
            DgvDaftarBarang.Name = "DgvDaftarBarang";
            DgvDaftarBarang.RowHeadersWidth = 62;
            DgvDaftarBarang.Size = new Size(575, 152);
            DgvDaftarBarang.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "No";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nama Barang";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Kategori";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Harga";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Stok";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Satuan";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            // 
            // LbDaftarBarang
            // 
            LbDaftarBarang.AutoSize = true;
            LbDaftarBarang.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbDaftarBarang.Location = new Point(3, 0);
            LbDaftarBarang.Name = "LbDaftarBarang";
            LbDaftarBarang.Size = new Size(132, 23);
            LbDaftarBarang.TabIndex = 0;
            LbDaftarBarang.Text = "Daftar Barang";
            // 
            // BtnReset
            // 
            BtnReset.BackColor = Color.DimGray;
            BtnReset.ForeColor = Color.White;
            BtnReset.Location = new Point(451, 268);
            BtnReset.Name = "BtnReset";
            BtnReset.Size = new Size(112, 34);
            BtnReset.TabIndex = 14;
            BtnReset.Text = "Reset";
            BtnReset.UseVisualStyleBackColor = false;
            // 
            // BtnHapus
            // 
            BtnHapus.BackColor = Color.Red;
            BtnHapus.ForeColor = Color.White;
            BtnHapus.Location = new Point(310, 269);
            BtnHapus.Name = "BtnHapus";
            BtnHapus.Size = new Size(112, 34);
            BtnHapus.TabIndex = 13;
            BtnHapus.Text = "Hapus";
            BtnHapus.UseVisualStyleBackColor = false;
            // 
            // BtnEdit
            // 
            BtnEdit.BackColor = Color.DeepSkyBlue;
            BtnEdit.ForeColor = Color.White;
            BtnEdit.Location = new Point(173, 269);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(112, 34);
            BtnEdit.TabIndex = 12;
            BtnEdit.Text = "Edit";
            BtnEdit.UseVisualStyleBackColor = false;
            // 
            // BtnTambah
            // 
            BtnTambah.BackColor = Color.Green;
            BtnTambah.ForeColor = Color.White;
            BtnTambah.Location = new Point(29, 268);
            BtnTambah.Name = "BtnTambah";
            BtnTambah.Size = new Size(112, 34);
            BtnTambah.TabIndex = 11;
            BtnTambah.Text = "Tambah";
            BtnTambah.UseVisualStyleBackColor = false;
            // 
            // TbSatuan
            // 
            TbSatuan.BorderStyle = BorderStyle.FixedSingle;
            TbSatuan.Location = new Point(253, 229);
            TbSatuan.Name = "TbSatuan";
            TbSatuan.Size = new Size(261, 31);
            TbSatuan.TabIndex = 10;
            // 
            // LbSatuan
            // 
            LbSatuan.AutoSize = true;
            LbSatuan.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbSatuan.Location = new Point(29, 227);
            LbSatuan.Name = "LbSatuan";
            LbSatuan.Size = new Size(62, 22);
            LbSatuan.TabIndex = 9;
            LbSatuan.Text = "Satuan";
            // 
            // TbStok
            // 
            TbStok.BorderStyle = BorderStyle.FixedSingle;
            TbStok.Location = new Point(253, 182);
            TbStok.Name = "TbStok";
            TbStok.Size = new Size(261, 31);
            TbStok.TabIndex = 8;
            // 
            // LbStok
            // 
            LbStok.AutoSize = true;
            LbStok.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbStok.Location = new Point(29, 185);
            LbStok.Name = "LbStok";
            LbStok.Size = new Size(45, 22);
            LbStok.TabIndex = 7;
            LbStok.Text = "Stok";
            // 
            // TbHarga
            // 
            TbHarga.BorderStyle = BorderStyle.FixedSingle;
            TbHarga.Location = new Point(253, 137);
            TbHarga.Name = "TbHarga";
            TbHarga.Size = new Size(261, 31);
            TbHarga.TabIndex = 6;
            // 
            // LbHarga
            // 
            LbHarga.AutoSize = true;
            LbHarga.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbHarga.Location = new Point(29, 137);
            LbHarga.Name = "LbHarga";
            LbHarga.Size = new Size(58, 22);
            LbHarga.TabIndex = 5;
            LbHarga.Text = "Harga";
            // 
            // TbKategori
            // 
            TbKategori.BorderStyle = BorderStyle.FixedSingle;
            TbKategori.Location = new Point(253, 90);
            TbKategori.Name = "TbKategori";
            TbKategori.Size = new Size(261, 31);
            TbKategori.TabIndex = 4;
            // 
            // LbKategori
            // 
            LbKategori.AutoSize = true;
            LbKategori.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbKategori.Location = new Point(29, 88);
            LbKategori.Name = "LbKategori";
            LbKategori.Size = new Size(79, 22);
            LbKategori.TabIndex = 3;
            LbKategori.Text = "Kategori";
            // 
            // TbNamaBarang
            // 
            TbNamaBarang.BorderStyle = BorderStyle.FixedSingle;
            TbNamaBarang.Location = new Point(253, 46);
            TbNamaBarang.Name = "TbNamaBarang";
            TbNamaBarang.Size = new Size(261, 31);
            TbNamaBarang.TabIndex = 2;
            // 
            // LbNamaBarang
            // 
            LbNamaBarang.AutoSize = true;
            LbNamaBarang.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbNamaBarang.Location = new Point(29, 48);
            LbNamaBarang.Name = "LbNamaBarang";
            LbNamaBarang.Size = new Size(122, 22);
            LbNamaBarang.TabIndex = 1;
            LbNamaBarang.Text = "Nama Barang ";
            // 
            // LbDataBarang
            // 
            LbDataBarang.AutoSize = true;
            LbDataBarang.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbDataBarang.Location = new Point(20, 6);
            LbDataBarang.Name = "LbDataBarang";
            LbDataBarang.Size = new Size(143, 26);
            LbDataBarang.TabIndex = 0;
            LbDataBarang.Text = "Data Barang";
            // 
            // UcDataBarang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PaneDataBarang);
            Name = "UcDataBarang";
            Size = new Size(814, 548);
            PaneDataBarang.ResumeLayout(false);
            PaneDataBarang.PerformLayout();
            PanelDaftarBarang.ResumeLayout(false);
            PanelDaftarBarang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvDaftarBarang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PaneDataBarang;
        private Label LbNamaBarang;
        private Label LbDataBarang;
        private TextBox TbKategori;
        private Label LbKategori;
        private TextBox TbNamaBarang;
        private Label LbHarga;
        private TextBox TbHarga;
        private TextBox TbStok;
        private Label LbStok;
        private TextBox TbSatuan;
        private Label LbSatuan;
        private Button BtnEdit;
        private Button BtnTambah;
        private Button BtnHapus;
        private Button BtnReset;
        private Panel PanelDaftarBarang;
        private DataGridView DgvDaftarBarang;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Label LbDaftarBarang;
    }
}
