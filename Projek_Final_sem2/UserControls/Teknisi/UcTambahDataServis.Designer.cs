namespace Projek_Final_sem2.UserControls.Teknisi
{
    partial class UcTambahDataServis
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
            LblTambahDataServis = new Label();
            TbxNamaAlat = new TextBox();
            label1 = new Label();
            TbxKerusakan = new TextBox();
            LblKerusakan = new Label();
            TbxBiayaServis = new TextBox();
            LblBiayaServis = new Label();
            BtnSimpan = new Button();
            BtnBatal = new Button();
            SuspendLayout();
            // 
            // LblTambahDataServis
            // 
            LblTambahDataServis.AutoSize = true;
            LblTambahDataServis.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTambahDataServis.Location = new Point(88, 13);
            LblTambahDataServis.Name = "LblTambahDataServis";
            LblTambahDataServis.Size = new Size(185, 25);
            LblTambahDataServis.TabIndex = 0;
            LblTambahDataServis.Text = "Tambah Data Servis";
            // 
            // TbxNamaAlat
            // 
            TbxNamaAlat.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TbxNamaAlat.ForeColor = SystemColors.AppWorkspace;
            TbxNamaAlat.Location = new Point(94, 59);
            TbxNamaAlat.Name = "TbxNamaAlat";
            TbxNamaAlat.Size = new Size(266, 23);
            TbxNamaAlat.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 59);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 2;
            label1.Text = "Nama Alat";
            // 
            // TbxKerusakan
            // 
            TbxKerusakan.ForeColor = SystemColors.ButtonShadow;
            TbxKerusakan.Location = new Point(94, 88);
            TbxKerusakan.Name = "TbxKerusakan";
            TbxKerusakan.Size = new Size(266, 23);
            TbxKerusakan.TabIndex = 3;
            // 
            // LblKerusakan
            // 
            LblKerusakan.AutoSize = true;
            LblKerusakan.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblKerusakan.Location = new Point(19, 89);
            LblKerusakan.Name = "LblKerusakan";
            LblKerusakan.Size = new Size(68, 17);
            LblKerusakan.TabIndex = 4;
            LblKerusakan.Text = "Kerusakan";
            // 
            // TbxBiayaServis
            // 
            TbxBiayaServis.ForeColor = SystemColors.ButtonShadow;
            TbxBiayaServis.Location = new Point(94, 117);
            TbxBiayaServis.Name = "TbxBiayaServis";
            TbxBiayaServis.Size = new Size(266, 23);
            TbxBiayaServis.TabIndex = 5;
            TbxBiayaServis.KeyPress += TbxBiayaServis_KeyPress;
            // 
            // LblBiayaServis
            // 
            LblBiayaServis.AutoSize = true;
            LblBiayaServis.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblBiayaServis.Location = new Point(12, 117);
            LblBiayaServis.Name = "LblBiayaServis";
            LblBiayaServis.Size = new Size(76, 17);
            LblBiayaServis.TabIndex = 6;
            LblBiayaServis.Text = "Biaya Servis";
            // 
            // BtnSimpan
            // 
            BtnSimpan.BackColor = Color.LimeGreen;
            BtnSimpan.Location = new Point(88, 165);
            BtnSimpan.Name = "BtnSimpan";
            BtnSimpan.Size = new Size(75, 23);
            BtnSimpan.TabIndex = 7;
            BtnSimpan.Text = "Simpan";
            BtnSimpan.UseVisualStyleBackColor = false;
            BtnSimpan.Click += BtnSimpan_Click;
            // 
            // BtnBatal
            // 
            BtnBatal.BackColor = Color.Red;
            BtnBatal.Location = new Point(285, 165);
            BtnBatal.Name = "BtnBatal";
            BtnBatal.Size = new Size(75, 23);
            BtnBatal.TabIndex = 8;
            BtnBatal.Text = "Batal";
            BtnBatal.UseVisualStyleBackColor = false;
            BtnBatal.Click += BtnBatal_Click;
            // 
            // UcTambahDataServis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BtnBatal);
            Controls.Add(BtnSimpan);
            Controls.Add(LblBiayaServis);
            Controls.Add(TbxBiayaServis);
            Controls.Add(LblKerusakan);
            Controls.Add(TbxKerusakan);
            Controls.Add(label1);
            Controls.Add(TbxNamaAlat);
            Controls.Add(LblTambahDataServis);
            Name = "UcTambahDataServis";
            Size = new Size(418, 257);
            Load += UcTambahDataServis_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTambahDataServis;
        private TextBox TbxNamaAlat;
        private Label label1;
        private TextBox TbxKerusakan;
        private Label LblKerusakan;
        private TextBox TbxBiayaServis;
        private Label LblBiayaServis;
        private Button BtnSimpan;
        private Button BtnBatal;
    }
}
