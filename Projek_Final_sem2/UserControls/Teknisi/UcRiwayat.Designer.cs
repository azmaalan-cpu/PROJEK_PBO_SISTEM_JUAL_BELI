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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DtpRiwayatAwal = new DateTimePicker();
            DtpRiwayatAkhir = new DateTimePicker();
            LblRiwayatServis = new Label();
            LblTanggalAwal = new Label();
            LblSampaiTanggal = new Label();
            BtnTampilkanRiwayat = new Button();
            DgvRiwayat = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            LblTotalSevis = new Label();
            LblTotalPendapatan = new Label();
            LblAngkaTotalServis = new Label();
            LblAngkaPendapatan = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)DgvRiwayat).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            DgvRiwayat.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            DgvRiwayat.Location = new Point(16, 105);
            DgvRiwayat.Name = "DgvRiwayat";
            DgvRiwayat.ReadOnly = true;
            DgvRiwayat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvRiwayat.Size = new Size(683, 173);
            DgvRiwayat.TabIndex = 6;
            DgvRiwayat.CellContentClick += DgvRiwayat_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID Servis";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tanggal";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Nama Alat";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Kerusakan";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            Column5.DefaultCellStyle = dataGridViewCellStyle1;
            Column5.HeaderText = "Biaya";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Status";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // LblTotalSevis
            // 
            LblTotalSevis.AutoSize = true;
            LblTotalSevis.Location = new Point(61, 35);
            LblTotalSevis.Name = "LblTotalSevis";
            LblTotalSevis.Size = new Size(66, 15);
            LblTotalSevis.TabIndex = 7;
            LblTotalSevis.Text = "Total Servis";
            // 
            // LblTotalPendapatan
            // 
            LblTotalPendapatan.AutoSize = true;
            LblTotalPendapatan.Location = new Point(28, 35);
            LblTotalPendapatan.Name = "LblTotalPendapatan";
            LblTotalPendapatan.Size = new Size(132, 15);
            LblTotalPendapatan.TabIndex = 8;
            LblTotalPendapatan.Text = "Total Pendapatan Servis";
            // 
            // LblAngkaTotalServis
            // 
            LblAngkaTotalServis.AutoSize = true;
            LblAngkaTotalServis.Location = new Point(87, 59);
            LblAngkaTotalServis.Name = "LblAngkaTotalServis";
            LblAngkaTotalServis.Size = new Size(13, 15);
            LblAngkaTotalServis.TabIndex = 9;
            LblAngkaTotalServis.Text = "0";
            LblAngkaTotalServis.Click += label3_Click;
            // 
            // LblAngkaPendapatan
            // 
            LblAngkaPendapatan.AutoSize = true;
            LblAngkaPendapatan.Location = new Point(89, 59);
            LblAngkaPendapatan.Name = "LblAngkaPendapatan";
            LblAngkaPendapatan.Size = new Size(13, 15);
            LblAngkaPendapatan.TabIndex = 10;
            LblAngkaPendapatan.Text = "0";
            // 
            // panel1
            // 
            panel1.Controls.Add(LblTotalSevis);
            panel1.Controls.Add(LblAngkaTotalServis);
            panel1.Location = new Point(16, 284);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.Controls.Add(LblTotalPendapatan);
            panel2.Controls.Add(LblAngkaPendapatan);
            panel2.Location = new Point(222, 284);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 12;
            // 
            // UcRiwayat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Label LblTotalSevis;
        private Label LblTotalPendapatan;
        private Label LblAngkaTotalServis;
        private Label LblAngkaPendapatan;
        private Panel panel1;
        private Panel panel2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}
