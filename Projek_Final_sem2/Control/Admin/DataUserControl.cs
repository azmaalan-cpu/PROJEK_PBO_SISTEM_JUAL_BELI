using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using Projek_Final_sem2.DAO;

namespace Projek_Final_sem2.Control.Admin
{
    // Controller untuk manajemen user (Admin)
    // Menyediakan: MuatUsers, DapatkanUserById, TambahUser, UbahUser, HapusUser
    // serta hashing/verifikasi password menggunakan PBKDF2
    public class DataUserControl
    {
        private readonly object _userDao;

        public DataUserControl()
        {
            var inst = Activator.CreateInstance(typeof(UserDAO));
            if (inst == null) throw new InvalidOperationException("Tidak bisa membuat instance UserDAO");
            _userDao = inst;
        }

        // Muat semua user (alias Bahasa Indonesia)
        public DataTable MuatUsers()
        {
            return LoadUsers();
        }

        // Metode asli: LoadUsers
        public DataTable LoadUsers()
        {
            try
            {
                var type = _userDao.GetType();
                var m = type.GetMethod("GetAllUsers") ?? type.GetMethod("GetAll") ?? type.GetMethod("GetUsers") ?? type.GetMethod("Get");
                if (m == null) return new DataTable();
                var res = m.Invoke(_userDao, null);
                if (res is DataTable dt) return dt;
                if (res is IEnumerable ie) return EnumerableToDataTable(ie);
                return new DataTable();
            }
            catch
            {
                return new DataTable();
            }
        }

        // Dapatkan user berdasarkan id (alias Bahasa Indonesia)
        public DataTable DapatkanUserById(int id)
        {
            return GetUserById(id);
        }

        // Metode asli: GetUserById
        public DataTable GetUserById(int id)
        {
            try
            {
                var type = _userDao.GetType();
                var m = type.GetMethod("GetById") ?? type.GetMethod("GetUserById") ?? type.GetMethod("FindById");
                if (m == null) return new DataTable();
                var res = m.Invoke(_userDao, new object[] { id });
                if (res is DataTable dt) return dt;
                if (res is IEnumerable ie) return EnumerableToDataTable(ie);
                if (res != null) return EnumerableToDataTable(new[] { res });
                return new DataTable();
            }
            catch
            {
                return new DataTable();
            }
        }

        // Tambah user (alias Bahasa Indonesia)
        public bool TambahUser(string username, string password, string role)
        {
            return AddUser(username, password, role);
        }

        // Metode asli: AddUser
        public bool AddUser(string username, string password, string role)
        {
            ValidateUserInput(username, password, role);
            var (hash, salt) = HashPassword(password);

            try
            {
                var type = _userDao.GetType();
                var m = type.GetMethod("Insert") ?? type.GetMethod("Add") ?? type.GetMethod("Create");
                if (m == null) return false;
                var p = m.GetParameters();
                object[] args;
                if (p.Length == 1)
                {
                    var modelType = p[0].ParameterType;
                    var model = Activator.CreateInstance(modelType);
                    if (model == null) return false;
                    SetPropertyIfExists(model, "username", username);
                    SetPropertyIfExists(model, "role", role);
                    SetPropertyIfExists(model, "password_hash", hash);
                    SetPropertyIfExists(model, "password_salt", salt);
                    SetPropertyIfExists(model, "passwordSalt", salt);
                    SetPropertyIfExists(model, "passwordHash", hash);
                    args = new object[] { model };
                }
                else if (p.Length >= 3)
                {
                    args = new object[] { username, hash, salt, role };
                }
                else
                {
                    args = new object[] { username, hash, salt, role };
                }

                var res = m.Invoke(_userDao, args);
                return InterpretResultAsSuccess(res);
            }
            catch
            {
                return false;
            }
        }

        // Ubah user (alias Bahasa Indonesia)
        public bool UbahUser(int id, string? username = null, string? password = null, string? role = null)
        {
            return EditUser(id, username, password, role);
        }

