namespace Projek_Final_sem2.UserControls.Teknisi
{
    partial class UcStatus
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
            LblStatusServis = new Label();
            LblNamaALatStatus = new Label();
            LblStatusSaatIni = new Label();
            label1 = new Label();
            CmbUbahStatus = new ComboBox();
            LblIDServisStatus = new Label();
            BtnUpdateStatus = new Button();
            BtnBatalStatus = new Button();
            BtnCariStatus = new Button();
            label2 = new Label();
            TbxIDServisStatus = new TextBox();
            TbxNamaAlatStatus = new TextBox();
            SuspendLayout();
            // 
            // LblStatusServis
            // 
            LblStatusServis.AutoSize = true;
            LblStatusServis.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblStatusServis.Location = new Point(12, 13);
            LblStatusServis.Name = "LblStatusServis";
            LblStatusServis.Size = new Size(125, 25);
            LblStatusServis.TabIndex = 0;
            LblStatusServis.Text = "Status Servis";
            // 
            // LblNamaALatStatus
            // 
            LblNamaALatStatus.AutoSize = true;
            LblNamaALatStatus.Font = new Font("Segoe UI", 11.25F);
            LblNamaALatStatus.Location = new Point(12, 93);
            LblNamaALatStatus.Name = "LblNamaALatStatus";
            LblNamaALatStatus.Size = new Size(80, 20);
            LblNamaALatStatus.TabIndex = 1;
            LblNamaALatStatus.Text = "Nama Alat";
            // 
            // LblStatusSaatIni
            // 
            LblStatusSaatIni.AutoSize = true;
            LblStatusSaatIni.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblStatusSaatIni.Location = new Point(140, 138);
            LblStatusSaatIni.Name = "LblStatusSaatIni";
            LblStatusSaatIni.Size = new Size(80, 15);
            LblStatusSaatIni.TabIndex = 2;
            LblStatusSaatIni.Text = "Status Saat Ini";
            LblStatusSaatIni.Click += LblStatusSaatIni_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(12, 173);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 4;
            label1.Text = "Ubah Status";
            // 
            // CmbUbahStatus
            // 
            CmbUbahStatus.FormattingEnabled = true;
            CmbUbahStatus.Location = new Point(140, 170);
            CmbUbahStatus.Name = "CmbUbahStatus";
            CmbUbahStatus.Size = new Size(180, 23);
            CmbUbahStatus.TabIndex = 5;
            CmbUbahStatus.SelectedIndexChanged += CmbUbahStatus_SelectedIndexChanged;
            // 
            // LblIDServisStatus
            // 
            LblIDServisStatus.AutoSize = true;
            LblIDServisStatus.Font = new Font("Segoe UI", 11.25F);
            LblIDServisStatus.Location = new Point(12, 56);
            LblIDServisStatus.Name = "LblIDServisStatus";
            LblIDServisStatus.Size = new Size(66, 20);
            LblIDServisStatus.TabIndex = 7;
            LblIDServisStatus.Text = "ID Servis";
            // 
            // BtnUpdateStatus
            // 
            BtnUpdateStatus.BackColor = Color.Lime;
            BtnUpdateStatus.Location = new Point(140, 210);
            BtnUpdateStatus.Name = "BtnUpdateStatus";
            BtnUpdateStatus.Size = new Size(75, 23);
            BtnUpdateStatus.TabIndex = 9;
            BtnUpdateStatus.Text = "Update";
            BtnUpdateStatus.UseVisualStyleBackColor = false;
            BtnUpdateStatus.Click += BtnUpdateStatus_Click;
            // 
            // BtnBatalStatus
            // 
            BtnBatalStatus.Location = new Point(245, 210);
            BtnBatalStatus.Name = "BtnBatalStatus";
            BtnBatalStatus.Size = new Size(75, 23);
            BtnBatalStatus.TabIndex = 10;
            BtnBatalStatus.Text = "X  Batal";
            BtnBatalStatus.UseVisualStyleBackColor = true;
            BtnBatalStatus.Click += BtnBatalStatus_Click;
            // 
            // BtnCariStatus
            // 
            BtnCariStatus.BackColor = SystemColors.ControlLight;
            BtnCariStatus.Location = new Point(346, 57);
            BtnCariStatus.Name = "BtnCariStatus";
            BtnCariStatus.Size = new Size(75, 23);
            BtnCariStatus.TabIndex = 11;
            BtnCariStatus.Text = "Cari";
            BtnCariStatus.UseVisualStyleBackColor = false;
            BtnCariStatus.Click += BtnCariStatus_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 138);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 12;
            label2.Text = "Status";
            // 
            // TbxIDServisStatus
            // 
            TbxIDServisStatus.Location = new Point(140, 53);
            TbxIDServisStatus.Name = "TbxIDServisStatus";
            TbxIDServisStatus.Size = new Size(180, 23);
            TbxIDServisStatus.TabIndex = 13;
            // 
            // TbxNamaAlatStatus
            // 
            TbxNamaAlatStatus.Location = new Point(140, 93);
            TbxNamaAlatStatus.Name = "TbxNamaAlatStatus";
            TbxNamaAlatStatus.Size = new Size(180, 23);
            TbxNamaAlatStatus.TabIndex = 14;
            // 
            // UcStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TbxNamaAlatStatus);
            Controls.Add(TbxIDServisStatus);
            Controls.Add(label2);
            Controls.Add(BtnCariStatus);
            Controls.Add(BtnBatalStatus);
            Controls.Add(BtnUpdateStatus);
            Controls.Add(LblIDServisStatus);
            Controls.Add(CmbUbahStatus);
            Controls.Add(label1);
            Controls.Add(LblStatusSaatIni);
            Controls.Add(LblNamaALatStatus);
            Controls.Add(LblStatusServis);
            Name = "UcStatus";
            Size = new Size(600, 298);
            Load += UcStatus_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblStatusServis;
        private Label LblNamaALatStatus;
        private Label LblStatusSaatIni;
        private Label label1;
        private ComboBox CmbUbahStatus;
        private Label LblIDServisStatus;
        private Button BtnUpdateStatus;
        private Button BtnBatalStatus;
        private Button BtnCariStatus;
        private Label label2;
        private TextBox TbxIDServisStatus;
        private TextBox TbxNamaAlatStatus;
    }
}
