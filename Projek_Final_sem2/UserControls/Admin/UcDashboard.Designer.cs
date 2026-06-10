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
            LbSelamatDatangAdmin = new Label();
            LbJudulDashboardAdmin = new Label();
            PanelDashboardAdmin.SuspendLayout();
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
            PanelDashboardAdmin.Controls.Add(PanelServisTerbaru);
            PanelDashboardAdmin.Controls.Add(PanelBarangMenipis);
            PanelDashboardAdmin.Controls.Add(PanelPenjualan);
            PanelDashboardAdmin.Controls.Add(PanelPendapatan);
            PanelDashboardAdmin.Controls.Add(PanelServis);
            PanelDashboardAdmin.Controls.Add(PanelDataBarang);
            PanelDashboardAdmin.Controls.Add(LbSelamatDatangAdmin);
            PanelDashboardAdmin.Controls.Add(LbJudulDashboardAdmin);
            PanelDashboardAdmin.Dock = DockStyle.Fill;
            PanelDashboardAdmin.Location = new Point(0, 0);
            PanelDashboardAdmin.Name = "PanelDashboardAdmin";
            PanelDashboardAdmin.Size = new Size(1013, 585);
            PanelDashboardAdmin.TabIndex = 2;
            // 
            // PanelServisTerbaru
            // 
            PanelServisTerbaru.Controls.Add(BtnLihatSemua);
            PanelServisTerbaru.Controls.Add(DgvServisTerbaru);
            PanelServisTerbaru.Controls.Add(LbServisTerbaru);
            PanelServisTerbaru.Location = new Point(383, 198);
            PanelServisTerbaru.Name = "PanelServisTerbaru";
            PanelServisTerbaru.Size = new Size(396, 245);
            PanelServisTerbaru.TabIndex = 7;
            // 
            // BtnLihatSemua
            // 
            BtnLihatSemua.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLihatSemua.Location = new Point(235, 198);
            BtnLihatSemua.Name = "BtnLihatSemua";
            BtnLihatSemua.Size = new Size(153, 34);
            BtnLihatSemua.TabIndex = 3;
            BtnLihatSemua.Text = "Lihat Semua";
            BtnLihatSemua.UseVisualStyleBackColor = true;
            // 
            // DgvServisTerbaru
            // 
            DgvServisTerbaru.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvServisTerbaru.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvServisTerbaru.Columns.AddRange(new DataGridViewColumn[] { Column5, Column6, Column7 });
            DgvServisTerbaru.Location = new Point(0, 41);
            DgvServisTerbaru.Name = "DgvServisTerbaru";
            DgvServisTerbaru.RowHeadersWidth = 62;
            DgvServisTerbaru.ScrollBars = ScrollBars.None;
            DgvServisTerbaru.Size = new Size(396, 128);
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
            LbServisTerbaru.Location = new Point(19, 6);
            LbServisTerbaru.Name = "LbServisTerbaru";
            LbServisTerbaru.Size = new Size(121, 25);
            LbServisTerbaru.TabIndex = 1;
            LbServisTerbaru.Text = "Servis Terbaru";
            // 
            // PanelBarangMenipis
            // 
            PanelBarangMenipis.Controls.Add(BtnLihatSem);
            PanelBarangMenipis.Controls.Add(DgvBarangStokMenipis);
            PanelBarangMenipis.Controls.Add(LbBarangMenipis);
            PanelBarangMenipis.Location = new Point(3, 198);
            PanelBarangMenipis.Name = "PanelBarangMenipis";
            PanelBarangMenipis.Size = new Size(374, 245);
            PanelBarangMenipis.TabIndex = 6;
            // 
            // BtnLihatSem
            // 
            BtnLihatSem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLihatSem.Location = new Point(211, 198);
            BtnLihatSem.Name = "BtnLihatSem";
            BtnLihatSem.Size = new Size(153, 34);
            BtnLihatSem.TabIndex = 2;
            BtnLihatSem.Text = "Lihat Semua";
            BtnLihatSem.UseVisualStyleBackColor = true;
            // 
            // DgvBarangStokMenipis
            // 
            DgvBarangStokMenipis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvBarangStokMenipis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvBarangStokMenipis.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column4 });
            DgvBarangStokMenipis.Location = new Point(4, 41);
            DgvBarangStokMenipis.Name = "DgvBarangStokMenipis";
            DgvBarangStokMenipis.RowHeadersWidth = 62;
            DgvBarangStokMenipis.Size = new Size(360, 128);
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
            LbBarangMenipis.Location = new Point(22, 6);
            LbBarangMenipis.Name = "LbBarangMenipis";
            LbBarangMenipis.Size = new Size(174, 25);
            LbBarangMenipis.TabIndex = 0;
            LbBarangMenipis.Text = "Barang Stok Menipis";
            // 
            // PanelPenjualan
            // 
            PanelPenjualan.BackColor = Color.GreenYellow;
            PanelPenjualan.Controls.Add(label1);
            PanelPenjualan.Controls.Add(LbPenjualan);
            PanelPenjualan.Location = new Point(152, 67);
            PanelPenjualan.Name = "PanelPenjualan";
            PanelPenjualan.Size = new Size(122, 92);
            PanelPenjualan.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 44);
            label1.Name = "label1";
            label1.Size = new Size(22, 25);
            label1.TabIndex = 3;
            label1.Text = "0";
            // 
            // LbPenjualan
            // 
            LbPenjualan.AutoSize = true;
            LbPenjualan.ForeColor = Color.White;
            LbPenjualan.Location = new Point(20, 8);
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
            PanelPendapatan.Location = new Point(421, 67);
            PanelPendapatan.Name = "PanelPendapatan";
            PanelPendapatan.Size = new Size(125, 92);
            PanelPendapatan.TabIndex = 5;
            // 
            // LbAngkaPendapatan
            // 
            LbAngkaPendapatan.AutoSize = true;
            LbAngkaPendapatan.ForeColor = Color.White;
            LbAngkaPendapatan.Location = new Point(54, 44);
            LbAngkaPendapatan.Name = "LbAngkaPendapatan";
            LbAngkaPendapatan.Size = new Size(22, 25);
            LbAngkaPendapatan.TabIndex = 4;
            LbAngkaPendapatan.Text = "0";
            // 
            // LbPendapatan
            // 
            LbPendapatan.AutoSize = true;
            LbPendapatan.ForeColor = Color.White;
            LbPendapatan.Location = new Point(15, 8);
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
            PanelServis.Location = new Point(279, 67);
            PanelServis.Name = "PanelServis";
            PanelServis.Size = new Size(134, 92);
            PanelServis.TabIndex = 4;
            // 
            // LbAngkaServis
            // 
            LbAngkaServis.AutoSize = true;
            LbAngkaServis.ForeColor = Color.White;
            LbAngkaServis.Location = new Point(59, 44);
            LbAngkaServis.Name = "LbAngkaServis";
            LbAngkaServis.Size = new Size(22, 25);
            LbAngkaServis.TabIndex = 3;
            LbAngkaServis.Text = "0";
            // 
            // LbServis
            // 
            LbServis.AutoSize = true;
            LbServis.ForeColor = Color.White;
            LbServis.Location = new Point(38, 13);
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
            PanelDataBarang.Location = new Point(7, 67);
            PanelDataBarang.Name = "PanelDataBarang";
            PanelDataBarang.Size = new Size(138, 92);
            PanelDataBarang.TabIndex = 2;
            // 
            // LbAngkaBarang
            // 
            LbAngkaBarang.AutoSize = true;
            LbAngkaBarang.ForeColor = Color.White;
            LbAngkaBarang.Location = new Point(57, 44);
            LbAngkaBarang.Name = "LbAngkaBarang";
            LbAngkaBarang.Size = new Size(22, 25);
            LbAngkaBarang.TabIndex = 1;
            LbAngkaBarang.Text = "0";
            // 
            // LbDataBarang
            // 
            LbDataBarang.AutoSize = true;
            LbDataBarang.ForeColor = Color.White;
            LbDataBarang.Location = new Point(18, 8);
            LbDataBarang.Name = "LbDataBarang";
            LbDataBarang.Size = new Size(109, 25);
            LbDataBarang.TabIndex = 0;
            LbDataBarang.Text = "Data Barang";
            // 
            // LbSelamatDatangAdmin
            // 
            LbSelamatDatangAdmin.AutoSize = true;
            LbSelamatDatangAdmin.Location = new Point(7, 39);
            LbSelamatDatangAdmin.Name = "LbSelamatDatangAdmin";
            LbSelamatDatangAdmin.Size = new Size(205, 25);
            LbSelamatDatangAdmin.TabIndex = 1;
            LbSelamatDatangAdmin.Text = "Selamat Datang, Admin!";
            // 
            // LbJudulDashboardAdmin
            // 
            LbJudulDashboardAdmin.AutoSize = true;
            LbJudulDashboardAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbJudulDashboardAdmin.Location = new Point(7, 7);
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
            Name = "UcDashboard";
            Size = new Size(1013, 585);
            Load += UcDashboard_Load;
            PanelDashboardAdmin.ResumeLayout(false);
            PanelDashboardAdmin.PerformLayout();
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
        private Label LbSelamatDatangAdmin;
        private Label LbJudulDashboardAdmin;
    }
}
