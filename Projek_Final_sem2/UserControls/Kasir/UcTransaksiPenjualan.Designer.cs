namespace Projek_Final_sem2.UserControls.Kasir
{
    partial class UcTransaksiPenjualan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcTransaksiPenjualan));
            label1 = new Label();
            PanelCariIdTransaksiPenjualan = new Panel();
            BtnCari = new Button();
            TxtCariBarang = new TextBox();
            LbCariIdBarangTransaksiPenjualan = new Label();
            gbKatalog = new GroupBox();
            FlpkatalogProduk = new FlowLayoutPanel();
            PanelBarang1 = new Panel();
            LbID1 = new Label();
            PcxBarang1 = new PictureBox();
            LbNamaBarang1 = new Label();
            LbStok1 = new Label();
            LbHarga1 = new Label();
            BtnTambah1 = new Button();
            PanelBarang2 = new Panel();
            BtnTambah2 = new Button();
            LbHarga2 = new Label();
            LbStok2 = new Label();
            LbNamaBarang2 = new Label();
            LbId2 = new Label();
            PcxBarang2 = new PictureBox();
            panel1 = new Panel();
            BtnTambah3 = new Button();
            LbHarga3 = new Label();
            LbStok3 = new Label();
            LbNamaBarang3 = new Label();
            LbId3 = new Label();
            PcxBarang3 = new PictureBox();
            panel2 = new Panel();
            BtnTambah4 = new Button();
            LbHarga4 = new Label();
            LbStok = new Label();
            LbNamaBarang4 = new Label();
            LbId4 = new Label();
            PcxBarang4 = new PictureBox();
            GbKeranjangBelanja = new GroupBox();
            DgvKeranjang = new DataGridView();
            ColSubTotal = new DataGridViewTextBoxColumn();
            ColQty = new DataGridViewTextBoxColumn();
            ColHarga = new DataGridViewTextBoxColumn();
            ColNamaBarang = new DataGridViewTextBoxColumn();
            ColIDBarang = new DataGridViewTextBoxColumn();
            ColNo = new DataGridViewTextBoxColumn();
            PanelTotalBayar = new Panel();
            LbTotalBayar = new Label();
            LblTotalBayar = new Label();
            BtnSimpanTransaksiPenjualan = new Button();
            BtnBersihTransaksi = new Button();
            PanelCariIdTransaksiPenjualan.SuspendLayout();
            gbKatalog.SuspendLayout();
            FlpkatalogProduk.SuspendLayout();
            PanelBarang1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PcxBarang1).BeginInit();
            PanelBarang2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PcxBarang2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PcxBarang3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PcxBarang4).BeginInit();
            GbKeranjangBelanja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvKeranjang).BeginInit();
            PanelTotalBayar.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(28, 13);
            label1.Name = "label1";
            label1.Size = new Size(181, 23);
            label1.TabIndex = 0;
            label1.Text = "Transaksi Penjualan";
            // 
            // PanelCariIdTransaksiPenjualan
            // 
            PanelCariIdTransaksiPenjualan.BorderStyle = BorderStyle.FixedSingle;
            PanelCariIdTransaksiPenjualan.Controls.Add(BtnCari);
            PanelCariIdTransaksiPenjualan.Controls.Add(TxtCariBarang);
            PanelCariIdTransaksiPenjualan.Controls.Add(LbCariIdBarangTransaksiPenjualan);
            PanelCariIdTransaksiPenjualan.Location = new Point(30, 54);
            PanelCariIdTransaksiPenjualan.Margin = new Padding(3, 4, 3, 4);
            PanelCariIdTransaksiPenjualan.Name = "PanelCariIdTransaksiPenjualan";
            PanelCariIdTransaksiPenjualan.Size = new Size(913, 80);
            PanelCariIdTransaksiPenjualan.TabIndex = 1;
            // 
            // BtnCari
            // 
            BtnCari.BackColor = Color.ForestGreen;
            BtnCari.FlatStyle = FlatStyle.Flat;
            BtnCari.ForeColor = Color.White;
            BtnCari.Location = new Point(500, 26);
            BtnCari.Margin = new Padding(3, 4, 3, 4);
            BtnCari.Name = "BtnCari";
            BtnCari.Size = new Size(106, 29);
            BtnCari.TabIndex = 2;
            BtnCari.Text = "Cari";
            BtnCari.UseVisualStyleBackColor = false;
            // 
            // TxtCariBarang
            // 
            TxtCariBarang.Location = new Point(207, 29);
            TxtCariBarang.Margin = new Padding(3, 4, 3, 4);
            TxtCariBarang.Name = "TxtCariBarang";
            TxtCariBarang.Size = new Size(281, 27);
            TxtCariBarang.TabIndex = 1;
            // 
            // LbCariIdBarangTransaksiPenjualan
            // 
            LbCariIdBarangTransaksiPenjualan.AutoSize = true;
            LbCariIdBarangTransaksiPenjualan.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbCariIdBarangTransaksiPenjualan.Location = new Point(28, 26);
            LbCariIdBarangTransaksiPenjualan.Name = "LbCariIdBarangTransaksiPenjualan";
            LbCariIdBarangTransaksiPenjualan.Size = new Size(162, 23);
            LbCariIdBarangTransaksiPenjualan.TabIndex = 0;
            LbCariIdBarangTransaksiPenjualan.Text = "Cari Id Barang    :";
            // 
            // gbKatalog
            // 
            gbKatalog.Controls.Add(FlpkatalogProduk);
            gbKatalog.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbKatalog.ForeColor = Color.ForestGreen;
            gbKatalog.Location = new Point(28, 152);
            gbKatalog.Margin = new Padding(3, 4, 3, 4);
            gbKatalog.Name = "gbKatalog";
            gbKatalog.Padding = new Padding(3, 4, 3, 4);
            gbKatalog.Size = new Size(1092, 285);
            gbKatalog.TabIndex = 2;
            gbKatalog.TabStop = false;
            gbKatalog.Text = "Katalog Produk";
            // 
            // FlpkatalogProduk
            // 
            FlpkatalogProduk.AutoScroll = true;
            FlpkatalogProduk.Controls.Add(PanelBarang1);
            FlpkatalogProduk.Controls.Add(PanelBarang2);
            FlpkatalogProduk.Controls.Add(panel1);
            FlpkatalogProduk.Controls.Add(panel2);
            FlpkatalogProduk.Dock = DockStyle.Fill;
            FlpkatalogProduk.Location = new Point(3, 27);
            FlpkatalogProduk.Margin = new Padding(3, 4, 3, 4);
            FlpkatalogProduk.Name = "FlpkatalogProduk";
            FlpkatalogProduk.Size = new Size(1086, 254);
            FlpkatalogProduk.TabIndex = 0;
            // 
            // PanelBarang1
            // 
            PanelBarang1.BackColor = Color.WhiteSmoke;
            PanelBarang1.BorderStyle = BorderStyle.FixedSingle;
            PanelBarang1.Controls.Add(BtnTambah1);
            PanelBarang1.Controls.Add(LbHarga1);
            PanelBarang1.Controls.Add(LbStok1);
            PanelBarang1.Controls.Add(LbNamaBarang1);
            PanelBarang1.Controls.Add(LbID1);
            PanelBarang1.Controls.Add(PcxBarang1);
            PanelBarang1.Location = new Point(3, 4);
            PanelBarang1.Margin = new Padding(3, 4, 3, 4);
            PanelBarang1.Name = "PanelBarang1";
            PanelBarang1.Size = new Size(202, 250);
            PanelBarang1.TabIndex = 0;
            // 
            // LbID1
            // 
            LbID1.AutoSize = true;
            LbID1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbID1.ForeColor = SystemColors.ActiveCaptionText;
            LbID1.Location = new Point(17, 111);
            LbID1.Name = "LbID1";
            LbID1.Size = new Size(95, 17);
            LbID1.TabIndex = 1;
            LbID1.Text = "ID : BRG001";
            LbID1.Click += LbLID1_Click;
            // 
            // PcxBarang1
            // 
            PcxBarang1.BackgroundImage = (Image)resources.GetObject("PcxBarang1.BackgroundImage");
            PcxBarang1.BackgroundImageLayout = ImageLayout.Zoom;
            PcxBarang1.Location = new Point(34, 9);
            PcxBarang1.Margin = new Padding(3, 4, 3, 4);
            PcxBarang1.Name = "PcxBarang1";
            PcxBarang1.Size = new Size(135, 89);
            PcxBarang1.SizeMode = PictureBoxSizeMode.Zoom;
            PcxBarang1.TabIndex = 0;
            PcxBarang1.TabStop = false;
            // 
            // LbNamaBarang1
            // 
            LbNamaBarang1.AutoSize = true;
            LbNamaBarang1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbNamaBarang1.Location = new Point(17, 135);
            LbNamaBarang1.Name = "LbNamaBarang1";
            LbNamaBarang1.Size = new Size(63, 17);
            LbNamaBarang1.TabIndex = 1;
            LbNamaBarang1.Text = "Cangkul";
            // 
            // LbStok1
            // 
            LbStok1.AutoSize = true;
            LbStok1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbStok1.ForeColor = SystemColors.ActiveCaptionText;
            LbStok1.Location = new Point(17, 160);
            LbStok1.Name = "LbStok1";
            LbStok1.Size = new Size(67, 17);
            LbStok1.TabIndex = 2;
            LbStok1.Text = "Stok : 15";
            // 
            // LbHarga1
            // 
            LbHarga1.AutoSize = true;
            LbHarga1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHarga1.Location = new Point(17, 185);
            LbHarga1.Name = "LbHarga1";
            LbHarga1.Size = new Size(75, 17);
            LbHarga1.TabIndex = 3;
            LbHarga1.Text = "Rp 75.000";
            // 
            // BtnTambah1
            // 
            BtnTambah1.BackColor = Color.ForestGreen;
            BtnTambah1.FlatStyle = FlatStyle.Flat;
            BtnTambah1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnTambah1.ForeColor = Color.White;
            BtnTambah1.Location = new Point(45, 209);
            BtnTambah1.Margin = new Padding(3, 4, 3, 4);
            BtnTambah1.Name = "BtnTambah1";
            BtnTambah1.Size = new Size(112, 31);
            BtnTambah1.TabIndex = 4;
            BtnTambah1.Text = "Tambah";
            BtnTambah1.UseVisualStyleBackColor = false;
            // 
            // PanelBarang2
            // 
            PanelBarang2.BackColor = Color.WhiteSmoke;
            PanelBarang2.BorderStyle = BorderStyle.FixedSingle;
            PanelBarang2.Controls.Add(BtnTambah2);
            PanelBarang2.Controls.Add(LbHarga2);
            PanelBarang2.Controls.Add(LbStok2);
            PanelBarang2.Controls.Add(LbNamaBarang2);
            PanelBarang2.Controls.Add(LbId2);
            PanelBarang2.Controls.Add(PcxBarang2);
            PanelBarang2.Location = new Point(211, 4);
            PanelBarang2.Margin = new Padding(3, 4, 3, 4);
            PanelBarang2.Name = "PanelBarang2";
            PanelBarang2.Size = new Size(202, 250);
            PanelBarang2.TabIndex = 1;
            // 
            // BtnTambah2
            // 
            BtnTambah2.BackColor = Color.ForestGreen;
            BtnTambah2.FlatStyle = FlatStyle.Flat;
            BtnTambah2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnTambah2.ForeColor = Color.White;
            BtnTambah2.Location = new Point(45, 209);
            BtnTambah2.Margin = new Padding(3, 4, 3, 4);
            BtnTambah2.Name = "BtnTambah2";
            BtnTambah2.Size = new Size(112, 31);
            BtnTambah2.TabIndex = 4;
            BtnTambah2.Text = "Tambah";
            BtnTambah2.UseVisualStyleBackColor = false;
            // 
            // LbHarga2
            // 
            LbHarga2.AutoSize = true;
            LbHarga2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHarga2.Location = new Point(17, 185);
            LbHarga2.Name = "LbHarga2";
            LbHarga2.Size = new Size(83, 17);
            LbHarga2.TabIndex = 3;
            LbHarga2.Text = "Rp 800.000";
            // 
            // LbStok2
            // 
            LbStok2.AutoSize = true;
            LbStok2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbStok2.ForeColor = SystemColors.ActiveCaptionText;
            LbStok2.Location = new Point(17, 160);
            LbStok2.Name = "LbStok2";
            LbStok2.Size = new Size(67, 17);
            LbStok2.TabIndex = 2;
            LbStok2.Text = "Stok : 10";
            // 
            // LbNamaBarang2
            // 
            LbNamaBarang2.AutoSize = true;
            LbNamaBarang2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbNamaBarang2.Location = new Point(17, 135);
            LbNamaBarang2.Name = "LbNamaBarang2";
            LbNamaBarang2.Size = new Size(76, 17);
            LbNamaBarang2.TabIndex = 1;
            LbNamaBarang2.Text = "Pompa Air";
            // 
            // LbId2
            // 
            LbId2.AutoSize = true;
            LbId2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbId2.ForeColor = SystemColors.ActiveCaptionText;
            LbId2.Location = new Point(17, 111);
            LbId2.Name = "LbId2";
            LbId2.Size = new Size(95, 17);
            LbId2.TabIndex = 1;
            LbId2.Text = "ID : BRG002";
            // 
            // PcxBarang2
            // 
            PcxBarang2.BackgroundImage = (Image)resources.GetObject("PcxBarang2.BackgroundImage");
            PcxBarang2.BackgroundImageLayout = ImageLayout.Zoom;
            PcxBarang2.Location = new Point(34, 9);
            PcxBarang2.Margin = new Padding(3, 4, 3, 4);
            PcxBarang2.Name = "PcxBarang2";
            PcxBarang2.Size = new Size(135, 89);
            PcxBarang2.SizeMode = PictureBoxSizeMode.Zoom;
            PcxBarang2.TabIndex = 0;
            PcxBarang2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(BtnTambah3);
            panel1.Controls.Add(LbHarga3);
            panel1.Controls.Add(LbStok3);
            panel1.Controls.Add(LbNamaBarang3);
            panel1.Controls.Add(LbId3);
            panel1.Controls.Add(PcxBarang3);
            panel1.Location = new Point(419, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 250);
            panel1.TabIndex = 2;
            // 
            // BtnTambah3
            // 
            BtnTambah3.BackColor = Color.ForestGreen;
            BtnTambah3.FlatStyle = FlatStyle.Flat;
            BtnTambah3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnTambah3.ForeColor = Color.White;
            BtnTambah3.Location = new Point(45, 209);
            BtnTambah3.Margin = new Padding(3, 4, 3, 4);
            BtnTambah3.Name = "BtnTambah3";
            BtnTambah3.Size = new Size(112, 31);
            BtnTambah3.TabIndex = 4;
            BtnTambah3.Text = "Tambah";
            BtnTambah3.UseVisualStyleBackColor = false;
            // 
            // LbHarga3
            // 
            LbHarga3.AutoSize = true;
            LbHarga3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHarga3.Location = new Point(17, 185);
            LbHarga3.Name = "LbHarga3";
            LbHarga3.Size = new Size(83, 17);
            LbHarga3.TabIndex = 3;
            LbHarga3.Text = "Rp 350.000";
            // 
            // LbStok3
            // 
            LbStok3.AutoSize = true;
            LbStok3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbStok3.ForeColor = SystemColors.ActiveCaptionText;
            LbStok3.Location = new Point(17, 160);
            LbStok3.Name = "LbStok3";
            LbStok3.Size = new Size(67, 17);
            LbStok3.TabIndex = 2;
            LbStok3.Text = "Stok : 12";
            // 
            // LbNamaBarang3
            // 
            LbNamaBarang3.AutoSize = true;
            LbNamaBarang3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbNamaBarang3.Location = new Point(17, 135);
            LbNamaBarang3.Name = "LbNamaBarang3";
            LbNamaBarang3.Size = new Size(109, 17);
            LbNamaBarang3.TabIndex = 1;
            LbNamaBarang3.Text = "Mesin Semprot";
            // 
            // LbId3
            // 
            LbId3.AutoSize = true;
            LbId3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbId3.ForeColor = SystemColors.ActiveCaptionText;
            LbId3.Location = new Point(17, 111);
            LbId3.Name = "LbId3";
            LbId3.Size = new Size(95, 17);
            LbId3.TabIndex = 1;
            LbId3.Text = "ID : BRG003";
            // 
            // PcxBarang3
            // 
            PcxBarang3.BackgroundImage = (Image)resources.GetObject("PcxBarang3.BackgroundImage");
            PcxBarang3.BackgroundImageLayout = ImageLayout.Stretch;
            PcxBarang3.Location = new Point(34, 9);
            PcxBarang3.Margin = new Padding(3, 4, 3, 4);
            PcxBarang3.Name = "PcxBarang3";
            PcxBarang3.Size = new Size(135, 89);
            PcxBarang3.SizeMode = PictureBoxSizeMode.Zoom;
            PcxBarang3.TabIndex = 0;
            PcxBarang3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(BtnTambah4);
            panel2.Controls.Add(LbHarga4);
            panel2.Controls.Add(LbStok);
            panel2.Controls.Add(LbNamaBarang4);
            panel2.Controls.Add(LbId4);
            panel2.Controls.Add(PcxBarang4);
            panel2.Location = new Point(627, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(202, 250);
            panel2.TabIndex = 3;
            // 
            // BtnTambah4
            // 
            BtnTambah4.BackColor = Color.ForestGreen;
            BtnTambah4.FlatStyle = FlatStyle.Flat;
            BtnTambah4.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnTambah4.ForeColor = Color.White;
            BtnTambah4.Location = new Point(45, 209);
            BtnTambah4.Margin = new Padding(3, 4, 3, 4);
            BtnTambah4.Name = "BtnTambah4";
            BtnTambah4.Size = new Size(112, 31);
            BtnTambah4.TabIndex = 4;
            BtnTambah4.Text = "Tambah";
            BtnTambah4.UseVisualStyleBackColor = false;
            // 
            // LbHarga4
            // 
            LbHarga4.AutoSize = true;
            LbHarga4.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbHarga4.Location = new Point(17, 185);
            LbHarga4.Name = "LbHarga4";
            LbHarga4.Size = new Size(83, 17);
            LbHarga4.TabIndex = 3;
            LbHarga4.Text = "Rp 250.000";
            // 
            // LbStok
            // 
            LbStok.AutoSize = true;
            LbStok.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbStok.ForeColor = SystemColors.ActiveCaptionText;
            LbStok.Location = new Point(17, 160);
            LbStok.Name = "LbStok";
            LbStok.Size = new Size(67, 17);
            LbStok.TabIndex = 2;
            LbStok.Text = "Stok : 20";
            // 
            // LbNamaBarang4
            // 
            LbNamaBarang4.AutoSize = true;
            LbNamaBarang4.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbNamaBarang4.Location = new Point(17, 135);
            LbNamaBarang4.Name = "LbNamaBarang4";
            LbNamaBarang4.Size = new Size(123, 17);
            LbNamaBarang4.TabIndex = 1;
            LbNamaBarang4.Text = "Selang Pompa Air";
            // 
            // LbId4
            // 
            LbId4.AutoSize = true;
            LbId4.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbId4.ForeColor = SystemColors.ActiveCaptionText;
            LbId4.Location = new Point(17, 111);
            LbId4.Name = "LbId4";
            LbId4.Size = new Size(95, 17);
            LbId4.TabIndex = 1;
            LbId4.Text = "ID : BRG004";
            // 
            // PcxBarang4
            // 
            PcxBarang4.BackgroundImage = (Image)resources.GetObject("PcxBarang4.BackgroundImage");
            PcxBarang4.BackgroundImageLayout = ImageLayout.Zoom;
            PcxBarang4.Location = new Point(34, 9);
            PcxBarang4.Margin = new Padding(3, 4, 3, 4);
            PcxBarang4.Name = "PcxBarang4";
            PcxBarang4.Size = new Size(135, 89);
            PcxBarang4.SizeMode = PictureBoxSizeMode.Zoom;
            PcxBarang4.TabIndex = 0;
            PcxBarang4.TabStop = false;
            // 
            // GbKeranjangBelanja
            // 
            GbKeranjangBelanja.Controls.Add(DgvKeranjang);
            GbKeranjangBelanja.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GbKeranjangBelanja.ForeColor = Color.ForestGreen;
            GbKeranjangBelanja.Location = new Point(31, 449);
            GbKeranjangBelanja.Name = "GbKeranjangBelanja";
            GbKeranjangBelanja.Size = new Size(863, 181);
            GbKeranjangBelanja.TabIndex = 3;
            GbKeranjangBelanja.TabStop = false;
            GbKeranjangBelanja.Text = "Keranjang Belanja";
            // 
            // DgvKeranjang
            // 
            DgvKeranjang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvKeranjang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvKeranjang.Columns.AddRange(new DataGridViewColumn[] { ColNo, ColIDBarang, ColNamaBarang, ColHarga, ColQty, ColSubTotal });
            DgvKeranjang.Location = new Point(10, 23);
            DgvKeranjang.Name = "DgvKeranjang";
            DgvKeranjang.ReadOnly = true;
            DgvKeranjang.RowHeadersWidth = 51;
            DgvKeranjang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvKeranjang.Size = new Size(842, 148);
            DgvKeranjang.TabIndex = 0;
            // 
            // ColSubTotal
            // 
            ColSubTotal.HeaderText = "SubTotal";
            ColSubTotal.MinimumWidth = 6;
            ColSubTotal.Name = "ColSubTotal";
            ColSubTotal.ReadOnly = true;
            // 
            // ColQty
            // 
            ColQty.HeaderText = "Qty";
            ColQty.MinimumWidth = 6;
            ColQty.Name = "ColQty";
            ColQty.ReadOnly = true;
            // 
            // ColHarga
            // 
            ColHarga.HeaderText = "Harga";
            ColHarga.MinimumWidth = 6;
            ColHarga.Name = "ColHarga";
            ColHarga.ReadOnly = true;
            // 
            // ColNamaBarang
            // 
            ColNamaBarang.HeaderText = "Nama Barang";
            ColNamaBarang.MinimumWidth = 6;
            ColNamaBarang.Name = "ColNamaBarang";
            ColNamaBarang.ReadOnly = true;
            // 
            // ColIDBarang
            // 
            ColIDBarang.HeaderText = "ID Barang";
            ColIDBarang.MinimumWidth = 6;
            ColIDBarang.Name = "ColIDBarang";
            ColIDBarang.ReadOnly = true;
            // 
            // ColNo
            // 
            ColNo.HeaderText = "No";
            ColNo.MinimumWidth = 6;
            ColNo.Name = "ColNo";
            ColNo.ReadOnly = true;
            // 
            // PanelTotalBayar
            // 
            PanelTotalBayar.Controls.Add(BtnBersihTransaksi);
            PanelTotalBayar.Controls.Add(BtnSimpanTransaksiPenjualan);
            PanelTotalBayar.Controls.Add(LblTotalBayar);
            PanelTotalBayar.Controls.Add(LbTotalBayar);
            PanelTotalBayar.Location = new Point(30, 634);
            PanelTotalBayar.Name = "PanelTotalBayar";
            PanelTotalBayar.Size = new Size(945, 60);
            PanelTotalBayar.TabIndex = 4;
            // 
            // LbTotalBayar
            // 
            LbTotalBayar.AutoSize = true;
            LbTotalBayar.Location = new Point(29, 22);
            LbTotalBayar.Name = "LbTotalBayar";
            LbTotalBayar.Size = new Size(100, 20);
            LbTotalBayar.TabIndex = 0;
            LbTotalBayar.Text = "Total Bayar  :";
            // 
            // LblTotalBayar
            // 
            LblTotalBayar.AutoSize = true;
            LblTotalBayar.ForeColor = Color.ForestGreen;
            LblTotalBayar.Location = new Point(135, 23);
            LblTotalBayar.Name = "LblTotalBayar";
            LblTotalBayar.Size = new Size(41, 20);
            LblTotalBayar.TabIndex = 1;
            LblTotalBayar.Text = "Rp 0";
            // 
            // BtnSimpanTransaksiPenjualan
            // 
            BtnSimpanTransaksiPenjualan.BackColor = Color.ForestGreen;
            BtnSimpanTransaksiPenjualan.FlatStyle = FlatStyle.Flat;
            BtnSimpanTransaksiPenjualan.ForeColor = Color.White;
            BtnSimpanTransaksiPenjualan.Location = new Point(561, 6);
            BtnSimpanTransaksiPenjualan.Name = "BtnSimpanTransaksiPenjualan";
            BtnSimpanTransaksiPenjualan.Size = new Size(180, 50);
            BtnSimpanTransaksiPenjualan.TabIndex = 2;
            BtnSimpanTransaksiPenjualan.Text = "Simpan";
            BtnSimpanTransaksiPenjualan.UseVisualStyleBackColor = false;
            // 
            // BtnBersihTransaksi
            // 
            BtnBersihTransaksi.BackColor = Color.Red;
            BtnBersihTransaksi.FlatStyle = FlatStyle.Flat;
            BtnBersihTransaksi.ForeColor = Color.White;
            BtnBersihTransaksi.Location = new Point(759, 6);
            BtnBersihTransaksi.Name = "BtnBersihTransaksi";
            BtnBersihTransaksi.Size = new Size(180, 50);
            BtnBersihTransaksi.TabIndex = 3;
            BtnBersihTransaksi.Text = "Bersih";
            BtnBersihTransaksi.UseVisualStyleBackColor = false;
            // 
            // UcTransaksiPenjualan
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelTotalBayar);
            Controls.Add(GbKeranjangBelanja);
            Controls.Add(gbKatalog);
            Controls.Add(PanelCariIdTransaksiPenjualan);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UcTransaksiPenjualan";
            Size = new Size(1159, 697);
            Load += UcTransaksiPenjualan_Load;
            PanelCariIdTransaksiPenjualan.ResumeLayout(false);
            PanelCariIdTransaksiPenjualan.PerformLayout();
            gbKatalog.ResumeLayout(false);
            FlpkatalogProduk.ResumeLayout(false);
            PanelBarang1.ResumeLayout(false);
            PanelBarang1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PcxBarang1).EndInit();
            PanelBarang2.ResumeLayout(false);
            PanelBarang2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PcxBarang2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PcxBarang3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PcxBarang4).EndInit();
            GbKeranjangBelanja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvKeranjang).EndInit();
            PanelTotalBayar.ResumeLayout(false);
            PanelTotalBayar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel PanelCariIdTransaksiPenjualan;
        private Label LbCariIdBarangTransaksiPenjualan;
        private Button BtnCari;
        private TextBox TxtCariBarang;
        private GroupBox gbKatalog;
        private FlowLayoutPanel FlpkatalogProduk;
        private Panel PanelBarang1;
        private PictureBox PcxBarang1;
        private Label LbID1;
        private Label LbNamaBarang1;
        private Label LbHarga1;
        private Label LbStok1;
        private Button BtnTambah1;
        private Panel PanelBarang2;
        private Button BtnTambah2;
        private Label LbHarga2;
        private Label LbStok2;
        private Label LbNamaBarang2;
        private Label LbId2;
        private PictureBox PcxBarang2;
        private Panel panel1;
        private Button BtnTambah3;
        private Label LbHarga3;
        private Label LbStok3;
        private Label LbNamaBarang3;
        private Label LbId3;
        private PictureBox PcxBarang3;
        private Panel panel2;
        private Button BtnTambah4;
        private Label LbHarga4;
        private Label LbStok;
        private Label LbNamaBarang4;
        private Label LbId4;
        private PictureBox PcxBarang4;
        private GroupBox GbKeranjangBelanja;
        private DataGridView DgvKeranjang;
        private DataGridViewTextBoxColumn ColNo;
        private DataGridViewTextBoxColumn ColIDBarang;
        private DataGridViewTextBoxColumn ColNamaBarang;
        private DataGridViewTextBoxColumn ColHarga;
        private DataGridViewTextBoxColumn ColQty;
        private DataGridViewTextBoxColumn ColSubTotal;
        private Panel PanelTotalBayar;
        private Label LbTotalBayar;
        private Label LblTotalBayar;
        private Button BtnBersihTransaksi;
        private Button BtnSimpanTransaksiPenjualan;
    }
}
