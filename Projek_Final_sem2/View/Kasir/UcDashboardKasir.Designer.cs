namespace Projek_Final_sem2.UserControls.Kasir
{
    partial class UcDashboardKasir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcDashboardKasir));
            LbDashboard = new Label();
            LbSelamatDatang = new Label();
            PanelBarang = new Panel();
            LabelTotalBarang = new Label();
            LbDataBarang = new Label();
            PanelPenjualan = new Panel();
            LabelTotalTransaksi = new Label();
            LbPenjualan = new Label();
            PanelPendapatan = new Panel();
            LabelTotalPendapatan = new Label();
            LbPendapatan = new Label();
            PanelDataGridView = new Panel();
            DgvTransaksi = new DataGridView();
            ColNo = new DataGridViewTextBoxColumn();
            ColTanggal = new DataGridViewTextBoxColumn();
            ColNoTransaksi = new DataGridViewTextBoxColumn();
            ColTotal = new DataGridViewTextBoxColumn();
            LbTransaksiPenjualan = new Label();
            PanelInfo = new Panel();
            LbJumlahBarang = new Label();
            LbPendapatanDashboard = new Label();
            LbIdTransaksi = new Label();
            LabelJumlahBarang = new Label();
            LabelPendapatan = new Label();
            LabelIdTransaksi = new Label();
            PcxKeranjang = new PictureBox();
            LbInformasi = new Label();
            PanelBarang.SuspendLayout();
            PanelPenjualan.SuspendLayout();
            PanelPendapatan.SuspendLayout();
            PanelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvTransaksi).BeginInit();
            PanelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PcxKeranjang).BeginInit();
            SuspendLayout();
            // 
            // LbDashboard
            // 
            LbDashboard.AutoSize = true;
            LbDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbDashboard.Location = new Point(20, 20);
            LbDashboard.Name = "LbDashboard";
            LbDashboard.Size = new Size(114, 28);
            LbDashboard.TabIndex = 0;
            LbDashboard.Text = "Dashboard";
            // 
            // LbSelamatDatang
            // 
            LbSelamatDatang.AutoSize = true;
            LbSelamatDatang.Location = new Point(20, 57);
            LbSelamatDatang.Name = "LbSelamatDatang";
            LbSelamatDatang.Size = new Size(155, 20);
            LbSelamatDatang.TabIndex = 1;
            LbSelamatDatang.Text = "Selamat Datang, Kasir";
            // 
            // PanelBarang
            // 
            PanelBarang.BackColor = Color.DodgerBlue;
            PanelBarang.Controls.Add(LabelTotalBarang);
            PanelBarang.Controls.Add(LbDataBarang);
            PanelBarang.Location = new Point(20, 95);
            PanelBarang.Name = "PanelBarang";
            PanelBarang.Size = new Size(263, 125);
            PanelBarang.TabIndex = 2;
            // 
            // LabelTotalBarang
            // 
            LabelTotalBarang.AutoSize = true;
            LabelTotalBarang.ForeColor = Color.White;
            LabelTotalBarang.Location = new Point(20, 86);
            LabelTotalBarang.Name = "LabelTotalBarang";
            LabelTotalBarang.Size = new Size(93, 20);
            LabelTotalBarang.TabIndex = 1;
            LabelTotalBarang.Text = "Total Barang";
            // 
            // LbDataBarang
            // 
            LbDataBarang.AutoSize = true;
            LbDataBarang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbDataBarang.ForeColor = Color.White;
            LbDataBarang.Location = new Point(18, 13);
            LbDataBarang.Name = "LbDataBarang";
            LbDataBarang.Size = new Size(100, 20);
            LbDataBarang.TabIndex = 0;
            LbDataBarang.Text = "Data Barang ";
            // 
            // PanelPenjualan
            // 
            PanelPenjualan.BackColor = Color.ForestGreen;
            PanelPenjualan.Controls.Add(LabelTotalTransaksi);
            PanelPenjualan.Controls.Add(LbPenjualan);
            PanelPenjualan.Location = new Point(289, 95);
            PanelPenjualan.Name = "PanelPenjualan";
            PanelPenjualan.Size = new Size(275, 125);
            PanelPenjualan.TabIndex = 4;
            // 
            // LabelTotalTransaksi
            // 
            LabelTotalTransaksi.AutoSize = true;
            LabelTotalTransaksi.ForeColor = Color.White;
            LabelTotalTransaksi.Location = new Point(42, 86);
            LabelTotalTransaksi.Name = "LabelTotalTransaksi";
            LabelTotalTransaksi.Size = new Size(105, 20);
            LabelTotalTransaksi.TabIndex = 2;
            LabelTotalTransaksi.Text = "Total Transaksi";
            // 
            // LbPenjualan
            // 
            LbPenjualan.AutoSize = true;
            LbPenjualan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbPenjualan.ForeColor = Color.White;
            LbPenjualan.Location = new Point(38, 16);
            LbPenjualan.Name = "LbPenjualan";
            LbPenjualan.Size = new Size(77, 20);
            LbPenjualan.TabIndex = 0;
            LbPenjualan.Text = "Penjualan";
            // 
            // PanelPendapatan
            // 
            PanelPendapatan.BackColor = Color.DarkOrange;
            PanelPendapatan.Controls.Add(LabelTotalPendapatan);
            PanelPendapatan.Controls.Add(LbPendapatan);
            PanelPendapatan.Location = new Point(570, 95);
            PanelPendapatan.Name = "PanelPendapatan";
            PanelPendapatan.Size = new Size(285, 125);
            PanelPendapatan.TabIndex = 5;
            // 
            // LabelTotalPendapatan
            // 
            LabelTotalPendapatan.AutoSize = true;
            LabelTotalPendapatan.ForeColor = Color.White;
            LabelTotalPendapatan.Location = new Point(18, 86);
            LabelTotalPendapatan.Name = "LabelTotalPendapatan";
            LabelTotalPendapatan.Size = new Size(124, 20);
            LabelTotalPendapatan.TabIndex = 3;
            LabelTotalPendapatan.Text = "Total Pendapatan";
            // 
            // LbPendapatan
            // 
            LbPendapatan.AutoSize = true;
            LbPendapatan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbPendapatan.ForeColor = Color.White;
            LbPendapatan.Location = new Point(18, 16);
            LbPendapatan.Name = "LbPendapatan";
            LbPendapatan.Size = new Size(135, 20);
            LbPendapatan.TabIndex = 0;
            LbPendapatan.Text = "Total Pendapatan ";
            // 
            // PanelDataGridView
            // 
            PanelDataGridView.Controls.Add(DgvTransaksi);
            PanelDataGridView.Controls.Add(LbTransaksiPenjualan);
            PanelDataGridView.Location = new Point(20, 259);
            PanelDataGridView.Name = "PanelDataGridView";
            PanelDataGridView.Size = new Size(507, 269);
            PanelDataGridView.TabIndex = 6;
            // 
            // DgvTransaksi
            // 
            DgvTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvTransaksi.Columns.AddRange(new DataGridViewColumn[] { ColNo, ColTanggal, ColNoTransaksi, ColTotal });
            DgvTransaksi.Location = new Point(3, 36);
            DgvTransaksi.Name = "DgvTransaksi";
            DgvTransaksi.RowHeadersWidth = 51;
            DgvTransaksi.Size = new Size(504, 230);
            DgvTransaksi.TabIndex = 1;
            DgvTransaksi.CellClick += DgvTransaksi_CellClick;
            // 
            // ColNo
            // 
            ColNo.HeaderText = "No";
            ColNo.MinimumWidth = 6;
            ColNo.Name = "ColNo";
            ColNo.Width = 50;
            // 
            // ColTanggal
            // 
            ColTanggal.DataPropertyName = "tanggal";
            ColTanggal.HeaderText = "Tanggal";
            ColTanggal.MinimumWidth = 6;
            ColTanggal.Name = "ColTanggal";
            ColTanggal.Width = 120;
            // 
            // ColNoTransaksi
            // 
            ColNoTransaksi.DataPropertyName = "id_transaksi";
            ColNoTransaksi.HeaderText = "No Transaksi";
            ColNoTransaksi.MinimumWidth = 6;
            ColNoTransaksi.Name = "ColNoTransaksi";
            ColNoTransaksi.Width = 150;
            // 
            // ColTotal
            // 
            ColTotal.DataPropertyName = "total";
            ColTotal.HeaderText = "Total";
            ColTotal.MinimumWidth = 6;
            ColTotal.Name = "ColTotal";
            ColTotal.Width = 120;
            // 
            // LbTransaksiPenjualan
            // 
            LbTransaksiPenjualan.AutoSize = true;
            LbTransaksiPenjualan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbTransaksiPenjualan.Location = new Point(7, 8);
            LbTransaksiPenjualan.Name = "LbTransaksiPenjualan";
            LbTransaksiPenjualan.Size = new Size(146, 20);
            LbTransaksiPenjualan.TabIndex = 0;
            LbTransaksiPenjualan.Text = "Transaksi Penjualan";
            // 
            // PanelInfo
            // 
            PanelInfo.Controls.Add(LbJumlahBarang);
            PanelInfo.Controls.Add(LbPendapatanDashboard);
            PanelInfo.Controls.Add(LbIdTransaksi);
            PanelInfo.Controls.Add(LabelJumlahBarang);
            PanelInfo.Controls.Add(LabelPendapatan);
            PanelInfo.Controls.Add(LabelIdTransaksi);
            PanelInfo.Controls.Add(PcxKeranjang);
            PanelInfo.Controls.Add(LbInformasi);
            PanelInfo.Location = new Point(533, 259);
            PanelInfo.Name = "PanelInfo";
            PanelInfo.Size = new Size(455, 269);
            PanelInfo.TabIndex = 7;
            // 
            // LbJumlahBarang
            // 
            LbJumlahBarang.AutoSize = true;
            LbJumlahBarang.Location = new Point(162, 155);
            LbJumlahBarang.Name = "LbJumlahBarang";
            LbJumlahBarang.Size = new Size(110, 20);
            LbJumlahBarang.TabIndex = 10;
            LbJumlahBarang.Text = "Jumlah Barang ";
            // 
            // LbPendapatanDashboard
            // 
            LbPendapatanDashboard.AutoSize = true;
            LbPendapatanDashboard.Location = new Point(141, 106);
            LbPendapatanDashboard.Name = "LbPendapatanDashboard";
            LbPendapatanDashboard.Size = new Size(89, 20);
            LbPendapatanDashboard.TabIndex = 9;
            LbPendapatanDashboard.Text = "pendapatan";
            // 
            // LbIdTransaksi
            // 
            LbIdTransaksi.AutoSize = true;
            LbIdTransaksi.Location = new Point(140, 59);
            LbIdTransaksi.Name = "LbIdTransaksi";
            LbIdTransaksi.Size = new Size(85, 20);
            LbIdTransaksi.TabIndex = 8;
            LbIdTransaksi.Text = "Id Transaksi";
            // 
            // LabelJumlahBarang
            // 
            LabelJumlahBarang.AutoSize = true;
            LabelJumlahBarang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelJumlahBarang.Location = new Point(22, 155);
            LabelJumlahBarang.Name = "LabelJumlahBarang";
            LabelJumlahBarang.Size = new Size(134, 20);
            LabelJumlahBarang.TabIndex = 4;
            LabelJumlahBarang.Text = "Jumlah Barang    :";
            // 
            // LabelPendapatan
            // 
            LabelPendapatan.AutoSize = true;
            LabelPendapatan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelPendapatan.Location = new Point(22, 106);
            LabelPendapatan.Name = "LabelPendapatan";
            LabelPendapatan.Size = new Size(104, 20);
            LabelPendapatan.TabIndex = 3;
            LabelPendapatan.Text = "Pendapatan  :";
            // 
            // LabelIdTransaksi
            // 
            LabelIdTransaksi.AutoSize = true;
            LabelIdTransaksi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelIdTransaksi.Location = new Point(22, 59);
            LabelIdTransaksi.Name = "LabelIdTransaksi";
            LabelIdTransaksi.Size = new Size(108, 20);
            LabelIdTransaksi.TabIndex = 2;
            LabelIdTransaksi.Text = "Id Transaksi   :";
            // 
            // PcxKeranjang
            // 
            PcxKeranjang.BackgroundImage = (Image)resources.GetObject("PcxKeranjang.BackgroundImage");
            PcxKeranjang.BackgroundImageLayout = ImageLayout.Zoom;
            PcxKeranjang.Location = new Point(316, 130);
            PcxKeranjang.Name = "PcxKeranjang";
            PcxKeranjang.Size = new Size(125, 120);
            PcxKeranjang.SizeMode = PictureBoxSizeMode.Zoom;
            PcxKeranjang.TabIndex = 1;
            PcxKeranjang.TabStop = false;
            // 
            // LbInformasi
            // 
            LbInformasi.AutoSize = true;
            LbInformasi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbInformasi.Location = new Point(16, 15);
            LbInformasi.Name = "LbInformasi";
            LbInformasi.Size = new Size(81, 20);
            LbInformasi.TabIndex = 0;
            LbInformasi.Text = "Informasi ";
            // 
            // UcDashboardKasir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelInfo);
            Controls.Add(PanelDataGridView);
            Controls.Add(PanelPendapatan);
            Controls.Add(PanelPenjualan);
            Controls.Add(PanelBarang);
            Controls.Add(LbSelamatDatang);
            Controls.Add(LbDashboard);
            Name = "UcDashboardKasir";
            Size = new Size(1020, 579);
            Load += UcDashboardKasir_Load;
            PanelBarang.ResumeLayout(false);
            PanelBarang.PerformLayout();
            PanelPenjualan.ResumeLayout(false);
            PanelPenjualan.PerformLayout();
            PanelPendapatan.ResumeLayout(false);
            PanelPendapatan.PerformLayout();
            PanelDataGridView.ResumeLayout(false);
            PanelDataGridView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvTransaksi).EndInit();
            PanelInfo.ResumeLayout(false);
            PanelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PcxKeranjang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbDashboard;
        private Label LbSelamatDatang;
        private Panel PanelBarang;
        private Label LbDataBarang;
        private Panel PanelPenjualan;
        private Label LbPenjualan;
        private Panel PanelPendapatan;
        private Label LbPendapatan;
        private Panel PanelDataGridView;
        private Label LbTransaksiPenjualan;
        private DataGridView DgvTransaksi;
        private Panel PanelInfo;
        private Label LbInformasi;
        private PictureBox PcxKeranjang;
        private Label LabelTotalBarang;
        private Label LabelTotalTransaksi;
        private Label LabelTotalPendapatan;
        private Label LabelIdTransaksi;
        private Label LabelJumlahBarang;
        private Label LabelPendapatan;
        private Label LbJumlahBarang;
        private Label LbPendapatanDashboard;
        private Label LbIdTransaksi;
        private DataGridViewTextBoxColumn ColNo;
        private DataGridViewTextBoxColumn ColTanggal;
        private DataGridViewTextBoxColumn ColNoTransaksi;
        private DataGridViewTextBoxColumn ColTotal;
    }
}
