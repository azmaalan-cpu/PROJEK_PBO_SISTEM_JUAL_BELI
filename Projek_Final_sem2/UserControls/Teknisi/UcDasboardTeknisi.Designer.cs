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
            PanelPenjualan.SuspendLayout();
            PanelPendapatan.SuspendLayout();
            PanelServis.SuspendLayout();
            PanelDataBarang.SuspendLayout();
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
            PanelPenjualan.Controls.Add(label1);
            PanelPenjualan.Controls.Add(LbPenjualan);
            PanelPenjualan.Location = new Point(141, 46);
            PanelPenjualan.Margin = new Padding(2);
            PanelPenjualan.Name = "PanelPenjualan";
            PanelPenjualan.Size = new Size(119, 78);
            PanelPenjualan.TabIndex = 8;
            PanelPenjualan.Paint += PanelPenjualan_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(45, 39);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(19, 21);
            label1.TabIndex = 3;
            label1.Text = "0";
            // 
            // LbPenjualan
            // 
            LbPenjualan.AutoSize = true;
            LbPenjualan.Font = new Font("Segoe UI", 12F);
            LbPenjualan.ForeColor = Color.White;
            LbPenjualan.Location = new Point(24, 18);
            LbPenjualan.Margin = new Padding(2, 0, 2, 0);
            LbPenjualan.Name = "LbPenjualan";
            LbPenjualan.Size = new Size(77, 21);
            LbPenjualan.TabIndex = 0;
            LbPenjualan.Text = "Penjualan";
            // 
            // PanelPendapatan
            // 
            PanelPendapatan.BackColor = Color.Fuchsia;
            PanelPendapatan.Controls.Add(LbAngkaPendapatan);
            PanelPendapatan.Controls.Add(LbPendapatan);
            PanelPendapatan.Location = new Point(408, 49);
            PanelPendapatan.Margin = new Padding(2);
            PanelPendapatan.Name = "PanelPendapatan";
            PanelPendapatan.Size = new Size(126, 75);
            PanelPendapatan.TabIndex = 9;
            // 
            // LbAngkaPendapatan
            // 
            LbAngkaPendapatan.AutoSize = true;
            LbAngkaPendapatan.Font = new Font("Segoe UI", 12F);
            LbAngkaPendapatan.ForeColor = Color.White;
            LbAngkaPendapatan.Location = new Point(56, 36);
            LbAngkaPendapatan.Margin = new Padding(2, 0, 2, 0);
            LbAngkaPendapatan.Name = "LbAngkaPendapatan";
            LbAngkaPendapatan.Size = new Size(19, 21);
            LbAngkaPendapatan.TabIndex = 4;
            LbAngkaPendapatan.Text = "0";
            // 
            // LbPendapatan
            // 
            LbPendapatan.AutoSize = true;
            LbPendapatan.Font = new Font("Segoe UI", 12F);
            LbPendapatan.ForeColor = Color.White;
            LbPendapatan.Location = new Point(28, 15);
            LbPendapatan.Margin = new Padding(2, 0, 2, 0);
            LbPendapatan.Name = "LbPendapatan";
            LbPendapatan.Size = new Size(91, 21);
            LbPendapatan.TabIndex = 0;
            LbPendapatan.Text = "Pendapatan";
            // 
            // PanelServis
            // 
            PanelServis.BackColor = Color.Orange;
            PanelServis.Controls.Add(LbAngkaServis);
            PanelServis.Controls.Add(LbServis);
            PanelServis.Font = new Font("Segoe UI", 12F);
            PanelServis.Location = new Point(273, 46);
            PanelServis.Margin = new Padding(2);
            PanelServis.Name = "PanelServis";
            PanelServis.Size = new Size(122, 78);
            PanelServis.TabIndex = 7;
            // 
            // LbAngkaServis
            // 
            LbAngkaServis.AutoSize = true;
            LbAngkaServis.Font = new Font("Segoe UI", 12F);
            LbAngkaServis.ForeColor = Color.White;
            LbAngkaServis.Location = new Point(50, 39);
            LbAngkaServis.Margin = new Padding(2, 0, 2, 0);
            LbAngkaServis.Name = "LbAngkaServis";
            LbAngkaServis.Size = new Size(19, 21);
            LbAngkaServis.TabIndex = 3;
            LbAngkaServis.Text = "0";
            // 
            // LbServis
            // 
            LbServis.AutoSize = true;
            LbServis.Font = new Font("Segoe UI", 12F);
            LbServis.ForeColor = Color.White;
            LbServis.Location = new Point(35, 18);
            LbServis.Margin = new Padding(2, 0, 2, 0);
            LbServis.Name = "LbServis";
            LbServis.Size = new Size(52, 21);
            LbServis.TabIndex = 0;
            LbServis.Text = "Servis";
            // 
            // PanelDataBarang
            // 
            PanelDataBarang.BackColor = Color.DodgerBlue;
            PanelDataBarang.Controls.Add(LbAngkaBarang);
            PanelDataBarang.Controls.Add(LbDataBarang);
            PanelDataBarang.Font = new Font("Segoe UI", 12F);
            PanelDataBarang.Location = new Point(2, 46);
            PanelDataBarang.Margin = new Padding(2);
            PanelDataBarang.Name = "PanelDataBarang";
            PanelDataBarang.Size = new Size(122, 78);
            PanelDataBarang.TabIndex = 6;
            // 
            // LbAngkaBarang
            // 
            LbAngkaBarang.AutoSize = true;
            LbAngkaBarang.Font = new Font("Segoe UI", 12F);
            LbAngkaBarang.ForeColor = Color.White;
            LbAngkaBarang.Location = new Point(38, 39);
            LbAngkaBarang.Margin = new Padding(2, 0, 2, 0);
            LbAngkaBarang.Name = "LbAngkaBarang";
            LbAngkaBarang.Size = new Size(19, 21);
            LbAngkaBarang.TabIndex = 1;
            LbAngkaBarang.Text = "0";
            // 
            // LbDataBarang
            // 
            LbDataBarang.AutoSize = true;
            LbDataBarang.Font = new Font("Segoe UI", 12F);
            LbDataBarang.ForeColor = Color.White;
            LbDataBarang.Location = new Point(11, 18);
            LbDataBarang.Margin = new Padding(2, 0, 2, 0);
            LbDataBarang.Name = "LbDataBarang";
            LbDataBarang.Size = new Size(95, 21);
            LbDataBarang.TabIndex = 0;
            LbDataBarang.Text = "Data Barang";
            // 
            // UcDasboardTeknisi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelPenjualan);
            Controls.Add(PanelPendapatan);
            Controls.Add(PanelServis);
            Controls.Add(PanelDataBarang);
            Controls.Add(LbSelamatDatangAdmin);
            Controls.Add(LbJudulDashboardAdmin);
            Name = "UcDasboardTeknisi";
            Size = new Size(577, 350);
            PanelPenjualan.ResumeLayout(false);
            PanelPenjualan.PerformLayout();
            PanelPendapatan.ResumeLayout(false);
            PanelPendapatan.PerformLayout();
            PanelServis.ResumeLayout(false);
            PanelServis.PerformLayout();
            PanelDataBarang.ResumeLayout(false);
            PanelDataBarang.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbSelamatDatangAdmin;
        private Label LbJudulDashboardAdmin;
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
    }
}
