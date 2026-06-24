using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using Projek_Final_sem2.Control.Kasir;
using Projek_Final_sem2.DAO;
using Projek_Final_sem2.Koneksi;

namespace Projek_Final_sem2.UserControls.Kasir
{
    public partial class UcDashboardKasir : UserControl
    {
        private DashboardTransaksiKasirDAO transaksiDAO = new DashboardTransaksiKasirDAO();
        private TransaksiServiceControl transaksiService = new TransaksiServiceControl();

        public UcDashboardKasir()
        {
            InitializeComponent();
        }

        private void LoadDashboardKasir()
        {
            DataTable dt = transaksiService.GetDashboardKasir();

            if (dt.Rows.Count > 0)
            {
                LbPendapatan.Text = "Total Pendapatan";

                LabelTotalBarang.Text =
                dt.Rows[0]["total_barang"].ToString();

                LabelTotalTransaksi.Text =
                dt.Rows[0]["total_transaksi"].ToString();

                LabelTotalPendapatan.Text = Convert.ToDecimal(dt.Rows[0]["total_pendapatan"])
                 .ToString("N0");
            }
        }

        private void UcDashboardKasir_Load(object sender, EventArgs e)
        {
            LoadDashboardKasir();
            LoadTransaksi();
        }

        private void LoadTransaksi()
        {
            DgvTransaksi.RowHeadersVisible = false;
            DgvTransaksi.AutoGenerateColumns = false;
            DgvTransaksi.DataSource =
                transaksiService.GetTransaksiPenjualan();

            DataTable dt =
            transaksiService.GetInformasiTransaksi();

            if (dt.Rows.Count > 0)
            {
                LbIdTransaksi.Text =
                    dt.Rows[0]["id_transaksi"].ToString();

                if (dt.Rows.Count > 0)
{
    var row = dt.Rows[0];

    LbIdTransaksi.Text = row.Table.Columns.Contains("id_transaksi") && row["id_transaksi"] != DBNull.Value
        ? row["id_transaksi"].ToString()
        : string.Empty;

    if (row.Table.Columns.Contains("total_harga") && row["total_harga"] != DBNull.Value)
    {
        LbPendapatanDashboard.Text = Convert.ToDecimal(row["total_harga"]).ToString("N0");
    }
    else
    {
        LbPendapatanDashboard.Text = "0";
    }

    LbJumlahBarang.Text = row.Table.Columns.Contains("jumlah_barang") && row["jumlah_barang"] != DBNull.Value
        ? row["jumlah_barang"].ToString()
        : "0";
}

                LbJumlahBarang.Text =
                    dt.Rows[0]["jumlah_barang"].ToString();
            }


        }

        private void DgvTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;

            int idTransaksi =
                Convert.ToInt32(
                DgvTransaksi.Rows[e.RowIndex]
                .Cells[0].Value);
            
            // Prefer mengambil nilai langsung dari DataGridView yang diklik
            try
            {
                // Set ID transaksi dari cell yang diklik
                LbIdTransaksi.Text = idTransaksi.ToString();

                // Jika DataGridView.DataSource adalah DataTable, gunakan baris dari sana
                if (DgvTransaksi.DataSource is DataTable srcDt)
                {
                    DataRow[] found = null;
                    if (srcDt.Columns.Contains("id_transaksi"))
                        found = srcDt.Select($"id_transaksi = {idTransaksi}");
                    else if (srcDt.Columns.Contains("no_transaksi"))
                        found = srcDt.Select($"no_transaksi = {idTransaksi}");

                    if (found != null && found.Length > 0)
                    {
                        var r = found[0];
                        // Cari nilai total dari beberapa kemungkinan nama kolom
                        string[] totalCols = new[] { "total_harga", "total", "total_pendapatan", "total_price" };
                        decimal totalVal = 0m;
                        foreach (var c in totalCols)
                        {
                            if (r.Table.Columns.Contains(c) && r[c] != DBNull.Value)
                            {
                                totalVal = Convert.ToDecimal(r[c]);
                                break;
                            }
                        }
                        LbPendapatanDashboard.Text = totalVal.ToString("N0");

                        // Cari jumlah barang dari beberapa kemungkinan nama kolom
                        string[] qtyCols = new[] { "jumlah_barang", "quantity", "qty", "jumlah" };
                        string qtyText = "0";
                        foreach (var c in qtyCols)
                        {
                            if (r.Table.Columns.Contains(c) && r[c] != DBNull.Value)
                            {
                                qtyText = r[c].ToString();
                                break;
                            }
                        }
                        LbJumlahBarang.Text = qtyText;
                        return;
                    }
                }

                // Fallback: baca langsung dari baris DataGridView
                var rowView = DgvTransaksi.Rows[e.RowIndex];
                object totalCell = null;
                if (rowView.Cells.Count > 2) totalCell = rowView.Cells[2].Value;
                else if (rowView.Cells.Count > 1) totalCell = rowView.Cells[1].Value;

                if (totalCell != null && totalCell != DBNull.Value && decimal.TryParse(totalCell.ToString(), out var parsed))
                {
                    LbPendapatanDashboard.Text = parsed.ToString("N0");
                }

                // Cari jumlah barang berdasarkan nama kolom pada DataGridView
                string qtyVal = "0";
                try
                {
                    foreach (DataGridViewCell cell in rowView.Cells)
                    {
                        var colName = rowView.DataGridView.Columns[cell.ColumnIndex].Name?.ToLowerInvariant() ?? string.Empty;
                        if (colName.Contains("jumlah") || colName.Contains("qty") || colName.Contains("quantity"))
                        {
                            if (cell.Value != null) qtyVal = cell.Value.ToString();
                            break;
                        }
                    }
                }
                catch { }

                LbJumlahBarang.Text = qtyVal;
            }
            catch
            {
                // jangan biarkan error crash UI
            }
        }

        private void DgvTransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

