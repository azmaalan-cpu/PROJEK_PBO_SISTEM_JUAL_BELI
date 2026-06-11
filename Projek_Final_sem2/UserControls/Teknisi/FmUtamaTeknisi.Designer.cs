namespace Projek_Final_sem2.UserControls.Teknisi
{
    partial class FmUtamaTeknisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmUtamaTeknisi));
            panel1 = new Panel();
            panel2 = new Panel();
            BtnLogoutTeknisi = new Button();
            BtnRiwayat = new Button();
            BtnStatus = new Button();
            BtnKerusakan = new Button();
            LbMenuUtamaTeknisi = new Label();
            LbTeknisi = new Label();
            PcxMenuTeknisi = new PictureBox();
            BtnDataServis = new Button();
            BtnDashboardTeknisi = new Button();
            panelcontent = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PcxMenuTeknisi).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(panelcontent);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(BtnLogoutTeknisi);
            panel1.Controls.Add(BtnRiwayat);
            panel1.Controls.Add(BtnStatus);
            panel1.Controls.Add(BtnKerusakan);
            panel1.Controls.Add(LbMenuUtamaTeknisi);
            panel1.Controls.Add(LbTeknisi);
            panel1.Controls.Add(PcxMenuTeknisi);
            panel1.Controls.Add(BtnDataServis);
            panel1.Controls.Add(BtnDashboardTeknisi);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 449);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Location = new Point(202, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 446);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // BtnLogoutTeknisi
            // 
            BtnLogoutTeknisi.BackColor = Color.LimeGreen;
            BtnLogoutTeknisi.Location = new Point(12, 405);
            BtnLogoutTeknisi.Name = "BtnLogoutTeknisi";
            BtnLogoutTeknisi.Size = new Size(171, 23);
            BtnLogoutTeknisi.TabIndex = 10;
            BtnLogoutTeknisi.Text = "Log Out";
            BtnLogoutTeknisi.UseVisualStyleBackColor = false;
            BtnLogoutTeknisi.Click += BtnLogoutTeknisi_Click;
            // 
            // BtnRiwayat
            // 
            BtnRiwayat.BackColor = Color.LimeGreen;
            BtnRiwayat.Location = new Point(12, 225);
            BtnRiwayat.Name = "BtnRiwayat";
            BtnRiwayat.Size = new Size(171, 23);
            BtnRiwayat.TabIndex = 11;
            BtnRiwayat.Text = "Riwayat";
            BtnRiwayat.UseVisualStyleBackColor = false;
            BtnRiwayat.Click += BtnRiwayat_Click;
            // 
            // BtnStatus
            // 
            BtnStatus.BackColor = Color.LimeGreen;
            BtnStatus.Location = new Point(12, 196);
            BtnStatus.Name = "BtnStatus";
            BtnStatus.Size = new Size(171, 23);
            BtnStatus.TabIndex = 10;
            BtnStatus.Text = "Status";
            BtnStatus.UseVisualStyleBackColor = false;
            BtnStatus.Click += BtnStatus_Click;
            // 
            // BtnKerusakan
            // 
            BtnKerusakan.BackColor = Color.LimeGreen;
            BtnKerusakan.Location = new Point(12, 167);
            BtnKerusakan.Name = "BtnKerusakan";
            BtnKerusakan.Size = new Size(171, 23);
            BtnKerusakan.TabIndex = 9;
            BtnKerusakan.Text = "Kerusakan";
            BtnKerusakan.UseVisualStyleBackColor = false;
            BtnKerusakan.Click += BtnKerusakan_Click;
            // 
            // LbMenuUtamaTeknisi
            // 
            LbMenuUtamaTeknisi.AutoSize = true;
            LbMenuUtamaTeknisi.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbMenuUtamaTeknisi.ForeColor = Color.White;
            LbMenuUtamaTeknisi.Location = new Point(15, 19);
            LbMenuUtamaTeknisi.Name = "LbMenuUtamaTeknisi";
            LbMenuUtamaTeknisi.Size = new Size(98, 17);
            LbMenuUtamaTeknisi.TabIndex = 8;
            LbMenuUtamaTeknisi.Text = "Menu Utama";
            LbMenuUtamaTeknisi.Click += LbMenuUtama_Click;
            // 
            // LbTeknisi
            // 
            LbTeknisi.AutoSize = true;
            LbTeknisi.BackColor = Color.DarkGreen;
            LbTeknisi.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbTeknisi.ForeColor = Color.White;
            LbTeknisi.Location = new Point(75, 44);
            LbTeknisi.Name = "LbTeknisi";
            LbTeknisi.Size = new Size(58, 19);
            LbTeknisi.TabIndex = 6;
            LbTeknisi.Text = "Teknisi";
            LbTeknisi.Click += LbKasir_Click;
            // 
            // PcxMenuTeknisi
            // 
            PcxMenuTeknisi.BackColor = Color.Transparent;
            PcxMenuTeknisi.BackgroundImage = (Image)resources.GetObject("PcxMenuTeknisi.BackgroundImage");
            PcxMenuTeknisi.BackgroundImageLayout = ImageLayout.Stretch;
            PcxMenuTeknisi.Location = new Point(12, 44);
            PcxMenuTeknisi.Margin = new Padding(3, 2, 3, 2);
            PcxMenuTeknisi.Name = "PcxMenuTeknisi";
            PcxMenuTeknisi.Size = new Size(57, 47);
            PcxMenuTeknisi.SizeMode = PictureBoxSizeMode.StretchImage;
            PcxMenuTeknisi.TabIndex = 5;
            PcxMenuTeknisi.TabStop = false;
            PcxMenuTeknisi.Click += PcxMenuKasir_Click;
            // 
            // BtnDataServis
            // 
            BtnDataServis.BackColor = Color.LimeGreen;
            BtnDataServis.Location = new Point(12, 138);
            BtnDataServis.Name = "BtnDataServis";
            BtnDataServis.Size = new Size(171, 23);
            BtnDataServis.TabIndex = 1;
            BtnDataServis.Text = "Data Servis";
            BtnDataServis.UseVisualStyleBackColor = false;
            BtnDataServis.Click += BtnDataServis_Click;
            // 
            // BtnDashboardTeknisi
            // 
            BtnDashboardTeknisi.BackColor = Color.LimeGreen;
            BtnDashboardTeknisi.Location = new Point(12, 109);
            BtnDashboardTeknisi.Name = "BtnDashboardTeknisi";
            BtnDashboardTeknisi.Size = new Size(171, 23);
            BtnDashboardTeknisi.TabIndex = 0;
            BtnDashboardTeknisi.Text = "Dashboard";
            BtnDashboardTeknisi.UseVisualStyleBackColor = false;
            BtnDashboardTeknisi.Click += BtnDashboardTeknisi_Click;
            // 
            // panelcontent
            // 
            panelcontent.Location = new Point(200, 1);
            panelcontent.Name = "panelcontent";
            panelcontent.Size = new Size(600, 449);
            panelcontent.TabIndex = 1;
            panelcontent.Paint += panelcontent_Paint;
            // 
            // FmUtamaTeknisi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FmUtamaTeknisi";
            Text = "Form1";
            Load += FmUtamaTeknisi_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PcxMenuTeknisi).EndInit();
            ResumeLayout(false);
        }
        private void loadControl(UserControl uc)
        {
            panelcontent.Controls.Clear();

            uc.Dock = DockStyle.Fill;

            panelcontent.Controls.Add(uc);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnDashboardTeknisi_Click(object sender, EventArgs e)
        {
            loadControl(new UcDasboardTeknisi());
            throw new NotImplementedException();
        }

        private void PcxMenuKasir_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LbKasir_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LbMenuUtama_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        

        #endregion

        private Panel panel1;
        private Button BtnDashboardTeknisi;
        private Button BtnDataServis;
        private Label LbMenuUtamaTeknisi;
        private Label LbTeknisi;
        private PictureBox PcxMenuTeknisi;
        private Button BtnKerusakan;
        private Button BtnStatus;
        private Button BtnLogoutTeknisi;
        private Button BtnRiwayat;
        private Panel panel2;
        private Panel panelcontent;
    }
}

//skndfsfhsldbj