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
            id_alat = new DataGridViewTextBoxColumn();
            nama_alat = new DataGridViewTextBoxColumn();
            nama_kategori = new DataGridViewTextBoxColumn();
            harga = new DataGridViewTextBoxColumn();
            stok = new DataGridViewTextBoxColumn();
            nama_supplier = new DataGridViewTextBoxColumn();
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
            TbKategori = new TextBox();
            LbKategori = new Label();
            TbNamaAlat = new TextBox();
            LbNamaAlat = new Label();
            LbDataBarang = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
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
            PaneDataBarang.Controls.Add(TbKategori);
            PaneDataBarang.Controls.Add(LbKategori);
            PaneDataBarang.Controls.Add(TbNamaAlat);
            PaneDataBarang.Controls.Add(LbNamaAlat);
            PaneDataBarang.Controls.Add(LbDataBarang);
            PaneDataBarang.Dock = DockStyle.Fill;
            PaneDataBarang.Location = new Point(0, 0);
            PaneDataBarang.Margin = new Padding(2, 2, 2, 2);
            PaneDataBarang.Name = "PaneDataBarang";
            PaneDataBarang.Size = new Size(570, 329);
            PaneDataBarang.TabIndex = 0;
            // 
            // CbxSupplier
            // 
            CbxSupplier.FormattingEnabled = true;
            CbxSupplier.Location = new Point(177, 133);
            CbxSupplier.Margin = new Padding(2, 2, 2, 2);
            CbxSupplier.Name = "CbxSupplier";
            CbxSupplier.Size = new Size(184, 23);
            CbxSupplier.TabIndex = 17;
            // 
            // CbxKategori
            // 
            CbxKategori.FormattingEnabled = true;
            CbxKategori.Location = new Point(177, 53);
            CbxKategori.Margin = new Padding(2, 2, 2, 2);
            CbxKategori.Name = "CbxKategori";
            CbxKategori.Size = new Size(184, 23);
            CbxKategori.TabIndex = 16;
            // 
            // PanelDaftarBarang
            // 
            PanelDaftarBarang.Controls.Add(DgvDaftarBarang);
            PanelDaftarBarang.Controls.Add(LbDaftarBarang);
            PanelDaftarBarang.Location = new Point(20, 186);
            PanelDaftarBarang.Margin = new Padding(2, 2, 2, 2);
            PanelDaftarBarang.Name = "PanelDaftarBarang";
            PanelDaftarBarang.Size = new Size(407, 107);
            PanelDaftarBarang.TabIndex = 15;
            // 
            // DgvDaftarBarang
            // 
            DgvDaftarBarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvDaftarBarang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDaftarBarang.Columns.AddRange(new DataGridViewColumn[] { id_alat, nama_alat, nama_kategori, harga, stok, nama_supplier });
            DgvDaftarBarang.Location = new Point(2, 16);
            DgvDaftarBarang.Margin = new Padding(2, 2, 2, 2);
            DgvDaftarBarang.Name = "DgvDaftarBarang";
            DgvDaftarBarang.RowHeadersWidth = 62;
            DgvDaftarBarang.Size = new Size(402, 91);
            DgvDaftarBarang.TabIndex = 1;
            DgvDaftarBarang.CellClick += DgvDaftarBarang_CellClick;
            DgvDaftarBarang.CellContentClick += DgvDaftarBarang_CellContentClick;
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
            // LbDaftarBarang
            // 
            LbDaftarBarang.AutoSize = true;
            LbDaftarBarang.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbDaftarBarang.Location = new Point(2, 0);
            LbDaftarBarang.Margin = new Padding(2, 0, 2, 0);
            LbDaftarBarang.Name = "LbDaftarBarang";
            LbDaftarBarang.Size = new Size(96, 17);
            LbDaftarBarang.TabIndex = 0;
            LbDaftarBarang.Text = "Daftar Barang";
            // 
            // BtnReset
            // 
            BtnReset.BackColor = Color.DimGray;
            BtnReset.ForeColor = Color.White;
            BtnReset.Location = new Point(316, 161);
            BtnReset.Margin = new Padding(2, 2, 2, 2);
            BtnReset.Name = "BtnReset";
            BtnReset.Size = new Size(78, 20);
            BtnReset.TabIndex = 14;
            BtnReset.Text = "Reset";
            BtnReset.UseVisualStyleBackColor = false;
            BtnReset.Click += BtnReset_Click;
            // 
            // BtnHapus
            // 
            BtnHapus.BackColor = Color.Red;
            BtnHapus.ForeColor = Color.White;
            BtnHapus.Location = new Point(217, 161);
            BtnHapus.Margin = new Padding(2, 2, 2, 2);
            BtnHapus.Name = "BtnHapus";
            BtnHapus.Size = new Size(78, 20);
            BtnHapus.TabIndex = 13;
            BtnHapus.Text = "Hapus";
            BtnHapus.UseVisualStyleBackColor = false;
            BtnHapus.Click += BtnHapus_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.BackColor = Color.DeepSkyBlue;
            BtnEdit.ForeColor = Color.White;
            BtnEdit.Location = new Point(121, 161);
            BtnEdit.Margin = new Padding(2, 2, 2, 2);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(78, 20);
            BtnEdit.TabIndex = 12;
            BtnEdit.Text = "Edit";
            BtnEdit.UseVisualStyleBackColor = false;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnTambah
            // 
            BtnTambah.BackColor = Color.Green;
            BtnTambah.ForeColor = Color.White;
            BtnTambah.Location = new Point(25, 161);
            BtnTambah.Margin = new Padding(2, 2, 2, 2);
            BtnTambah.Name = "BtnTambah";
            BtnTambah.Size = new Size(78, 20);
            BtnTambah.TabIndex = 11;
            BtnTambah.Text = "Tambah";
            BtnTambah.UseVisualStyleBackColor = false;
            BtnTambah.Click += BtnTambah_Click;
            // 
            // LbSupplier
            // 
            LbSupplier.AutoSize = true;
            LbSupplier.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbSupplier.Location = new Point(20, 136);
            LbSupplier.Margin = new Padding(2, 0, 2, 0);
            LbSupplier.Name = "LbSupplier";
            LbSupplier.Size = new Size(53, 16);
            LbSupplier.TabIndex = 9;
            LbSupplier.Text = "Supplier";
            // 
            // TbStok
            // 
            TbStok.BorderStyle = BorderStyle.FixedSingle;
            TbStok.Location = new Point(177, 109);
            TbStok.Margin = new Padding(2, 2, 2, 2);
            TbStok.Name = "TbStok";
            TbStok.Size = new Size(183, 23);
            TbStok.TabIndex = 8;
            // 
            // LbStok
            // 
            LbStok.AutoSize = true;
            LbStok.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbStok.Location = new Point(20, 111);
            LbStok.Margin = new Padding(2, 0, 2, 0);
            LbStok.Name = "LbStok";
            LbStok.Size = new Size(33, 16);
            LbStok.TabIndex = 7;
            LbStok.Text = "Stok";
            // 
            // TbHarga
            // 
            TbHarga.BorderStyle = BorderStyle.FixedSingle;
            TbHarga.Location = new Point(177, 82);
            TbHarga.Margin = new Padding(2, 2, 2, 2);
            TbHarga.Name = "TbHarga";
            TbHarga.Size = new Size(183, 23);
            TbHarga.TabIndex = 6;
            // 
            // LbHarga
            // 
            LbHarga.AutoSize = true;
            LbHarga.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbHarga.Location = new Point(20, 82);
            LbHarga.Margin = new Padding(2, 0, 2, 0);
            LbHarga.Name = "LbHarga";
            LbHarga.Size = new Size(40, 16);
            LbHarga.TabIndex = 5;
            LbHarga.Text = "Harga";
            // 
            // TbKategori
            // 
            TbKategori.BorderStyle = BorderStyle.FixedSingle;
            TbKategori.Location = new Point(177, 54);
            TbKategori.Margin = new Padding(2, 2, 2, 2);
            TbKategori.Name = "TbKategori";
            TbKategori.Size = new Size(183, 23);
            TbKategori.TabIndex = 4;
            // 
            // LbKategori
            // 
            LbKategori.AutoSize = true;
            LbKategori.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbKategori.Location = new Point(20, 54);
            LbKategori.Margin = new Padding(2, 0, 2, 0);
            LbKategori.Name = "LbKategori";
            LbKategori.Size = new Size(54, 16);
            LbKategori.TabIndex = 3;
            LbKategori.Text = "Kategori";
            // 
            // TbNamaAlat
            // 
            TbNamaAlat.BorderStyle = BorderStyle.FixedSingle;
            TbNamaAlat.Location = new Point(177, 28);
            TbNamaAlat.Margin = new Padding(2, 2, 2, 2);
            TbNamaAlat.Name = "TbNamaAlat";
            TbNamaAlat.Size = new Size(183, 23);
            TbNamaAlat.TabIndex = 2;
            // 
            // LbNamaAlat
            // 
            LbNamaAlat.AutoSize = true;
            LbNamaAlat.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbNamaAlat.Location = new Point(20, 29);
            LbNamaAlat.Margin = new Padding(2, 0, 2, 0);
            LbNamaAlat.Name = "LbNamaAlat";
            LbNamaAlat.Size = new Size(65, 16);
            LbNamaAlat.TabIndex = 1;
            LbNamaAlat.Text = "Nama Alat";
            // 
            // LbDataBarang
            // 
            LbDataBarang.AutoSize = true;
            LbDataBarang.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbDataBarang.Location = new Point(14, 4);
            LbDataBarang.Margin = new Padding(2, 0, 2, 0);
            LbDataBarang.Name = "LbDataBarang";
            LbDataBarang.Size = new Size(95, 19);
            LbDataBarang.TabIndex = 0;
            LbDataBarang.Text = "Data Barang";
            // 
            // Column1
            // 
            Column1.HeaderText = "No";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nama Barang";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Kategori";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Harga";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "Stok";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // Column6
            // 
            Column6.HeaderText = "Satuan";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.Width = 150;
            // 
            // UcDataBarang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PaneDataBarang);
            Margin = new Padding(2, 2, 2, 2);
            Name = "UcDataBarang";
            Size = new Size(570, 329);
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
        private TextBox TbKategori;
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
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
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
