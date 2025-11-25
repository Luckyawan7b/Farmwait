using Farmwait.Models;
using System.Data;

namespace Farmwait.Controllers
{
    public class ProdukController
    {
        // Mengambil data tabel
        public DataTable LoadData()
        {
            return Produk.AmbilSemuaProduk();
        }
        public DataTable GetListHewan()
        {
            return Hewan.AmbilSemuaHewan();
        }

        public bool SimpanProduk(int id, string nama, string jenis, object idHewanObj, string jumlahStr, string hargaStr)
        {
            if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(jenis) || idHewanObj == null)
            {
                MessageBox.Show("Nama, Jenis, dan Hewan Asal wajib diisi!");
                return false;
            }

            if (!int.TryParse(jumlahStr, out int jumlah) || !int.TryParse(hargaStr, out int harga))
            {
                MessageBox.Show("Jumlah dan Harga harus angka!");
                return false;
            }

            Produk prod = new Produk();
            prod.Id = id;
            prod.Nama = nama;
            prod.JenisProduk = jenis;
            prod.IdHewan = Convert.ToInt32(idHewanObj); 
            prod.JumlahProduk = jumlah;
            prod.HargaProduk = harga;

            if (id == 0)
            {
                return prod.TambahData();
            }
            else
            {
                return prod.UpdateData();
            }
        }

        public bool HapusProduk(int id)
        {
            Produk produk = new Produk();
            produk.Id = id;
            return produk.HapusData();
        }
    }
}