        // Metode asli: EditUser
        public bool EditUser(int id, string? username = null, string? password = null, string? role = null)
        {
            if (username == null && password == null && role == null) return false;
            byte[]? hash = null; byte[]? salt = null;
            if (!string.IsNullOrEmpty(password)) (hash, salt) = HashPassword(password);

            try
            {
                var type = _userDao.GetType();
                var m = type.GetMethod("Update") ?? type.GetMethod("Edit") ?? type.GetMethod("Modify");
                if (m == null) return false;
                var p = m.GetParameters();
                object[] args;
                if (p.Length == 2)
                {
                    var modelType = p[1].ParameterType;
                    var model = Activator.CreateInstance(modelType);
                    if (model == null) return false;
                    if (username != null) SetPropertyIfExists(model, "username", username);
                    if (role != null) SetPropertyIfExists(model, "role", role);
                    if (hash != null) SetPropertyIfExists(model, "password_hash", hash);
                    if (salt != null) SetPropertyIfExists(model, "password_salt", salt);
                    args = new object[] { id, model };
                }
                else if (p.Length == 1)
                {
                    var modelType = p[0].ParameterType;
                    var model = Activator.CreateInstance(modelType);
                    if (model == null) return false;
                    SetPropertyIfExists(model, "id", id);
                    if (username != null) SetPropertyIfExists(model, "username", username);
                    if (role != null) SetPropertyIfExists(model, "role", role);
                    if (hash != null) SetPropertyIfExists(model, "password_hash", hash);
                    if (salt != null) SetPropertyIfExists(model, "password_salt", salt);
                    args = new object[] { model };
                }
                else
                {
                    args = new object[] { id, username ?? string.Empty, hash ?? new byte[0], salt ?? new byte[0], role ?? string.Empty };
                }

                var res = m.Invoke(_userDao, args);
                return InterpretResultAsSuccess(res);
            }
            catch
            {
                return false;
            }
        }

        // Hapus user (alias Bahasa Indonesia)
        public bool HapusUser(int id)
        {
            return DeleteUser(id);
        }

        // Metode asli: DeleteUser
        public bool DeleteUser(int id)
        {
            try
            {
                var type = _userDao.GetType();
                var m = type.GetMethod("Delete") ?? type.GetMethod("Remove") ?? type.GetMethod("DeleteById");
                if (m == null) return false;
                var p = m.GetParameters();
                object[] args = p.Length == 1 ? new object[] { id } : new object[] { };
                var res = m.Invoke(_userDao, args);
                return InterpretResultAsSuccess(res);
            }
            catch
            {
                return false;
            }
        }

        // --- Helpers ---
        // Validasi input user (username, password, role)
        // Melempar ArgumentException jika input tidak valid
        private static void ValidateUserInput(string username, string password, string role)
        {
            if (string.IsNullOrWhiteSpace(username)) throw new ArgumentException("Username wajib diisi");
            if (string.IsNullOrWhiteSpace(password) || password.Length < 8) throw new ArgumentException("Password minimal 8 karakter");
            if (string.IsNullOrWhiteSpace(role)) throw new ArgumentException("Role wajib diisi");
        }

        // Hash password menggunakan PBKDF2 (instance API) - kembalikan (hash, salt)
        private static (byte[] hash, byte[] salt) HashPassword(string password)
        {
            var salt = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            using var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100_000, HashAlgorithmName.SHA256);
            var hash = pbkdf2.GetBytes(32);
            return (hash, salt);
        }

        // Alias (Bahasa Indonesia): HashSandi
        private static (byte[] hash, byte[] salt) HashSandi(string password) => HashPassword(password);

        // Verifikasi password terhadap hash dan salt yang tersimpan
        public static bool VerifyPassword(string password, byte[] storedHash, byte[] storedSalt)
        {
            // gunakan instance API untuk kompatibilitas
            using var pbkdf2 = new Rfc2898DeriveBytes(password, storedSalt, 100_000, HashAlgorithmName.SHA256);
            var computed = pbkdf2.GetBytes(storedHash.Length);
            return CryptographicOperations.FixedTimeEquals(computed, storedHash);
        }

        // Alias (Bahasa Indonesia): VerifikasiSandi
        public static bool VerifikasiSandi(string password, byte[] storedHash, byte[] storedSalt) => VerifyPassword(password, storedHash, storedSalt);

        // Interpretasi hasil dari DAO: true jika sukses
        private static bool InterpretResultAsSuccess(object? res)
        {
            if (res == null) return false;
            if (res is bool b) return b;
            if (res is int i) return i > 0;
            if (res is long l) return l > 0;
            return true;
        }

        // Set property pada model jika properti tersedia (dengan perbandingan nama case-insensitive)
        private static void SetPropertyIfExists(object? model, string propName, object? value)
        {
            if (model == null) return;
            var t = model.GetType();
            var prop = t.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                        .FirstOrDefault(p => string.Equals(p.Name, propName, StringComparison.OrdinalIgnoreCase) ||
                                             string.Equals(p.Name.Replace("_", ""), propName, StringComparison.OrdinalIgnoreCase));
            if (prop == null) return;
            try
            {
                if (prop.PropertyType == typeof(byte[]) && value is byte[] b) prop.SetValue(model, b);
                else if (prop.PropertyType == typeof(string) && value != null) prop.SetValue(model, Convert.ToString(value));
                else if (prop.PropertyType.IsEnum && value != null) prop.SetValue(model, Enum.Parse(prop.PropertyType, value.ToString() ?? string.Empty));
                else if (value != null) prop.SetValue(model, Convert.ChangeType(value, prop.PropertyType));
            }
            catch
            {
                // ignore property set failures
            }
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
