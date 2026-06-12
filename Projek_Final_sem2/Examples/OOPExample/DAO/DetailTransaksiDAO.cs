using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using Npgsql;
using Projek_Final_sem2.Koneksi;

namespace Projek_Final_sem2.Examples.OOPExample.DAO
{
    public class DetailTransaksiDAO : IDetailTransaksiDAO
    {
        private DatabaseHelper db = new DatabaseHelper();
        public void InsertDetailTransaksi(
            int idTransaksi,
            int idAlat,
            int jumlah,
            decimal subtotal)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string sql = @"
                INSERT INTO detail_transaksi
                (id_transaksi, id_alat, jumlah, subtotal)
                VALUES
                (@id_transaksi, @id_alat, @jumlah, @subtotal)";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id_transaksi", idTransaksi);
                    cmd.Parameters.AddWithValue("@id_alat", idAlat);
                    cmd.Parameters.AddWithValue("@jumlah", jumlah);
                    cmd.Parameters.AddWithValue("@subtotal", subtotal);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
   
