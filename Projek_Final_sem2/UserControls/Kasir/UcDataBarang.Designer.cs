namespace Projek_Final_sem2.UserControls.Kasir
{
    partial class UcDataBarang
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
            LbJudulDataBarang = new Label();
            PanelCari = new Panel();
            BtnCari = new Button();
            TxtCariIdBarang = new TextBox();
            LbCariIdBarang = new Label();
            PanelDataBarang = new Panel();
            DgvBarang = new DataGridView();
            ColNo = new DataGridViewTextBoxColumn();
            ColIdBarang = new DataGridViewTextBoxColumn();
            ColNamaBarang = new DataGridViewTextBoxColumn();
            ColHargaBarang = new DataGridViewTextBoxColumn();
            ColStokBarang = new DataGridViewTextBoxColumn();
            label1 = new Label();
            PanelCari.SuspendLayout();
            PanelDataBarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvBarang).BeginInit();
            SuspendLayout();
            // 
            // LbJudulDataBarang
            // 
            LbJudulDataBarang.AutoSize = true;
            LbJudulDataBarang.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbJudulDataBarang.ForeColor = Color.DarkGreen;
            LbJudulDataBarang.Location = new Point(43, 15);
            LbJudulDataBarang.Name = "LbJudulDataBarang";
            LbJudulDataBarang.Size = new Size(175, 32);
            LbJudulDataBarang.TabIndex = 0;
            LbJudulDataBarang.Text = "Data Barang ";
            // 
            // PanelCari
            // 
            PanelCari.Controls.Add(BtnCari);
            PanelCari.Controls.Add(TxtCariIdBarang);
            PanelCari.Controls.Add(LbCariIdBarang);
            PanelCari.Location = new Point(31, 64);
            PanelCari.Name = "PanelCari";
            PanelCari.Size = new Size(977, 80);
            PanelCari.TabIndex = 1;
            // 
            // BtnCari
            // 
            BtnCari.BackColor = Color.ForestGreen;
            BtnCari.FlatStyle = FlatStyle.Flat;
            BtnCari.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCari.ForeColor = Color.White;
            BtnCari.Location = new Point(474, 27);
            BtnCari.Name = "BtnCari";
            BtnCari.Size = new Size(106, 29);
            BtnCari.TabIndex = 2;
            BtnCari.Text = "Cari";
            BtnCari.UseVisualStyleBackColor = false;
            // 
            // TxtCariIdBarang
            // 
            TxtCariIdBarang.Location = new Point(186, 27);
            TxtCariIdBarang.Name = "TxtCariIdBarang";
            TxtCariIdBarang.Size = new Size(281, 27);
            TxtCariIdBarang.TabIndex = 1;
            // 
            // LbCariIdBarang
            // 
            LbCariIdBarang.AutoSize = true;
            LbCariIdBarang.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbCariIdBarang.Location = new Point(16, 27);
            LbCariIdBarang.Name = "LbCariIdBarang";
            LbCariIdBarang.Size = new Size(147, 23);
            LbCariIdBarang.TabIndex = 0;
            LbCariIdBarang.Text = "Cari Id Barang :";
            // 
            // PanelDataBarang
            // 
            PanelDataBarang.Controls.Add(DgvBarang);
            PanelDataBarang.Controls.Add(label1);
            PanelDataBarang.Location = new Point(31, 159);
            PanelDataBarang.Name = "PanelDataBarang";
            PanelDataBarang.Size = new Size(789, 321);
            PanelDataBarang.TabIndex = 4;
            // 
            // DgvBarang
            // 
            DgvBarang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvBarang.Columns.AddRange(new DataGridViewColumn[] { ColNo, ColIdBarang, ColNamaBarang, ColHargaBarang, ColStokBarang });
            DgvBarang.Location = new Point(13, 35);
            DgvBarang.Name = "DgvBarang";
            DgvBarang.RowHeadersWidth = 51;
            DgvBarang.Size = new Size(742, 265);
            DgvBarang.TabIndex = 1;
            // 
            // ColNo
            // 
            ColNo.HeaderText = "No";
            ColNo.MinimumWidth = 6;
            ColNo.Name = "ColNo";
            ColNo.Width = 125;
            // 
            // ColIdBarang
            // 
            ColIdBarang.HeaderText = "Id Barang";
            ColIdBarang.MinimumWidth = 6;
            ColIdBarang.Name = "ColIdBarang";
            ColIdBarang.Width = 125;
            // 
            // ColNamaBarang
            // 
            ColNamaBarang.HeaderText = "Nama Barang";
            ColNamaBarang.MinimumWidth = 6;
            ColNamaBarang.Name = "ColNamaBarang";
            ColNamaBarang.Width = 125;
            // 
            // ColHargaBarang
            // 
            ColHargaBarang.HeaderText = "Harga Barang";
            ColHargaBarang.MinimumWidth = 6;
            ColHargaBarang.Name = "ColHargaBarang";
            ColHargaBarang.Width = 125;
            // 
            // ColStokBarang
            // 
            ColStokBarang.HeaderText = "Stok Barang";
            ColStokBarang.MinimumWidth = 6;
            ColStokBarang.Name = "ColStokBarang";
            ColStokBarang.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(17, 12);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 0;
            label1.Text = "Daftar Data Barang ";
            // 
            // UcDataBarang
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            Controls.Add(PanelDataBarang);
            Controls.Add(PanelCari);
            Controls.Add(LbJudulDataBarang);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "UcDataBarang";
            Size = new Size(1172, 698);
            PanelCari.ResumeLayout(false);
            PanelCari.PerformLayout();
            PanelDataBarang.ResumeLayout(false);
            PanelDataBarang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvBarang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbJudulDataBarang;
        private Panel PanelCari;
        private Label LbCariIdBarang;
        private Button BtnCari;
        private TextBox TxtCariIdBarang;
        private Panel PanelDataBarang;
        private Label label1;
        private DataGridView DgvBarang;
        private DataGridViewTextBoxColumn ColNo;
        private DataGridViewTextBoxColumn ColIdBarang;
        private DataGridViewTextBoxColumn ColNamaBarang;
        private DataGridViewTextBoxColumn ColHargaBarang;
        private DataGridViewTextBoxColumn ColStokBarang;
    }
}
