using Farmwait.Models; // <-- Jangan lupa tambahkan ini biar kenal class Transaksi
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
    public partial class HalTransaksiPeternak : Form
    {
        public HalTransaksiPeternak()
        {
            InitializeComponent();
        }

        // INI YANG AKAN MUNCUL SETELAH DOUBLE CLICK BACKGROUND
        private void HalTransaksiPeternak_Load(object sender, EventArgs e)
        {
            // Masukkan logika pemanggilan data di sini
            try
            {
                // Panggil method statis dari Model Transaksi
                dgvTransaksi.DataSource = Transaksi.AmbilSemua();

                // Rapikan kolom
                dgvTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        // Biarkan kosong saja kalau tidak dipakai
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

   
        private void dgvTransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Cek apakah yang diklik adalah kolom tombol "colEdit" (Pastikan nama kolomnya bener ya)
            //    && Pastikan bukan header tabel (RowIndex >= 0)
            if (e.ColumnIndex == dgvTransaksi.Columns["colEdit"].Index && e.RowIndex >= 0)
            {
                // 2. Ambil baris yang sedang diklik
                DataGridViewRow row = dgvTransaksi.Rows[e.RowIndex];

                // 3. Ambil data dari sel. 
                // PENTING: Karena pakai PostgreSQL, nama kolom biasanya HURUF KECIL SEMUA.
                // Sesuaikan string di dalam ["..."] dengan nama kolom di Database pgAdmin Bapak.
                // GANTI BAGIAN INI:
                string id = row.Cells["idTransaksi"].Value.ToString();       // I besar
                string tgl = row.Cells["tanggalTransaksi"].Value.ToString(); // T besar
                string akun = row.Cells["idAkun"].Value.ToString();          // I & A besar
                string metode = row.Cells["metodePembayaran"].Value.ToString(); // M & P besar
                string produk = row.Cells["idProduk"].Value.ToString();      // I & P besar
                string status = row.Cells["status"].Value.ToString();        // S besar

                // 4. Panggil Form Pop-up (Kirim paket data lengkap)
                FormTransaksiPeternak formPopUp = new FormTransaksiPeternak(id, tgl, akun, metode, produk, status);

                // 5. Tampilkan sebagai Dialog (User harus tutup pop-up dulu baru bisa balik)
                formPopUp.ShowDialog();

                // 6. REFRESH TABEL (Panggil ulang fungsi load biar status barunya muncul)
                // Kita copy logika yang ada di HalTransaksiPeternak_Load
                try
                {
                    dgvTransaksi.DataSource = Transaksi.AmbilSemua();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal refresh: " + ex.Message);
                }
            }
        }
    
    }
}