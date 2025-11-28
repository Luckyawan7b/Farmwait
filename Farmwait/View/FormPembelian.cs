using Farmwait.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Farmwait.View
{
    public partial class FormPembelian : Form
    {
        private int _idProduk;
        private int _hargaSatuan;
        private int _idUserPembeli;
        public FormPembelian(int idProduk, string namaProduk, int hargaSatuan, int idUser)
        {
            InitializeComponent();

            _idProduk = idProduk;
            _hargaSatuan = hargaSatuan;
            _idUserPembeli = idUser; // Simpan ID User

            // Set Tampilan
            tbNamaProduk.Text = namaProduk;
            //tbHargaSatuan.Text = hargaSatuan.ToString("N0");
            tbTanggalTransaksi.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            AmbilIdBerikutnya();
            // TEMPEL ID USER KE TEXTBOX (Sesuai request Bapak)

            tbJumlah.Text = "1";
            HitungTotal(); // Panggil fungsi hitung

            tbIDAkun.Text = _idUserPembeli.ToString();

            //tbIDTransaksi.Text = "Auto-Gen";
        }
        private void tbJumlah_TextChanged(object sender, EventArgs e)
        {
            HitungTotal();
        }

        private void HitungTotal()
        {
            // Cek apakah input angka valid?
            if (int.TryParse(tbJumlah.Text, out int jumlah))
            {
                int total = jumlah * _hargaSatuan;
                tbTotalHarga.Text = total.ToString("N0"); // Format ribuan
            }
            else
            {
                tbTotalHarga.Text = "0";
            }
        }

        private void AmbilIdBerikutnya()
        {
            try
            {
                using (var conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    // Query: Ambil angka ID terbesar, kalau null anggap 0, lalu tambah 1
                    string sql = "SELECT COALESCE(MAX(idtransaksi), 0) + 1 FROM public.transaksi";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        // ExecuteScalar untuk mengambil 1 angka hasil query
                        int nextId = Convert.ToInt32(cmd.ExecuteScalar());
                        tbIDTransaksi.Text = nextId.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                tbIDTransaksi.Text = "Error";
                MessageBox.Show("Gagal ambil ID: " + ex.Message);
            }
        }

        private void FormPembelian_Load(object sender, EventArgs e)
        {

        }
    }
}
