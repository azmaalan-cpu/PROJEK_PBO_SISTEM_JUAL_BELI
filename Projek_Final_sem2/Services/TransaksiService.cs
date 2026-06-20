using System.Data;
using Projek_Final_sem2.Examples.OOPExample.DAO;
using System;
using System.Windows.Forms;
using Projek_Final_sem2.DAO;

namespace Projek_Final_sem2.Services
{
    public class TransaksiService
    {
        private readonly TransaksiDAO _transaksiDao = new TransaksiDAO();
        private readonly DashboardTransaksiKasirDAO _dashboardTransaksiKasirDAO = new DashboardTransaksiKasirDAO();
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

        public int CekStok(int idAlat) => _transaksiDao.CekStok(idAlat);
        public DataTable GetDataBarang() => _dashboardTransaksiKasirDAO.GetDataBarang();
        public DataTable GetDashboardKasir()
        {
            return _dashboardTransaksiKasirDAO.GetDashboardKasir();
        }

        public DataTable GetInformasiTransaksi()
        {
            return _dashboardTransaksiKasirDAO.GetInformasiTransaksi();
        }

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
