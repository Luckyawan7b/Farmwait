using Farmwait.Models;
using System.Data;
using System.Windows.Forms;

namespace Farmwait.Controllers
{
    public class PakanController
    {
        public DataTable LoadDataPakan()
        {
            return Pakan.AmbilSemua();
        }

        public bool SimpanPakan(int id, string nama, string stokStr, string hargaStr)
        {
            // Validasi input
            if (string.IsNullOrWhiteSpace(nama) || !int.TryParse(stokStr, out int stok) || !int.TryParse(hargaStr, out int harga))
            {
                MessageBox.Show("Input tidak valid!");
                return false;
            }

            // [INSTANSIASI OBJEK] Membuat object nyata dari class Pakan
            Pakan pakanBaru = new Pakan();
            pakanBaru.Id = id;
            pakanBaru.Nama = nama;
            pakanBaru.Stok = stok;
            pakanBaru.Harga = harga;

            // Logika simpan/update berdasarkan ID
            if (id == 0)
            {
                return pakanBaru.SimpanKeDatabase(); // Memanggil method milik object
            }
            else
            {
                return pakanBaru.UpdateDatabase(); // Memanggil method milik object
            }
        }
    }
}