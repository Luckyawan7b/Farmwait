using Farmwait.Models;
using Npgsql;
using System;
using System.Windows.Forms;

namespace Farmwait.View
{
    public partial class FormPembelian : Form
    {
        private int _idProduk;
        private int _hargaSatuan;
        private int _idUserPembeli;

        // 1. TAMBAHAN: Variabel global untuk simpan info stok
        private int _stokTersedia;

        // 2. TAMBAHAN: Masukkan 'int stokAwal' di dalam kurung ini
        public FormPembelian(int idProduk, string namaProduk, int hargaSatuan, int idUser, int stokAwal)
        {
            InitializeComponent();

            _idProduk = idProduk;
            _hargaSatuan = hargaSatuan;
            _idUserPembeli = idUser;

            // Simpan stok ke variabel global biar bisa dicek nanti
            _stokTersedia = stokAwal;

            // Set Tampilan
            tbNamaProduk.Text = namaProduk;
            tbTanggalTransaksi.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            tbIDAkun.Text = _idUserPembeli.ToString();

            // Tampilkan Info Stok di Judul Form biar user tau
            this.Text = $"Form Pembelian (Stok Tersedia: {_stokTersedia})";

            AmbilIdBerikutnya();

            tbJumlah.Text = "1";
            HitungTotal();
        }

        private void tbJumlah_TextChanged(object sender, EventArgs e)
        {
            HitungTotal();
        }

        private void HitungTotal()
        {
            if (int.TryParse(tbJumlah.Text, out int jumlah))
            {
                int total = jumlah * _hargaSatuan;
                tbTotalHarga.Text = total.ToString("N0");
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
                    string sql = "SELECT COALESCE(MAX(idtransaksi), 0) + 1 FROM public.transaksi";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
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
            // Kosongkan saja tidak apa-apa
        }

        // Ini Tombol "Buat Pesanan" (Sepertinya Bapak pakai Label yang diklik ya? Gpp, fungsinya sama)
        private void btnBuatPesanan_Click(object sender, EventArgs e)
        {
            // Validasi Input Kosong
            if (string.IsNullOrEmpty(tbJumlah.Text) || tbJumlah.Text == "0")
            {
                MessageBox.Show("Jumlah beli minimal 1!");
                return;
            }

            // Validasi Metode Pembayaran
            if (string.IsNullOrEmpty(cbMetodePembayaran.Text))
            {
                MessageBox.Show("Mohon pilih metode pembayaran!");
                return;
            }

            // 3. TAMBAHAN: Validasi Stok (PENTING!)
            int jumlah = int.Parse(tbJumlah.Text);

            if (jumlah > _stokTersedia)
            {
                MessageBox.Show($"Stok tidak cukup! Stok sisa: {_stokTersedia}");
                tbJumlah.Text = _stokTersedia.ToString(); // Reset ke angka maksimal
                return; // Berhenti di sini, jangan lanjut simpan
            }

            try
            {
                int totalHargaFix = jumlah * _hargaSatuan;

                // A. Simpan Transaksi (Status otomatis 'Proses')
                Transaksi.TambahTransaksi(
                    DateTime.Now,
                    _idUserPembeli,
                    cbMetodePembayaran.Text,
                    _idProduk,
                    jumlah,
                    totalHargaFix
                );

                // B. TAMBAHAN: Potong Stok di Database Produk
                // (Pastikan method KurangiStok sudah ada di Model Produk.cs ya Pak!)
                Produk.KurangiStok(_idProduk, jumlah);

                MessageBox.Show("Pesanan Berhasil Dibuat! Stok berkurang.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}