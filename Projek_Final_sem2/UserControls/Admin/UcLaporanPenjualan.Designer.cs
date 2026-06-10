namespace Projek_Final_sem2.UserControls
{
    partial class UcLaporanPenjualan
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
            PanelLaporanPenjualan = new Panel();
            PanelTotalTransaksi = new Panel();
            PanelTotal = new Panel();
            LbTotalTransaksi = new Label();
            PanelGrafikPenjualan = new Panel();
            LbGrafikPenjualan = new Label();
            PanelFilterTanggal = new Panel();
            BtnExport = new Button();
            BtnCetak = new Button();
            BtnTampilkan = new Button();
            TbTanggalAkhir = new TextBox();
            LbTanggalAkhir = new Label();
            TbTanggalAwal = new TextBox();
            LbTanggalAwal = new Label();
            LbFilterTanggal = new Label();
            LbJudulLaporanPenjualan = new Label();
            Column3 = new DataGridViewTextBoxColumn();
            FmPlotPenjualan = new ScottPlot.WinForms.FormsPlot();
            PanelLaporanPenjualan.SuspendLayout();
            PanelTotalTransaksi.SuspendLayout();
            PanelGrafikPenjualan.SuspendLayout();
            PanelFilterTanggal.SuspendLayout();
            SuspendLayout();
            // 
            // PanelLaporanPenjualan
            // 
            PanelLaporanPenjualan.BackColor = Color.White;
            PanelLaporanPenjualan.Controls.Add(PanelTotalTransaksi);
            PanelLaporanPenjualan.Controls.Add(PanelGrafikPenjualan);
            PanelLaporanPenjualan.Controls.Add(LbGrafikPenjualan);
            PanelLaporanPenjualan.Controls.Add(PanelFilterTanggal);
            PanelLaporanPenjualan.Controls.Add(LbJudulLaporanPenjualan);
            PanelLaporanPenjualan.Dock = DockStyle.Fill;
            PanelLaporanPenjualan.Location = new Point(0, 0);
            PanelLaporanPenjualan.Name = "PanelLaporanPenjualan";
            PanelLaporanPenjualan.Size = new Size(865, 582);
            PanelLaporanPenjualan.TabIndex = 0;
            // 
            // PanelTotalTransaksi
            // 
            PanelTotalTransaksi.Controls.Add(PanelTotal);
            PanelTotalTransaksi.Controls.Add(LbTotalTransaksi);
            PanelTotalTransaksi.Location = new Point(27, 477);
            PanelTotalTransaksi.Name = "PanelTotalTransaksi";
            PanelTotalTransaksi.Size = new Size(281, 93);
            PanelTotalTransaksi.TabIndex = 4;
            // 
            // PanelTotal
            // 
            PanelTotal.BackColor = Color.LightGray;
            PanelTotal.Location = new Point(157, 17);
            PanelTotal.Name = "PanelTotal";
            PanelTotal.Size = new Size(88, 58);
            PanelTotal.TabIndex = 1;
            // 
            // LbTotalTransaksi
            // 
            LbTotalTransaksi.AutoSize = true;
            LbTotalTransaksi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbTotalTransaksi.Location = new Point(13, 26);
            LbTotalTransaksi.Name = "LbTotalTransaksi";
            LbTotalTransaksi.Size = new Size(138, 25);
            LbTotalTransaksi.TabIndex = 0;
            LbTotalTransaksi.Text = "Total Transaksi";
            // 
            // PanelGrafikPenjualan
            // 
            PanelGrafikPenjualan.Controls.Add(FmPlotPenjualan);
            PanelGrafikPenjualan.Location = new Point(27, 307);
            PanelGrafikPenjualan.Name = "PanelGrafikPenjualan";
            PanelGrafikPenjualan.Size = new Size(659, 164);
            PanelGrafikPenjualan.TabIndex = 3;
            // 
            // LbGrafikPenjualan
            // 
            LbGrafikPenjualan.AutoSize = true;
            LbGrafikPenjualan.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbGrafikPenjualan.Location = new Point(24, 278);
            LbGrafikPenjualan.Name = "LbGrafikPenjualan";
            LbGrafikPenjualan.Size = new Size(190, 26);
            LbGrafikPenjualan.TabIndex = 2;
            LbGrafikPenjualan.Text = "Grafik Penjualan";
            // 
            // PanelFilterTanggal
            // 
            PanelFilterTanggal.BackColor = Color.White;
            PanelFilterTanggal.Controls.Add(BtnExport);
            PanelFilterTanggal.Controls.Add(BtnCetak);
            PanelFilterTanggal.Controls.Add(BtnTampilkan);
            PanelFilterTanggal.Controls.Add(TbTanggalAkhir);
            PanelFilterTanggal.Controls.Add(LbTanggalAkhir);
            PanelFilterTanggal.Controls.Add(TbTanggalAwal);
            PanelFilterTanggal.Controls.Add(LbTanggalAwal);
            PanelFilterTanggal.Controls.Add(LbFilterTanggal);
            PanelFilterTanggal.Location = new Point(27, 47);
            PanelFilterTanggal.Name = "PanelFilterTanggal";
            PanelFilterTanggal.Size = new Size(671, 228);
            PanelFilterTanggal.TabIndex = 1;
            // 
            // BtnExport
            // 
            BtnExport.BackColor = Color.Red;
            BtnExport.ForeColor = Color.White;
            BtnExport.Location = new Point(326, 165);
            BtnExport.Name = "BtnExport";
            BtnExport.Size = new Size(112, 34);
            BtnExport.TabIndex = 7;
            BtnExport.Text = "Export";
            BtnExport.UseVisualStyleBackColor = false;
            // 
            // BtnCetak
            // 
            BtnCetak.BackColor = Color.DeepSkyBlue;
            BtnCetak.ForeColor = Color.White;
            BtnCetak.Location = new Point(192, 165);
            BtnCetak.Name = "BtnCetak";
            BtnCetak.Size = new Size(112, 34);
            BtnCetak.TabIndex = 6;
            BtnCetak.Text = "Cetak";
            BtnCetak.UseVisualStyleBackColor = false;
            // 
            // BtnTampilkan
            // 
            BtnTampilkan.BackColor = Color.Green;
            BtnTampilkan.ForeColor = Color.White;
            BtnTampilkan.Location = new Point(36, 165);
            BtnTampilkan.Name = "BtnTampilkan";
            BtnTampilkan.Size = new Size(132, 34);
            BtnTampilkan.TabIndex = 5;
            BtnTampilkan.Text = "Tampilkan";
            BtnTampilkan.UseVisualStyleBackColor = false;
            // 
            // TbTanggalAkhir
            // 
            TbTanggalAkhir.BorderStyle = BorderStyle.FixedSingle;
            TbTanggalAkhir.Location = new Point(248, 110);
            TbTanggalAkhir.Name = "TbTanggalAkhir";
            TbTanggalAkhir.Size = new Size(253, 31);
            TbTanggalAkhir.TabIndex = 4;
            // 
            // LbTanggalAkhir
            // 
            LbTanggalAkhir.AutoSize = true;
            LbTanggalAkhir.Location = new Point(29, 110);
            LbTanggalAkhir.Name = "LbTanggalAkhir";
            LbTanggalAkhir.Size = new Size(119, 25);
            LbTanggalAkhir.TabIndex = 3;
            LbTanggalAkhir.Text = "Tanggal Akhir";
            // 
            // TbTanggalAwal
            // 
            TbTanggalAwal.BorderStyle = BorderStyle.FixedSingle;
            TbTanggalAwal.Location = new Point(248, 53);
            TbTanggalAwal.Name = "TbTanggalAwal";
            TbTanggalAwal.Size = new Size(253, 31);
            TbTanggalAwal.TabIndex = 2;
            // 
            // LbTanggalAwal
            // 
            LbTanggalAwal.AutoSize = true;
            LbTanggalAwal.Location = new Point(29, 59);
            LbTanggalAwal.Name = "LbTanggalAwal";
            LbTanggalAwal.Size = new Size(116, 25);
            LbTanggalAwal.TabIndex = 1;
            LbTanggalAwal.Text = "Tanggal Awal";
            // 
            // LbFilterTanggal
            // 
            LbFilterTanggal.AutoSize = true;
            LbFilterTanggal.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbFilterTanggal.Location = new Point(13, 10);
            LbFilterTanggal.Name = "LbFilterTanggal";
            LbFilterTanggal.Size = new Size(127, 23);
            LbFilterTanggal.TabIndex = 0;
            LbFilterTanggal.Text = "Filter Tanggal";
            // 
            // LbJudulLaporanPenjualan
            // 
            LbJudulLaporanPenjualan.AutoSize = true;
            LbJudulLaporanPenjualan.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbJudulLaporanPenjualan.Location = new Point(27, 13);
            LbJudulLaporanPenjualan.Name = "LbJudulLaporanPenjualan";
            LbJudulLaporanPenjualan.Size = new Size(211, 26);
            LbJudulLaporanPenjualan.TabIndex = 0;
            LbJudulLaporanPenjualan.Text = "Laporan Penjualan";
            // 
            // Column3
            // 
            Column3.HeaderText = "Pelanggan";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // FmPlotPenjualan
            // 
            FmPlotPenjualan.Location = new Point(3, 3);
            FmPlotPenjualan.Name = "FmPlotPenjualan";
            FmPlotPenjualan.Size = new Size(653, 158);
            FmPlotPenjualan.TabIndex = 0;
            // 
            // UcLaporanPenjualan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelLaporanPenjualan);
            Name = "UcLaporanPenjualan";
            Size = new Size(865, 582);
            Load += UcLaporanPenjualan_Load;
            PanelLaporanPenjualan.ResumeLayout(false);
            PanelLaporanPenjualan.PerformLayout();
            PanelTotalTransaksi.ResumeLayout(false);
            PanelTotalTransaksi.PerformLayout();
            PanelGrafikPenjualan.ResumeLayout(false);
            PanelFilterTanggal.ResumeLayout(false);
            PanelFilterTanggal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelLaporanPenjualan;
        private Label LbJudulLaporanPenjualan;
        private Panel PanelFilterTanggal;
        private TextBox TbTanggalAwal;
        private Label LbTanggalAwal;
        private Label LbFilterTanggal;
        private Button BtnExport;
        private Button BtnCetak;
        private Button BtnTampilkan;
        private TextBox TbTanggalAkhir;
        private Label LbTanggalAkhir;
        private Panel PanelGrafikPenjualan;
        private Label LbGrafikPenjualan;
        private DataGridViewTextBoxColumn Column3;
        private Panel PanelTotalTransaksi;
        private Panel PanelTotal;
        private Label LbTotalTransaksi;
        private ScottPlot.WinForms.FormsPlot FmPlotPenjualan;
    }
}
