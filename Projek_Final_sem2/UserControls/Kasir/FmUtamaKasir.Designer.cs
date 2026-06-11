namespace Projek_Final_sem2.UserControls.Kasir
{
    partial class FmUtamaKasir
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmUtamaKasir));
            PanelMenuUtamaKasir = new Panel();
            BtnLogout = new Button();
            BtnTransaksiPenjualan = new Button();
            ButtonDataBarang = new Button();
            LbMenuUtama = new Label();
            LabelKasir = new Label();
            BtnDashboardKasir = new Button();
            LbKasir = new Label();
            PcxMenuKasir = new PictureBox();
            PanelContainer = new Panel();
            PanelMenuUtamaKasir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PcxMenuKasir).BeginInit();
            SuspendLayout();
            // 
            // PanelMenuUtamaKasir
            // 
            PanelMenuUtamaKasir.BackColor = Color.DarkGreen;
            PanelMenuUtamaKasir.Controls.Add(BtnLogout);
            PanelMenuUtamaKasir.Controls.Add(BtnTransaksiPenjualan);
            PanelMenuUtamaKasir.Controls.Add(ButtonDataBarang);
            PanelMenuUtamaKasir.Controls.Add(LbMenuUtama);
            PanelMenuUtamaKasir.Controls.Add(LabelKasir);
            PanelMenuUtamaKasir.Controls.Add(BtnDashboardKasir);
            PanelMenuUtamaKasir.Controls.Add(LbKasir);
            PanelMenuUtamaKasir.Controls.Add(PcxMenuKasir);
            PanelMenuUtamaKasir.Dock = DockStyle.Left;
            PanelMenuUtamaKasir.Location = new Point(0, 0);
            PanelMenuUtamaKasir.Name = "PanelMenuUtamaKasir";
            PanelMenuUtamaKasir.Size = new Size(254, 753);
            PanelMenuUtamaKasir.TabIndex = 0;
            // 
            // BtnLogout
            // 
            BtnLogout.BackColor = Color.ForestGreen;
            BtnLogout.FlatStyle = FlatStyle.Flat;
            BtnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLogout.ForeColor = Color.White;
            BtnLogout.Location = new Point(12, 292);
            BtnLogout.Name = "BtnLogout";
            BtnLogout.Size = new Size(227, 29);
            BtnLogout.TabIndex = 8;
            BtnLogout.Text = "Logout";
            BtnLogout.UseVisualStyleBackColor = false;
            BtnLogout.Click += BtnLogout_Click;
            // 
            // BtnTransaksiPenjualan
            // 
            BtnTransaksiPenjualan.BackColor = Color.ForestGreen;
            BtnTransaksiPenjualan.FlatStyle = FlatStyle.Flat;
            BtnTransaksiPenjualan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnTransaksiPenjualan.ForeColor = Color.White;
            BtnTransaksiPenjualan.Location = new Point(15, 247);
            BtnTransaksiPenjualan.Name = "BtnTransaksiPenjualan";
            BtnTransaksiPenjualan.Size = new Size(224, 29);
            BtnTransaksiPenjualan.TabIndex = 6;
            BtnTransaksiPenjualan.Text = "Transaksi Penjualan";
            BtnTransaksiPenjualan.UseVisualStyleBackColor = false;
            BtnTransaksiPenjualan.Click += BtnTransaksiPenjualan_Click;
            // 
            // ButtonDataBarang
            // 
            ButtonDataBarang.BackColor = Color.ForestGreen;
            ButtonDataBarang.FlatStyle = FlatStyle.Flat;
            ButtonDataBarang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonDataBarang.ForeColor = Color.White;
            ButtonDataBarang.ImageAlign = ContentAlignment.MiddleLeft;
            ButtonDataBarang.Location = new Point(15, 191);
            ButtonDataBarang.Name = "ButtonDataBarang";
            ButtonDataBarang.Size = new Size(225, 45);
            ButtonDataBarang.TabIndex = 5;
            ButtonDataBarang.Text = "Data Barang ";
            ButtonDataBarang.UseVisualStyleBackColor = false;
            ButtonDataBarang.Click += ButtonDataBarang_Click;
            // 
            // LbMenuUtama
            // 
            LbMenuUtama.AutoSize = true;
            LbMenuUtama.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbMenuUtama.ForeColor = Color.White;
            LbMenuUtama.Location = new Point(15, 15);
            LbMenuUtama.Name = "LbMenuUtama";
            LbMenuUtama.Size = new Size(114, 20);
            LbMenuUtama.TabIndex = 4;
            LbMenuUtama.Text = "Menu Utama";
            // 
            // LabelKasir
            // 
            LabelKasir.AutoSize = true;
            LabelKasir.ForeColor = Color.White;
            LabelKasir.Location = new Point(83, 82);
            LabelKasir.Name = "LabelKasir";
            LabelKasir.Size = new Size(41, 20);
            LabelKasir.TabIndex = 3;
            LabelKasir.Text = "Kasir";
            // 
            // BtnDashboardKasir
            // 
            BtnDashboardKasir.BackColor = Color.ForestGreen;
            BtnDashboardKasir.FlatStyle = FlatStyle.Flat;
            BtnDashboardKasir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDashboardKasir.ForeColor = Color.White;
            BtnDashboardKasir.ImageAlign = ContentAlignment.MiddleLeft;
            BtnDashboardKasir.Location = new Point(15, 140);
            BtnDashboardKasir.Name = "BtnDashboardKasir";
            BtnDashboardKasir.Size = new Size(225, 40);
            BtnDashboardKasir.TabIndex = 2;
            BtnDashboardKasir.Text = "Dashboard ";
            BtnDashboardKasir.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnDashboardKasir.UseVisualStyleBackColor = false;
            BtnDashboardKasir.Click += BtnDashboardKasir_Click;
            // 
            // LbKasir
            // 
            LbKasir.AutoSize = true;
            LbKasir.BackColor = Color.DarkGreen;
            LbKasir.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbKasir.ForeColor = Color.White;
            LbKasir.Location = new Point(83, 59);
            LbKasir.Name = "LbKasir";
            LbKasir.Size = new Size(52, 23);
            LbKasir.TabIndex = 1;
            LbKasir.Text = "kasir";
            // 
            // PcxMenuKasir
            // 
            PcxMenuKasir.BackgroundImage = (Image)resources.GetObject("PcxMenuKasir.BackgroundImage");
            PcxMenuKasir.BackgroundImageLayout = ImageLayout.Stretch;
            PcxMenuKasir.Location = new Point(12, 48);
            PcxMenuKasir.Name = "PcxMenuKasir";
            PcxMenuKasir.Size = new Size(65, 63);
            PcxMenuKasir.SizeMode = PictureBoxSizeMode.StretchImage;
            PcxMenuKasir.TabIndex = 0;
            PcxMenuKasir.TabStop = false;
            // 
            // PanelContainer
            // 
            PanelContainer.Dock = DockStyle.Fill;
            PanelContainer.Location = new Point(254, 0);
            PanelContainer.Name = "PanelContainer";
            PanelContainer.Size = new Size(1228, 753);
            PanelContainer.TabIndex = 1;
            // 
            // FmUtamaKasir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 753);
            Controls.Add(PanelContainer);
            Controls.Add(PanelMenuUtamaKasir);
            Name = "FmUtamaKasir";
            Text = "FmUtamaKasir";
            Load += FmUtamaKasir_load;
            PanelMenuUtamaKasir.ResumeLayout(false);
            PanelMenuUtamaKasir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PcxMenuKasir).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelMenuUtamaKasir;
        private PictureBox PcxMenuKasir;
        private Label LbKasir;
        private Button BtnDashboardKasir;
        private Label LabelKasir;
        private Label LbMenuUtama;
        private Button ButtonDataBarang;
        private Button BtnTransaksiPenjualan;
        private Button BtnLogout;
        private Panel PanelContainer;
    }
}