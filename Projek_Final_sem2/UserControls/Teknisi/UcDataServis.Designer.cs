namespace Projek_Final_sem2.UserControls.Teknisi
{
    partial class UcDataServis
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
            components = new System.ComponentModel.Container();
            DgvDataServis = new DataGridView();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            TextCariDataServis = new TextBox();
            label2 = new Label();
            BtnTambahDataServis = new Button();
            ColumnIdServis = new DataGridViewTextBoxColumn();
            ColumnTanggalServis = new DataGridViewTextBoxColumn();
            ColumnNamaAlat = new DataGridViewTextBoxColumn();
            ColumnKerusakan = new DataGridViewTextBoxColumn();
            ColumnBiayaServis = new DataGridViewTextBoxColumn();
            ColumnStatus = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DgvDataServis).BeginInit();
            SuspendLayout();
            // 
            // DgvDataServis
            // 
            DgvDataServis.AllowUserToOrderColumns = true;
            DgvDataServis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDataServis.Columns.AddRange(new DataGridViewColumn[] { ColumnIdServis, ColumnTanggalServis, ColumnNamaAlat, ColumnKerusakan, ColumnBiayaServis, ColumnStatus });
            DgvDataServis.Location = new Point(7, 93);
            DgvDataServis.Name = "DgvDataServis";
            DgvDataServis.Size = new Size(610, 305);
            DgvDataServis.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 1;
            label1.Text = "Data Servis";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // TextCariDataServis
            // 
            TextCariDataServis.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextCariDataServis.ForeColor = SystemColors.ActiveBorder;
            TextCariDataServis.Location = new Point(489, 63);
            TextCariDataServis.Name = "TextCariDataServis";
            TextCariDataServis.Size = new Size(128, 27);
            TextCariDataServis.TabIndex = 3;
            TextCariDataServis.Text = "Nama Alat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(489, 46);
            label2.Name = "label2";
            label2.Size = new Size(54, 16);
            label2.TabIndex = 4;
            label2.Text = "Cari Alat";
            // 
            // BtnTambahDataServis
            // 
            BtnTambahDataServis.BackColor = Color.Green;
            BtnTambahDataServis.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnTambahDataServis.ForeColor = SystemColors.ControlLightLight;
            BtnTambahDataServis.Location = new Point(7, 63);
            BtnTambahDataServis.Name = "BtnTambahDataServis";
            BtnTambahDataServis.Size = new Size(88, 27);
            BtnTambahDataServis.TabIndex = 5;
            BtnTambahDataServis.Text = "Tambah";
            BtnTambahDataServis.UseVisualStyleBackColor = false;
            BtnTambahDataServis.Click += BtnTambahDataServis_Click;
            // 
            // ColumnIdServis
            // 
            ColumnIdServis.HeaderText = "ID Servis";
            ColumnIdServis.Name = "ColumnIdServis";
            ColumnIdServis.Width = 70;
            // 
            // ColumnTanggalServis
            // 
            ColumnTanggalServis.HeaderText = "Tanggal";
            ColumnTanggalServis.Name = "ColumnTanggalServis";
            // 
            // ColumnNamaAlat
            // 
            ColumnNamaAlat.HeaderText = "Nama Alat";
            ColumnNamaAlat.Name = "ColumnNamaAlat";
            ColumnNamaAlat.Width = 120;
            // 
            // ColumnKerusakan
            // 
            ColumnKerusakan.HeaderText = "Kerusakan";
            ColumnKerusakan.Name = "ColumnKerusakan";
            ColumnKerusakan.Width = 120;
            // 
            // ColumnBiayaServis
            // 
            ColumnBiayaServis.HeaderText = "Biaya Servis";
            ColumnBiayaServis.Name = "ColumnBiayaServis";
            // 
            // ColumnStatus
            // 
            ColumnStatus.HeaderText = "Status";
            ColumnStatus.Name = "ColumnStatus";
            ColumnStatus.Width = 80;
            // 
            // UcDataServis
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BtnTambahDataServis);
            Controls.Add(label2);
            Controls.Add(TextCariDataServis);
            Controls.Add(label1);
            Controls.Add(DgvDataServis);
            Font = new Font("Yu Gothic", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Name = "UcDataServis";
            Size = new Size(627, 406);
            ((System.ComponentModel.ISupportInitialize)DgvDataServis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvDataServis;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox TextCariDataServis;
        private Label label2;
        private Button BtnTambahDataServis;
        private DataGridViewTextBoxColumn ColumnIdServis;
        private DataGridViewTextBoxColumn ColumnTanggalServis;
        private DataGridViewTextBoxColumn ColumnNamaAlat;
        private DataGridViewTextBoxColumn ColumnKerusakan;
        private DataGridViewTextBoxColumn ColumnBiayaServis;
        private DataGridViewTextBoxColumn ColumnStatus;
    }
}
