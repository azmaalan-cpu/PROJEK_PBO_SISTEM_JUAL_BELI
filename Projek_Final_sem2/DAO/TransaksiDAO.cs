using System;
using System.Data;
using Projek_Final_sem2.Koneksi;

namespace Projek_Final_sem2.DAO
{
    // Minimal TransaksiDAO to satisfy existing callers; implement real DB logic later.
    public class TransaksiDAO
    {
        private readonly DatabaseHelper _db = new DatabaseHelper();

        public int InsertTransaksi(int idUser, decimal totalHarga)
        {
            // TODO: implement DB insert and return generated id
            return -1;
        }

        public int CekStok(int idAlat)
        {
            // TODO: query DB for stock
            return 0;
        }

        public void InsertDetail(int idTransaksi, int idAlat, int jumlah, decimal subtotal)
        {
            // TODO: implement DB insert detail
        }

        public void KurangiStok(int idAlat, int jumlah)
        {
            // TODO: implement DB stock decrement
        }

        public DataTable GetDataGrafikPenjualan(DateTime awal, DateTime akhir)
        {
            DataTable dt = new DataTable();
            using (var conn = _db.GetConnection())
            {
                conn.Open();
                // Try to read aggregated penjualan per date from a view or function.
                // Expecting columns: tanggal, total_penjualan
                string sql = @"SELECT * FROM v_transaksi_penjualan WHERE tanggal::date BETWEEN @awal::date AND @akhir::date ORDER BY tanggal";
                using (var cmd = new Npgsql.NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@awal", awal.Date);
                    cmd.Parameters.AddWithValue("@akhir", akhir.Date);
                    using (var adapter = new Npgsql.NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        // Wrapper for laporan penjualan used by admin control.
        public DataTable GetLaporanPenjualan(DateTime awal, DateTime akhir)
        {
            // For now delegate to GetDataGrafikPenjualan. Implement real query as needed.
            return GetDataGrafikPenjualan(awal, akhir);
        }
    }
}
