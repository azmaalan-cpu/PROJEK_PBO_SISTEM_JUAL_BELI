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
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvBarang).BeginInit();
            SuspendLayout();
            // 
            // PanelHeader
            // 
            PanelHeader.BorderStyle = BorderStyle.FixedSingle;
            PanelHeader.Controls.Add(BtnCariID);
            PanelHeader.Controls.Add(TbCariID);
            PanelHeader.Controls.Add(LbCariId);
            PanelHeader.Location = new Point(1, 35);
            PanelHeader.Margin = new Padding(3, 2, 3, 2);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(596, 76);
            PanelHeader.TabIndex = 0;
            // 
            // BtnCariID
            // 
            BtnCariID.BackColor = Color.ForestGreen;
            BtnCariID.ForeColor = SystemColors.Control;
            BtnCariID.Location = new Point(349, 26);
            BtnCariID.Margin = new Padding(3, 2, 3, 2);
            BtnCariID.Name = "BtnCariID";
            BtnCariID.Size = new Size(83, 22);
            BtnCariID.TabIndex = 2;
            BtnCariID.Text = "Cari";
            BtnCariID.UseVisualStyleBackColor = false;
            BtnCariID.Click += BtnCariID_Click;
            // 
            // TbCariID
            // 
            TbCariID.BorderStyle = BorderStyle.FixedSingle;
            TbCariID.Location = new Point(174, 26);
            TbCariID.Margin = new Padding(3, 2, 3, 2);
            TbCariID.Name = "TbCariID";
            TbCariID.Size = new Size(153, 23);
            TbCariID.TabIndex = 1;
            TbCariID.TextChanged += TbCariID_TextChanged;
            // 
            // LbCariId
            // 
            LbCariId.AutoSize = true;
            LbCariId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbCariId.ForeColor = SystemColors.ActiveCaptionText;
            LbCariId.Location = new Point(28, 23);
            LbCariId.Name = "LbCariId";
            LbCariId.Size = new Size(127, 21);
            LbCariId.TabIndex = 0;
            LbCariId.Text = "Cari ID Barang :";
            // 
            // LbJudulDataBarang
            // 
            LbJudulDataBarang.AutoSize = true;
            LbJudulDataBarang.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbJudulDataBarang.ForeColor = Color.ForestGreen;
            LbJudulDataBarang.Location = new Point(6, 7);
            LbJudulDataBarang.Name = "LbJudulDataBarang";
            LbJudulDataBarang.Size = new Size(121, 21);
            LbJudulDataBarang.TabIndex = 1;
            LbJudulDataBarang.Text = "DATA BARANG";
            // 
            // DgvBarang
            // 
            DgvBarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvBarang.BackgroundColor = SystemColors.Control;
            DgvBarang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvBarang.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column4, Column5 });
            DgvBarang.Location = new Point(3, 115);
            DgvBarang.Margin = new Padding(3, 2, 3, 2);
            DgvBarang.Name = "DgvBarang";
            DgvBarang.RowHeadersWidth = 51;
            DgvBarang.Size = new Size(594, 161);
            DgvBarang.TabIndex = 0;
            DgvBarang.CellContentClick += DgvBarang_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "id_alat";
            Column1.HeaderText = "ID Barang";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "nama_alat";
            Column2.HeaderText = "Nama Barang";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "harga";
            Column4.HeaderText = "Harga";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "stok";
            Column5.HeaderText = "Stok";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            // 
            // UcDataBarangKasir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DgvBarang);
            Controls.Add(LbJudulDataBarang);
            Controls.Add(PanelHeader);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UcDataBarangKasir";
            Size = new Size(1029, 472);
            Load += UcDataBarangKasir_Load;
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvBarang).EndInit();
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
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}
