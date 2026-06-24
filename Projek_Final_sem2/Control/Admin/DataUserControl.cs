using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using Projek_Final_sem2.DAO;
using Projek_Final_sem2.Models;

namespace Projek_Final_sem2.Control.Admin
{
    // Controller untuk manajemen user (Admin)
    // Menyediakan: MuatUsers, DapatkanUserById, TambahUser, UbahUser, HapusUser
    // serta hashing/verifikasi password menggunakan PBKDF2
    public class DataUserControl
    {

        // Field encapsulation: menyimpan UserDAO privat
        // OOP pillars: Encapsulation (digunakan)
        private readonly UserDAO _userDao;

        // Konstruktor
        // OOP pillars: Encapsulation, Abstraction
        public DataUserControl()
        {
            _userDao = new UserDAO();
        }

        // Muat semua user (alias Bahasa Indonesia)
        // OOP pillars: Abstraction, Encapsulation
        public DataTable MuatUsers()
        {
            return LoadUsers();
        }

        // Metode asli: LoadUsers
        // OOP pillars: Abstraction, Encapsulation
        public DataTable LoadUsers()
        {
            try
            {
                return _userDao.GettAll() ?? new DataTable();
            }
            catch
            {
                return new DataTable();
            }
        }

        // Dapatkan user berdasarkan id (alias Bahasa Indonesia)
        // OOP pillars: Abstraction, Encapsulation
        public DataTable DapatkanUserById(int id)
        {
            return GetUserById(id);
        }

        // Metode asli: GetUserById
        // OOP pillars: Abstraction, Encapsulation
        public DataTable GetUserById(int id)
        {
            try
            {
                var dt = _userDao.GettAll();
                if (dt == null) return new DataTable();
                var found = dt.Select($"id_user = {id}");
                var outDt = dt.Clone();
                foreach (var row in found) outDt.ImportRow(row);
                return outDt;
            }
            catch
            {
                return new DataTable();
            }
        }

        // Tambah user (alias Bahasa Indonesia)
        // OOP pillars: Abstraction, Encapsulation
        public bool TambahUser(string username, string password, string role)
        {
            return AddUser(username, password, role);
        }

        // Metode asli: AddUser
        // OOP pillars: Abstraction, Encapsulation
        public bool AddUser(string username, string password, string role)
        {
            ValidateUserInput(username, password, role);
            try
            {
                var user = new User
                {
                    Username = username,
                    Password = password,
                    IdRole = int.TryParse(role, out var r) ? r : 0
                };
                _userDao.Insert(user);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Ubah user (alias Bahasa Indonesia)
        // OOP pillars: Abstraction, Encapsulation
        public bool UbahUser(int id, string? username = null, string? password = null, string? role = null)
        {
            return EditUser(id, username, password, role);
        }

        // Metode asli: EditUser
        // OOP pillars: Abstraction, Encapsulation
        public bool EditUser(int id, string? username = null, string? password = null, string? role = null)
        {
            if (username == null && password == null && role == null) return false;
            try
            {
                var user = new User
                {
                    IdUser = id,
                    Username = username ?? string.Empty,
                    Password = password ?? string.Empty,
                    IdRole = role != null && int.TryParse(role, out var r) ? r : 0
                };
                _userDao.Update(user);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Hapus user (alias Bahasa Indonesia)
        // OOP pillars: Abstraction, Encapsulation
        public bool HapusUser(int id)
        {
            return DeleteUser(id);
        }

        // Metode asli: DeleteUser
        // OOP pillars: Abstraction, Encapsulation
        public bool DeleteUser(int id)
        {
            try
            {
                _userDao.Delete(id);
                return true;
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
        // OOP pillars: Abstraction, Encapsulation
        private static bool InterpretResultAsSuccess(object? res)
        {
            if (res == null) return false;
            if (res is bool b) return b;
            if (res is int i) return i > 0;
            if (res is long l) return l > 0;
            return true;
        }

        // Set property pada model jika properti tersedia (dengan perbandingan nama case-insensitive)
        // OOP pillars: Encapsulation, Polymorphism
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
