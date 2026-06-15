namespace Projek_Final_sem2.UserControls.Kasir
{
    partial class UcTransaksiService
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            GbCariService = new GroupBox();
            BtnCariIdServis = new Button();
            TbCariIdService = new TextBox();
            LbCariService = new Label();
            GbDataService = new GroupBox();
            groupBox1 = new GroupBox();
            LbNamaAlat = new Label();
            LbIdService = new Label();
            PanelMainService = new Panel();
            BtnBayarService = new Button();
            BtnSelesai = new Button();
            GbPembayaran = new GroupBox();
            LbTotalBayarServis = new Label();
            GbDetailKerusakan = new GroupBox();
            LbSparePart = new Label();
            LbKerusakan = new Label();
            GbCariService.SuspendLayout();
            GbDataService.SuspendLayout();
            PanelMainService.SuspendLayout();
            GbPembayaran.SuspendLayout();
            GbDetailKerusakan.SuspendLayout();
            SuspendLayout();
            // 
            // GbCariService
            // 
            GbCariService.Controls.Add(BtnCariIdServis);
            GbCariService.Controls.Add(TbCariIdService);
            GbCariService.Controls.Add(LbCariService);
            GbCariService.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GbCariService.ForeColor = Color.ForestGreen;
            GbCariService.Location = new Point(18, 8);
            GbCariService.Margin = new Padding(3, 2, 3, 2);
            GbCariService.Name = "GbCariService";
            GbCariService.Padding = new Padding(3, 2, 3, 2);
            GbCariService.Size = new Size(563, 76);
            GbCariService.TabIndex = 1;
            GbCariService.TabStop = false;
            GbCariService.Text = "Transaksi Service";
            // 
            // BtnCariIdServis
            // 
            BtnCariIdServis.BackColor = Color.ForestGreen;
            BtnCariIdServis.FlatStyle = FlatStyle.Flat;
            BtnCariIdServis.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCariIdServis.ForeColor = Color.White;
            BtnCariIdServis.Location = new Point(353, 33);
            BtnCariIdServis.Margin = new Padding(3, 2, 3, 2);
            BtnCariIdServis.Name = "BtnCariIdServis";
            BtnCariIdServis.Size = new Size(79, 26);
            BtnCariIdServis.TabIndex = 2;
            BtnCariIdServis.Text = "Cari";
            BtnCariIdServis.UseVisualStyleBackColor = false;
            // 
            // TbCariIdService
            // 
            TbCariIdService.Location = new Point(152, 33);
            TbCariIdService.Margin = new Padding(3, 2, 3, 2);
            TbCariIdService.Name = "TbCariIdService";
            TbCariIdService.Size = new Size(195, 29);
            TbCariIdService.TabIndex = 1;
            // 
            // LbCariService
            // 
            LbCariService.AutoSize = true;
            LbCariService.Location = new Point(10, 32);
            LbCariService.Name = "LbCariService";
            LbCariService.Size = new Size(127, 21);
            LbCariService.TabIndex = 0;
            LbCariService.Text = "Cari Id Service :";
            // 
            // GbDataService
            // 
            GbDataService.Controls.Add(groupBox1);
            GbDataService.Controls.Add(LbNamaAlat);
            GbDataService.Controls.Add(LbIdService);
            GbDataService.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GbDataService.ForeColor = SystemColors.ActiveCaptionText;
            GbDataService.Location = new Point(16, 88);
            GbDataService.Margin = new Padding(3, 2, 3, 2);
            GbDataService.Name = "GbDataService";
            GbDataService.Padding = new Padding(3, 2, 3, 2);
            GbDataService.Size = new Size(564, 94);
            GbDataService.TabIndex = 2;
            GbDataService.TabStop = false;
            GbDataService.Text = "Data Service ";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(0, 143);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(219, 94);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // LbNamaAlat
            // 
            LbNamaAlat.AutoSize = true;
            LbNamaAlat.ForeColor = Color.ForestGreen;
            LbNamaAlat.Location = new Point(13, 63);
            LbNamaAlat.Name = "LbNamaAlat";
            LbNamaAlat.Size = new Size(99, 21);
            LbNamaAlat.TabIndex = 1;
            LbNamaAlat.Text = "Nama Alat :";
            // 
            // LbIdService
            // 
            LbIdService.AutoSize = true;
            LbIdService.ForeColor = Color.ForestGreen;
            LbIdService.Location = new Point(13, 33);
            LbIdService.Name = "LbIdService";
            LbIdService.Size = new Size(97, 21);
            LbIdService.TabIndex = 0;
            LbIdService.Text = "Id Service : ";
            // 
            // PanelMainService
            // 
            PanelMainService.BackColor = Color.WhiteSmoke;
            PanelMainService.Controls.Add(BtnBayarService);
            PanelMainService.Controls.Add(BtnSelesai);
            PanelMainService.Controls.Add(GbPembayaran);
            PanelMainService.Controls.Add(GbDetailKerusakan);
            PanelMainService.Controls.Add(GbDataService);
            PanelMainService.Controls.Add(GbCariService);
            PanelMainService.Location = new Point(3, 2);
            PanelMainService.Margin = new Padding(3, 2, 3, 2);
            PanelMainService.Name = "PanelMainService";
            PanelMainService.Size = new Size(875, 494);
            PanelMainService.TabIndex = 0;
            PanelMainService.Paint += PanelMainService_Paint;
            // 
            // BtnBayarService
            // 
            BtnBayarService.BackColor = Color.ForestGreen;
            BtnBayarService.FlatStyle = FlatStyle.Flat;
            BtnBayarService.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBayarService.ForeColor = Color.White;
            BtnBayarService.Location = new Point(18, 372);
            BtnBayarService.Margin = new Padding(3, 2, 3, 2);
            BtnBayarService.Name = "BtnBayarService";
            BtnBayarService.Size = new Size(130, 32);
            BtnBayarService.TabIndex = 4;
            BtnBayarService.Text = "Bayar Service";
            BtnBayarService.UseVisualStyleBackColor = false;
            // 
            // BtnSelesai
            // 
            BtnSelesai.BackColor = Color.Red;
            BtnSelesai.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSelesai.ForeColor = Color.White;
            BtnSelesai.Location = new Point(170, 372);
            BtnSelesai.Margin = new Padding(3, 2, 3, 2);
            BtnSelesai.Name = "BtnSelesai";
            BtnSelesai.Size = new Size(130, 22);
            BtnSelesai.TabIndex = 5;
            BtnSelesai.Text = "Selesai";
            BtnSelesai.UseVisualStyleBackColor = false;
            // 
            // GbPembayaran
            // 
            GbPembayaran.Controls.Add(LbTotalBayarServis);
            GbPembayaran.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GbPembayaran.Location = new Point(16, 284);
            GbPembayaran.Margin = new Padding(3, 2, 3, 2);
            GbPembayaran.Name = "GbPembayaran";
            GbPembayaran.Padding = new Padding(3, 2, 3, 2);
            GbPembayaran.Size = new Size(564, 68);
            GbPembayaran.TabIndex = 4;
            GbPembayaran.TabStop = false;
            GbPembayaran.Text = "Pembayaran";
            // 
            // LbTotalBayarServis
            // 
            LbTotalBayarServis.AutoSize = true;
            LbTotalBayarServis.ForeColor = Color.ForestGreen;
            LbTotalBayarServis.Location = new Point(6, 36);
            LbTotalBayarServis.Name = "LbTotalBayarServis";
            LbTotalBayarServis.Size = new Size(153, 21);
            LbTotalBayarServis.TabIndex = 2;
            LbTotalBayarServis.Text = "Total Bayar Servis :";
            // 
            // GbDetailKerusakan
            // 
            GbDetailKerusakan.Controls.Add(LbSparePart);
            GbDetailKerusakan.Controls.Add(LbKerusakan);
            GbDetailKerusakan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GbDetailKerusakan.Location = new Point(18, 186);
            GbDetailKerusakan.Margin = new Padding(3, 2, 3, 2);
            GbDetailKerusakan.Name = "GbDetailKerusakan";
            GbDetailKerusakan.Padding = new Padding(3, 2, 3, 2);
            GbDetailKerusakan.Size = new Size(563, 94);
            GbDetailKerusakan.TabIndex = 3;
            GbDetailKerusakan.TabStop = false;
            GbDetailKerusakan.Text = "Detail Kerusakan";
            // 
            // LbSparePart
            // 
            LbSparePart.AutoSize = true;
            LbSparePart.ForeColor = Color.ForestGreen;
            LbSparePart.Location = new Point(8, 61);
            LbSparePart.Name = "LbSparePart";
            LbSparePart.Size = new Size(92, 21);
            LbSparePart.TabIndex = 2;
            LbSparePart.Text = "Sparepart :";
            // 
            // LbKerusakan
            // 
            LbKerusakan.AutoSize = true;
            LbKerusakan.ForeColor = Color.ForestGreen;
            LbKerusakan.Location = new Point(8, 29);
            LbKerusakan.Name = "LbKerusakan";
            LbKerusakan.Size = new Size(101, 21);
            LbKerusakan.TabIndex = 0;
            LbKerusakan.Text = "Kerusakan : ";
            // 
            // UcTransaksiService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelMainService);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UcTransaksiService";
            Size = new Size(878, 496);
            GbCariService.ResumeLayout(false);
            GbCariService.PerformLayout();
            GbDataService.ResumeLayout(false);
            GbDataService.PerformLayout();
            PanelMainService.ResumeLayout(false);
            GbPembayaran.ResumeLayout(false);
            GbPembayaran.PerformLayout();
            GbDetailKerusakan.ResumeLayout(false);
            GbDetailKerusakan.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private GroupBox GbCariService;
        private Button BtnCariIdServis;
        private TextBox TbCariIdService;
        private Label LbCariService;
        private GroupBox GbDataService;
        private GroupBox groupBox1;
        private Label LbNamaAlamat;
        private Label LbNamaAlat;
        private Label LbIdService;
        private Panel PanelMainService;
        private GroupBox GbDetailKerusakan;
        private Label LbSparePart;
        private Label LbDiagnosa;
        private Label LbKerusakan;
        private GroupBox GbPembayaran;
        private Label LbBiayaJasa;
        private Label LbBiayaSparePart;
        private Label LbBiayaStatus;
        private Label LbTotalBayarServis;
        private Button BtnBayarService;
        private Button BtnSelesai;
    }
}
