using System;
using System.Collections.Generic;
using System.Text;

namespace Projek_Final_sem2.Models
{
    public class Service
    {
        public int id_servis { get; set; }
        // keep original and a common nama_alat property used by views
        public string nama_alat_servis { get; set; }
        public string nama_alat { get => nama_alat_servis; set => nama_alat_servis = value; }
        public DateTime tanggal_servis { get; set; }
        public string status_servis { get; set; }
        public string kerusakan { get; set; }
        public int biaya_servis { get; set; }
        public string sparepart { get; set; }
    }
}
