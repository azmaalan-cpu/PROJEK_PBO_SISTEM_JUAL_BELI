using System;
using Projek_Final_sem2.Examples.OOPExample.DAO;
using Npgsql;

namespace Projek_Final_sem2.Examples.OOPExample.DAO
{
//Inheritance, Polymorphism, Encapsulation
    public class TransaksiDAO : BaseDAO, ITransaksiDAO
    {
//Encapsulation
        public int InsertTransaksi(int idUser, decimal totalHarga)
        {
            string sql = @"INSERT INTO transaksi (id_user, total_harga) VALUES (@id_user, @total_harga) RETURNING id_transaksi";
            var result = ExecuteScalar(sql, cmd =>
            {
                cmd.Parameters.AddWithValue("@id_user", idUser);
                cmd.Parameters.AddWithValue("@total_harga", totalHarga);
            });

            return result == null ? -1 : Convert.ToInt32(result);
        }

 //Encapsulation
        public void InsertDetail(int idTransaksi, int idAlat, int jumlah, decimal subtotal)
        {
            string sql = @"INSERT INTO detail_transaksi (id_transaksi, id_alat, jumlah, subtotal) VALUES (@id_transaksi, @id_alat, @jumlah, @subtotal)";
            ExecuteNonQuery(sql, cmd =>
            {
                cmd.Parameters.AddWithValue("@id_transaksi", idTransaksi);
                cmd.Parameters.AddWithValue("@id_alat", idAlat);
                cmd.Parameters.AddWithValue("@jumlah", jumlah);
                cmd.Parameters.AddWithValue("@subtotal", subtotal);
            });
        }

//Encapsulation
        public int CekStok(int idAlat)
        {
            string sql = @"SELECT stok FROM alat_pertanian WHERE id_alat = @id_alat";
            var result = ExecuteScalar(sql, cmd => cmd.Parameters.AddWithValue("@id_alat", idAlat));
            return result == null ? 0 : Convert.ToInt32(result);
        }

//Encapsulation
        public void KurangiStok(int idAlat, int jumlah)
        {
            string sql = @"UPDATE alat_pertanian SET stok = stok - @jumlah WHERE id_alat = @id_alat";
            ExecuteNonQuery(sql, cmd =>
            {
                cmd.Parameters.AddWithValue("@jumlah", jumlah);
                cmd.Parameters.AddWithValue("@id_alat", idAlat);
            });
        }
    }
}
