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
            LbAngkaPenjualan = new Label();
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
            PanelDashboardAdmin.Margin = new Padding(1, 2, 1, 2);
            PanelDashboardAdmin.Name = "PanelDashboardAdmin";
            PanelDashboardAdmin.Size = new Size(1500, 875);
            PanelDashboardAdmin.TabIndex = 2;
            // 
            // PanelJudulAdmin
            // 
            PanelJudulAdmin.BackColor = Color.FromArgb(192, 255, 192);
            PanelJudulAdmin.Controls.Add(LabelJudulRingkasanSistem);
            PanelJudulAdmin.Controls.Add(LabelJudul);
            PanelJudulAdmin.Location = new Point(9, 67);
            PanelJudulAdmin.Margin = new Padding(4, 3, 4, 3);
            PanelJudulAdmin.Name = "PanelJudulAdmin";
            PanelJudulAdmin.Size = new Size(1474, 157);
            PanelJudulAdmin.TabIndex = 8;
            // 
            // LabelJudulRingkasanSistem
            // 
            LabelJudulRingkasanSistem.AutoSize = true;
            LabelJudulRingkasanSistem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelJudulRingkasanSistem.Location = new Point(31, 82);
            LabelJudulRingkasanSistem.Margin = new Padding(4, 0, 4, 0);
            LabelJudulRingkasanSistem.Name = "LabelJudulRingkasanSistem";
            LabelJudulRingkasanSistem.Size = new Size(463, 25);
            LabelJudulRingkasanSistem.TabIndex = 1;
            LabelJudulRingkasanSistem.Text = "Berikut adalah informasi ringkasan data pada sistem.";
            // 
            // LabelJudul
            // 
            LabelJudul.AutoSize = true;
            LabelJudul.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelJudul.ForeColor = Color.Green;
            LabelJudul.Location = new Point(31, 42);
            LabelJudul.Margin = new Padding(4, 0, 4, 0);
            LabelJudul.Name = "LabelJudul";
            LabelJudul.Size = new Size(292, 32);
            LabelJudul.TabIndex = 0;
            LabelJudul.Text = "Selamat Datang, Admin!";
            // 
            // PanelServisTerbaru
            // 
            PanelServisTerbaru.Controls.Add(BtnLihatSemua);
            PanelServisTerbaru.Controls.Add(DgvServisTerbaru);
            PanelServisTerbaru.Controls.Add(LbServisTerbaru);
            PanelServisTerbaru.Location = new Point(756, 388);
            PanelServisTerbaru.Margin = new Padding(1, 2, 1, 2);
            PanelServisTerbaru.Name = "PanelServisTerbaru";
            PanelServisTerbaru.Size = new Size(726, 485);
            PanelServisTerbaru.TabIndex = 7;
            // 
            // BtnLihatSemua
            // 
            BtnLihatSemua.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLihatSemua.Location = new Point(569, 448);
            BtnLihatSemua.Margin = new Padding(1, 2, 1, 2);
            BtnLihatSemua.Name = "BtnLihatSemua";
            BtnLihatSemua.Size = new Size(151, 33);
            BtnLihatSemua.TabIndex = 3;
            BtnLihatSemua.Text = "Lihat Semua";
            BtnLihatSemua.UseVisualStyleBackColor = true;
            // 
            // DgvServisTerbaru
            // 
            DgvServisTerbaru.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvServisTerbaru.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvServisTerbaru.Columns.AddRange(new DataGridViewColumn[] { Column5, Column6, Column7 });
            DgvServisTerbaru.Location = new Point(0, 45);
            DgvServisTerbaru.Margin = new Padding(1, 2, 1, 2);
            DgvServisTerbaru.Name = "DgvServisTerbaru";
            DgvServisTerbaru.RowHeadersWidth = 62;
            DgvServisTerbaru.ScrollBars = ScrollBars.None;
            DgvServisTerbaru.Size = new Size(721, 402);
            DgvServisTerbaru.TabIndex = 2;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "id_servis";
            Column5.HeaderText = "No";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.DataPropertyName = "nama_alat";
            Column6.HeaderText = "Nama Barang";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.DataPropertyName = "status_servis";
            Column7.HeaderText = "Status";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            // 
            // LbServisTerbaru
            // 
            LbServisTerbaru.AutoSize = true;
            LbServisTerbaru.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbServisTerbaru.Location = new Point(6, 7);
            LbServisTerbaru.Margin = new Padding(1, 0, 1, 0);
            LbServisTerbaru.Name = "LbServisTerbaru";
            LbServisTerbaru.Size = new Size(141, 30);
            LbServisTerbaru.TabIndex = 1;
            LbServisTerbaru.Text = "Servis Terbaru";
            // 
            // PanelBarangMenipis
            // 
            PanelBarangMenipis.Controls.Add(BtnLihatSem);
            PanelBarangMenipis.Controls.Add(DgvBarangStokMenipis);
            PanelBarangMenipis.Controls.Add(LbBarangMenipis);
            PanelBarangMenipis.Location = new Point(9, 388);
            PanelBarangMenipis.Margin = new Padding(1, 2, 1, 2);
            PanelBarangMenipis.Name = "PanelBarangMenipis";
            PanelBarangMenipis.Size = new Size(744, 485);
            PanelBarangMenipis.TabIndex = 6;
            // 
            // BtnLihatSem
            // 
            BtnLihatSem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLihatSem.Location = new Point(589, 448);
            BtnLihatSem.Margin = new Padding(1, 2, 1, 2);
            BtnLihatSem.Name = "BtnLihatSem";
            BtnLihatSem.Size = new Size(151, 33);
            BtnLihatSem.TabIndex = 2;
            BtnLihatSem.Text = "Lihat Semua";
            BtnLihatSem.UseVisualStyleBackColor = true;
            // 
            // DgvBarangStokMenipis
            // 
            DgvBarangStokMenipis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvBarangStokMenipis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvBarangStokMenipis.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column4 });
            DgvBarangStokMenipis.Location = new Point(4, 42);
            DgvBarangStokMenipis.Margin = new Padding(1, 2, 1, 2);
            DgvBarangStokMenipis.Name = "DgvBarangStokMenipis";
            DgvBarangStokMenipis.RowHeadersWidth = 62;
            DgvBarangStokMenipis.Size = new Size(736, 405);
            DgvBarangStokMenipis.TabIndex = 1;
            DgvBarangStokMenipis.CellDoubleClick += DgvBarangStokMenipis_CellDoubleClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "id_barang";
            Column1.HeaderText = "No";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "nama_alat";
            Column2.HeaderText = "Nama Barang";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "stok";
            Column4.HeaderText = "Stok";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            // 
            // LbBarangMenipis
            // 
            LbBarangMenipis.AutoSize = true;
            LbBarangMenipis.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbBarangMenipis.Location = new Point(4, 7);
            LbBarangMenipis.Margin = new Padding(1, 0, 1, 0);
            LbBarangMenipis.Name = "LbBarangMenipis";
            LbBarangMenipis.Size = new Size(202, 30);
            LbBarangMenipis.TabIndex = 0;
            LbBarangMenipis.Text = "Barang Stok Menipis";
            // 
            // PanelPenjualan
            // 
            PanelPenjualan.BackColor = Color.GreenYellow;
            PanelPenjualan.Controls.Add(LbAngkaPenjualan);
            PanelPenjualan.Controls.Add(LbPenjualan);
            PanelPenjualan.Location = new Point(306, 228);
            PanelPenjualan.Margin = new Padding(1, 2, 1, 2);
            PanelPenjualan.Name = "PanelPenjualan";
            PanelPenjualan.Size = new Size(309, 147);
            PanelPenjualan.TabIndex = 5;
            // 
            // LbAngkaPenjualan
            // 
            LbAngkaPenjualan.AutoSize = true;
            LbAngkaPenjualan.ForeColor = Color.White;
            LbAngkaPenjualan.Location = new Point(137, 63);
            LbAngkaPenjualan.Margin = new Padding(1, 0, 1, 0);
            LbAngkaPenjualan.Name = "LbAngkaPenjualan";
            LbAngkaPenjualan.Size = new Size(22, 25);
            LbAngkaPenjualan.TabIndex = 3;
            LbAngkaPenjualan.Text = "0";
            // 
            // LbPenjualan
            // 
            LbPenjualan.AutoSize = true;
            LbPenjualan.ForeColor = Color.White;
            LbPenjualan.Location = new Point(111, 18);
            LbPenjualan.Margin = new Padding(1, 0, 1, 0);
            LbPenjualan.Name = "LbPenjualan";
            LbPenjualan.Size = new Size(86, 25);
            LbPenjualan.TabIndex = 0;
            LbPenjualan.Text = "Penjualan";
            // 
            // PanelPendapatan
            // 
            PanelPendapatan.BackColor = Color.Fuchsia;
            PanelPendapatan.Controls.Add(LbAngkaPendapatan);
            PanelPendapatan.Controls.Add(LbPendapatan);
            PanelPendapatan.Location = new Point(966, 228);
            PanelPendapatan.Margin = new Padding(1, 2, 1, 2);
            PanelPendapatan.Name = "PanelPendapatan";
            PanelPendapatan.Size = new Size(324, 147);
            PanelPendapatan.TabIndex = 5;
            // 
            // LbAngkaPendapatan
            // 
            LbAngkaPendapatan.AutoSize = true;
            LbAngkaPendapatan.ForeColor = Color.White;
            LbAngkaPendapatan.Location = new Point(125, 63);
            LbAngkaPendapatan.Margin = new Padding(1, 0, 1, 0);
            LbAngkaPendapatan.Name = "LbAngkaPendapatan";
            LbAngkaPendapatan.Size = new Size(22, 25);
            LbAngkaPendapatan.TabIndex = 4;
            LbAngkaPendapatan.Text = "0";
            // 
            // LbPendapatan
            // 
            LbPendapatan.AutoSize = true;
            LbPendapatan.ForeColor = Color.White;
            LbPendapatan.Location = new Point(104, 18);
            LbPendapatan.Margin = new Padding(1, 0, 1, 0);
            LbPendapatan.Name = "LbPendapatan";
            LbPendapatan.Size = new Size(105, 25);
            LbPendapatan.TabIndex = 0;
            LbPendapatan.Text = "Pendapatan";
            // 
            // PanelServis
            // 
            PanelServis.BackColor = Color.Orange;
            PanelServis.Controls.Add(LbAngkaServis);
            PanelServis.Controls.Add(LbServis);
            PanelServis.Location = new Point(634, 228);
            PanelServis.Margin = new Padding(1, 2, 1, 2);
            PanelServis.Name = "PanelServis";
            PanelServis.Size = new Size(319, 147);
            PanelServis.TabIndex = 4;
            // 
            // LbAngkaServis
            // 
            LbAngkaServis.AutoSize = true;
            LbAngkaServis.ForeColor = Color.White;
            LbAngkaServis.Location = new Point(141, 63);
            LbAngkaServis.Margin = new Padding(1, 0, 1, 0);
            LbAngkaServis.Name = "LbAngkaServis";
            LbAngkaServis.Size = new Size(22, 25);
            LbAngkaServis.TabIndex = 3;
            LbAngkaServis.Text = "0";
            // 
            // LbServis
            // 
            LbServis.AutoSize = true;
            LbServis.ForeColor = Color.White;
            LbServis.Location = new Point(126, 18);
            LbServis.Margin = new Padding(1, 0, 1, 0);
            LbServis.Name = "LbServis";
            LbServis.Size = new Size(58, 25);
            LbServis.TabIndex = 0;
            LbServis.Text = "Servis";
            // 
            // PanelDataBarang
            // 
            PanelDataBarang.BackColor = Color.DodgerBlue;
            PanelDataBarang.Controls.Add(LbAngkaBarang);
            PanelDataBarang.Controls.Add(LbDataBarang);
            PanelDataBarang.Location = new Point(11, 228);
            PanelDataBarang.Margin = new Padding(1, 2, 1, 2);
            PanelDataBarang.Name = "PanelDataBarang";
            PanelDataBarang.Size = new Size(289, 147);
            PanelDataBarang.TabIndex = 2;
            // 
            // LbAngkaBarang
            // 
            LbAngkaBarang.AutoSize = true;
            LbAngkaBarang.ForeColor = Color.White;
            LbAngkaBarang.Location = new Point(129, 63);
            LbAngkaBarang.Margin = new Padding(1, 0, 1, 0);
            LbAngkaBarang.Name = "LbAngkaBarang";
            LbAngkaBarang.Size = new Size(22, 25);
            LbAngkaBarang.TabIndex = 1;
            LbAngkaBarang.Text = "0";
            LbAngkaBarang.Click += LbAngkaBarang_Click;
            // 
            // LbDataBarang
            // 
            LbDataBarang.AutoSize = true;
            LbDataBarang.ForeColor = Color.White;
            LbDataBarang.Location = new Point(86, 18);
            LbDataBarang.Margin = new Padding(1, 0, 1, 0);
            LbDataBarang.Name = "LbDataBarang";
            LbDataBarang.Size = new Size(109, 25);
            LbDataBarang.TabIndex = 0;
            LbDataBarang.Text = "Data Barang";
            // 
            // LbJudulDashboardAdmin
            // 
            LbJudulDashboardAdmin.AutoSize = true;
            LbJudulDashboardAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbJudulDashboardAdmin.Location = new Point(39, 8);
            LbJudulDashboardAdmin.Margin = new Padding(1, 0, 1, 0);
            LbJudulDashboardAdmin.Name = "LbJudulDashboardAdmin";
            LbJudulDashboardAdmin.Size = new Size(138, 32);
            LbJudulDashboardAdmin.TabIndex = 0;
            LbJudulDashboardAdmin.Text = "Dashboard";
            // 
            // UcDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(PanelDashboardAdmin);
            Margin = new Padding(1, 2, 1, 2);
            Name = "UcDashboard";
            Size = new Size(1500, 875);
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
        private Label LbServisTerbaru;
        private Panel PanelBarangMenipis;
        private Button BtnLihatSem;
        private DataGridView DgvBarangStokMenipis;
        private Label LbBarangMenipis;
        private Panel PanelPenjualan;
        private Label LbAngkaPenjualan;
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
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}
