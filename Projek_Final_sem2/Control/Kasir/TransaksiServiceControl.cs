using System.Data;
using System;
using System.Windows.Forms;
using Projek_Final_sem2.DAO;

namespace Projek_Final_sem2.Control.Kasir

{
    public class TransaksiServiceControl
    {
        private readonly TransaksiDAO _transaksiDao = new TransaksiDAO();
        private readonly DashboardTransaksiKasirDAO _dashboardTransaksiKasirDAO = new DashboardTransaksiKasirDAO();
        // Simpan transaksi penjualan: buat transaksi, insert detail, kurangi stok
        // OOP pillars:
        // - Abstraction: (digunakan) menyederhanakan alur penyimpanan transaksi
        // - Encapsulation: (digunakan) detail DB dibungkus di DAO
        // - Inheritance: (tidak digunakan)
        // - Polymorphism: (tidak digunakan)
        public bool SimpanTransaksi(int idUser, DataGridView dgv, decimal totalHarga)
        {
            int idTransaksi = _transaksiDao.InsertTransaksi(idUser, totalHarga);

            if (idTransaksi == -1)
                return false;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow)
                    continue;

                int idAlat = Convert.ToInt32(row.Cells["ColIDBarang"].Value);
                int jumlah = Convert.ToInt32(row.Cells["ColJumlah"].Value);
                decimal subtotal = Convert.ToDecimal(row.Cells["ColSubTotal"].Value);

                if (_transaksiDao.CekStok(idAlat) < jumlah)
                    throw new Exception("Stok tidak mencukupi");

                _transaksiDao.InsertDetail
                (
                    idTransaksi,
                    idAlat,
                    jumlah,
                    subtotal
                );

                _transaksiDao.KurangiStok
                 (
                     idAlat,
                     jumlah
                 );
            }

            return true;
        }

        // Cek stok (delegasi ke DAO)
        // OOP pillars: Abstraction, Encapsulation
        public int CekStok(int idAlat) => _transaksiDao.CekStok(idAlat);

        // Ambil data barang untuk kasir
        // OOP pillars: Abstraction, Encapsulation
        public DataTable GetDataBarang() => _dashboardTransaksiKasirDAO.GetDataBarang();

        // Ambil ringkasan dashboard kasir
        // OOP pillars: Abstraction, Encapsulation
        public DataTable GetDashboardKasir()
        {
            return _dashboardTransaksiKasirDAO.GetDashboardKasir();
        }

        // Ambil informasi transaksi
        // OOP pillars: Abstraction, Encapsulation
        public DataRow GetInformasiTransaksById(int idTransaksi)
        {
            return _dashboardTransaksiKasirDAO.GetInfromasiTransaksiById(idTransaksi);
        }

        // Ambil daftar transaksi penjualan
        // OOP pillars: Abstraction, Encapsulation
        public DataTable GetTransaksiPenjualan()
        {
            return _dashboardTransaksiKasirDAO.GetTransaksiPenjualan();
        }
        //public decimal GetTotalPendapatan() => _dahboardTransaksiKasirDAO.GetTotalPendapatan();
        //public int GetTotalBarangTerjual() => _dahboardTransaksiKasirDAO.GetTotalBarangTerjual();
        //public int GetTotalTransaksi() => _dahboardTransaksiKasirDAO.GetTotalTransaksi();
        //public DataTable GetInformasiTransaksi() => _dahboardTransaksiKasirDAO.GetInformasiTransaksi();
        //public DataTable GetTransaksiPenjualan() => _dahboardTransaksiKasirDAO.GetTransaksiPenjualan();
    }
}
