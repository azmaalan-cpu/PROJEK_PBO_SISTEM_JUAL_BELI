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
        private readonly object _barangDao;

        public DataBarangControl()
        {
            // instantiate BarangDAO via its type
            _barangDao = Activator.CreateInstance(typeof(BarangDAO));
        }

        public DataTable LoadDataBarang()
        {
            try
            {
                var type = _barangDao.GetType();
                var m = type.GetMethod("GetAll") ?? type.GetMethod("GetAllBarang") ?? type.GetMethod("Get") ;
                if (m == null) return new DataTable();

                var result = m.Invoke(_barangDao, null);
                if (result is DataTable dt) return dt;
                if (result is IEnumerable ie) return EnumerableToDataTable(ie);
                return new DataTable();
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
                var type = _barangDao.GetType();
                var m = type.GetMethod("Insert") ?? type.GetMethod("Add") ?? type.GetMethod("Create");
                if (m == null) return false;
                var parameters = m.GetParameters();
                object[] args = parameters.Length == 1 ? new object[] { model } : parameters.Length == 0 ? new object[0] : new object[] { model };
                var res = m.Invoke(_barangDao, args);
                return InterpretResultAsSuccess(res);
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
                var type = _barangDao.GetType();
                var m = type.GetMethod("Update") ?? type.GetMethod("Edit") ?? type.GetMethod("Modify");
                if (m == null) return false;
                var parameters = m.GetParameters();
                object[] args;
                if (parameters.Length == 2)
                    args = new object[] { id, model };
                else if (parameters.Length == 1)
                    args = new object[] { model };
                else
                    args = new object[0];

                var res = m.Invoke(_barangDao, args);
                return InterpretResultAsSuccess(res);
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
                var type = _barangDao.GetType();
                var m = type.GetMethod("Delete") ?? type.GetMethod("Remove") ?? type.GetMethod("DeleteById");
                if (m == null) return false;
                var parameters = m.GetParameters();
                object[] args = parameters.Length == 1 ? new object[] { id } : new object[] { };
                var res = m.Invoke(_barangDao, args);
                return InterpretResultAsSuccess(res);
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
