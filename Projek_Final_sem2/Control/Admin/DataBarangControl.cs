using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Reflection;
using Projek_Final_sem2.DAO;

namespace Projek_Final_sem2.Control.Admin
{
    // Reflection-based adapter so control compiles regardless of exact BarangDAO signatures.
    public class DataBarangControl
    {
        private readonly AlatDAO _alatDao;

        public DataBarangControl()
        {
            _alatDao = new AlatDAO();
        }

        public DataTable LoadDataBarang()
        {
            try
            {
                return _alatDao.GetAll() ?? new DataTable();
            }
            catch
            {
                return new DataTable();
            }
        }

        public bool BtnTambah_Click(object model)
        {
            try
            {
                if (model is Models.Alat alat)
                {
                    _alatDao.Insert(alat);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool BtnEdit_Click(int id, object model)
        {
            try
            {
                if (model is Models.Alat alat)
                {
                    alat.IdAlat = id;
                    _alatDao.Update(alat);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool BtnHapus_Click(int id)
        {
            try
            {
                _alatDao.Delete(id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static bool InterpretResultAsSuccess(object res)
        {
            if (res == null) return false;
            if (res is bool b) return b;
            if (res is int i) return i > 0;
            if (res is long l) return l > 0;
            return true;
        }

        private static DataTable EnumerableToDataTable(IEnumerable items)
        {
            var dt = new DataTable();
            var enumerator = items.GetEnumerator();
            if (!enumerator.MoveNext()) return dt;
            var first = enumerator.Current;
            if (first == null) return dt;
            var props = first.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var p in props) dt.Columns.Add(p.Name, Nullable.GetUnderlyingType(p.PropertyType) ?? p.PropertyType);
            void AddRow(object item)
            {
                var values = props.Select(p => p.GetValue(item) ?? DBNull.Value).ToArray();
                dt.Rows.Add(values);
            }
            AddRow(first);
            while (enumerator.MoveNext()) AddRow(enumerator.Current);
            return dt;
        }
    }
}
