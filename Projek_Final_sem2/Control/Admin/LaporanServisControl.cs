using System;
using System.Data;
using Projek_Final_sem2.DAO;

namespace Projek_Final_sem2.Control.Admin
{
    public class LaporanServisControl
    {
        private readonly ServiceDAO _serviceDao = new ServiceDAO();

        // Returns raw DataTable from DAO for further use (e.g. grid)
        public DataTable LoadDataServis(DateTime tanggalAwal, DateTime tanggalAkhir)
        {
            return _serviceDao.GetGrafikServis(tanggalAwal, tanggalAkhir);
        }

        // Prepares plot data (values, labels, positions) and total
        public (double[] values, string[] labels, double[] positions, decimal total) LoadGrafikServis(DateTime tanggalAwal, DateTime tanggalAkhir)
        {
            var dt = _serviceDao.GetGrafikServis(tanggalAwal, tanggalAkhir);
          

            double[] values = dt.AsEnumerable().Select(row => Convert.ToDouble(row["total_servis"]) ).ToArray();

            string[] labels = dt.AsEnumerable().Select(row =>
            {
                var obj = row["tanggal"];
                if (obj == DBNull.Value) return string.Empty;
                if (obj is DateTime dtime) return dtime.ToString("dd/MM/yyyy");
                // Npgsql v7+ may return DateOnly for DATE columns
                var type = obj.GetType();
                if (type.Name == "DateOnly")
                {
                    // fallback via reflection to avoid direct DateOnly dependency
                    var prop = type.GetMethod("ToDateTime", new Type[] { typeof(System.TimeOnly) });
                    if (prop != null)
                    {
                        // call ToDateTime(TimeOnly.MinValue)
                        var timeOnlyType = Type.GetType("System.TimeOnly");
                        object minTime = Activator.CreateInstance(timeOnlyType);
                        var dtv = prop.Invoke(obj, new object[] { minTime });
                        return Convert.ToDateTime(dtv).ToString("dd/MM/yyyy");
                    }
                    // last resort
                    return obj.ToString();
                }
                return Convert.ToDateTime(obj).ToString("dd/MM/yyyy");
            }).ToArray();

            double[] positions = Enumerable.Range(0, labels.Length).Select(x => (double)x).ToArray();

            decimal totalServis = dt.AsEnumerable().Sum(row => Convert.ToDecimal(row["total_servis"]));

            return (values, labels, positions, totalServis);
        }

        // Replicates the behaviour of a view button handler: returns prepared data for UI
        public (double[] values, string[] labels, double[] positions, decimal total) BtnTampilkan_Click(DateTime tanggalAwal, DateTime tanggalAkhir)
        {
            return LoadGrafikServis(tanggalAwal, tanggalAkhir);
        }
    }
}
