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
            LbNamaAlamat = new Label();
            LbNamaAlat = new Label();
            LbIdService = new Label();
            PanelMainService = new Panel();
            GbPembayaran = new GroupBox();
            LbBiayaStatus = new Label();
            LbTotalBayar = new Label();
            LbBiayaSparePart = new Label();
            LbBiayaJasa = new Label();
            GbDetailKerusakan = new GroupBox();
            LbSparePart = new Label();
            LbDiagnosa = new Label();
            LbKerusakan = new Label();
            BtnBayarService = new Button();
            BtnSelesai = new Button();
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
            GbCariService.Location = new Point(20, 10);
            GbCariService.Name = "GbCariService";
            GbCariService.Size = new Size(643, 101);
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
            BtnCariIdServis.Location = new Point(403, 44);
            BtnCariIdServis.Name = "BtnCariIdServis";
            BtnCariIdServis.Size = new Size(90, 34);
            BtnCariIdServis.TabIndex = 2;
            BtnCariIdServis.Text = "Cari";
            BtnCariIdServis.UseVisualStyleBackColor = false;
            // 
            // TbCariIdService
            // 
            TbCariIdService.Location = new Point(174, 44);
            TbCariIdService.Name = "TbCariIdService";
            TbCariIdService.Size = new Size(222, 34);
            TbCariIdService.TabIndex = 1;
            // 
            // LbCariService
            // 
            LbCariService.AutoSize = true;
            LbCariService.Location = new Point(11, 43);
            LbCariService.Name = "LbCariService";
            LbCariService.Size = new Size(159, 28);
            LbCariService.TabIndex = 0;
            LbCariService.Text = "Cari Id Service :";
            // 
            // GbDataService
            // 
            GbDataService.Controls.Add(groupBox1);
            GbDataService.Controls.Add(LbNamaAlamat);
            GbDataService.Controls.Add(LbNamaAlat);
            GbDataService.Controls.Add(LbIdService);
            GbDataService.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GbDataService.ForeColor = SystemColors.ActiveCaptionText;
            GbDataService.Location = new Point(18, 117);
            GbDataService.Name = "GbDataService";
            GbDataService.Size = new Size(645, 185);
            GbDataService.TabIndex = 2;
            GbDataService.TabStop = false;
            GbDataService.Text = "Data Service ";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(0, 191);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // LbNamaAlamat
            // 
            LbNamaAlamat.AutoSize = true;
            LbNamaAlamat.ForeColor = Color.ForestGreen;
            LbNamaAlamat.Location = new Point(15, 125);
            LbNamaAlamat.Name = "LbNamaAlamat";
            LbNamaAlamat.Size = new Size(153, 28);
            LbNamaAlamat.TabIndex = 2;
            LbNamaAlamat.Text = "Nama Alamat :";
            // 
            // LbNamaAlat
            // 
            LbNamaAlat.AutoSize = true;
            LbNamaAlat.ForeColor = Color.ForestGreen;
            LbNamaAlat.Location = new Point(15, 84);
            LbNamaAlat.Name = "LbNamaAlat";
            LbNamaAlat.Size = new Size(124, 28);
            LbNamaAlat.TabIndex = 1;
            LbNamaAlat.Text = "Nama Alat :";
            // 
            // LbIdService
            // 
            LbIdService.AutoSize = true;
            LbIdService.ForeColor = Color.ForestGreen;
            LbIdService.Location = new Point(15, 44);
            LbIdService.Name = "LbIdService";
            LbIdService.Size = new Size(122, 28);
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
            PanelMainService.Location = new Point(3, 3);
            PanelMainService.Name = "PanelMainService";
            PanelMainService.Size = new Size(1000, 658);
            PanelMainService.TabIndex = 0;
            PanelMainService.Paint += PanelMainService_Paint;
            // 
            // GbPembayaran
            // 
            GbPembayaran.Controls.Add(LbBiayaStatus);
            GbPembayaran.Controls.Add(LbTotalBayar);
            GbPembayaran.Controls.Add(LbBiayaSparePart);
            GbPembayaran.Controls.Add(LbBiayaJasa);
            GbPembayaran.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GbPembayaran.Location = new Point(18, 481);
            GbPembayaran.Name = "GbPembayaran";
            GbPembayaran.Size = new Size(645, 171);
            GbPembayaran.TabIndex = 4;
            GbPembayaran.TabStop = false;
            GbPembayaran.Text = "Pembayaran";
            // 
            // LbBiayaStatus
            // 
            LbBiayaStatus.AutoSize = true;
            LbBiayaStatus.ForeColor = Color.ForestGreen;
            LbBiayaStatus.Location = new Point(15, 123);
            LbBiayaStatus.Name = "LbBiayaStatus";
            LbBiayaStatus.Size = new Size(140, 28);
            LbBiayaStatus.TabIndex = 3;
            LbBiayaStatus.Text = "Biaya Status :";
            // 
            // LbTotalBayar
            // 
            LbTotalBayar.AutoSize = true;
            LbTotalBayar.ForeColor = Color.ForestGreen;
            LbTotalBayar.Location = new Point(15, 92);
            LbTotalBayar.Name = "LbTotalBayar";
            LbTotalBayar.Size = new Size(188, 28);
            LbTotalBayar.TabIndex = 2;
            LbTotalBayar.Text = "Biaya Total Bayar :";
            // 
            // LbBiayaSparePart
            // 
            LbBiayaSparePart.AutoSize = true;
            LbBiayaSparePart.ForeColor = Color.ForestGreen;
            LbBiayaSparePart.Location = new Point(14, 62);
            LbBiayaSparePart.Name = "LbBiayaSparePart";
            LbBiayaSparePart.Size = new Size(174, 28);
            LbBiayaSparePart.TabIndex = 1;
            LbBiayaSparePart.Text = "Biaya Sparepart :";
            // 
            // LbBiayaJasa
            // 
            LbBiayaJasa.AutoSize = true;
            LbBiayaJasa.ForeColor = Color.ForestGreen;
            LbBiayaJasa.Location = new Point(14, 30);
            LbBiayaJasa.Name = "LbBiayaJasa";
            LbBiayaJasa.Size = new Size(121, 28);
            LbBiayaJasa.TabIndex = 0;
            LbBiayaJasa.Text = "Biaya Jasa :";
            // 
            // GbDetailKerusakan
            // 
            GbDetailKerusakan.Controls.Add(LbSparePart);
            GbDetailKerusakan.Controls.Add(LbDiagnosa);
            GbDetailKerusakan.Controls.Add(LbKerusakan);
            GbDetailKerusakan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GbDetailKerusakan.Location = new Point(20, 308);
            GbDetailKerusakan.Name = "GbDetailKerusakan";
            GbDetailKerusakan.Size = new Size(643, 167);
            GbDetailKerusakan.TabIndex = 3;
            GbDetailKerusakan.TabStop = false;
            GbDetailKerusakan.Text = "Detail Kerusakan";
            // 
            // LbSparePart
            // 
            LbSparePart.AutoSize = true;
            LbSparePart.ForeColor = Color.ForestGreen;
            LbSparePart.Location = new Point(13, 124);
            LbSparePart.Name = "LbSparePart";
            LbSparePart.Size = new Size(116, 28);
            LbSparePart.TabIndex = 2;
            LbSparePart.Text = "Sparepart :";
            // 
            // LbDiagnosa
            // 
            LbDiagnosa.AutoSize = true;
            LbDiagnosa.ForeColor = Color.ForestGreen;
            LbDiagnosa.Location = new Point(11, 79);
            LbDiagnosa.Name = "LbDiagnosa";
            LbDiagnosa.Size = new Size(111, 28);
            LbDiagnosa.TabIndex = 1;
            LbDiagnosa.Text = "Diagnosa :";
            // 
            // LbKerusakan
            // 
            LbKerusakan.AutoSize = true;
            LbKerusakan.ForeColor = Color.ForestGreen;
            LbKerusakan.Location = new Point(9, 39);
            LbKerusakan.Name = "LbKerusakan";
            LbKerusakan.Size = new Size(127, 28);
            LbKerusakan.TabIndex = 0;
            LbKerusakan.Text = "Kerusakan : ";
            // 
            // BtnBayarService
            // 
            BtnBayarService.BackColor = Color.ForestGreen;
            BtnBayarService.FlatStyle = FlatStyle.Flat;
            BtnBayarService.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBayarService.ForeColor = Color.White;
            BtnBayarService.Location = new Point(682, 529);
            BtnBayarService.Name = "BtnBayarService";
            BtnBayarService.Size = new Size(148, 42);
            BtnBayarService.TabIndex = 4;
            BtnBayarService.Text = "Bayar Service";
            BtnBayarService.UseVisualStyleBackColor = false;
            // 
            // BtnSelesai
            // 
            BtnSelesai.BackColor = Color.Red;
            BtnSelesai.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSelesai.ForeColor = Color.White;
            BtnSelesai.Location = new Point(682, 577);
            BtnSelesai.Name = "BtnSelesai";
            BtnSelesai.Size = new Size(148, 29);
            BtnSelesai.TabIndex = 5;
            BtnSelesai.Text = "Selesai";
            BtnSelesai.UseVisualStyleBackColor = false;
            // 
            // TransaksiService
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelMainService);
            Name = "TransaksiService";
            Size = new Size(1003, 661);
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
        private Label LbTotalBayar;
        private Button BtnBayarService;
        private Button BtnSelesai;
    }
}
