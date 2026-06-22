using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projek_Final_sem2.Koneksi
{
    public class DatabaseHelper
    {
        //private string coonString = "Host=localhost;Port=5432;Database=projek_sistem_jual_tani;Username=postgres;Password=Azma140700";
        //private string coonString = "Host=localhost;Port=5432;Database=FINAL_PRESENTASI_PROJECT;Username=postgres;Password=Alen12345678";
        private string coonString = "Host=localhost;Port=5432;Database=Projek_pbo;Username=postgres;Password=hadil";
        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(coonString);
        }
    }
}

