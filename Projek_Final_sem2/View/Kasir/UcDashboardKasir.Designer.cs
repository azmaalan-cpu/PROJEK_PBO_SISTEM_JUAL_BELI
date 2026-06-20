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
            ColNoTransaksi = new DataGridViewTextBoxColumn();
            ColTanggal = new DataGridViewTextBoxColumn();
            ColTotal = new DataGridViewTextBoxColumn();
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
            LbDashboard.Location = new Point(25, 25);
            LbDashboard.Margin = new Padding(4, 0, 4, 0);
            LbDashboard.Name = "LbDashboard";
            LbDashboard.Size = new Size(138, 32);
            LbDashboard.TabIndex = 0;
            LbDashboard.Text = "Dashboard";
            // 
            // LbSelamatDatang
            // 
            LbSelamatDatang.AutoSize = true;
            LbSelamatDatang.Location = new Point(25, 71);
            LbSelamatDatang.Margin = new Padding(4, 0, 4, 0);
            LbSelamatDatang.Name = "LbSelamatDatang";
            LbSelamatDatang.Size = new Size(184, 25);
            LbSelamatDatang.TabIndex = 1;
            LbSelamatDatang.Text = "Selamat Datang, Kasir";
            // 
            // PanelBarang
            // 
            PanelBarang.BackColor = Color.DodgerBlue;
            PanelBarang.Controls.Add(LabelTotalBarang);
            PanelBarang.Controls.Add(LbDataBarang);
            PanelBarang.Location = new Point(25, 119);
            PanelBarang.Margin = new Padding(4);
            PanelBarang.Name = "PanelBarang";
            PanelBarang.Size = new Size(329, 156);
            PanelBarang.TabIndex = 2;
            // 
            // LabelTotalBarang
            // 
            LabelTotalBarang.AutoSize = true;
            LabelTotalBarang.ForeColor = Color.White;
            LabelTotalBarang.Location = new Point(25, 108);
            LabelTotalBarang.Margin = new Padding(4, 0, 4, 0);
            LabelTotalBarang.Name = "LabelTotalBarang";
            LabelTotalBarang.Size = new Size(109, 25);
            LabelTotalBarang.TabIndex = 1;
            LabelTotalBarang.Text = "Total Barang";
            // 
            // LbDataBarang
            // 
            LbDataBarang.AutoSize = true;
            LbDataBarang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbDataBarang.ForeColor = Color.White;
            LbDataBarang.Location = new Point(22, 16);
            LbDataBarang.Margin = new Padding(4, 0, 4, 0);
            LbDataBarang.Name = "LbDataBarang";
            LbDataBarang.Size = new Size(123, 25);
            LbDataBarang.TabIndex = 0;
            LbDataBarang.Text = "Data Barang ";
            // 
            // PanelPenjualan
            // 
            PanelPenjualan.BackColor = Color.ForestGreen;
            PanelPenjualan.Controls.Add(LabelTotalTransaksi);
            PanelPenjualan.Controls.Add(LbPenjualan);
            PanelPenjualan.Location = new Point(361, 119);
            PanelPenjualan.Margin = new Padding(4);
            PanelPenjualan.Name = "PanelPenjualan";
            PanelPenjualan.Size = new Size(344, 156);
            PanelPenjualan.TabIndex = 4;
            // 
            // LabelTotalTransaksi
            // 
            LabelTotalTransaksi.AutoSize = true;
            LabelTotalTransaksi.ForeColor = Color.White;
            LabelTotalTransaksi.Location = new Point(52, 108);
            LabelTotalTransaksi.Margin = new Padding(4, 0, 4, 0);
            LabelTotalTransaksi.Name = "LabelTotalTransaksi";
            LabelTotalTransaksi.Size = new Size(124, 25);
            LabelTotalTransaksi.TabIndex = 2;
            LabelTotalTransaksi.Text = "Total Transaksi";
            // 
            // LbPenjualan
            // 
            LbPenjualan.AutoSize = true;
            LbPenjualan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbPenjualan.ForeColor = Color.White;
            LbPenjualan.Location = new Point(48, 20);
            LbPenjualan.Margin = new Padding(4, 0, 4, 0);
            LbPenjualan.Name = "LbPenjualan";
            LbPenjualan.Size = new Size(95, 25);
            LbPenjualan.TabIndex = 0;
            LbPenjualan.Text = "Penjualan";
            // 
            // PanelPendapatan
            // 
            PanelPendapatan.BackColor = Color.DarkOrange;
            PanelPendapatan.Controls.Add(LabelTotalPendapatan);
            PanelPendapatan.Controls.Add(LbPendapatan);
            PanelPendapatan.Location = new Point(712, 119);
            PanelPendapatan.Margin = new Padding(4);
            PanelPendapatan.Name = "PanelPendapatan";
            PanelPendapatan.Size = new Size(356, 156);
            PanelPendapatan.TabIndex = 5;
            // 
            // LabelTotalPendapatan
            // 
            LabelTotalPendapatan.AutoSize = true;
            LabelTotalPendapatan.ForeColor = Color.White;
            LabelTotalPendapatan.Location = new Point(22, 108);
            LabelTotalPendapatan.Margin = new Padding(4, 0, 4, 0);
            LabelTotalPendapatan.Name = "LabelTotalPendapatan";
            LabelTotalPendapatan.Size = new Size(147, 25);
            LabelTotalPendapatan.TabIndex = 3;
            LabelTotalPendapatan.Text = "Total Pendapatan";
            // 
            // LbPendapatan
            // 
            LbPendapatan.AutoSize = true;
            LbPendapatan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbPendapatan.ForeColor = Color.White;
            LbPendapatan.Location = new Point(22, 20);
            LbPendapatan.Margin = new Padding(4, 0, 4, 0);
            LbPendapatan.Name = "LbPendapatan";
            LbPendapatan.Size = new Size(165, 25);
            LbPendapatan.TabIndex = 0;
            LbPendapatan.Text = "Total Pendapatan ";
            // 
            // PanelDataGridView
            // 
            PanelDataGridView.Controls.Add(DgvTransaksi);
            PanelDataGridView.Controls.Add(LbTransaksiPenjualan);
            PanelDataGridView.Location = new Point(25, 324);
            PanelDataGridView.Margin = new Padding(4);
            PanelDataGridView.Name = "PanelDataGridView";
            PanelDataGridView.Size = new Size(634, 336);
            PanelDataGridView.TabIndex = 6;
            // 
            // DgvTransaksi
            // 
            DgvTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvTransaksi.Columns.AddRange(new DataGridViewColumn[] { ColNoTransaksi, ColTanggal, ColTotal });
            DgvTransaksi.Location = new Point(4, 45);
            DgvTransaksi.Margin = new Padding(4);
            DgvTransaksi.Name = "DgvTransaksi";
            DgvTransaksi.RowHeadersWidth = 51;
            DgvTransaksi.Size = new Size(630, 288);
            DgvTransaksi.TabIndex = 1;
            DgvTransaksi.CellClick += DgvTransaksi_CellClick;
            DgvTransaksi.CellContentClick += DgvTransaksi_CellContentClick;
            // 
            // LbTransaksiPenjualan
            // 
            LbTransaksiPenjualan.AutoSize = true;
            LbTransaksiPenjualan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbTransaksiPenjualan.Location = new Point(9, 10);
            LbTransaksiPenjualan.Margin = new Padding(4, 0, 4, 0);
            LbTransaksiPenjualan.Name = "LbTransaksiPenjualan";
            LbTransaksiPenjualan.Size = new Size(179, 25);
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
            PanelInfo.Location = new Point(666, 324);
            PanelInfo.Margin = new Padding(4);
            PanelInfo.Name = "PanelInfo";
            PanelInfo.Size = new Size(569, 336);
            PanelInfo.TabIndex = 7;
            // 
            // LbJumlahBarang
            // 
            LbJumlahBarang.AutoSize = true;
            LbJumlahBarang.Location = new Point(202, 194);
            LbJumlahBarang.Margin = new Padding(4, 0, 4, 0);
            LbJumlahBarang.Name = "LbJumlahBarang";
            LbJumlahBarang.Size = new Size(132, 25);
            LbJumlahBarang.TabIndex = 10;
            LbJumlahBarang.Text = "Jumlah Barang ";
            // 
            // LbPendapatanDashboard
            // 
            LbPendapatanDashboard.AutoSize = true;
            LbPendapatanDashboard.Location = new Point(176, 132);
            LbPendapatanDashboard.Margin = new Padding(4, 0, 4, 0);
            LbPendapatanDashboard.Name = "LbPendapatanDashboard";
            LbPendapatanDashboard.Size = new Size(107, 25);
            LbPendapatanDashboard.TabIndex = 9;
            LbPendapatanDashboard.Text = "pendapatan";
            // 
            // LbIdTransaksi
            // 
            LbIdTransaksi.AutoSize = true;
            LbIdTransaksi.Location = new Point(175, 74);
            LbIdTransaksi.Margin = new Padding(4, 0, 4, 0);
            LbIdTransaksi.Name = "LbIdTransaksi";
            LbIdTransaksi.Size = new Size(103, 25);
            LbIdTransaksi.TabIndex = 8;
            LbIdTransaksi.Text = "Id Transaksi";
            // 
            // LabelJumlahBarang
            // 
            LabelJumlahBarang.AutoSize = true;
            LabelJumlahBarang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelJumlahBarang.Location = new Point(28, 194);
            LabelJumlahBarang.Margin = new Padding(4, 0, 4, 0);
            LabelJumlahBarang.Name = "LabelJumlahBarang";
            LabelJumlahBarang.Size = new Size(164, 25);
            LabelJumlahBarang.TabIndex = 4;
            LabelJumlahBarang.Text = "Jumlah Barang    :";
            // 
            // LabelPendapatan
            // 
            LabelPendapatan.AutoSize = true;
            LabelPendapatan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelPendapatan.Location = new Point(28, 132);
            LabelPendapatan.Margin = new Padding(4, 0, 4, 0);
            LabelPendapatan.Name = "LabelPendapatan";
            LabelPendapatan.Size = new Size(128, 25);
            LabelPendapatan.TabIndex = 3;
            LabelPendapatan.Text = "Pendapatan  :";
            // 
            // LabelIdTransaksi
            // 
            LabelIdTransaksi.AutoSize = true;
            LabelIdTransaksi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelIdTransaksi.Location = new Point(28, 74);
            LabelIdTransaksi.Margin = new Padding(4, 0, 4, 0);
            LabelIdTransaksi.Name = "LabelIdTransaksi";
            LabelIdTransaksi.Size = new Size(133, 25);
            LabelIdTransaksi.TabIndex = 2;
            LabelIdTransaksi.Text = "Id Transaksi   :";
            // 
            // PcxKeranjang
            // 
            PcxKeranjang.BackgroundImage = (Image)resources.GetObject("PcxKeranjang.BackgroundImage");
            PcxKeranjang.BackgroundImageLayout = ImageLayout.Zoom;
            PcxKeranjang.Location = new Point(395, 162);
            PcxKeranjang.Margin = new Padding(4);
            PcxKeranjang.Name = "PcxKeranjang";
            PcxKeranjang.Size = new Size(156, 150);
            PcxKeranjang.SizeMode = PictureBoxSizeMode.Zoom;
            PcxKeranjang.TabIndex = 1;
            PcxKeranjang.TabStop = false;
            // 
            // LbInformasi
            // 
            LbInformasi.AutoSize = true;
            LbInformasi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbInformasi.Location = new Point(20, 19);
            LbInformasi.Margin = new Padding(4, 0, 4, 0);
            LbInformasi.Name = "LbInformasi";
            LbInformasi.Size = new Size(98, 25);
            LbInformasi.TabIndex = 0;
            LbInformasi.Text = "Informasi ";
            // 
            // ColNoTransaksi
            // 
            ColNoTransaksi.DataPropertyName = "id_transaksi";
            ColNoTransaksi.HeaderText = "No Transaksi";
            ColNoTransaksi.MinimumWidth = 6;
            ColNoTransaksi.Name = "ColNoTransaksi";
            ColNoTransaksi.Width = 150;
            // 
            // ColTanggal
            // 
            ColTanggal.DataPropertyName = "tanggal";
            ColTanggal.HeaderText = "Tanggal";
            ColTanggal.MinimumWidth = 6;
            ColTanggal.Name = "ColTanggal";
            ColTanggal.Width = 120;
            // 
            // ColTotal
            // 
            ColTotal.DataPropertyName = "total";
            ColTotal.HeaderText = "Total";
            ColTotal.MinimumWidth = 6;
            ColTotal.Name = "ColTotal";
            ColTotal.Width = 120;
            // 
            // UcDashboardKasir
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelInfo);
            Controls.Add(PanelDataGridView);
            Controls.Add(PanelPendapatan);
            Controls.Add(PanelPenjualan);
            Controls.Add(PanelBarang);
            Controls.Add(LbSelamatDatang);
            Controls.Add(LbDashboard);
            Margin = new Padding(4);
            Name = "UcDashboardKasir";
            Size = new Size(1275, 724);
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
        private DataGridViewTextBoxColumn ColNoTransaksi;
        private DataGridViewTextBoxColumn ColTanggal;
        private DataGridViewTextBoxColumn ColTotal;
    }
}
