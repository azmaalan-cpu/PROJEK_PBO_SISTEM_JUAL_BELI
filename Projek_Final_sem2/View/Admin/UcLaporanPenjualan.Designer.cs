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
            LbTotal = new Label();
            LbTotalPenjualan = new Label();
            PanelGrafikPenjualan = new Panel();
            FmPlotPenjualan = new ScottPlot.WinForms.FormsPlot();
            LbGrafikPenjualan = new Label();
            PanelFilterTanggal = new Panel();
            DtmPickerTanggalAkhir = new DateTimePicker();
            DtmPickerTanggalAwal = new DateTimePicker();
            BtnExport = new Button();
            BtnCetak = new Button();
            BtnTampilkan = new Button();
            LbTanggalAkhir = new Label();
            LbTanggalAwal = new Label();
            LbFilterTanggal = new Label();
            LbJudulLaporanPenjualan = new Label();
            Column3 = new DataGridViewTextBoxColumn();
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
            PanelLaporanPenjualan.Margin = new Padding(2, 2, 2, 2);
            PanelLaporanPenjualan.Name = "PanelLaporanPenjualan";
            PanelLaporanPenjualan.Size = new Size(740, 423);
            PanelLaporanPenjualan.TabIndex = 0;
            // 
            // PanelTotalTransaksi
            // 
            PanelTotalTransaksi.Controls.Add(LbTotal);
            PanelTotalTransaksi.Controls.Add(LbTotalPenjualan);
            PanelTotalTransaksi.Location = new Point(19, 357);
            PanelTotalTransaksi.Margin = new Padding(2, 2, 2, 2);
            PanelTotalTransaksi.Name = "PanelTotalTransaksi";
            PanelTotalTransaksi.Size = new Size(360, 52);
            PanelTotalTransaksi.TabIndex = 4;
            // 
            // LbTotal
            // 
            LbTotal.AutoSize = true;
            LbTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbTotal.Location = new Point(120, 16);
            LbTotal.Margin = new Padding(2, 0, 2, 0);
            LbTotal.Name = "LbTotal";
            LbTotal.Size = new Size(0, 15);
            LbTotal.TabIndex = 1;
            // 
            // LbTotalPenjualan
            // 
            LbTotalPenjualan.AutoSize = true;
            LbTotalPenjualan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbTotalPenjualan.Location = new Point(9, 16);
            LbTotalPenjualan.Margin = new Padding(2, 0, 2, 0);
            LbTotalPenjualan.Name = "LbTotalPenjualan";
            LbTotalPenjualan.Size = new Size(96, 15);
            LbTotalPenjualan.TabIndex = 0;
            LbTotalPenjualan.Text = "Total Penjualan :";
            // 
            // PanelGrafikPenjualan
            // 
            PanelGrafikPenjualan.Controls.Add(FmPlotPenjualan);
            PanelGrafikPenjualan.Location = new Point(19, 188);
            PanelGrafikPenjualan.Name = "PanelGrafikPenjualan";
            PanelGrafikPenjualan.Size = new Size(659, 164);
            PanelGrafikPenjualan.TabIndex = 3;
            // 
            // FmPlotPenjualan
            // 
            FmPlotPenjualan.Location = new Point(4, 2);
            FmPlotPenjualan.Name = "FmPlotPenjualan";
            FmPlotPenjualan.Size = new Size(653, 158);
            FmPlotPenjualan.TabIndex = 0;
            FmPlotPenjualan.Load += FmPlotPenjualan_Load;
            // 
            // LbGrafikPenjualan
            // 
            LbGrafikPenjualan.AutoSize = true;
            LbGrafikPenjualan.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbGrafikPenjualan.Location = new Point(19, 167);
            LbGrafikPenjualan.Name = "LbGrafikPenjualan";
            LbGrafikPenjualan.Size = new Size(122, 19);
            LbGrafikPenjualan.TabIndex = 2;
            LbGrafikPenjualan.Text = "Grafik Penjualan";
            // 
            // PanelFilterTanggal
            // 
            PanelFilterTanggal.BackColor = Color.White;
            PanelFilterTanggal.Controls.Add(DtmPickerTanggalAkhir);
            PanelFilterTanggal.Controls.Add(DtmPickerTanggalAwal);
            PanelFilterTanggal.Controls.Add(BtnExport);
            PanelFilterTanggal.Controls.Add(BtnCetak);
            PanelFilterTanggal.Controls.Add(BtnTampilkan);
            PanelFilterTanggal.Controls.Add(LbTanggalAkhir);
            PanelFilterTanggal.Controls.Add(LbTanggalAwal);
            PanelFilterTanggal.Controls.Add(LbFilterTanggal);
            PanelFilterTanggal.Location = new Point(19, 28);
            PanelFilterTanggal.Margin = new Padding(2, 2, 2, 2);
            PanelFilterTanggal.Name = "PanelFilterTanggal";
            PanelFilterTanggal.Size = new Size(470, 137);
            PanelFilterTanggal.TabIndex = 1;
            // 
            // DtmPickerTanggalAkhir
            // 
            DtmPickerTanggalAkhir.Location = new Point(134, 66);
            DtmPickerTanggalAkhir.Name = "DtmPickerTanggalAkhir";
            DtmPickerTanggalAkhir.Size = new Size(300, 23);
            DtmPickerTanggalAkhir.TabIndex = 9;
            // 
            // DtmPickerTanggalAwal
            // 
            DtmPickerTanggalAwal.Location = new Point(134, 32);
            DtmPickerTanggalAwal.Name = "DtmPickerTanggalAwal";
            DtmPickerTanggalAwal.Size = new Size(300, 23);
            DtmPickerTanggalAwal.TabIndex = 8;
            // 
            // BtnExport
            // 
            BtnExport.BackColor = Color.Red;
            BtnExport.ForeColor = Color.White;
            BtnExport.Location = new Point(228, 99);
            BtnExport.Margin = new Padding(2, 2, 2, 2);
            BtnExport.Name = "BtnExport";
            BtnExport.Size = new Size(78, 20);
            BtnExport.TabIndex = 7;
            BtnExport.Text = "Export";
            BtnExport.UseVisualStyleBackColor = false;
            // 
            // BtnCetak
            // 
            BtnCetak.BackColor = Color.DeepSkyBlue;
            BtnCetak.ForeColor = Color.White;
            BtnCetak.Location = new Point(134, 99);
            BtnCetak.Margin = new Padding(2, 2, 2, 2);
            BtnCetak.Name = "BtnCetak";
            BtnCetak.Size = new Size(78, 20);
            BtnCetak.TabIndex = 6;
            BtnCetak.Text = "Cetak";
            BtnCetak.UseVisualStyleBackColor = false;
            // 
            // BtnTampilkan
            // 
            BtnTampilkan.BackColor = Color.Green;
            BtnTampilkan.ForeColor = Color.White;
            BtnTampilkan.Location = new Point(25, 99);
            BtnTampilkan.Margin = new Padding(2, 2, 2, 2);
            BtnTampilkan.Name = "BtnTampilkan";
            BtnTampilkan.Size = new Size(92, 20);
            BtnTampilkan.TabIndex = 5;
            BtnTampilkan.Text = "Tampilkan";
            BtnTampilkan.UseVisualStyleBackColor = false;
            BtnTampilkan.Click += BtnTampilkan_Click;
            // 
            // LbTanggalAkhir
            // 
            LbTanggalAkhir.AutoSize = true;
            LbTanggalAkhir.Location = new Point(20, 66);
            LbTanggalAkhir.Margin = new Padding(2, 0, 2, 0);
            LbTanggalAkhir.Name = "LbTanggalAkhir";
            LbTanggalAkhir.Size = new Size(80, 15);
            LbTanggalAkhir.TabIndex = 3;
            LbTanggalAkhir.Text = "Tanggal Akhir";
            // 
            // LbTanggalAwal
            // 
            LbTanggalAwal.AutoSize = true;
            LbTanggalAwal.Location = new Point(20, 35);
            LbTanggalAwal.Margin = new Padding(2, 0, 2, 0);
            LbTanggalAwal.Name = "LbTanggalAwal";
            LbTanggalAwal.Size = new Size(78, 15);
            LbTanggalAwal.TabIndex = 1;
            LbTanggalAwal.Text = "Tanggal Awal";
            // 
            // LbFilterTanggal
            // 
            LbFilterTanggal.AutoSize = true;
            LbFilterTanggal.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbFilterTanggal.Location = new Point(9, 6);
            LbFilterTanggal.Margin = new Padding(2, 0, 2, 0);
            LbFilterTanggal.Name = "LbFilterTanggal";
            LbFilterTanggal.Size = new Size(93, 17);
            LbFilterTanggal.TabIndex = 0;
            LbFilterTanggal.Text = "Filter Tanggal";
            // 
            // LbJudulLaporanPenjualan
            // 
            LbJudulLaporanPenjualan.AutoSize = true;
            LbJudulLaporanPenjualan.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbJudulLaporanPenjualan.Location = new Point(19, 8);
            LbJudulLaporanPenjualan.Margin = new Padding(2, 0, 2, 0);
            LbJudulLaporanPenjualan.Name = "LbJudulLaporanPenjualan";
            LbJudulLaporanPenjualan.Size = new Size(134, 19);
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
            // UcLaporanPenjualan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelLaporanPenjualan);
            Margin = new Padding(2, 2, 2, 2);
            Name = "UcLaporanPenjualan";
            Size = new Size(740, 423);
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
        private Label LbTanggalAwal;
        private Label LbFilterTanggal;
        private Button BtnExport;
        private Button BtnCetak;
        private Button BtnTampilkan;
        private Label LbTanggalAkhir;
        private Panel PanelGrafikPenjualan;
        private Label LbGrafikPenjualan;
        private DataGridViewTextBoxColumn Column3;
        private Panel PanelTotalTransaksi;
        private Panel PanelTotal;
        private Label LbTotalPenjualan;
        private ScottPlot.WinForms.FormsPlot FmPlotPenjualan;
        private DateTimePicker DtmPickerTanggalAwal;
        private DateTimePicker DtmPickerTanggalAkhir;
        private Label LbTotal;
    }
}
