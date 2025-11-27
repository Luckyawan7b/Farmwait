using Farmwait.Models;
using System;
using System.Windows.Forms;

namespace Farmwait.View
{
    public partial class FormTransaksiPeternak : Form
    {
        // Variabel untuk menyimpan ID yang sedang diedit
        private int _idTransaksi;

        // Constructor kita perbanyak parameternya biar bisa nerima paket lengkap
        public FormTransaksiPeternak(string id, string tgl, string akun, string metode, string produk, string status)
        {
            InitializeComponent();

            // 1. Simpan ID untuk keperluan query Update nanti
            _idTransaksi = int.Parse(id);

            // 2. Tempel data kiriman ke TextBox (tb)
            tbIDTransaksi.Text = id;
            tbTanggalTransaksi.Text = tgl;
            tbIDAkun.Text = akun;
            tbMetodePembayaran.Text = metode;
            tbIDProduk.Text = produk; // Tambahan ID Produk

            // 3. Khusus Status, tempel ke ComboBox
            // Pastikan nama combobox-nya 'cbStatus' atau sesuaikan jika Bapak namakan 'tbStatus'
            cbStatus.Text = status;
        }

        private void FormTransaksiPeternak_Load(object sender, EventArgs e)
        {
            // Pastikan TextBox selain status tidak bisa diedit user (ReadOnly)
            tbIDTransaksi.ReadOnly = true;
            tbTanggalTransaksi.ReadOnly = true;
            tbIDAkun.ReadOnly = true;
            tbMetodePembayaran.ReadOnly = true;
            tbIDProduk.ReadOnly = true;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                // Panggil Model untuk update status ke Database
                Transaksi.UpdateStatus(_idTransaksi, cbStatus.Text);

                MessageBox.Show("Status berhasil diperbarui!");
                this.Close(); // Tutup form setelah simpan
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal update: " + ex.Message);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}