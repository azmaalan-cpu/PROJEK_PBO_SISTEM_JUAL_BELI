using System;
using System.Collections.Generic;
using System.Text;

namespace Projek_Final_sem2.Models
{
    public class Alat
    {
        public int IdAlat {  get; set; }
        public string NamaAlat { get; set; }
        public decimal Harga { get; set; }
        public int Stok {  get; set; }
        public int IdKategori { get; set; }
        public int IdSupplier { get; set; }

    }
}
