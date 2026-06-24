using Projek_Final_sem2.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Projek_Final_sem2.Control.Teknisi
{
    public class KerusakanControl
    {
        private readonly ServiceDAO _serviceDao = new ServiceDAO();

        // Buat servis baru dengan validasi input, delegasi ke DAO untuk insert
        // OOP pillars:
        // - Abstraction: (digunakan) menyederhanakan pembuatan servis
        // - Encapsulation: (digunakan) validation dan panggilan DAO dibungkus
        // - Inheritance: (tidak digunakan)
        // - Polymorphism: (tidak digunakan)
        public bool CreateServis(int idUser, string namaAlat, string kerusakan, decimal biayaServis, string sparepart)
        {
            // Business validations moved back into controller per user request.
            if (string.IsNullOrWhiteSpace(namaAlat))
                throw new ArgumentException("Nama alat harus diisi", nameof(namaAlat));

            if (string.IsNullOrWhiteSpace(kerusakan))
                throw new ArgumentException("Kerusakan harus diisi", nameof(kerusakan));

            if (biayaServis < 0)
                throw new ArgumentException("Biaya servis tidak valid", nameof(biayaServis));

            // Call DAO low-level insert.
            return _serviceDao.InsertServis(idUser, namaAlat, kerusakan, biayaServis, sparepart);
        }

        // Ambil user berdasarkan role via ServiceDAO
        // OOP pillars: Abstraction, Encapsulation
        public DataTable GetUsersByRole(string role)
        {
            return _serviceDao.GetUsersByRole(role);
        }
    }
}
