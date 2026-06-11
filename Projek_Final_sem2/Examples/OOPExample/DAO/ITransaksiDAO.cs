using System;

namespace Projek_Final_sem2.Examples.OOPExample.DAO
{
    public interface ITransaksiDAO
    {
        int InsertTransaksi(int idUser, decimal totalHarga);
        void InsertDetail(int idTransaksi, int idAlat, int jumlah, decimal subtotal);
        int CekStok(int idAlat);
        void KurangiStok(int idAlat, int jumlah);
    }
}
