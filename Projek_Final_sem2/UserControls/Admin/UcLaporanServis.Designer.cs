namespace Projek_Final_sem2.UserControls
{
    partial class UcLaporanServis
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
            LbJudulLaporanServis = new Label();
            PanelFilterTanggal = new Panel();
            DtmPickerTanggalAwal = new DateTimePicker();
            DtmPickerTanggalAkhir = new DateTimePicker();
            BtnExport = new Button();
            BtnCetak = new Button();
            BtnTampilkan = new Button();
            LbTanggalAkhir = new Label();
            LbTanggalAwal = new Label();
            LbFilterTanggal = new Label();
            PanelTotalTransaksi = new Panel();
            LbTotalPendapatanServis = new Label();
            LbTotalService = new Label();
            LbDataServis = new Label();
            FmPlotServis = new ScottPlot.WinForms.FormsPlot();
            PanelFilterTanggal.SuspendLayout();
            PanelTotalTransaksi.SuspendLayout();
            SuspendLayout();
            // 
            // LbJudulLaporanServis
            // 
            LbJudulLaporanServis.AutoSize = true;
            LbJudulLaporanServis.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbJudulLaporanServis.Location = new Point(47, 8);
            LbJudulLaporanServis.Name = "LbJudulLaporanServis";
            LbJudulLaporanServis.Size = new Size(182, 32);
            LbJudulLaporanServis.TabIndex = 0;
            LbJudulLaporanServis.Text = "Laporan Servis";
            // 
            // PanelFilterTanggal
            // 
            PanelFilterTanggal.BackColor = Color.White;
            PanelFilterTanggal.Controls.Add(DtmPickerTanggalAwal);
            PanelFilterTanggal.Controls.Add(DtmPickerTanggalAkhir);
            PanelFilterTanggal.Controls.Add(BtnExport);
            PanelFilterTanggal.Controls.Add(BtnCetak);
            PanelFilterTanggal.Controls.Add(BtnTampilkan);
            PanelFilterTanggal.Controls.Add(LbTanggalAkhir);
            PanelFilterTanggal.Controls.Add(LbTanggalAwal);
            PanelFilterTanggal.Controls.Add(LbFilterTanggal);
            PanelFilterTanggal.Location = new Point(44, 43);
            PanelFilterTanggal.Name = "PanelFilterTanggal";
            PanelFilterTanggal.Size = new Size(684, 228);
            PanelFilterTanggal.TabIndex = 2;
            // 
            // DtmPickerTanggalAwal
            // 
            DtmPickerTanggalAwal.Location = new Point(191, 52);
            DtmPickerTanggalAwal.Name = "DtmPickerTanggalAwal";
            DtmPickerTanggalAwal.Size = new Size(300, 31);
            DtmPickerTanggalAwal.TabIndex = 9;
            // 
            // DtmPickerTanggalAkhir
            // 
            DtmPickerTanggalAkhir.Location = new Point(191, 105);
            DtmPickerTanggalAkhir.Name = "DtmPickerTanggalAkhir";
            DtmPickerTanggalAkhir.Size = new Size(300, 31);
            DtmPickerTanggalAkhir.TabIndex = 8;
            // 
            // BtnExport
            // 
            BtnExport.BackColor = Color.Red;
            BtnExport.ForeColor = Color.White;
            BtnExport.Location = new Point(326, 165);
            BtnExport.Name = "BtnExport";
            BtnExport.Size = new Size(111, 33);
            BtnExport.TabIndex = 7;
            BtnExport.Text = "Export";
            BtnExport.UseVisualStyleBackColor = false;
            // 
            // BtnCetak
            // 
            BtnCetak.BackColor = Color.DeepSkyBlue;
            BtnCetak.ForeColor = Color.White;
            BtnCetak.Location = new Point(191, 165);
            BtnCetak.Name = "BtnCetak";
            BtnCetak.Size = new Size(111, 33);
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
            BtnTampilkan.Size = new Size(131, 33);
            BtnTampilkan.TabIndex = 5;
            BtnTampilkan.Text = "Tampilkan";
            BtnTampilkan.UseVisualStyleBackColor = false;
            BtnTampilkan.Click += BtnTampilkan_Click;
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
            // LbTanggalAwal
            // 
            LbTanggalAwal.AutoSize = true;
            LbTanggalAwal.Location = new Point(29, 58);
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
            // PanelTotalTransaksi
            // 
            PanelTotalTransaksi.Controls.Add(LbTotalPendapatanServis);
            PanelTotalTransaksi.Controls.Add(LbTotalService);
            PanelTotalTransaksi.Location = new Point(44, 487);
            PanelTotalTransaksi.Name = "PanelTotalTransaksi";
            PanelTotalTransaksi.Size = new Size(684, 93);
            PanelTotalTransaksi.TabIndex = 5;
            // 
            // LbTotalPendapatanServis
            // 
            LbTotalPendapatanServis.AutoSize = true;
            LbTotalPendapatanServis.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbTotalPendapatanServis.Location = new Point(260, 27);
            LbTotalPendapatanServis.Name = "LbTotalPendapatanServis";
            LbTotalPendapatanServis.Size = new Size(226, 25);
            LbTotalPendapatanServis.TabIndex = 2;
            LbTotalPendapatanServis.Text = "Total Pendapatan Servis :";
            // 
            // LbTotalService
            // 
            LbTotalService.AutoSize = true;
            LbTotalService.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbTotalService.Location = new Point(3, 27);
            LbTotalService.Name = "LbTotalService";
            LbTotalService.Size = new Size(131, 25);
            LbTotalService.TabIndex = 0;
            LbTotalService.Text = "Total Service :";
            // 
            // LbDataServis
            // 
            LbDataServis.AutoSize = true;
            LbDataServis.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbDataServis.Location = new Point(47, 279);
            LbDataServis.Name = "LbDataServis";
            LbDataServis.Size = new Size(129, 26);
            LbDataServis.TabIndex = 6;
            LbDataServis.Text = "Data Servis";
            // 
            // FmPlotServis
            // 
            FmPlotServis.Location = new Point(44, 306);
            FmPlotServis.Name = "FmPlotServis";
            FmPlotServis.Size = new Size(684, 175);
            FmPlotServis.TabIndex = 7;
            FmPlotServis.Load += FmPlotServis_Load;
            // 
            // UcLaporanServis
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(FmPlotServis);
            Controls.Add(LbDataServis);
            Controls.Add(PanelTotalTransaksi);
            Controls.Add(PanelFilterTanggal);
            Controls.Add(LbJudulLaporanServis);
            Name = "UcLaporanServis";
            Size = new Size(853, 592);
            Load += UcLaporanServis_Load;
            PanelFilterTanggal.ResumeLayout(false);
            PanelFilterTanggal.PerformLayout();
            PanelTotalTransaksi.ResumeLayout(false);
            PanelTotalTransaksi.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbJudulLaporanServis;
        private Panel PanelFilterTanggal;
        private Button BtnExport;
        private Button BtnCetak;
        private Button BtnTampilkan;
        private Label LbTanggalAkhir;
        private Label LbTanggalAwal;
        private Label LbFilterTanggal;
        private Panel PanelTotalTransaksi;
        private Label LbTotalPendapatanServis;
        private Label LbTotalService;
        private Label LbDataServis;
        private DataGridViewTextBoxColumn Column3;
        private DateTimePicker DtmPickerTanggalAwal;
        private DateTimePicker DtmPickerTanggalAkhir;
        private ScottPlot.WinForms.FormsPlot FmPlotServis;
    }
}
