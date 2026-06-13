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
            PanelDashboardAdmin.Margin = new Padding(2);
            PanelDashboardAdmin.Name = "PanelDashboardAdmin";
            PanelDashboardAdmin.Size = new Size(1200, 700);
            PanelDashboardAdmin.TabIndex = 2;
            // 
            // PanelJudulAdmin
            // 
            PanelJudulAdmin.BackColor = Color.FromArgb(192, 255, 192);
            PanelJudulAdmin.Controls.Add(LabelJudulRingkasanSistem);
            PanelJudulAdmin.Controls.Add(LabelJudul);
            PanelJudulAdmin.Location = new Point(6, 53);
            PanelJudulAdmin.Name = "PanelJudulAdmin";
            PanelJudulAdmin.Size = new Size(1179, 125);
            PanelJudulAdmin.TabIndex = 8;
            // 
            // LabelJudulRingkasanSistem
            // 
            LabelJudulRingkasanSistem.AutoSize = true;
            LabelJudulRingkasanSistem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelJudulRingkasanSistem.Location = new Point(25, 66);
            LabelJudulRingkasanSistem.Name = "LabelJudulRingkasanSistem";
            LabelJudulRingkasanSistem.Size = new Size(380, 20);
            LabelJudulRingkasanSistem.TabIndex = 1;
            LabelJudulRingkasanSistem.Text = "Berikut adalah informasi ringkasan data pada sistem.";
            // 
            // LabelJudul
            // 
            LabelJudul.AutoSize = true;
            LabelJudul.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelJudul.ForeColor = Color.Green;
            LabelJudul.Location = new Point(25, 34);
            LabelJudul.Name = "LabelJudul";
            LabelJudul.Size = new Size(243, 28);
            LabelJudul.TabIndex = 0;
            LabelJudul.Text = "Selamat Datang, Admin!";
            // 
            // PanelServisTerbaru
            // 
            PanelServisTerbaru.Controls.Add(BtnLihatSemua);
            PanelServisTerbaru.Controls.Add(DgvServisTerbaru);
            PanelServisTerbaru.Controls.Add(LbServisTerbaru);
            PanelServisTerbaru.Location = new Point(605, 310);
            PanelServisTerbaru.Margin = new Padding(2);
            PanelServisTerbaru.Name = "PanelServisTerbaru";
            PanelServisTerbaru.Size = new Size(580, 388);
            PanelServisTerbaru.TabIndex = 7;
            // 
            // BtnLihatSemua
            // 
            BtnLihatSemua.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLihatSemua.Location = new Point(454, 359);
            BtnLihatSemua.Margin = new Padding(2);
            BtnLihatSemua.Name = "BtnLihatSemua";
            BtnLihatSemua.Size = new Size(122, 27);
            BtnLihatSemua.TabIndex = 3;
            BtnLihatSemua.Text = "Lihat Semua";
            BtnLihatSemua.UseVisualStyleBackColor = true;
            // 
            // DgvServisTerbaru
            // 
            DgvServisTerbaru.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvServisTerbaru.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvServisTerbaru.Columns.AddRange(new DataGridViewColumn[] { Column5, Column6, Column7 });
            DgvServisTerbaru.Location = new Point(0, 36);
            DgvServisTerbaru.Margin = new Padding(2);
            DgvServisTerbaru.Name = "DgvServisTerbaru";
            DgvServisTerbaru.RowHeadersWidth = 62;
            DgvServisTerbaru.ScrollBars = ScrollBars.None;
            DgvServisTerbaru.Size = new Size(578, 322);
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
            LbServisTerbaru.Location = new Point(4, 5);
            LbServisTerbaru.Margin = new Padding(2, 0, 2, 0);
            LbServisTerbaru.Name = "LbServisTerbaru";
            LbServisTerbaru.Size = new Size(115, 23);
            LbServisTerbaru.TabIndex = 1;
            LbServisTerbaru.Text = "Servis Terbaru";
            // 
            // PanelBarangMenipis
            // 
            PanelBarangMenipis.Controls.Add(BtnLihatSem);
            PanelBarangMenipis.Controls.Add(DgvBarangStokMenipis);
            PanelBarangMenipis.Controls.Add(LbBarangMenipis);
            PanelBarangMenipis.Location = new Point(6, 310);
            PanelBarangMenipis.Margin = new Padding(2);
            PanelBarangMenipis.Name = "PanelBarangMenipis";
            PanelBarangMenipis.Size = new Size(595, 388);
            PanelBarangMenipis.TabIndex = 6;
            // 
            // BtnLihatSem
            // 
            BtnLihatSem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLihatSem.Location = new Point(470, 359);
            BtnLihatSem.Margin = new Padding(2);
            BtnLihatSem.Name = "BtnLihatSem";
            BtnLihatSem.Size = new Size(122, 27);
            BtnLihatSem.TabIndex = 2;
            BtnLihatSem.Text = "Lihat Semua";
            BtnLihatSem.UseVisualStyleBackColor = true;
            // 
            // DgvBarangStokMenipis
            // 
            DgvBarangStokMenipis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvBarangStokMenipis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvBarangStokMenipis.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column4 });
            DgvBarangStokMenipis.Location = new Point(3, 34);
            DgvBarangStokMenipis.Margin = new Padding(2);
            DgvBarangStokMenipis.Name = "DgvBarangStokMenipis";
            DgvBarangStokMenipis.RowHeadersWidth = 62;
            DgvBarangStokMenipis.Size = new Size(589, 324);
            DgvBarangStokMenipis.TabIndex = 1;
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
            LbBarangMenipis.Location = new Point(3, 5);
            LbBarangMenipis.Margin = new Padding(2, 0, 2, 0);
            LbBarangMenipis.Name = "LbBarangMenipis";
            LbBarangMenipis.Size = new Size(165, 23);
            LbBarangMenipis.TabIndex = 0;
            LbBarangMenipis.Text = "Barang Stok Menipis";
            // 
            // PanelPenjualan
            // 
            PanelPenjualan.BackColor = Color.GreenYellow;
            PanelPenjualan.Controls.Add(label1);
            PanelPenjualan.Controls.Add(LbPenjualan);
            PanelPenjualan.Location = new Point(192, 206);
            PanelPenjualan.Margin = new Padding(2);
            PanelPenjualan.Name = "PanelPenjualan";
            PanelPenjualan.Size = new Size(180, 100);
            PanelPenjualan.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(77, 45);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(17, 20);
            label1.TabIndex = 3;
            label1.Text = "0";
            // 
            // LbPenjualan
            // 
            LbPenjualan.AutoSize = true;
            LbPenjualan.ForeColor = Color.White;
            LbPenjualan.Location = new Point(52, 12);
            LbPenjualan.Margin = new Padding(2, 0, 2, 0);
            LbPenjualan.Name = "LbPenjualan";
            LbPenjualan.Size = new Size(72, 20);
            LbPenjualan.TabIndex = 0;
            LbPenjualan.Text = "Penjualan";
            // 
            // PanelPendapatan
            // 
            PanelPendapatan.BackColor = Color.Fuchsia;
            PanelPendapatan.Controls.Add(LbAngkaPendapatan);
            PanelPendapatan.Controls.Add(LbPendapatan);
            PanelPendapatan.Location = new Point(558, 206);
            PanelPendapatan.Margin = new Padding(2);
            PanelPendapatan.Name = "PanelPendapatan";
            PanelPendapatan.Size = new Size(180, 100);
            PanelPendapatan.TabIndex = 5;
            // 
            // LbAngkaPendapatan
            // 
            LbAngkaPendapatan.AutoSize = true;
            LbAngkaPendapatan.ForeColor = Color.White;
            LbAngkaPendapatan.Location = new Point(76, 48);
            LbAngkaPendapatan.Margin = new Padding(2, 0, 2, 0);
            LbAngkaPendapatan.Name = "LbAngkaPendapatan";
            LbAngkaPendapatan.Size = new Size(17, 20);
            LbAngkaPendapatan.TabIndex = 4;
            LbAngkaPendapatan.Text = "0";
            // 
            // LbPendapatan
            // 
            LbPendapatan.AutoSize = true;
            LbPendapatan.ForeColor = Color.White;
            LbPendapatan.Location = new Point(43, 11);
            LbPendapatan.Margin = new Padding(2, 0, 2, 0);
            LbPendapatan.Name = "LbPendapatan";
            LbPendapatan.Size = new Size(87, 20);
            LbPendapatan.TabIndex = 0;
            LbPendapatan.Text = "Pendapatan";
            // 
            // PanelServis
            // 
            PanelServis.BackColor = Color.Orange;
            PanelServis.Controls.Add(LbAngkaServis);
            PanelServis.Controls.Add(LbServis);
            PanelServis.Location = new Point(375, 206);
            PanelServis.Margin = new Padding(2);
            PanelServis.Name = "PanelServis";
            PanelServis.Size = new Size(180, 100);
            PanelServis.TabIndex = 4;
            // 
            // LbAngkaServis
            // 
            LbAngkaServis.AutoSize = true;
            LbAngkaServis.ForeColor = Color.White;
            LbAngkaServis.Location = new Point(79, 47);
            LbAngkaServis.Margin = new Padding(2, 0, 2, 0);
            LbAngkaServis.Name = "LbAngkaServis";
            LbAngkaServis.Size = new Size(17, 20);
            LbAngkaServis.TabIndex = 3;
            LbAngkaServis.Text = "0";
            // 
            // LbServis
            // 
            LbServis.AutoSize = true;
            LbServis.ForeColor = Color.White;
            LbServis.Location = new Point(63, 15);
            LbServis.Margin = new Padding(2, 0, 2, 0);
            LbServis.Name = "LbServis";
            LbServis.Size = new Size(47, 20);
            LbServis.TabIndex = 0;
            LbServis.Text = "Servis";
            // 
            // PanelDataBarang
            // 
            PanelDataBarang.BackColor = Color.DodgerBlue;
            PanelDataBarang.Controls.Add(LbAngkaBarang);
            PanelDataBarang.Controls.Add(LbDataBarang);
            PanelDataBarang.Location = new Point(9, 206);
            PanelDataBarang.Margin = new Padding(2);
            PanelDataBarang.Name = "PanelDataBarang";
            PanelDataBarang.Size = new Size(180, 100);
            PanelDataBarang.TabIndex = 2;
            // 
            // LbAngkaBarang
            // 
            LbAngkaBarang.AutoSize = true;
            LbAngkaBarang.ForeColor = Color.White;
            LbAngkaBarang.Location = new Point(75, 44);
            LbAngkaBarang.Margin = new Padding(2, 0, 2, 0);
            LbAngkaBarang.Name = "LbAngkaBarang";
            LbAngkaBarang.Size = new Size(17, 20);
            LbAngkaBarang.TabIndex = 1;
            LbAngkaBarang.Text = "0";
            // 
            // LbDataBarang
            // 
            LbDataBarang.AutoSize = true;
            LbDataBarang.ForeColor = Color.White;
            LbDataBarang.Location = new Point(37, 13);
            LbDataBarang.Margin = new Padding(2, 0, 2, 0);
            LbDataBarang.Name = "LbDataBarang";
            LbDataBarang.Size = new Size(92, 20);
            LbDataBarang.TabIndex = 0;
            LbDataBarang.Text = "Data Barang";
            // 
            // LbJudulDashboardAdmin
            // 
            LbJudulDashboardAdmin.AutoSize = true;
            LbJudulDashboardAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbJudulDashboardAdmin.Location = new Point(31, 6);
            LbJudulDashboardAdmin.Margin = new Padding(2, 0, 2, 0);
            LbJudulDashboardAdmin.Name = "LbJudulDashboardAdmin";
            LbJudulDashboardAdmin.Size = new Size(114, 28);
            LbJudulDashboardAdmin.TabIndex = 0;
            LbJudulDashboardAdmin.Text = "Dashboard";
            // 
            // UcDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(PanelDashboardAdmin);
            Margin = new Padding(2);
            Name = "UcDashboard";
            Size = new Size(1200, 700);
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
