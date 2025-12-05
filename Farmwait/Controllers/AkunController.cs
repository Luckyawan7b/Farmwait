using Farmwait.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Farmwait.Controllers
{
    public class AkunController
    {
        // ... (Method LoadKabupaten, LoadKecamatan, dll tetap sama) ...
        public List<ComboBoxItem> LoadKabupaten() => Wilayah.GetKabupaten();
        public List<ComboBoxItem> LoadKecamatan(int idKab) => Wilayah.GetKecamatan(idKab);
        public List<ComboBoxItem> LoadDesa(int idKec) => Wilayah.GetDesa(idKec);

        // === TAMBAHAN BARU ===
        public WilayahDetail GetWilayahHierarchy(int idDesa)
        {
            return Wilayah.GetDetailByDesa(idDesa);
        }

        // ... (Sisa method Register, Login, LoadSemuaAkun, dll tetap sama, tidak perlu diubah) ...
        // Paste sisa kodingan AkunController.cs yang lama disini jika perlu, 
        // tapi intinya hanya nambah method GetWilayahHierarchy di atas.

        // (Saya sertakan method lainnya agar file lengkap jika dicopy paste)
        public bool Register(string username, string password, string nama, string email, string alamat, string telp, object selectedDesa)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(telp))
            {
                MessageBox.Show("Data wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (selectedDesa == null)
            {
                MessageBox.Show("Pilih lokasi Desa.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            int idDesa = ((ComboBoxItem)selectedDesa).Id;
            bool success = Akun.Daftar(username, password, nama, email, alamat, telp, idDesa);
            if (success) MessageBox.Show("Registrasi Berhasil!", "Sukses");
            return success;
        }

        public Akun Login(string username, string password) => Akun.CekLogin(username, password);
        public DataTable LoadSemuaAkun() => Akun.AmbilSemuaAkun();

        public Akun LoadDetailAkun(int id)
        {
            Akun akun = new Akun();
            if (akun.AmbilDetailById(id)) return akun;
            return null;
        }

        public bool UpdateAkun(int id, string user, string pass, string nama, string email, string alamat, string telp, int idDesa, string role)
        {
            Akun akun = new Akun();
            akun.IdAkun = id;
            akun.Username = user;
            akun.Password = pass;
            akun.Nama = nama;
            akun.Email = email;
            akun.Alamat = alamat;
            akun.Telp = telp;
            akun.IdDesa = idDesa;
            akun.Role = role;
            return akun.UpdateData();
        }
    }
}