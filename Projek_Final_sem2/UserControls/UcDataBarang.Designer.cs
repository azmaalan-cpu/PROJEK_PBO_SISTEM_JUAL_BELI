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
            CbxSupplier = new ComboBox();
            CbxKategori = new ComboBox();
            PanelDaftarBarang = new Panel();
            DgvDaftarBarang = new DataGridView();
            LbDaftarBarang = new Label();
            BtnReset = new Button();
            BtnHapus = new Button();
            BtnEdit = new Button();
            BtnTambah = new Button();
            LbSupplier = new Label();
            TbStok = new TextBox();
            LbStok = new Label();
            TbHarga = new TextBox();
            LbHarga = new Label();
            LbKategori = new Label();
            TbNamaAlat = new TextBox();
            LbNamaAlat = new Label();
            LbDataBarang = new Label();
            id_alat = new DataGridViewTextBoxColumn();
            nama_alat = new DataGridViewTextBoxColumn();
            nama_kategori = new DataGridViewTextBoxColumn();
            harga = new DataGridViewTextBoxColumn();
            stok = new DataGridViewTextBoxColumn();
            nama_supplier = new DataGridViewTextBoxColumn();
            PaneDataBarang.SuspendLayout();
            PanelDaftarBarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvDaftarBarang).BeginInit();
            SuspendLayout();
            // 
            // PaneDataBarang
            // 
            PaneDataBarang.BackColor = Color.White;
            PaneDataBarang.Controls.Add(CbxSupplier);
            PaneDataBarang.Controls.Add(CbxKategori);
            PaneDataBarang.Controls.Add(PanelDaftarBarang);
            PaneDataBarang.Controls.Add(BtnReset);
            PaneDataBarang.Controls.Add(BtnHapus);
            PaneDataBarang.Controls.Add(BtnEdit);
            PaneDataBarang.Controls.Add(BtnTambah);
            PaneDataBarang.Controls.Add(LbSupplier);
            PaneDataBarang.Controls.Add(TbStok);
            PaneDataBarang.Controls.Add(LbStok);
            PaneDataBarang.Controls.Add(TbHarga);
            PaneDataBarang.Controls.Add(LbHarga);
            PaneDataBarang.Controls.Add(LbKategori);
            PaneDataBarang.Controls.Add(TbNamaAlat);
            PaneDataBarang.Controls.Add(LbNamaAlat);
            PaneDataBarang.Controls.Add(LbDataBarang);
            PaneDataBarang.Dock = DockStyle.Fill;
            PaneDataBarang.Location = new Point(0, 0);
            PaneDataBarang.Name = "PaneDataBarang";
            PaneDataBarang.Size = new Size(814, 548);
            PaneDataBarang.TabIndex = 0;
            // 
            // CbxSupplier
            // 
            CbxSupplier.FormattingEnabled = true;
            CbxSupplier.Location = new Point(253, 221);
            CbxSupplier.Name = "CbxSupplier";
            CbxSupplier.Size = new Size(261, 33);
            CbxSupplier.TabIndex = 17;
            // 
            // CbxKategori
            // 
            CbxKategori.FormattingEnabled = true;
            CbxKategori.Location = new Point(253, 88);
            CbxKategori.Name = "CbxKategori";
            CbxKategori.Size = new Size(261, 33);
            CbxKategori.TabIndex = 16;
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
            DgvDaftarBarang.Columns.AddRange(new DataGridViewColumn[] { id_alat, nama_alat, nama_kategori, harga, stok, nama_supplier });
            DgvDaftarBarang.Location = new Point(3, 26);
            DgvDaftarBarang.Name = "DgvDaftarBarang";
            DgvDaftarBarang.RowHeadersWidth = 62;
            DgvDaftarBarang.Size = new Size(575, 152);
            DgvDaftarBarang.TabIndex = 1;
            DgvDaftarBarang.CellClick += DgvDaftarBarang_CellClick;
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
            BtnReset.Click += BtnReset_Click;
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
            BtnHapus.Click += BtnHapus_Click;
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
            BtnEdit.Click += BtnEdit_Click;
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
            BtnTambah.Click += BtnTambah_Click;
            // 
            // LbSupplier
            // 
            LbSupplier.AutoSize = true;
            LbSupplier.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbSupplier.Location = new Point(29, 227);
            LbSupplier.Name = "LbSupplier";
            LbSupplier.Size = new Size(78, 22);
            LbSupplier.TabIndex = 9;
            LbSupplier.Text = "Supplier";
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
            // LbKategori
            // 
            LbKategori.AutoSize = true;
            LbKategori.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbKategori.Location = new Point(29, 90);
            LbKategori.Name = "LbKategori";
            LbKategori.Size = new Size(79, 22);
            LbKategori.TabIndex = 3;
            LbKategori.Text = "Kategori";
            // 
            // TbNamaAlat
            // 
            TbNamaAlat.BorderStyle = BorderStyle.FixedSingle;
            TbNamaAlat.Location = new Point(253, 46);
            TbNamaAlat.Name = "TbNamaAlat";
            TbNamaAlat.Size = new Size(261, 31);
            TbNamaAlat.TabIndex = 2;
            // 
            // LbNamaAlat
            // 
            LbNamaAlat.AutoSize = true;
            LbNamaAlat.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbNamaAlat.Location = new Point(29, 48);
            LbNamaAlat.Name = "LbNamaAlat";
            LbNamaAlat.Size = new Size(94, 22);
            LbNamaAlat.TabIndex = 1;
            LbNamaAlat.Text = "Nama Alat";
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
            // id_alat
            // 
            id_alat.DataPropertyName = "id_alat";
            id_alat.HeaderText = "ID";
            id_alat.MinimumWidth = 8;
            id_alat.Name = "id_alat";
            id_alat.Visible = false;
            // 
            // nama_alat
            // 
            nama_alat.DataPropertyName = "nama_alat";
            nama_alat.HeaderText = "Nama Alat";
            nama_alat.MinimumWidth = 8;
            nama_alat.Name = "nama_alat";
            // 
            // nama_kategori
            // 
            nama_kategori.DataPropertyName = "nama_kategori";
            nama_kategori.HeaderText = "Kategori";
            nama_kategori.MinimumWidth = 8;
            nama_kategori.Name = "nama_kategori";
            // 
            // harga
            // 
            harga.DataPropertyName = "harga";
            harga.HeaderText = "Harga";
            harga.MinimumWidth = 8;
            harga.Name = "harga";
            // 
            // stok
            // 
            stok.DataPropertyName = "stok";
            stok.HeaderText = "Stok";
            stok.MinimumWidth = 8;
            stok.Name = "stok";
            // 
            // nama_supplier
            // 
            nama_supplier.DataPropertyName = "nama_supplier";
            nama_supplier.HeaderText = "Supplier";
            nama_supplier.MinimumWidth = 8;
            nama_supplier.Name = "nama_supplier";
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
        private Label LbNamaAlat;
        private Label LbDataBarang;
        private Label LbKategori;
        private TextBox TbNamaAlat;
        private Label LbHarga;
        private TextBox TbHarga;
        private TextBox TbStok;
        private Label LbStok;
        private Label LbSupplier;
        private Button BtnEdit;
        private Button BtnTambah;
        private Button BtnHapus;
        private Button BtnReset;
        private Panel PanelDaftarBarang;
        private DataGridView DgvDaftarBarang;
        private Label LbDaftarBarang;
        private ComboBox CbxKategori;
        private ComboBox CbxSupplier;
        private DataGridViewTextBoxColumn id_alat;
        private DataGridViewTextBoxColumn nama_alat;
        private DataGridViewTextBoxColumn nama_kategori;
        private DataGridViewTextBoxColumn harga;
        private DataGridViewTextBoxColumn stok;
        private DataGridViewTextBoxColumn nama_supplier;
    }
}
