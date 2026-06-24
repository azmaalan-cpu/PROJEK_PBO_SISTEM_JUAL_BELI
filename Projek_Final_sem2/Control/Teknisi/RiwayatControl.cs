using System;
using System.Data;
using System.Linq;
using Projek_Final_sem2.DAO;

namespace Projek_Final_sem2.Control.Teknisi
{
    public class RiwayatControl
    {
        private readonly ServiceDAO _serviceDao = new ServiceDAO();

        // Get full history (unfiltered)
        // OOP pillars: Abstraction, Encapsulation
        public DataTable GetAllRiwayat()
        {
            return _serviceDao.DataServisRiwayat();
        }

        // Filter riwayat by date range (inclusive)
        // OOP pillars: Abstraction, Encapsulation
        public DataTable GetRiwayatByRange(DateTime awal, DateTime akhir)
        {
            var dt = _serviceDao.DataServisRiwayat();
            if (dt == null || dt.Rows.Count == 0)
                return dt;

            // We expect a column named 'tanggal_servis' — try to filter safely
            var filtered = dt.AsEnumerable()
                .Where(r =>
                {
                    if (r.IsNull("tanggal_servis"))
                        return false;

                    var val = r["tanggal_servis"];
                    DateTime dtVal;

                    if (val is DateTime d)
                        dtVal = d;
                    else if (val is DateOnly da)
                        dtVal = da.ToDateTime(System.TimeOnly.MinValue);
                    else if (DateTime.TryParse(val?.ToString(), out var parsed))
                        dtVal = parsed;
                    else
                        return false;

                    return dtVal.Date >= awal.Date && dtVal.Date <= akhir.Date;
                })
                .CopyToDataTable();

            return filtered;
        }

        // Summary (count and sum of biaya_servis) for a given range
        // OOP pillars: Abstraction, Encapsulation
        public (int totalCount, decimal totalPendapatan) GetSummary(DateTime awal, DateTime akhir)
        {
            var dt = GetRiwayatByRange(awal, akhir);
            if (dt == null || dt.Rows.Count == 0)
                return (0, 0m);

            int count = dt.Rows.Count;
            decimal sum = dt.AsEnumerable().Sum(r => Convert.ToDecimal(r["biaya_servis"]));
            return (count, sum);
        }
    }
}
