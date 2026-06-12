using System;
using System.Collections.Generic;
using System.Text;

namespace Projek_Final_sem2.Examples.OOPExample.DAO
{
    public interface IDetailTransaksiDAO
    {
        void InsertDetailTransaksi
        (
            int idTransaksi, 
            int idAlat, 
            int jumlah, 
            decimal subtotal
        );
    }
}
