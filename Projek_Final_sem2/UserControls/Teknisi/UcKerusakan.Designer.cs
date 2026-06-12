namespace Projek_Final_sem2.UserControls.Teknisi
{
    partial class UcKerusakan
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
            label1 = new Label();
            LblTanggalKerusakan = new Label();
            LblNamaAlatKerusakan = new Label();
            LblDetailKerusakan = new Label();
            TbxBiayaServisKerusakan = new TextBox();
            RtbxKerusakan = new RichTextBox();
            TbxNamaALatKerusakan = new TextBox();
            label2 = new Label();
            BtnBatalKerusakan = new Button();
            DtpKerusakan = new DateTimePicker();
            BtnSimpanKerusakan = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(199, 25);
            label1.TabIndex = 0;
            label1.Text = "Input Kerusakan Alat";
            // 
            // LblTanggalKerusakan
            // 
            LblTanggalKerusakan.AutoSize = true;
            LblTanggalKerusakan.Location = new Point(18, 55);
            LblTanggalKerusakan.Name = "LblTanggalKerusakan";
            LblTanggalKerusakan.Size = new Size(49, 15);
            LblTanggalKerusakan.TabIndex = 2;
            LblTanggalKerusakan.Text = "Tanggal";
            // 
            // LblNamaAlatKerusakan
            // 
            LblNamaAlatKerusakan.AutoSize = true;
            LblNamaAlatKerusakan.Location = new Point(18, 84);
            LblNamaAlatKerusakan.Name = "LblNamaAlatKerusakan";
            LblNamaAlatKerusakan.Size = new Size(63, 15);
            LblNamaAlatKerusakan.TabIndex = 3;
            LblNamaAlatKerusakan.Text = "Nama Alat";
            // 
            // LblDetailKerusakan
            // 
            LblDetailKerusakan.AutoSize = true;
            LblDetailKerusakan.Location = new Point(18, 110);
            LblDetailKerusakan.Name = "LblDetailKerusakan";
            LblDetailKerusakan.Size = new Size(61, 15);
            LblDetailKerusakan.TabIndex = 4;
            LblDetailKerusakan.Text = "Kerusakan";
            LblDetailKerusakan.Click += LblDetailKerusakan_Click;
            // 
            // TbxBiayaServisKerusakan
            // 
            TbxBiayaServisKerusakan.Location = new Point(117, 212);
            TbxBiayaServisKerusakan.Name = "TbxBiayaServisKerusakan";
            TbxBiayaServisKerusakan.Size = new Size(223, 23);
            TbxBiayaServisKerusakan.TabIndex = 8;
            TbxBiayaServisKerusakan.KeyPress += TbxBiayaServisKerusakan_KeyPress;
            // 
            // RtbxKerusakan
            // 
            RtbxKerusakan.Location = new Point(117, 110);
            RtbxKerusakan.Name = "RtbxKerusakan";
            RtbxKerusakan.Size = new Size(331, 96);
            RtbxKerusakan.TabIndex = 9;
            RtbxKerusakan.Text = "";
            // 
            // TbxNamaALatKerusakan
            // 
            TbxNamaALatKerusakan.Location = new Point(117, 81);
            TbxNamaALatKerusakan.Name = "TbxNamaALatKerusakan";
            TbxNamaALatKerusakan.Size = new Size(331, 23);
            TbxNamaALatKerusakan.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 212);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 11;
            label2.Text = "Biaya Servis (RP)";
            // 
            // BtnBatalKerusakan
            // 
            BtnBatalKerusakan.BackColor = Color.Red;
            BtnBatalKerusakan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBatalKerusakan.Location = new Point(373, 263);
            BtnBatalKerusakan.Name = "BtnBatalKerusakan";
            BtnBatalKerusakan.Size = new Size(75, 23);
            BtnBatalKerusakan.TabIndex = 13;
            BtnBatalKerusakan.Text = "Batal";
            BtnBatalKerusakan.UseVisualStyleBackColor = false;
            BtnBatalKerusakan.Click += BtnBatalKerusakan_Click;
            // 
            // DtpKerusakan
            // 
            DtpKerusakan.Location = new Point(117, 49);
            DtpKerusakan.Name = "DtpKerusakan";
            DtpKerusakan.Size = new Size(223, 23);
            DtpKerusakan.TabIndex = 14;
            DtpKerusakan.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // BtnSimpanKerusakan
            // 
            BtnSimpanKerusakan.BackColor = Color.Green;
            BtnSimpanKerusakan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSimpanKerusakan.Location = new Point(117, 263);
            BtnSimpanKerusakan.Name = "BtnSimpanKerusakan";
            BtnSimpanKerusakan.Size = new Size(75, 23);
            BtnSimpanKerusakan.TabIndex = 15;
            BtnSimpanKerusakan.Text = "Simpan";
            BtnSimpanKerusakan.UseVisualStyleBackColor = false;
            BtnSimpanKerusakan.Click += BtnSimpanKerusakan_Click_1;
            // 
            // UcKerusakan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BtnSimpanKerusakan);
            Controls.Add(DtpKerusakan);
            Controls.Add(BtnBatalKerusakan);
            Controls.Add(label2);
            Controls.Add(TbxNamaALatKerusakan);
            Controls.Add(RtbxKerusakan);
            Controls.Add(TbxBiayaServisKerusakan);
            Controls.Add(LblDetailKerusakan);
            Controls.Add(LblNamaAlatKerusakan);
            Controls.Add(LblTanggalKerusakan);
            Controls.Add(label1);
            Name = "UcKerusakan";
            Size = new Size(639, 385);
            Load += UcKerusakan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label LblTanggalKerusakan;
        private Label LblNamaAlatKerusakan;
        private Label LblDetailKerusakan;
        private TextBox TbxTanggalKerusakan;
        private TextBox TbxBiayaServisKerusakan;
        private RichTextBox RtbxKerusakan;
        private TextBox TbxNamaALatKerusakan;
        private Label label2;
        private Button button1;
        private Button BtnBatalKerusakan;
        private DateTimePicker DtpKerusakan;
        private Button BtnSimpanKerusakan;
    }
}
