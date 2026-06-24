using System;
using System.Collections.Generic;
using System.Text;

namespace Projek_Final_sem2.Control.Kasir
{
    public class DataBarangControl
    {
        // Field encapsulation: menyimpan BarangDAO privat
        // OOP pillars: Encapsulation
        private readonly DAO.BarangDAO _barangDao = new DAO.BarangDAO();
    }
}
