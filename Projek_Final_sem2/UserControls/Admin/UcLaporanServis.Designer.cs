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
            BtnExport = new Button();
            BtnCetak = new Button();
            BtnTampilkan = new Button();
            TbTanggalAkhir = new TextBox();
            LbTanggalAkhir = new Label();
            TbTanggalAwal = new TextBox();
            LbTanggalAwal = new Label();
            LbFilterTanggal = new Label();
            DgvDataServis = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            PanelTotalTransaksi = new Panel();
            PanelTotalPendapatanServis = new Panel();
            LbTotalPendapatanServis = new Label();
            PanelTotal = new Panel();
            LbTotalServis = new Label();
            LbDataServis = new Label();
            PanelFilterTanggal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvDataServis).BeginInit();
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
            PanelFilterTanggal.Controls.Add(BtnExport);
            PanelFilterTanggal.Controls.Add(BtnCetak);
            PanelFilterTanggal.Controls.Add(BtnTampilkan);
            PanelFilterTanggal.Controls.Add(TbTanggalAkhir);
            PanelFilterTanggal.Controls.Add(LbTanggalAkhir);
            PanelFilterTanggal.Controls.Add(TbTanggalAwal);
            PanelFilterTanggal.Controls.Add(LbTanggalAwal);
            PanelFilterTanggal.Controls.Add(LbFilterTanggal);
            PanelFilterTanggal.Location = new Point(31, 26);
            PanelFilterTanggal.Margin = new Padding(2, 2, 2, 2);
            PanelFilterTanggal.Name = "PanelFilterTanggal";
            PanelFilterTanggal.Size = new Size(470, 137);
            PanelFilterTanggal.TabIndex = 2;
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
            // 
            // TbTanggalAkhir
            // 
            TbTanggalAkhir.BorderStyle = BorderStyle.FixedSingle;
            TbTanggalAkhir.Location = new Point(174, 66);
            TbTanggalAkhir.Margin = new Padding(2, 2, 2, 2);
            TbTanggalAkhir.Name = "TbTanggalAkhir";
            TbTanggalAkhir.Size = new Size(178, 23);
            TbTanggalAkhir.TabIndex = 4;
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
            // TbTanggalAwal
            // 
            TbTanggalAwal.BorderStyle = BorderStyle.FixedSingle;
            TbTanggalAwal.Location = new Point(174, 32);
            TbTanggalAwal.Margin = new Padding(2, 2, 2, 2);
            TbTanggalAwal.Name = "TbTanggalAwal";
            TbTanggalAwal.Size = new Size(178, 23);
            TbTanggalAwal.TabIndex = 2;
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
            // DgvDataServis
            // 
            DgvDataServis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvDataServis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDataServis.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1, Column4, Column5, Column6 });
            DgvDataServis.Location = new Point(31, 188);
            DgvDataServis.Margin = new Padding(2, 2, 2, 2);
            DgvDataServis.Name = "DgvDataServis";
            DgvDataServis.RowHeadersWidth = 62;
            DgvDataServis.Size = new Size(461, 100);
            DgvDataServis.TabIndex = 3;
            DgvDataServis.CellContentClick += DgvDataServis_CellContentClick;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tanggal";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            // 
            // Column1
            // 
            Column1.HeaderText = "No.Servis";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            // 
            // Column4
            // 
            Column4.HeaderText = "Jenis Alat";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Biaya";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Status";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            // 
            // PanelTotalTransaksi
            // 
            PanelTotalTransaksi.Controls.Add(PanelTotalPendapatanServis);
            PanelTotalTransaksi.Controls.Add(LbTotalPendapatanServis);
            PanelTotalTransaksi.Controls.Add(PanelTotal);
            PanelTotalTransaksi.Controls.Add(LbTotalServis);
            PanelTotalTransaksi.Location = new Point(31, 292);
            PanelTotalTransaksi.Margin = new Padding(2, 2, 2, 2);
            PanelTotalTransaksi.Name = "PanelTotalTransaksi";
            PanelTotalTransaksi.Size = new Size(479, 56);
            PanelTotalTransaksi.TabIndex = 5;
            // 
            // PanelTotalPendapatanServis
            // 
            PanelTotalPendapatanServis.BackColor = Color.LightGray;
            PanelTotalPendapatanServis.Location = new Point(337, 10);
            PanelTotalPendapatanServis.Margin = new Padding(2, 2, 2, 2);
            PanelTotalPendapatanServis.Name = "PanelTotalPendapatanServis";
            PanelTotalPendapatanServis.Size = new Size(124, 35);
            PanelTotalPendapatanServis.TabIndex = 2;
            // 
            // LbTotalPendapatanServis
            // 
            LbTotalPendapatanServis.AutoSize = true;
            LbTotalPendapatanServis.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbTotalPendapatanServis.Location = new Point(182, 16);
            LbTotalPendapatanServis.Margin = new Padding(2, 0, 2, 0);
            LbTotalPendapatanServis.Name = "LbTotalPendapatanServis";
            LbTotalPendapatanServis.Size = new Size(139, 15);
            LbTotalPendapatanServis.TabIndex = 2;
            LbTotalPendapatanServis.Text = "Total Pendapatan Servis";
            // 
            // PanelTotal
            // 
            PanelTotal.BackColor = Color.LightGray;
            PanelTotal.Location = new Point(104, 10);
            PanelTotal.Margin = new Padding(2, 2, 2, 2);
            PanelTotal.Name = "PanelTotal";
            PanelTotal.Size = new Size(62, 35);
            PanelTotal.TabIndex = 1;
            // 
            // LbTotalServis
            // 
            LbTotalServis.AutoSize = true;
            LbTotalServis.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbTotalServis.Location = new Point(2, 16);
            LbTotalServis.Margin = new Padding(2, 0, 2, 0);
            LbTotalServis.Name = "LbTotalServis";
            LbTotalServis.Size = new Size(87, 15);
            LbTotalServis.TabIndex = 0;
            LbTotalServis.Text = "Total Transaksi";
            // 
            // LbDataServis
            // 
            LbDataServis.AutoSize = true;
            LbDataServis.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbDataServis.Location = new Point(33, 170);
            LbDataServis.Margin = new Padding(2, 0, 2, 0);
            LbDataServis.Name = "LbDataServis";
            LbDataServis.Size = new Size(88, 19);
            LbDataServis.TabIndex = 6;
            LbDataServis.Text = "Data Servis";
            // 
            // UcLaporanServis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(LbDataServis);
            Controls.Add(PanelTotalTransaksi);
            Controls.Add(DgvDataServis);
            Controls.Add(PanelFilterTanggal);
            Controls.Add(LbJudulLaporanServis);
            Margin = new Padding(2, 2, 2, 2);
            Name = "UcLaporanServis";
            Size = new Size(597, 355);
            Load += UcLaporanServis_Load;
            PanelFilterTanggal.ResumeLayout(false);
            PanelFilterTanggal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvDataServis).EndInit();
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
        private TextBox TbTanggalAkhir;
        private Label LbTanggalAkhir;
        private TextBox TbTanggalAwal;
        private Label LbTanggalAwal;
        private Label LbFilterTanggal;
        private DataGridView DgvDataServis;
        private Panel PanelTotalTransaksi;
        private Panel PanelTotalPendapatanServis;
        private Label LbTotalPendapatanServis;
        private Panel PanelTotal;
        private Label LbTotalServis;
        private Label LbDataServis;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}
