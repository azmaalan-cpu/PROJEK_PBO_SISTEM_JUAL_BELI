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
            ColNoTransaksi = new DataGridViewTextBoxColumn();
            ColTanggal = new DataGridViewTextBoxColumn();
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
            LbDashboard.Location = new Point(18, 15);
            LbDashboard.Name = "LbDashboard";
            LbDashboard.Size = new Size(93, 21);
            LbDashboard.TabIndex = 0;
            LbDashboard.Text = "Dashboard";
            // 
            // LbSelamatDatang
            // 
            LbSelamatDatang.AutoSize = true;
            LbSelamatDatang.Location = new Point(18, 43);
            LbSelamatDatang.Name = "LbSelamatDatang";
            LbSelamatDatang.Size = new Size(121, 15);
            LbSelamatDatang.TabIndex = 1;
            LbSelamatDatang.Text = "Selamat Datang, Kasir";
            // 
            // PanelBarang
            // 
            PanelBarang.BackColor = Color.DodgerBlue;
            PanelBarang.Controls.Add(LabelTotalBarang);
            PanelBarang.Controls.Add(LbDataBarang);
            PanelBarang.Location = new Point(18, 71);
            PanelBarang.Margin = new Padding(3, 2, 3, 2);
            PanelBarang.Name = "PanelBarang";
            PanelBarang.Size = new Size(230, 94);
            PanelBarang.TabIndex = 2;
            // 
            // LabelTotalBarang
            // 
            LabelTotalBarang.AutoSize = true;
            LabelTotalBarang.ForeColor = Color.White;
            LabelTotalBarang.Location = new Point(18, 65);
            LabelTotalBarang.Name = "LabelTotalBarang";
            LabelTotalBarang.Size = new Size(73, 15);
            LabelTotalBarang.TabIndex = 1;
            LabelTotalBarang.Text = "Total Barang";
            // 
            // LbDataBarang
            // 
            LbDataBarang.AutoSize = true;
            LbDataBarang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbDataBarang.ForeColor = Color.White;
            LbDataBarang.Location = new Point(15, 10);
            LbDataBarang.Name = "LbDataBarang";
            LbDataBarang.Size = new Size(78, 15);
            LbDataBarang.TabIndex = 0;
            LbDataBarang.Text = "Data Barang ";
            // 
            // PanelPenjualan
            // 
            PanelPenjualan.BackColor = Color.ForestGreen;
            PanelPenjualan.Controls.Add(LabelTotalTransaksi);
            PanelPenjualan.Controls.Add(LbPenjualan);
            PanelPenjualan.Location = new Point(253, 71);
            PanelPenjualan.Margin = new Padding(3, 2, 3, 2);
            PanelPenjualan.Name = "PanelPenjualan";
            PanelPenjualan.Size = new Size(241, 94);
            PanelPenjualan.TabIndex = 4;
            // 
            // LabelTotalTransaksi
            // 
            LabelTotalTransaksi.AutoSize = true;
            LabelTotalTransaksi.ForeColor = Color.White;
            LabelTotalTransaksi.Location = new Point(36, 65);
            LabelTotalTransaksi.Name = "LabelTotalTransaksi";
            LabelTotalTransaksi.Size = new Size(84, 15);
            LabelTotalTransaksi.TabIndex = 2;
            LabelTotalTransaksi.Text = "Total Transaksi";
            // 
            // LbPenjualan
            // 
            LbPenjualan.AutoSize = true;
            LbPenjualan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbPenjualan.ForeColor = Color.White;
            LbPenjualan.Location = new Point(34, 12);
            LbPenjualan.Name = "LbPenjualan";
            LbPenjualan.Size = new Size(60, 15);
            LbPenjualan.TabIndex = 0;
            LbPenjualan.Text = "Penjualan";
            // 
            // PanelPendapatan
            // 
            PanelPendapatan.BackColor = Color.DarkOrange;
            PanelPendapatan.Controls.Add(LabelTotalPendapatan);
            PanelPendapatan.Controls.Add(LbPendapatan);
            PanelPendapatan.Location = new Point(498, 71);
            PanelPendapatan.Margin = new Padding(3, 2, 3, 2);
            PanelPendapatan.Name = "PanelPendapatan";
            PanelPendapatan.Size = new Size(249, 94);
            PanelPendapatan.TabIndex = 5;
            // 
            // LabelTotalPendapatan
            // 
            LabelTotalPendapatan.AutoSize = true;
            LabelTotalPendapatan.ForeColor = Color.White;
            LabelTotalPendapatan.Location = new Point(15, 65);
            LabelTotalPendapatan.Name = "LabelTotalPendapatan";
            LabelTotalPendapatan.Size = new Size(99, 15);
            LabelTotalPendapatan.TabIndex = 3;
            LabelTotalPendapatan.Text = "Total Pendapatan";
            // 
            // LbPendapatan
            // 
            LbPendapatan.AutoSize = true;
            LbPendapatan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbPendapatan.ForeColor = Color.White;
            LbPendapatan.Location = new Point(15, 12);
            LbPendapatan.Name = "LbPendapatan";
            LbPendapatan.Size = new Size(105, 15);
            LbPendapatan.TabIndex = 0;
            LbPendapatan.Text = "Total Pendapatan ";
            // 
            // PanelDataGridView
            // 
            PanelDataGridView.Controls.Add(DgvTransaksi);
            PanelDataGridView.Controls.Add(LbTransaksiPenjualan);
            PanelDataGridView.Location = new Point(18, 194);
            PanelDataGridView.Margin = new Padding(3, 2, 3, 2);
            PanelDataGridView.Name = "PanelDataGridView";
            PanelDataGridView.Size = new Size(444, 202);
            PanelDataGridView.TabIndex = 6;
            // 
            // DgvTransaksi
            // 
            DgvTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvTransaksi.Columns.AddRange(new DataGridViewColumn[] { ColNoTransaksi, ColTanggal, ColTotal });
            DgvTransaksi.Location = new Point(3, 27);
            DgvTransaksi.Margin = new Padding(3, 2, 3, 2);
            DgvTransaksi.Name = "DgvTransaksi";
            DgvTransaksi.RowHeadersWidth = 51;
            DgvTransaksi.Size = new Size(441, 173);
            DgvTransaksi.TabIndex = 1;
            DgvTransaksi.CellClick += DgvTransaksi_CellClick;
            DgvTransaksi.CellContentClick += DgvTransaksi_CellContentClick;
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
            // LbTransaksiPenjualan
            // 
            LbTransaksiPenjualan.AutoSize = true;
            LbTransaksiPenjualan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbTransaksiPenjualan.Location = new Point(6, 6);
            LbTransaksiPenjualan.Name = "LbTransaksiPenjualan";
            LbTransaksiPenjualan.Size = new Size(113, 15);
            LbTransaksiPenjualan.TabIndex = 0;
            LbTransaksiPenjualan.Text = "Transaksi Penjualan";
            // 
            // PanelInfo
            // 
            PanelInfo.Controls.Add(LbPendapatanDashboard);
            PanelInfo.Controls.Add(LbIdTransaksi);
            PanelInfo.Controls.Add(LabelPendapatan);
            PanelInfo.Controls.Add(LabelIdTransaksi);
            PanelInfo.Controls.Add(PcxKeranjang);
            PanelInfo.Controls.Add(LbInformasi);
            PanelInfo.Controls.Add(LbJumlahBarang);
            PanelInfo.Controls.Add(LabelJumlahBarang);
            PanelInfo.Location = new Point(466, 194);
            PanelInfo.Margin = new Padding(3, 2, 3, 2);
            PanelInfo.Name = "PanelInfo";
            PanelInfo.Size = new Size(398, 202);
            PanelInfo.TabIndex = 0;
            // 
            // LbJumlahBarang
            // 
            LbJumlahBarang.AutoSize = true;
            LbJumlahBarang.Location = new Point(141, 116);
            LbJumlahBarang.Name = "LbJumlahBarang";
            LbJumlahBarang.Size = new Size(88, 15);
            LbJumlahBarang.TabIndex = 1;
            LbJumlahBarang.Text = "Jumlah Barang ";
            // 
            // LbPendapatanDashboard
            // 
            LbPendapatanDashboard.AutoSize = true;
            LbPendapatanDashboard.Location = new Point(123, 79);
            LbPendapatanDashboard.Name = "LbPendapatanDashboard";
            LbPendapatanDashboard.Size = new Size(70, 15);
            LbPendapatanDashboard.TabIndex = 9;
            LbPendapatanDashboard.Text = "pendapatan";
            // 
            // LbIdTransaksi
            // 
            LbIdTransaksi.AutoSize = true;
            LbIdTransaksi.Location = new Point(122, 44);
            LbIdTransaksi.Name = "LbIdTransaksi";
            LbIdTransaksi.Size = new Size(68, 15);
            LbIdTransaksi.TabIndex = 8;
            LbIdTransaksi.Text = "Id Transaksi";
            // 
            // LabelJumlahBarang
            // 
            LabelJumlahBarang.AutoSize = true;
            LabelJumlahBarang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelJumlahBarang.Location = new Point(20, 116);
            LabelJumlahBarang.Name = "LabelJumlahBarang";
            LabelJumlahBarang.Size = new Size(103, 15);
            LabelJumlahBarang.TabIndex = 4;
            LabelJumlahBarang.Text = "Jumlah Barang    :";
            // 
            // LabelPendapatan
            // 
            LabelPendapatan.AutoSize = true;
            LabelPendapatan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelPendapatan.Location = new Point(20, 79);
            LabelPendapatan.Name = "LabelPendapatan";
            LabelPendapatan.Size = new Size(81, 15);
            LabelPendapatan.TabIndex = 3;
            LabelPendapatan.Text = "Pendapatan  :";
            // 
            // LabelIdTransaksi
            // 
            LabelIdTransaksi.AutoSize = true;
            LabelIdTransaksi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelIdTransaksi.Location = new Point(20, 44);
            LabelIdTransaksi.Name = "LabelIdTransaksi";
            LabelIdTransaksi.Size = new Size(83, 15);
            LabelIdTransaksi.TabIndex = 2;
            LabelIdTransaksi.Text = "Id Transaksi   :";
            // 
            // PcxKeranjang
            // 
            PcxKeranjang.BackgroundImage = (Image)resources.GetObject("PcxKeranjang.BackgroundImage");
            PcxKeranjang.BackgroundImageLayout = ImageLayout.Zoom;
            PcxKeranjang.Location = new Point(276, 97);
            PcxKeranjang.Margin = new Padding(3, 2, 3, 2);
            PcxKeranjang.Name = "PcxKeranjang";
            PcxKeranjang.Size = new Size(109, 90);
            PcxKeranjang.SizeMode = PictureBoxSizeMode.Zoom;
            PcxKeranjang.TabIndex = 1;
            PcxKeranjang.TabStop = false;
            // 
            // LbInformasi
            // 
            LbInformasi.AutoSize = true;
            LbInformasi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbInformasi.Location = new Point(14, 11);
            LbInformasi.Name = "LbInformasi";
            LbInformasi.Size = new Size(63, 15);
            LbInformasi.TabIndex = 0;
            LbInformasi.Text = "Informasi ";
            // 
            // UcDashboardKasir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelInfo);
            Controls.Add(PanelDataGridView);
            Controls.Add(PanelPendapatan);
            Controls.Add(PanelPenjualan);
            Controls.Add(PanelBarang);
            Controls.Add(LbSelamatDatang);
            Controls.Add(LbDashboard);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UcDashboardKasir";
            Size = new Size(892, 434);
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
