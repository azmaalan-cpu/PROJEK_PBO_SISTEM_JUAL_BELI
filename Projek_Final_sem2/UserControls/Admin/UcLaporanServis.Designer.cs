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
            LbJudulLaporanServis.Location = new Point(33, 5);
            LbJudulLaporanServis.Margin = new Padding(2, 0, 2, 0);
            LbJudulLaporanServis.Name = "LbJudulLaporanServis";
            LbJudulLaporanServis.Size = new Size(122, 21);
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
            PanelFilterTanggal.Location = new Point(31, 26);
            PanelFilterTanggal.Margin = new Padding(2, 2, 2, 2);
            PanelFilterTanggal.Name = "PanelFilterTanggal";
            PanelFilterTanggal.Size = new Size(479, 137);
            PanelFilterTanggal.TabIndex = 2;
            // 
            // DtmPickerTanggalAwal
            // 
            DtmPickerTanggalAwal.Location = new Point(134, 31);
            DtmPickerTanggalAwal.Margin = new Padding(2, 2, 2, 2);
            DtmPickerTanggalAwal.Name = "DtmPickerTanggalAwal";
            DtmPickerTanggalAwal.Size = new Size(211, 23);
            DtmPickerTanggalAwal.TabIndex = 9;
            // 
            // DtmPickerTanggalAkhir
            // 
            DtmPickerTanggalAkhir.Location = new Point(134, 63);
            DtmPickerTanggalAkhir.Margin = new Padding(2, 2, 2, 2);
            DtmPickerTanggalAkhir.Name = "DtmPickerTanggalAkhir";
            DtmPickerTanggalAkhir.Size = new Size(211, 23);
            DtmPickerTanggalAkhir.TabIndex = 8;
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
            // PanelTotalTransaksi
            // 
            PanelTotalTransaksi.Controls.Add(LbTotalPendapatanServis);
            PanelTotalTransaksi.Controls.Add(LbTotalService);
            PanelTotalTransaksi.Location = new Point(31, 336);
            PanelTotalTransaksi.Margin = new Padding(2, 2, 2, 2);
            PanelTotalTransaksi.Name = "PanelTotalTransaksi";
            PanelTotalTransaksi.Size = new Size(479, 56);
            PanelTotalTransaksi.TabIndex = 5;
            PanelTotalTransaksi.Paint += PanelTotalTransaksi_Paint;
            // 
            // LbTotalPendapatanServis
            // 
            LbTotalPendapatanServis.AutoSize = true;
            LbTotalPendapatanServis.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbTotalPendapatanServis.Location = new Point(182, 16);
            LbTotalPendapatanServis.Margin = new Padding(2, 0, 2, 0);
            LbTotalPendapatanServis.Name = "LbTotalPendapatanServis";
            LbTotalPendapatanServis.Size = new Size(145, 15);
            LbTotalPendapatanServis.TabIndex = 2;
            LbTotalPendapatanServis.Text = "Total Pendapatan Servis :";
            // 
            // LbTotalService
            // 
            LbTotalService.AutoSize = true;
            LbTotalService.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbTotalService.Location = new Point(2, 16);
            LbTotalService.Margin = new Padding(2, 0, 2, 0);
            LbTotalService.Name = "LbTotalService";
            LbTotalService.Size = new Size(85, 15);
            LbTotalService.TabIndex = 0;
            LbTotalService.Text = "Total Service :";
            // 
            // LbDataServis
            // 
            LbDataServis.AutoSize = true;
            LbDataServis.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbDataServis.Location = new Point(33, 167);
            LbDataServis.Margin = new Padding(2, 0, 2, 0);
            LbDataServis.Name = "LbDataServis";
            LbDataServis.Size = new Size(88, 19);
            LbDataServis.TabIndex = 6;
            LbDataServis.Text = "Data Servis";
            // 
            // FmPlotServis
            // 
            FmPlotServis.Location = new Point(31, 184);
            FmPlotServis.Margin = new Padding(2, 2, 2, 2);
            FmPlotServis.Name = "FmPlotServis";
            FmPlotServis.Size = new Size(592, 148);
            FmPlotServis.TabIndex = 7;
            FmPlotServis.Load += FmPlotServis_Load;
            // 
            // UcLaporanServis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(FmPlotServis);
            Controls.Add(LbDataServis);
            Controls.Add(PanelTotalTransaksi);
            Controls.Add(PanelFilterTanggal);
            Controls.Add(LbJudulLaporanServis);
            Margin = new Padding(2, 2, 2, 2);
            Name = "UcLaporanServis";
            Size = new Size(717, 408);
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
