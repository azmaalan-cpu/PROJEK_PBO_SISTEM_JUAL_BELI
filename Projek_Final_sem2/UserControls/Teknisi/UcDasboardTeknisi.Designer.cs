namespace Projek_Final_sem2.UserControls.Teknisi
{
    partial class UcDasboardTeknisi
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
            LbSelamatDatangAdmin = new Label();
            LbJudulDashboardAdmin = new Label();
            PanelPenjualan = new Panel();
            LbAngkaProsesServis = new Label();
            LbProsesServis = new Label();
            PanelPendapatan = new Panel();
            LbAngkaMenunggu = new Label();
            LbMenungguServis = new Label();
            PanelServis = new Panel();
            LbAngkaSelesai = new Label();
            LbSelesai = new Label();
            PanelDataBarang = new Panel();
            LbAngkaTotalServis = new Label();
            LbTotalServis = new Label();
            panel1 = new Panel();
            DgvServisTerbaru = new DataGridView();
            Column_no_servis = new DataGridViewTextBoxColumn();
            Column_Id_servis = new DataGridViewTextBoxColumn();
            Column_tanggal_servis = new DataGridViewTextBoxColumn();
            Column_nama_alat = new DataGridViewTextBoxColumn();
            Column_kerusakan_servis = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Label_servis_serbaru = new Label();
            PanelPenjualan.SuspendLayout();
            PanelPendapatan.SuspendLayout();
            PanelServis.SuspendLayout();
            PanelDataBarang.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvServisTerbaru).BeginInit();
            SuspendLayout();
            // 
            // LbSelamatDatangAdmin
            // 
            LbSelamatDatangAdmin.AutoSize = true;
            LbSelamatDatangAdmin.Location = new Point(2, 29);
            LbSelamatDatangAdmin.Margin = new Padding(2, 0, 2, 0);
            LbSelamatDatangAdmin.Name = "LbSelamatDatangAdmin";
            LbSelamatDatangAdmin.Size = new Size(135, 15);
            LbSelamatDatangAdmin.TabIndex = 3;
            LbSelamatDatangAdmin.Text = "Selamat Datang, Teknisi!";
            LbSelamatDatangAdmin.Click += LbSelamatDatangAdmin_Click;
            // 
            // LbJudulDashboardAdmin
            // 
            LbJudulDashboardAdmin.AutoSize = true;
            LbJudulDashboardAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbJudulDashboardAdmin.Location = new Point(2, 8);
            LbJudulDashboardAdmin.Margin = new Padding(2, 0, 2, 0);
            LbJudulDashboardAdmin.Name = "LbJudulDashboardAdmin";
            LbJudulDashboardAdmin.Size = new Size(93, 21);
            LbJudulDashboardAdmin.TabIndex = 2;
            LbJudulDashboardAdmin.Text = "Dashboard";
            // 
            // PanelPenjualan
            // 
            PanelPenjualan.BackColor = Color.GreenYellow;
            PanelPenjualan.Controls.Add(LbAngkaProsesServis);
            PanelPenjualan.Controls.Add(LbProsesServis);
            PanelPenjualan.Location = new Point(141, 46);
            PanelPenjualan.Margin = new Padding(2);
            PanelPenjualan.Name = "PanelPenjualan";
            PanelPenjualan.Size = new Size(119, 78);
            PanelPenjualan.TabIndex = 8;
            PanelPenjualan.Paint += PanelPenjualan_Paint;
            // 
            // LbAngkaProsesServis
            // 
            LbAngkaProsesServis.AutoSize = true;
            LbAngkaProsesServis.Font = new Font("Segoe UI", 12F);
            LbAngkaProsesServis.ForeColor = Color.White;
            LbAngkaProsesServis.Location = new Point(47, 39);
            LbAngkaProsesServis.Margin = new Padding(2, 0, 2, 0);
            LbAngkaProsesServis.Name = "LbAngkaProsesServis";
            LbAngkaProsesServis.Size = new Size(19, 21);
            LbAngkaProsesServis.TabIndex = 3;
            LbAngkaProsesServis.Text = "0";
            // 
            // LbProsesServis
            // 
            LbProsesServis.AutoSize = true;
            LbProsesServis.Font = new Font("Segoe UI", 12F);
            LbProsesServis.ForeColor = Color.White;
            LbProsesServis.Location = new Point(30, 14);
            LbProsesServis.Margin = new Padding(2, 0, 2, 0);
            LbProsesServis.Name = "LbProsesServis";
            LbProsesServis.Size = new Size(56, 21);
            LbProsesServis.TabIndex = 0;
            LbProsesServis.Text = "Proses";
            LbProsesServis.Click += LbPenjualan_Click;
            // 
            // PanelPendapatan
            // 
            PanelPendapatan.BackColor = Color.Fuchsia;
            PanelPendapatan.Controls.Add(LbAngkaMenunggu);
            PanelPendapatan.Controls.Add(LbMenungguServis);
            PanelPendapatan.Location = new Point(408, 46);
            PanelPendapatan.Margin = new Padding(2);
            PanelPendapatan.Name = "PanelPendapatan";
            PanelPendapatan.Size = new Size(126, 78);
            PanelPendapatan.TabIndex = 9;
            // 
            // LbAngkaMenunggu
            // 
            LbAngkaMenunggu.AutoSize = true;
            LbAngkaMenunggu.Font = new Font("Segoe UI", 12F);
            LbAngkaMenunggu.ForeColor = Color.White;
            LbAngkaMenunggu.Location = new Point(56, 39);
            LbAngkaMenunggu.Margin = new Padding(2, 0, 2, 0);
            LbAngkaMenunggu.Name = "LbAngkaMenunggu";
            LbAngkaMenunggu.Size = new Size(19, 21);
            LbAngkaMenunggu.TabIndex = 4;
            LbAngkaMenunggu.Text = "0";
            // 
            // LbMenungguServis
            // 
            LbMenungguServis.AutoSize = true;
            LbMenungguServis.Font = new Font("Segoe UI", 12F);
            LbMenungguServis.ForeColor = Color.White;
            LbMenungguServis.Location = new Point(23, 14);
            LbMenungguServis.Margin = new Padding(2, 0, 2, 0);
            LbMenungguServis.Name = "LbMenungguServis";
            LbMenungguServis.Size = new Size(86, 21);
            LbMenungguServis.TabIndex = 0;
            LbMenungguServis.Text = "Menunggu";
            // 
            // PanelServis
            // 
            PanelServis.BackColor = Color.Orange;
            PanelServis.Controls.Add(LbAngkaSelesai);
            PanelServis.Controls.Add(LbSelesai);
            PanelServis.Font = new Font("Segoe UI", 12F);
            PanelServis.Location = new Point(273, 46);
            PanelServis.Margin = new Padding(2);
            PanelServis.Name = "PanelServis";
            PanelServis.Size = new Size(122, 78);
            PanelServis.TabIndex = 7;
            // 
            // LbAngkaSelesai
            // 
            LbAngkaSelesai.AutoSize = true;
            LbAngkaSelesai.Font = new Font("Segoe UI", 12F);
            LbAngkaSelesai.ForeColor = Color.White;
            LbAngkaSelesai.Location = new Point(50, 39);
            LbAngkaSelesai.Margin = new Padding(2, 0, 2, 0);
            LbAngkaSelesai.Name = "LbAngkaSelesai";
            LbAngkaSelesai.Size = new Size(19, 21);
            LbAngkaSelesai.TabIndex = 3;
            LbAngkaSelesai.Text = "0";
            // 
            // LbSelesai
            // 
            LbSelesai.AutoSize = true;
            LbSelesai.Font = new Font("Segoe UI", 12F);
            LbSelesai.ForeColor = Color.White;
            LbSelesai.Location = new Point(32, 14);
            LbSelesai.Margin = new Padding(2, 0, 2, 0);
            LbSelesai.Name = "LbSelesai";
            LbSelesai.Size = new Size(58, 21);
            LbSelesai.TabIndex = 0;
            LbSelesai.Text = "Selesai";
            LbSelesai.Click += LbServis_Click;
            // 
            // PanelDataBarang
            // 
            PanelDataBarang.BackColor = Color.DodgerBlue;
            PanelDataBarang.Controls.Add(LbAngkaTotalServis);
            PanelDataBarang.Controls.Add(LbTotalServis);
            PanelDataBarang.Font = new Font("Segoe UI", 12F);
            PanelDataBarang.Location = new Point(2, 46);
            PanelDataBarang.Margin = new Padding(2);
            PanelDataBarang.Name = "PanelDataBarang";
            PanelDataBarang.Size = new Size(122, 78);
            PanelDataBarang.TabIndex = 6;
            // 
            // LbAngkaTotalServis
            // 
            LbAngkaTotalServis.AutoSize = true;
            LbAngkaTotalServis.Font = new Font("Segoe UI", 12F);
            LbAngkaTotalServis.ForeColor = Color.White;
            LbAngkaTotalServis.Location = new Point(45, 39);
            LbAngkaTotalServis.Margin = new Padding(2, 0, 2, 0);
            LbAngkaTotalServis.Name = "LbAngkaTotalServis";
            LbAngkaTotalServis.Size = new Size(19, 21);
            LbAngkaTotalServis.TabIndex = 1;
            LbAngkaTotalServis.Text = "0";
            // 
            // LbTotalServis
            // 
            LbTotalServis.AutoSize = true;
            LbTotalServis.Font = new Font("Segoe UI", 12F);
            LbTotalServis.ForeColor = Color.White;
            LbTotalServis.Location = new Point(12, 14);
            LbTotalServis.Margin = new Padding(2, 0, 2, 0);
            LbTotalServis.Name = "LbTotalServis";
            LbTotalServis.Size = new Size(88, 21);
            LbTotalServis.TabIndex = 0;
            LbTotalServis.Text = "Total Servis";
            LbTotalServis.Click += LbDataBarang_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(DgvServisTerbaru);
            panel1.Location = new Point(3, 161);
            panel1.Name = "panel1";
            panel1.Size = new Size(531, 177);
            panel1.TabIndex = 10;
            // 
            // DgvServisTerbaru
            // 
            DgvServisTerbaru.AllowUserToOrderColumns = true;
            DgvServisTerbaru.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvServisTerbaru.Columns.AddRange(new DataGridViewColumn[] { Column_no_servis, Column_Id_servis, Column_tanggal_servis, Column_nama_alat, Column_kerusakan_servis, Status });
            DgvServisTerbaru.Location = new Point(3, 13);
            DgvServisTerbaru.Name = "DgvServisTerbaru";
            DgvServisTerbaru.Size = new Size(516, 150);
            DgvServisTerbaru.TabIndex = 0;
            DgvServisTerbaru.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column_no_servis
            // 
            Column_no_servis.HeaderText = "No.";
            Column_no_servis.Name = "Column_no_servis";
            Column_no_servis.Width = 30;
            // 
            // Column_Id_servis
            // 
            Column_Id_servis.HeaderText = "ID Servis";
            Column_Id_servis.Name = "Column_Id_servis";
            Column_Id_servis.Width = 50;
            // 
            // Column_tanggal_servis
            // 
            Column_tanggal_servis.HeaderText = "Tanggal";
            Column_tanggal_servis.Name = "Column_tanggal_servis";
            Column_tanggal_servis.Width = 70;
            // 
            // Column_nama_alat
            // 
            Column_nama_alat.HeaderText = "Nama Alat";
            Column_nama_alat.Name = "Column_nama_alat";
            Column_nama_alat.Width = 120;
            // 
            // Column_kerusakan_servis
            // 
            Column_kerusakan_servis.HeaderText = "Kerusakan";
            Column_kerusakan_servis.Name = "Column_kerusakan_servis";
            Column_kerusakan_servis.Width = 110;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // Label_servis_serbaru
            // 
            Label_servis_serbaru.AutoSize = true;
            Label_servis_serbaru.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_servis_serbaru.Location = new Point(7, 135);
            Label_servis_serbaru.Name = "Label_servis_serbaru";
            Label_servis_serbaru.Size = new Size(123, 21);
            Label_servis_serbaru.TabIndex = 11;
            Label_servis_serbaru.Text = "Servis Terbaru";
            // 
            // UcDasboardTeknisi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Label_servis_serbaru);
            Controls.Add(panel1);
            Controls.Add(PanelPenjualan);
            Controls.Add(PanelPendapatan);
            Controls.Add(PanelServis);
            Controls.Add(PanelDataBarang);
            Controls.Add(LbSelamatDatangAdmin);
            Controls.Add(LbJudulDashboardAdmin);
            Name = "UcDasboardTeknisi";
            Size = new Size(544, 350);
            PanelPenjualan.ResumeLayout(false);
            PanelPenjualan.PerformLayout();
            PanelPendapatan.ResumeLayout(false);
            PanelPendapatan.PerformLayout();
            PanelServis.ResumeLayout(false);
            PanelServis.PerformLayout();
            PanelDataBarang.ResumeLayout(false);
            PanelDataBarang.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvServisTerbaru).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbSelamatDatangAdmin;
        private Label LbJudulDashboardAdmin;
        private Panel PanelPenjualan;
        private Label LbAngkaProsesServis;
        private Label LbProsesServis;
        private Panel PanelPendapatan;
        private Label LbAngkaMenunggu;
        private Label LbMenungguServis;
        private Panel PanelServis;
        private Label LbAngkaSelesai;
        private Label LbSelesai;
        private Panel PanelDataBarang;
        private Label LbAngkaTotalServis;
        private Label LbTotalServis;
        private Panel panel1;
        private DataGridView DgvServisTerbaru;
        private DataGridViewTextBoxColumn Column_no_servis;
        private DataGridViewTextBoxColumn Column_Id_servis;
        private DataGridViewTextBoxColumn Column_tanggal_servis;
        private DataGridViewTextBoxColumn Column_nama_alat;
        private DataGridViewTextBoxColumn Column_kerusakan_servis;
        private DataGridViewTextBoxColumn Status;
        private Label Label_servis_serbaru;
    }
}
