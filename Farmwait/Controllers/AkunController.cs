using Farmwait.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Farmwait.Controllers
{
    public class AkunController
    {
        // Method untuk mengambil data wilayah via Model
        public List<ComboBoxItem> LoadKabupaten()
        {
            return Wilayah.GetKabupaten();
        }

        public List<ComboBoxItem> LoadKecamatan(int idKab)
        {
            return Wilayah.GetKecamatan(idKab);
        }

        public List<ComboBoxItem> LoadDesa(int idKec)
        {
            return Wilayah.GetDesa(idKec);
        }

        // Method Register
        public bool Register(string username, string password, string nama, string email, string alamat, string telp, object selectedDesa)
        {
            // 1. Validasi Input Kosong
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(telp))
            {
                MessageBox.Show("Data wajib (Username, Password, Nama, No Telp) harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 2. Validasi Desa Dipilih
            if (selectedDesa == null)
            {
                MessageBox.Show("Silakan pilih lokasi Desa tempat tinggal Anda.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Ambil ID Desa dari object ComboBox
            int idDesa = ((ComboBoxItem)selectedDesa).Id;

            // 3. Panggil Model untuk simpan
            bool success = Akun.Daftar(username, password, nama, email, alamat, telp, idDesa);

            if (success)
            {
                MessageBox.Show("Registrasi Berhasil! Silakan Login.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return success;
        }
        public bool Login(string username, string password)
        {
            // 1. Validasi Input Kosong
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username dan Password harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 2. Panggil Model
            string role = Akun.CekLogin(username, password);

            if (role != null)
            {
                MessageBox.Show($"Selamat datang, anda login sebagai {role}!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Disini anda bisa simpan session role jika perlu
                return true;
            }
            else
            {
                MessageBox.Show("Username atau Password salah!", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}