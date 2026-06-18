namespace Projek_Final_sem2.UserControls.Teknisi
{
    partial class UcRiwayat
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
            DtpRiwayatAwal = new DateTimePicker();
            DtpRiwayatAkhir = new DateTimePicker();
            LblRiwayatServis = new Label();
            LblTanggalAwal = new Label();
            LblSampaiTanggal = new Label();
            BtnTampilkanRiwayat = new Button();
            DgvRiwayat = new DataGridView();
            LbTotalPendapatan = new Label();
            TotalPendapatan = new Label();
            LbTotalServis = new Label();
            TotalServis = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvRiwayat).BeginInit();
            SuspendLayout();
            // 
            // DtpRiwayatAwal
            // 
            DtpRiwayatAwal.Location = new Point(16, 76);
            DtpRiwayatAwal.Name = "DtpRiwayatAwal";
            DtpRiwayatAwal.Size = new Size(226, 23);
            DtpRiwayatAwal.TabIndex = 0;
            // 
            // DtpRiwayatAkhir
            // 
            DtpRiwayatAkhir.Location = new Point(291, 76);
            DtpRiwayatAkhir.Name = "DtpRiwayatAkhir";
            DtpRiwayatAkhir.Size = new Size(216, 23);
            DtpRiwayatAkhir.TabIndex = 1;
            // 
            // LblRiwayatServis
            // 
            LblRiwayatServis.AutoSize = true;
            LblRiwayatServis.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblRiwayatServis.Location = new Point(16, 20);
            LblRiwayatServis.Name = "LblRiwayatServis";
            LblRiwayatServis.Size = new Size(139, 25);
            LblRiwayatServis.TabIndex = 2;
            LblRiwayatServis.Text = "Riwayat Servis";
            // 
            // LblTanggalAwal
            // 
            LblTanggalAwal.AutoSize = true;
            LblTanggalAwal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblTanggalAwal.Location = new Point(16, 58);
            LblTanggalAwal.Name = "LblTanggalAwal";
            LblTanggalAwal.Size = new Size(73, 15);
            LblTanggalAwal.TabIndex = 3;
            LblTanggalAwal.Text = "Dari Tanggal";
            // 
            // LblSampaiTanggal
            // 
            LblSampaiTanggal.AutoSize = true;
            LblSampaiTanggal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblSampaiTanggal.Location = new Point(291, 58);
            LblSampaiTanggal.Name = "LblSampaiTanggal";
            LblSampaiTanggal.Size = new Size(91, 15);
            LblSampaiTanggal.TabIndex = 4;
            LblSampaiTanggal.Text = "Sampai Tanggal";
            // 
            // BtnTampilkanRiwayat
            // 
            BtnTampilkanRiwayat.BackColor = Color.Lime;
            BtnTampilkanRiwayat.Location = new Point(589, 76);
            BtnTampilkanRiwayat.Name = "BtnTampilkanRiwayat";
            BtnTampilkanRiwayat.Size = new Size(110, 23);
            BtnTampilkanRiwayat.TabIndex = 5;
            BtnTampilkanRiwayat.Text = "Tampilkan";
            BtnTampilkanRiwayat.UseVisualStyleBackColor = false;
            BtnTampilkanRiwayat.Click += BtnTampilkanRiwayat_Click;
            // 
            // DgvRiwayat
            // 
            DgvRiwayat.AllowUserToAddRows = false;
            DgvRiwayat.AllowUserToOrderColumns = true;
            DgvRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvRiwayat.Location = new Point(16, 105);
            DgvRiwayat.Name = "DgvRiwayat";
            DgvRiwayat.ReadOnly = true;
            DgvRiwayat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvRiwayat.Size = new Size(683, 197);
            DgvRiwayat.TabIndex = 6;
            DgvRiwayat.CellContentClick += DgvRiwayat_CellContentClick;
            // 
            // LbTotalPendapatan
            // 
            LbTotalPendapatan.AutoSize = true;
            LbTotalPendapatan.Location = new Point(16, 318);
            LbTotalPendapatan.Name = "LbTotalPendapatan";
            LbTotalPendapatan.Size = new Size(105, 15);
            LbTotalPendapatan.TabIndex = 7;
            LbTotalPendapatan.Text = "Total Pendapatan :";
            // 
            // TotalPendapatan
            // 
            TotalPendapatan.AutoSize = true;
            TotalPendapatan.Location = new Point(127, 318);
            TotalPendapatan.Name = "TotalPendapatan";
            TotalPendapatan.Size = new Size(13, 15);
            TotalPendapatan.TabIndex = 8;
            TotalPendapatan.Text = "0";
            TotalPendapatan.Click += TotalPendapatan_Click;
            // 
            // LbTotalServis
            // 
            LbTotalServis.AutoSize = true;
            LbTotalServis.Location = new Point(16, 344);
            LbTotalServis.Name = "LbTotalServis";
            LbTotalServis.Size = new Size(72, 15);
            LbTotalServis.TabIndex = 9;
            LbTotalServis.Text = "Total Servis :";
            // 
            // TotalServis
            // 
            TotalServis.AutoSize = true;
            TotalServis.Location = new Point(127, 344);
            TotalServis.Name = "TotalServis";
            TotalServis.Size = new Size(13, 15);
            TotalServis.TabIndex = 10;
            TotalServis.Text = "0";
            // 
            // UcRiwayat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TotalServis);
            Controls.Add(LbTotalServis);
            Controls.Add(TotalPendapatan);
            Controls.Add(LbTotalPendapatan);
            Controls.Add(DgvRiwayat);
            Controls.Add(BtnTampilkanRiwayat);
            Controls.Add(LblSampaiTanggal);
            Controls.Add(LblTanggalAwal);
            Controls.Add(LblRiwayatServis);
            Controls.Add(DtpRiwayatAkhir);
            Controls.Add(DtpRiwayatAwal);
            Name = "UcRiwayat";
            Size = new Size(725, 407);
            Load += UcRiwayat_Load;
            ((System.ComponentModel.ISupportInitialize)DgvRiwayat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker DtpRiwayatAwal;
        private DateTimePicker DtpRiwayatAkhir;
        private Label LblRiwayatServis;
        private Label LblTanggalAwal;
        private Label LblSampaiTanggal;
        private Button BtnTampilkanRiwayat;
        private DataGridView DgvRiwayat;
        private Label LbTotalPendapatan;
        private Label TotalPendapatan;
        private Label LbTotalServis;
        private Label TotalServis;
    }
}
