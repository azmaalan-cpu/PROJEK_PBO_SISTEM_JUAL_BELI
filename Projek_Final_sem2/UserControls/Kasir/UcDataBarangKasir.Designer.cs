namespace Projek_Final_sem2.UserControls.Kasir
{
    partial class UcDataBarangKasir
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
            PanelHeader = new Panel();
            BtnCariID = new Button();
            TbCariID = new TextBox();
            LbCariId = new Label();
            LbJudulDataBarang = new Label();
            DgvBarang = new DataGridView();
            ColIdBarang = new DataGridViewTextBoxColumn();
            ColNamaBarang = new DataGridViewTextBoxColumn();
            ColHarga = new DataGridViewTextBoxColumn();
            ColStok = new DataGridViewTextBoxColumn();
            PanelTotal = new Panel();
            LbTotalBarang = new Label();
            PanelKeranjangBarang = new Panel();
            PcxKeranjang = new PictureBox();
            PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvBarang).BeginInit();
            PanelTotal.SuspendLayout();
            PanelKeranjangBarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PcxKeranjang).BeginInit();
            SuspendLayout();
            // 
            // PanelHeader
            // 
            PanelHeader.BorderStyle = BorderStyle.FixedSingle;
            PanelHeader.Controls.Add(BtnCariID);
            PanelHeader.Controls.Add(TbCariID);
            PanelHeader.Controls.Add(LbCariId);
            PanelHeader.Location = new Point(1, 47);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(681, 101);
            PanelHeader.TabIndex = 0;
            // 
            // BtnCariID
            // 
            BtnCariID.BackColor = Color.ForestGreen;
            BtnCariID.ForeColor = SystemColors.Control;
            BtnCariID.Location = new Point(399, 35);
            BtnCariID.Name = "BtnCariID";
            BtnCariID.Size = new Size(94, 29);
            BtnCariID.TabIndex = 2;
            BtnCariID.Text = "Cari";
            BtnCariID.UseVisualStyleBackColor = false;
            BtnCariID.Click += BtnCariID_Click;
            // 
            // TbCariID
            // 
            TbCariID.BorderStyle = BorderStyle.FixedSingle;
            TbCariID.Location = new Point(198, 35);
            TbCariID.Name = "TbCariID";
            TbCariID.Size = new Size(175, 27);
            TbCariID.TabIndex = 1;
            TbCariID.TextChanged += TbCariID_TextChanged;
            // 
            // LbCariId
            // 
            LbCariId.AutoSize = true;
            LbCariId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbCariId.ForeColor = SystemColors.ActiveCaptionText;
            LbCariId.Location = new Point(32, 30);
            LbCariId.Name = "LbCariId";
            LbCariId.Size = new Size(160, 28);
            LbCariId.TabIndex = 0;
            LbCariId.Text = "Cari ID Barang :";
            // 
            // LbJudulDataBarang
            // 
            LbJudulDataBarang.AutoSize = true;
            LbJudulDataBarang.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbJudulDataBarang.ForeColor = Color.ForestGreen;
            LbJudulDataBarang.Location = new Point(6, 9);
            LbJudulDataBarang.Name = "LbJudulDataBarang";
            LbJudulDataBarang.Size = new Size(155, 28);
            LbJudulDataBarang.TabIndex = 1;
            LbJudulDataBarang.Text = "DATA BARANG";
            // 
            // DgvBarang
            // 
            DgvBarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvBarang.BackgroundColor = SystemColors.Control;
            DgvBarang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvBarang.Columns.AddRange(new DataGridViewColumn[] { ColIdBarang, ColNamaBarang, ColHarga, ColStok });
            DgvBarang.Location = new Point(3, 154);
            DgvBarang.Name = "DgvBarang";
            DgvBarang.RowHeadersWidth = 51;
            DgvBarang.Size = new Size(679, 215);
            DgvBarang.TabIndex = 0;
            // 
            // ColIdBarang
            // 
            ColIdBarang.DataPropertyName = "id_alat";
            ColIdBarang.HeaderText = "ID Barang";
            ColIdBarang.MinimumWidth = 6;
            ColIdBarang.Name = "ColIdBarang";
            // 
            // ColNamaBarang
            // 
            ColNamaBarang.DataPropertyName = "nama_alat";
            ColNamaBarang.HeaderText = "Nama Barang";
            ColNamaBarang.MinimumWidth = 6;
            ColNamaBarang.Name = "ColNamaBarang";
            // 
            // ColHarga
            // 
            ColHarga.DataPropertyName = "harga";
            ColHarga.HeaderText = "Harga";
            ColHarga.MinimumWidth = 6;
            ColHarga.Name = "ColHarga";
            // 
            // ColStok
            // 
            ColStok.DataPropertyName = "Stok";
            ColStok.HeaderText = "Stok";
            ColStok.MinimumWidth = 6;
            ColStok.Name = "ColStok";
            // 
            // PanelTotal
            // 
            PanelTotal.Controls.Add(LbTotalBarang);
            PanelTotal.Location = new Point(3, 375);
            PanelTotal.Name = "PanelTotal";
            PanelTotal.Size = new Size(246, 90);
            PanelTotal.TabIndex = 2;
            // 
            // LbTotalBarang
            // 
            LbTotalBarang.AutoSize = true;
            LbTotalBarang.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbTotalBarang.Location = new Point(3, 24);
            LbTotalBarang.Name = "LbTotalBarang";
            LbTotalBarang.Size = new Size(143, 28);
            LbTotalBarang.TabIndex = 0;
            LbTotalBarang.Text = "Total Barang :";
            // 
            // PanelKeranjangBarang
            // 
            PanelKeranjangBarang.Controls.Add(PcxKeranjang);
            PanelKeranjangBarang.Location = new Point(382, 375);
            PanelKeranjangBarang.Name = "PanelKeranjangBarang";
            PanelKeranjangBarang.Size = new Size(300, 90);
            PanelKeranjangBarang.TabIndex = 3;
            // 
            // PcxKeranjang
            // 
            PcxKeranjang.BackgroundImage = Properties.Resources.ChatGPT_Image_5_Jun_2026__00_18_09;
            PcxKeranjang.BackgroundImageLayout = ImageLayout.Zoom;
            PcxKeranjang.Location = new Point(3, 3);
            PcxKeranjang.Name = "PcxKeranjang";
            PcxKeranjang.Size = new Size(141, 84);
            PcxKeranjang.TabIndex = 0;
            PcxKeranjang.TabStop = false;
            // 
            // UcDataBarangKasir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelKeranjangBarang);
            Controls.Add(PanelTotal);
            Controls.Add(DgvBarang);
            Controls.Add(LbJudulDataBarang);
            Controls.Add(PanelHeader);
            Name = "UcDataBarangKasir";
            Size = new Size(1176, 629);
            Load += UcDataBarangKasir_Load;
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvBarang).EndInit();
            PanelTotal.ResumeLayout(false);
            PanelTotal.PerformLayout();
            PanelKeranjangBarang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PcxKeranjang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelHeader;
        private Label LbJudulDataBarang;
        private Label LbCariId;
        private TextBox TbCariID;
        private Button BtnCariID;
        private DataGridView DgvBarang;
        private Panel PanelTotal;
        private Label LbTotalBarang;
        private Panel PanelKeranjangBarang;
        private PictureBox pictureBox1;
        private PictureBox PcxKeranjang;
        private DataGridViewTextBoxColumn ColIdBarang;
        private DataGridViewTextBoxColumn ColNamaBarang;
        private DataGridViewTextBoxColumn ColHarga;
        private DataGridViewTextBoxColumn ColStok;
    }
}
