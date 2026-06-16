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
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            LbNamaAlat = new Label();
            LbIdService = new Label();
            PanelMainService = new Panel();
            BtnBayarService = new Button();
            Btnbatal = new Button();
            GbPembayaran = new GroupBox();
            label5 = new Label();
            LbTotalBayarServis = new Label();
            GbDetailKerusakan = new GroupBox();
            label4 = new Label();
            label3 = new Label();
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
            GbCariService.Location = new Point(26, 13);
            GbCariService.Margin = new Padding(4, 3, 4, 3);
            GbCariService.Name = "GbCariService";
            GbCariService.Padding = new Padding(4, 3, 4, 3);
            GbCariService.Size = new Size(804, 127);
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
            BtnCariIdServis.Location = new Point(504, 55);
            BtnCariIdServis.Margin = new Padding(4, 3, 4, 3);
            BtnCariIdServis.Name = "BtnCariIdServis";
            BtnCariIdServis.Size = new Size(113, 43);
            BtnCariIdServis.TabIndex = 2;
            BtnCariIdServis.Text = "Cari";
            BtnCariIdServis.UseVisualStyleBackColor = false;
            BtnCariIdServis.Click += BtnCariIdServis_Click;
            // 
            // TbCariIdService
            // 
            TbCariIdService.Location = new Point(217, 55);
            TbCariIdService.Margin = new Padding(4, 3, 4, 3);
            TbCariIdService.Name = "TbCariIdService";
            TbCariIdService.Size = new Size(277, 39);
            TbCariIdService.TabIndex = 1;
            // 
            // LbCariService
            // 
            LbCariService.AutoSize = true;
            LbCariService.Location = new Point(14, 53);
            LbCariService.Margin = new Padding(4, 0, 4, 0);
            LbCariService.Name = "LbCariService";
            LbCariService.Size = new Size(192, 32);
            LbCariService.TabIndex = 0;
            LbCariService.Text = "Cari Id Service :";
            // 
            // GbDataService
            // 
            GbDataService.Controls.Add(label2);
            GbDataService.Controls.Add(label1);
            GbDataService.Controls.Add(groupBox1);
            GbDataService.Controls.Add(LbNamaAlat);
            GbDataService.Controls.Add(LbIdService);
            GbDataService.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GbDataService.ForeColor = SystemColors.ActiveCaptionText;
            GbDataService.Location = new Point(23, 147);
            GbDataService.Margin = new Padding(4, 3, 4, 3);
            GbDataService.Name = "GbDataService";
            GbDataService.Padding = new Padding(4, 3, 4, 3);
            GbDataService.Size = new Size(806, 157);
            GbDataService.TabIndex = 2;
            GbDataService.TabStop = false;
            GbDataService.Text = "Data Service ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 105);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(24, 32);
            label2.TabIndex = 5;
            label2.Text = "-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 55);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(24, 32);
            label1.TabIndex = 4;
            label1.Text = "-";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(0, 238);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(313, 157);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // LbNamaAlat
            // 
            LbNamaAlat.AutoSize = true;
            LbNamaAlat.ForeColor = Color.ForestGreen;
            LbNamaAlat.Location = new Point(19, 105);
            LbNamaAlat.Margin = new Padding(4, 0, 4, 0);
            LbNamaAlat.Name = "LbNamaAlat";
            LbNamaAlat.Size = new Size(148, 32);
            LbNamaAlat.TabIndex = 1;
            LbNamaAlat.Text = "Nama Alat :";
            // 
            // LbIdService
            // 
            LbIdService.AutoSize = true;
            LbIdService.ForeColor = Color.ForestGreen;
            LbIdService.Location = new Point(19, 55);
            LbIdService.Margin = new Padding(4, 0, 4, 0);
            LbIdService.Name = "LbIdService";
            LbIdService.Size = new Size(147, 32);
            LbIdService.TabIndex = 0;
            LbIdService.Text = "Id Service : ";
            // 
            // PanelMainService
            // 
            PanelMainService.BackColor = Color.WhiteSmoke;
            PanelMainService.Controls.Add(BtnBayarService);
            PanelMainService.Controls.Add(Btnbatal);
            PanelMainService.Controls.Add(GbPembayaran);
            PanelMainService.Controls.Add(GbDetailKerusakan);
            PanelMainService.Controls.Add(GbDataService);
            PanelMainService.Controls.Add(GbCariService);
            PanelMainService.Location = new Point(4, 3);
            PanelMainService.Margin = new Padding(4, 3, 4, 3);
            PanelMainService.Name = "PanelMainService";
            PanelMainService.Size = new Size(1250, 823);
            PanelMainService.TabIndex = 0;
            PanelMainService.Paint += PanelMainService_Paint;
            // 
            // BtnBayarService
            // 
            BtnBayarService.BackColor = Color.ForestGreen;
            BtnBayarService.FlatStyle = FlatStyle.Flat;
            BtnBayarService.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBayarService.ForeColor = Color.White;
            BtnBayarService.Location = new Point(26, 620);
            BtnBayarService.Margin = new Padding(4, 3, 4, 3);
            BtnBayarService.Name = "BtnBayarService";
            BtnBayarService.Size = new Size(186, 53);
            BtnBayarService.TabIndex = 4;
            BtnBayarService.Text = "Bayar Service";
            BtnBayarService.UseVisualStyleBackColor = false;
            BtnBayarService.Click += BtnBayarService_Click;
            // 
            // Btnbatal
            // 
            Btnbatal.BackColor = Color.Red;
            Btnbatal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btnbatal.ForeColor = Color.White;
            Btnbatal.Location = new Point(243, 620);
            Btnbatal.Margin = new Padding(4, 3, 4, 3);
            Btnbatal.Name = "Btnbatal";
            Btnbatal.Size = new Size(213, 53);
            Btnbatal.TabIndex = 5;
            Btnbatal.Text = "batal";
            Btnbatal.UseVisualStyleBackColor = false;
            Btnbatal.Click += Btnbatal_Click;
            // 
            // GbPembayaran
            // 
            GbPembayaran.Controls.Add(label5);
            GbPembayaran.Controls.Add(LbTotalBayarServis);
            GbPembayaran.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GbPembayaran.Location = new Point(23, 473);
            GbPembayaran.Margin = new Padding(4, 3, 4, 3);
            GbPembayaran.Name = "GbPembayaran";
            GbPembayaran.Padding = new Padding(4, 3, 4, 3);
            GbPembayaran.Size = new Size(806, 113);
            GbPembayaran.TabIndex = 4;
            GbPembayaran.TabStop = false;
            GbPembayaran.Text = "Pembayaran";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(236, 60);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(24, 32);
            label5.TabIndex = 8;
            label5.Text = "-";
            // 
            // LbTotalBayarServis
            // 
            LbTotalBayarServis.AutoSize = true;
            LbTotalBayarServis.ForeColor = Color.ForestGreen;
            LbTotalBayarServis.Location = new Point(9, 60);
            LbTotalBayarServis.Margin = new Padding(4, 0, 4, 0);
            LbTotalBayarServis.Name = "LbTotalBayarServis";
            LbTotalBayarServis.Size = new Size(230, 32);
            LbTotalBayarServis.TabIndex = 2;
            LbTotalBayarServis.Text = "Total Bayar Servis :";
            // 
            // GbDetailKerusakan
            // 
            GbDetailKerusakan.Controls.Add(label4);
            GbDetailKerusakan.Controls.Add(label3);
            GbDetailKerusakan.Controls.Add(LbSparePart);
            GbDetailKerusakan.Controls.Add(LbKerusakan);
            GbDetailKerusakan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GbDetailKerusakan.Location = new Point(26, 310);
            GbDetailKerusakan.Margin = new Padding(4, 3, 4, 3);
            GbDetailKerusakan.Name = "GbDetailKerusakan";
            GbDetailKerusakan.Padding = new Padding(4, 3, 4, 3);
            GbDetailKerusakan.Size = new Size(804, 157);
            GbDetailKerusakan.TabIndex = 3;
            GbDetailKerusakan.TabStop = false;
            GbDetailKerusakan.Text = "Detail Kerusakan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(233, 102);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(24, 32);
            label4.TabIndex = 7;
            label4.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 48);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(24, 32);
            label3.TabIndex = 6;
            label3.Text = "-";
            // 
            // LbSparePart
            // 
            LbSparePart.AutoSize = true;
            LbSparePart.ForeColor = Color.ForestGreen;
            LbSparePart.Location = new Point(11, 102);
            LbSparePart.Margin = new Padding(4, 0, 4, 0);
            LbSparePart.Name = "LbSparePart";
            LbSparePart.Size = new Size(140, 32);
            LbSparePart.TabIndex = 2;
            LbSparePart.Text = "Sparepart :";
            // 
            // LbKerusakan
            // 
            LbKerusakan.AutoSize = true;
            LbKerusakan.ForeColor = Color.ForestGreen;
            LbKerusakan.Location = new Point(11, 48);
            LbKerusakan.Margin = new Padding(4, 0, 4, 0);
            LbKerusakan.Name = "LbKerusakan";
            LbKerusakan.Size = new Size(154, 32);
            LbKerusakan.TabIndex = 0;
            LbKerusakan.Text = "Kerusakan : ";
            // 
            // UcTransaksiService
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelMainService);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UcTransaksiService";
            Size = new Size(1254, 827);
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
        private Button Btnbatal;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
    }
}
