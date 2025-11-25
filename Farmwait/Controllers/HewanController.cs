using Farmwait.Models;
using System.Data;
using System.Windows.Forms;

namespace Farmwait.Controllers
{
    public class HewanController
    {
        // Mengambil data untuk DataGridView
        public DataTable LoadData()
        {
            return Hewan.AmbilSemuaHewan();
        }
        public DataTable GetListPakan()
        {
            return Pakan.AmbilSemua();
        }

        public bool SimpanHewan(int id, string jenis, string jk, string beratStr, string usiaStr, object idPakanObj, string porsiStr)
        {
            // 1. Validasi
            if (string.IsNullOrWhiteSpace(jenis) || string.IsNullOrWhiteSpace(jk) || idPakanObj == null)
            {
                MessageBox.Show("Data Jenis, Kelamin, dan Pakan wajib diisi!");
                return false;
            }

            if (!int.TryParse(beratStr, out int berat) || !int.TryParse(usiaStr, out int usia) || !int.TryParse(porsiStr, out int porsi))
            {
                MessageBox.Show("Berat, Usia, dan Porsi harus angka!");
                return false;
            }

            // 2. [INSTANSIASI] Membuat Objek Hewan
            Hewan hewan = new Hewan();
            hewan.Id = id;
            hewan.Nama = jenis; // Nama di ItemGudang = jenishewan
            hewan.JenisKelamin = jk;
            hewan.Berat = berat;
            hewan.Usia = usia;
            hewan.IdPakan = Convert.ToInt32(idPakanObj); // Mengambil ValueMember dari ComboBox
            hewan.PorsiPakan = porsi;

            // 3. Tentukan Aksi (Polimorfisme logic)
            if (id == 0)
            {
                return hewan.TambahData(); // Mode Tambah
            }
            else
            {
                return hewan.UpdateData(); // Mode Edit
            }
        }

        // Menghapus Data (Soft Delete)
        public bool HapusHewan(int id)
        {
            // [INSTANSIASI] Membuat objek hewan spesifik
            Hewan hewanDihapus = new Hewan();
            hewanDihapus.Id = id;

            // Memanggil method milik objek tersebut
            return hewanDihapus.HapusData();
        }
    }
}