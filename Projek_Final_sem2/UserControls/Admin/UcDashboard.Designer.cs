namespace Projek_Final_sem2.UserControls
{
    partial class UcDashboard
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
            PanelDashboardAdmin = new Panel();
            PanelJudulAdmin = new Panel();
            LabelJudulRingkasanSistem = new Label();
            LabelJudul = new Label();
            PanelServisTerbaru = new Panel();
            BtnLihatSemua = new Button();
            DgvServisTerbaru = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            LbServisTerbaru = new Label();
            PanelBarangMenipis = new Panel();
            BtnLihatSem = new Button();
            DgvBarangStokMenipis = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            LbBarangMenipis = new Label();
            PanelPenjualan = new Panel();
            label1 = new Label();
            LbPenjualan = new Label();
            PanelPendapatan = new Panel();
            LbAngkaPendapatan = new Label();
            LbPendapatan = new Label();
            PanelServis = new Panel();
            LbAngkaServis = new Label();
            LbServis = new Label();
            PanelDataBarang = new Panel();
            LbAngkaBarang = new Label();
            LbDataBarang = new Label();
            LbJudulDashboardAdmin = new Label();
            PanelDashboardAdmin.SuspendLayout();
            PanelJudulAdmin.SuspendLayout();
            PanelServisTerbaru.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvServisTerbaru).BeginInit();
            PanelBarangMenipis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvBarangStokMenipis).BeginInit();
            PanelPenjualan.SuspendLayout();
            PanelPendapatan.SuspendLayout();
            PanelServis.SuspendLayout();
            PanelDataBarang.SuspendLayout();
            SuspendLayout();
            // 
            // PanelDashboardAdmin
            // 
            PanelDashboardAdmin.BackColor = Color.White;
            PanelDashboardAdmin.Controls.Add(PanelJudulAdmin);
            PanelDashboardAdmin.Controls.Add(PanelServisTerbaru);
            PanelDashboardAdmin.Controls.Add(PanelBarangMenipis);
            PanelDashboardAdmin.Controls.Add(PanelPenjualan);
            PanelDashboardAdmin.Controls.Add(PanelPendapatan);
            PanelDashboardAdmin.Controls.Add(PanelServis);
            PanelDashboardAdmin.Controls.Add(PanelDataBarang);
            PanelDashboardAdmin.Controls.Add(LbJudulDashboardAdmin);
            PanelDashboardAdmin.Dock = DockStyle.Fill;
            PanelDashboardAdmin.Location = new Point(0, 0);
            PanelDashboardAdmin.Margin = new Padding(1);
            PanelDashboardAdmin.Name = "PanelDashboardAdmin";
            PanelDashboardAdmin.Size = new Size(1050, 525);
            PanelDashboardAdmin.TabIndex = 2;
            // 
            // PanelJudulAdmin
            // 
            PanelJudulAdmin.BackColor = Color.FromArgb(192, 255, 192);
            PanelJudulAdmin.Controls.Add(LabelJudulRingkasanSistem);
            PanelJudulAdmin.Controls.Add(LabelJudul);
            PanelJudulAdmin.Location = new Point(6, 40);
            PanelJudulAdmin.Margin = new Padding(3, 2, 3, 2);
            PanelJudulAdmin.Name = "PanelJudulAdmin";
            PanelJudulAdmin.Size = new Size(1032, 94);
            PanelJudulAdmin.TabIndex = 8;
            // 
            // LabelJudulRingkasanSistem
            // 
            LabelJudulRingkasanSistem.AutoSize = true;
            LabelJudulRingkasanSistem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelJudulRingkasanSistem.Location = new Point(22, 49);
            LabelJudulRingkasanSistem.Name = "LabelJudulRingkasanSistem";
            LabelJudulRingkasanSistem.Size = new Size(296, 15);
            LabelJudulRingkasanSistem.TabIndex = 1;
            LabelJudulRingkasanSistem.Text = "Berikut adalah informasi ringkasan data pada sistem.";
            // 
            // LabelJudul
            // 
            LabelJudul.AutoSize = true;
            LabelJudul.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelJudul.ForeColor = Color.Green;
            LabelJudul.Location = new Point(22, 25);
            LabelJudul.Name = "LabelJudul";
            LabelJudul.Size = new Size(196, 21);
            LabelJudul.TabIndex = 0;
            LabelJudul.Text = "Selamat Datang, Admin!";
            // 
            // PanelServisTerbaru
            // 
            PanelServisTerbaru.Controls.Add(BtnLihatSemua);
            PanelServisTerbaru.Controls.Add(DgvServisTerbaru);
            PanelServisTerbaru.Controls.Add(LbServisTerbaru);
            PanelServisTerbaru.Location = new Point(529, 233);
            PanelServisTerbaru.Margin = new Padding(1);
            PanelServisTerbaru.Name = "PanelServisTerbaru";
            PanelServisTerbaru.Size = new Size(508, 291);
            PanelServisTerbaru.TabIndex = 7;
            // 
            // BtnLihatSemua
            // 
            BtnLihatSemua.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLihatSemua.Location = new Point(398, 269);
            BtnLihatSemua.Margin = new Padding(1);
            BtnLihatSemua.Name = "BtnLihatSemua";
            BtnLihatSemua.Size = new Size(106, 20);
            BtnLihatSemua.TabIndex = 3;
            BtnLihatSemua.Text = "Lihat Semua";
            BtnLihatSemua.UseVisualStyleBackColor = true;
            // 
            // DgvServisTerbaru
            // 
            DgvServisTerbaru.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvServisTerbaru.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvServisTerbaru.Columns.AddRange(new DataGridViewColumn[] { Column5, Column6, Column7 });
            DgvServisTerbaru.Location = new Point(0, 27);
            DgvServisTerbaru.Margin = new Padding(1);
            DgvServisTerbaru.Name = "DgvServisTerbaru";
            DgvServisTerbaru.RowHeadersWidth = 62;
            DgvServisTerbaru.ScrollBars = ScrollBars.None;
            DgvServisTerbaru.Size = new Size(505, 241);
            DgvServisTerbaru.TabIndex = 2;
            // 
            // Column5
            // 
            Column5.HeaderText = "No";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Pelanggan";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Status";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            // 
            // LbServisTerbaru
            // 
            LbServisTerbaru.AutoSize = true;
            LbServisTerbaru.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbServisTerbaru.Location = new Point(4, 4);
            LbServisTerbaru.Margin = new Padding(1, 0, 1, 0);
            LbServisTerbaru.Name = "LbServisTerbaru";
            LbServisTerbaru.Size = new Size(94, 19);
            LbServisTerbaru.TabIndex = 1;
            LbServisTerbaru.Text = "Servis Terbaru";
            // 
            // PanelBarangMenipis
            // 
            PanelBarangMenipis.Controls.Add(BtnLihatSem);
            PanelBarangMenipis.Controls.Add(DgvBarangStokMenipis);
            PanelBarangMenipis.Controls.Add(LbBarangMenipis);
            PanelBarangMenipis.Location = new Point(6, 233);
            PanelBarangMenipis.Margin = new Padding(1);
            PanelBarangMenipis.Name = "PanelBarangMenipis";
            PanelBarangMenipis.Size = new Size(521, 291);
            PanelBarangMenipis.TabIndex = 6;
            // 
            // BtnLihatSem
            // 
            BtnLihatSem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLihatSem.Location = new Point(412, 269);
            BtnLihatSem.Margin = new Padding(1);
            BtnLihatSem.Name = "BtnLihatSem";
            BtnLihatSem.Size = new Size(106, 20);
            BtnLihatSem.TabIndex = 2;
            BtnLihatSem.Text = "Lihat Semua";
            BtnLihatSem.UseVisualStyleBackColor = true;
            // 
            // DgvBarangStokMenipis
            // 
            DgvBarangStokMenipis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvBarangStokMenipis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvBarangStokMenipis.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column4 });
            DgvBarangStokMenipis.Location = new Point(3, 25);
            DgvBarangStokMenipis.Margin = new Padding(1);
            DgvBarangStokMenipis.Name = "DgvBarangStokMenipis";
            DgvBarangStokMenipis.RowHeadersWidth = 62;
            DgvBarangStokMenipis.Size = new Size(515, 243);
            DgvBarangStokMenipis.TabIndex = 1;
            DgvBarangStokMenipis.CellContentClick += DgvBarangStokMenipis_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "No";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nama";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            // 
            // Column4
            // 
            Column4.HeaderText = "Stok";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            // 
            // LbBarangMenipis
            // 
            LbBarangMenipis.AutoSize = true;
            LbBarangMenipis.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbBarangMenipis.Location = new Point(3, 4);
            LbBarangMenipis.Margin = new Padding(1, 0, 1, 0);
            LbBarangMenipis.Name = "LbBarangMenipis";
            LbBarangMenipis.Size = new Size(135, 19);
            LbBarangMenipis.TabIndex = 0;
            LbBarangMenipis.Text = "Barang Stok Menipis";
            // 
            // PanelPenjualan
            // 
            PanelPenjualan.BackColor = Color.GreenYellow;
            PanelPenjualan.Controls.Add(label1);
            PanelPenjualan.Controls.Add(LbPenjualan);
            PanelPenjualan.Location = new Point(214, 137);
            PanelPenjualan.Margin = new Padding(1);
            PanelPenjualan.Name = "PanelPenjualan";
            PanelPenjualan.Size = new Size(216, 88);
            PanelPenjualan.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(96, 38);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 3;
            label1.Text = "0";
            // 
            // LbPenjualan
            // 
            LbPenjualan.AutoSize = true;
            LbPenjualan.ForeColor = Color.White;
            LbPenjualan.Location = new Point(78, 11);
            LbPenjualan.Margin = new Padding(1, 0, 1, 0);
            LbPenjualan.Name = "LbPenjualan";
            LbPenjualan.Size = new Size(59, 15);
            LbPenjualan.TabIndex = 0;
            LbPenjualan.Text = "Penjualan";
            // 
            // PanelPendapatan
            // 
            PanelPendapatan.BackColor = Color.Fuchsia;
            PanelPendapatan.Controls.Add(LbAngkaPendapatan);
            PanelPendapatan.Controls.Add(LbPendapatan);
            PanelPendapatan.Location = new Point(676, 137);
            PanelPendapatan.Margin = new Padding(1);
            PanelPendapatan.Name = "PanelPendapatan";
            PanelPendapatan.Size = new Size(227, 88);
            PanelPendapatan.TabIndex = 5;
            // 
            // LbAngkaPendapatan
            // 
            LbAngkaPendapatan.AutoSize = true;
            LbAngkaPendapatan.ForeColor = Color.White;
            LbAngkaPendapatan.Location = new Point(98, 38);
            LbAngkaPendapatan.Margin = new Padding(1, 0, 1, 0);
            LbAngkaPendapatan.Name = "LbAngkaPendapatan";
            LbAngkaPendapatan.Size = new Size(13, 15);
            LbAngkaPendapatan.TabIndex = 4;
            LbAngkaPendapatan.Text = "0";
            // 
            // LbPendapatan
            // 
            LbPendapatan.AutoSize = true;
            LbPendapatan.ForeColor = Color.White;
            LbPendapatan.Location = new Point(76, 11);
            LbPendapatan.Margin = new Padding(1, 0, 1, 0);
            LbPendapatan.Name = "LbPendapatan";
            LbPendapatan.Size = new Size(70, 15);
            LbPendapatan.TabIndex = 0;
            LbPendapatan.Text = "Pendapatan";
            // 
            // PanelServis
            // 
            PanelServis.BackColor = Color.Orange;
            PanelServis.Controls.Add(LbAngkaServis);
            PanelServis.Controls.Add(LbServis);
            PanelServis.Location = new Point(444, 137);
            PanelServis.Margin = new Padding(1);
            PanelServis.Name = "PanelServis";
            PanelServis.Size = new Size(223, 88);
            PanelServis.TabIndex = 4;
            // 
            // LbAngkaServis
            // 
            LbAngkaServis.AutoSize = true;
            LbAngkaServis.ForeColor = Color.White;
            LbAngkaServis.Location = new Point(99, 38);
            LbAngkaServis.Margin = new Padding(1, 0, 1, 0);
            LbAngkaServis.Name = "LbAngkaServis";
            LbAngkaServis.Size = new Size(13, 15);
            LbAngkaServis.TabIndex = 3;
            LbAngkaServis.Text = "0";
            // 
            // LbServis
            // 
            LbServis.AutoSize = true;
            LbServis.ForeColor = Color.White;
            LbServis.Location = new Point(88, 11);
            LbServis.Margin = new Padding(1, 0, 1, 0);
            LbServis.Name = "LbServis";
            LbServis.Size = new Size(37, 15);
            LbServis.TabIndex = 0;
            LbServis.Text = "Servis";
            // 
            // PanelDataBarang
            // 
            PanelDataBarang.BackColor = Color.DodgerBlue;
            PanelDataBarang.Controls.Add(LbAngkaBarang);
            PanelDataBarang.Controls.Add(LbDataBarang);
            PanelDataBarang.Location = new Point(8, 137);
            PanelDataBarang.Margin = new Padding(1);
            PanelDataBarang.Name = "PanelDataBarang";
            PanelDataBarang.Size = new Size(202, 88);
            PanelDataBarang.TabIndex = 2;
            // 
            // LbAngkaBarang
            // 
            LbAngkaBarang.AutoSize = true;
            LbAngkaBarang.ForeColor = Color.White;
            LbAngkaBarang.Location = new Point(90, 38);
            LbAngkaBarang.Margin = new Padding(1, 0, 1, 0);
            LbAngkaBarang.Name = "LbAngkaBarang";
            LbAngkaBarang.Size = new Size(13, 15);
            LbAngkaBarang.TabIndex = 1;
            LbAngkaBarang.Text = "0";
            LbAngkaBarang.Click += LbAngkaBarang_Click;
            // 
            // LbDataBarang
            // 
            LbDataBarang.AutoSize = true;
            LbDataBarang.ForeColor = Color.White;
            LbDataBarang.Location = new Point(60, 11);
            LbDataBarang.Margin = new Padding(1, 0, 1, 0);
            LbDataBarang.Name = "LbDataBarang";
            LbDataBarang.Size = new Size(71, 15);
            LbDataBarang.TabIndex = 0;
            LbDataBarang.Text = "Data Barang";
            // 
            // LbJudulDashboardAdmin
            // 
            LbJudulDashboardAdmin.AutoSize = true;
            LbJudulDashboardAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbJudulDashboardAdmin.Location = new Point(27, 5);
            LbJudulDashboardAdmin.Margin = new Padding(1, 0, 1, 0);
            LbJudulDashboardAdmin.Name = "LbJudulDashboardAdmin";
            LbJudulDashboardAdmin.Size = new Size(93, 21);
            LbJudulDashboardAdmin.TabIndex = 0;
            LbJudulDashboardAdmin.Text = "Dashboard";
            // 
            // UcDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(PanelDashboardAdmin);
            Margin = new Padding(1);
            Name = "UcDashboard";
            Size = new Size(1050, 525);
            Load += UcDashboard_Load;
            PanelDashboardAdmin.ResumeLayout(false);
            PanelDashboardAdmin.PerformLayout();
            PanelJudulAdmin.ResumeLayout(false);
            PanelJudulAdmin.PerformLayout();
            PanelServisTerbaru.ResumeLayout(false);
            PanelServisTerbaru.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvServisTerbaru).EndInit();
            PanelBarangMenipis.ResumeLayout(false);
            PanelBarangMenipis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvBarangStokMenipis).EndInit();
            PanelPenjualan.ResumeLayout(false);
            PanelPenjualan.PerformLayout();
            PanelPendapatan.ResumeLayout(false);
            PanelPendapatan.PerformLayout();
            PanelServis.ResumeLayout(false);
            PanelServis.PerformLayout();
            PanelDataBarang.ResumeLayout(false);
            PanelDataBarang.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelDashboardAdmin;
        private Panel PanelServisTerbaru;
        private Button BtnLihatSemua;
        private DataGridView DgvServisTerbaru;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Label LbServisTerbaru;
        private Panel PanelBarangMenipis;
        private Button BtnLihatSem;
        private DataGridView DgvBarangStokMenipis;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private Label LbBarangMenipis;
        private Panel PanelPenjualan;
        private Label label1;
        private Label LbPenjualan;
        private Panel PanelPendapatan;
        private Label LbAngkaPendapatan;
        private Label LbPendapatan;
        private Panel PanelServis;
        private Label LbAngkaServis;
        private Label LbServis;
        private Panel PanelDataBarang;
        private Label LbAngkaBarang;
        private Label LbDataBarang;
        private Label LbJudulDashboardAdmin;
        private Panel PanelJudulAdmin;
        private Label LabelJudul;
        private Label LabelJudulRingkasanSistem;
    }
}
