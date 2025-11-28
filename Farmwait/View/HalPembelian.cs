using Farmwait.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmwait.View
{
    public partial class HalPembelian : Form
    {
        private int _idUserLogin;
        public HalPembelian(int idUser)
        {
            InitializeComponent();
            _idUserLogin = idUser;
        }

        private void HalTransaksiPembeli_Load(object sender, EventArgs e)
        {
            // Masukkan logika pemanggilan data di sini
            try
            {
                // Panggil method statis dari Model Transaksi
                dgvPembelian.DataSource = Produk.AmbilSemuaProduk();

                // Rapikan kolom
                dgvPembelian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        private void dgvPembelian_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPembelian.Columns["colBeli"].Index && e.RowIndex >= 0)
            {
                // 2. Ambil baris yang sedang diklik
                DataGridViewRow row = dgvPembelian.Rows[e.RowIndex];

                int idProduk = Convert.ToInt32(row.Cells["colIDProduk"].Value);
                //string namaProduk = row.Cells["namaproduk"].Value.ToString();
                int hargaProduk = Convert.ToInt32(row.Cells["hargaproduk"].Value);

                // 3. Ambil data dari sel. 
                // PENTING: Karena pakai PostgreSQL, nama kolom biasanya HURUF KECIL SEMUA.
                // Sesuaikan string di dalam ["..."] dengan nama kolom di Database pgAdmin Bapak.
                // GANTI BAGIAN INI:
                //string id = row.Cells["id"].Value.ToString();
                string nama = row.Cells["colNamaProduk"].Value.ToString();
                //string jenisProduk = row.Cells["jenisProduk"].Value.ToString();
                //string idHewan = row.Cells["idHewan"].Value.ToString();
                string jumlahProduk = row.Cells["jumlahProduk"].Value.ToString();
                //string hargaProduk = row.Cells["hargaProduk"].Value.ToString();

                // 4. Panggil Form Pop-up (Kirim paket data lengkap)
                //FormPembelian formBeli = new FormPembelian(idProduk, nama, hargaProduk, _idUserLogin);


                int stokAwal = int.Parse(row.Cells["jumlahProduk"].Value.ToString());

                // Kirim Stok ke Form Pembelian (Parameter terakhir)
                FormPembelian formBeli = new FormPembelian(idProduk, nama, hargaProduk, _idUserLogin, stokAwal);

                // 5. Tampilkan sebagai Dialog (User harus tutup pop-up dulu baru bisa balik)
                formBeli.ShowDialog();

                // 6. REFRESH TABEL (Panggil ulang fungsi load biar status barunya muncul)
                // Kita copy logika yang ada di HalTransaksiPeternak_Load
                try
                {
                    dgvPembelian.DataSource = Produk.AmbilSemuaProduk();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal refresh: " + ex.Message);
                }
            }
        }
    }
}
