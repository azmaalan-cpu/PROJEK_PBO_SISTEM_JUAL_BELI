using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Projek_Final_sem2.UserControls.Teknisi
{
    public partial class UcStatus : UserControl
    {
        private object? _statusController;

        public UcStatus()
        {
            InitializeComponent();
        }

        private void UcStatus_Load(object sender, EventArgs e)
        {
            try
            {
                InitController();
                LoadStatusOptions();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan inisialisasi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitController()
        {
            if (_statusController != null) return;

            // Cari tipe StatusControl di semua assembly yang dimuat
            Type? ctrlType = null;
            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                try
                {
                    ctrlType = asm.GetType("Projek_Final_sem2.Control.Teknisi.StatusControl");
                    if (ctrlType != null) break;

                    // fallback: cari berdasarkan nama tipe saja
                    ctrlType = asm.GetTypes().FirstOrDefault(t => string.Equals(t.Name, "StatusControl", StringComparison.OrdinalIgnoreCase));
                    if (ctrlType != null) break;
                }
                catch
                {
                    // beberapa assembly mungkin tidak bisa di-reflect; abaikan
                }
            }

            if (ctrlType == null) return; // tidak ditemukan, biarkan tetap null

            _statusController = Activator.CreateInstance(ctrlType);
        }

        private void LoadStatusOptions()
        {
            CmbUbahStatus.Items.Clear();

            // Coba panggil beberapa nama method yang mungkin ada di controller
            var candidates = new[] { "GetStatuses", "GetStatusOptions", "GetAllStatuses", "GetAllStatus", "GetStatusList" };
            var list = InvokeControllerReturningEnumerable(candidates);

            if (list != null && list.Any())
            {
                foreach (var item in list)
                {
                    CmbUbahStatus.Items.Add(item?.ToString());
                }
            }

            // fallback jika controller tidak menyediakan daftar status
            if (CmbUbahStatus.Items.Count == 0)
            {
                CmbUbahStatus.Items.AddRange(new object[] { "Dalam Perbaikan", "Selesai", "Menunggu Sparepart", "Dibatalkan", "Diperiksa" });
            }
        }

        private IEnumerable<object>? InvokeControllerReturningEnumerable(string[] methodNames)
        {
            if (_statusController == null) return null;
            var t = _statusController.GetType();

            foreach (var name in methodNames)
            {
                var m = t.GetMethod(name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                if (m == null) continue;

                var res = m.Invoke(_statusController, null);
                if (res == null) return null;

                if (res is IEnumerable<object> eo) return eo;

                if (res is System.Collections.IEnumerable ie)
                {
                    var temp = new List<object>();
                    foreach (var o in ie) temp.Add(o ?? "");
                    return temp;
                }
            }

            return null;
        }

        private object? InvokeControllerFindById(string id)
        {
            if (_statusController == null) return null;
            var t = _statusController.GetType();
            var candidateNames = new[] { "GetById", "FindById", "Find", "GetServiceById", "CariServis", "CariService", "GetService" };

            foreach (var name in candidateNames)
            {
                var m = t.GetMethod(name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                if (m == null) continue;

                // coba panggil dengan satu parameter (id)
                try
                {
                    var parameters = m.GetParameters();
                    object? arg = id;
                    if (parameters.Length == 0) continue;

                    var paramType = parameters[0].ParameterType;
                    // konversi sederhana
                    if (paramType == typeof(int) && int.TryParse(id, out var iv)) arg = iv;

                    return m.Invoke(_statusController, new object[] { arg! });
                }
                catch
                {
                    // kalau gagal, lanjut ke candidate berikutnya
                }
            }

            return null;
        }

        private string? GetPropertyValueAsString(object obj, params string[] propNames)
        {
            if (obj == null) return null;
            var t = obj.GetType();

            foreach (var pname in propNames)
            {
                var p = t.GetProperty(pname, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                if (p == null) continue;
                var val = p.GetValue(obj);
                if (val != null) return val.ToString();
            }

            // cek fields sebagai fallback
            foreach (var fname in propNames)
            {
                var f = t.GetField(fname, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                if (f == null) continue;
                var val = f.GetValue(obj);
                if (val != null) return val.ToString();
            }

            return null;
        }

        private void BtnCariStatus_Click(object sender, EventArgs e)
        {
            var id = TbxIDServisStatus.Text?.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Masukkan ID Servis terlebih dahulu.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var data = InvokeControllerFindById(id);
                if (data == null)
                {
                    MessageBox.Show("Data servis tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Ambil nama alat dan status dari object hasil
                var nama = GetPropertyValueAsString(data, "NamaAlat", "Nama", "Nama_Barang", "Name");
                var status = GetPropertyValueAsString(data, "Status", "StatusServis", "StatusService", "Stat");

                TbxNamaAlatStatus.Text = nama ?? string.Empty;
                LblStatusSaatIni.Text = status ?? "Status Saat Ini";

                // Jika ada status saat ini, coba set selected index di combobox bila ada value sama
                if (!string.IsNullOrEmpty(status))
                {
                    var found = CmbUbahStatus.Items.Cast<object?>().FirstOrDefault(x => string.Equals(x?.ToString(), status, StringComparison.OrdinalIgnoreCase));
                    if (found != null) CmbUbahStatus.SelectedItem = found;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal mencari data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdateStatus_Click(object sender, EventArgs e)
        {
            var id = TbxIDServisStatus.Text?.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Masukkan ID Servis terlebih dahulu.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var newStatus = CmbUbahStatus.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(newStatus))
            {
                MessageBox.Show("Pilih status baru yang ingin diterapkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                if (_statusController == null)
                {
                    MessageBox.Show("Controller status belum terinisialisasi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var t = _statusController.GetType();
                var candidateNames = new[] { "UpdateStatus", "UbahStatus", "SetStatus", "ChangeStatus", "Update" };
                bool invoked = false;
                object? result = null;

                foreach (var name in candidateNames)
                {
                    var m = t.GetMethod(name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                    if (m == null) continue;

                    var parameters = m.GetParameters();
                    try
                    {
                        // beberapa signature: (id, status) atau (int id, string status) atau (serviceObj)
                        if (parameters.Length == 2)
                        {
                            object? arg0 = id;
                            if (parameters[0].ParameterType == typeof(int) && int.TryParse(id, out var iid)) arg0 = iid;
                            result = m.Invoke(_statusController, new object[] { arg0!, newStatus! });
                        }
                        else if (parameters.Length == 1)
                        {
                            // coba buat object model yang hanya punya id dan status jika diperlukan
                            var pType = parameters[0].ParameterType;
                            object? model = null;
                            try
                            {
                                model = Activator.CreateInstance(pType);
                                var pid = pType.GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                                if (pid != null)
                                {
                                    if (pid.PropertyType == typeof(int) && int.TryParse(id, out var iid)) pid.SetValue(model, iid);
                                    else pid.SetValue(model, id);
                                }
                                var pstatus = pType.GetProperty("Status", BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                                if (pstatus != null) pstatus.SetValue(model, newStatus);
                            }
                            catch
                            {
                                model = id; // fallback
                            }

                            result = m.Invoke(_statusController, new object[] { model! });
                        }
                        else
                        {
                            // tidak cocok, lewati
                            continue;
                        }

                        invoked = true;
                        break;
                    }
                    catch
                    {
                        // lanjut ke candidate berikutnya
                    }
                }

                if (!invoked)
                {
                    MessageBox.Show("Method update status tidak ditemukan di controller.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Interpretasi hasil: kalau return bool true atau int > 0 dianggap berhasil
                bool success = false;
                if (result is bool b) success = b;
                else if (result is int iv) success = iv > 0;
                else if (result is long lv) success = lv > 0;
                else if (result == null) success = true; // beberapa method tidak mengembalikan apa-apa

                if (success)
                {
                    MessageBox.Show("Status berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // refresh tampilan
                    BtnCariStatus_Click(null, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Gagal memperbarui status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat update: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBatalStatus_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            TbxIDServisStatus.Clear();
            TbxNamaAlatStatus.Clear();
            LblStatusSaatIni.Text = "Status Saat Ini";
            CmbUbahStatus.SelectedIndex = -1;
        }

        private void CmbUbahStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // opsional: bisa tampilkan preview
        }

        private void LblStatusSaatIni_Click(object sender, EventArgs e)
        {
            // tidak dipakai
        }
    }
}
