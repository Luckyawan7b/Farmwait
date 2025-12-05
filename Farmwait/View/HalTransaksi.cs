using Farmwait.Models;
using System;
using System.Windows.Forms;

namespace Farmwait.View
{
    public partial class HalTransaksi : Form
    {
        public HalTransaksi()
        {
            InitializeComponent();
        }

        private void HalTransaksiPeternak_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Panggil data dari Model (sudah ada nama produk & jumlah)
                dgvTransaksi.DataSource = Transaksi.AmbilSemua();

                // Rapikan Header Kolom
                // Gunakan Nama Kolom (huruf kecil) sesuai hasil Query Database (PostgreSQL)
                if (dgvTransaksi.Columns.Contains("idtransaksi"))
                    dgvTransaksi.Columns["idtransaksi"].HeaderText = "ID Transaksi";

                if (dgvTransaksi.Columns.Contains("tanggaltransaksi"))
                    dgvTransaksi.Columns["tanggaltransaksi"].HeaderText = "Tanggal";

                if (dgvTransaksi.Columns.Contains("idakun"))
                    dgvTransaksi.Columns["idakun"].HeaderText = "ID Pembeli";

                if (dgvTransaksi.Columns.Contains("metodepembayaran"))
                    dgvTransaksi.Columns["metodepembayaran"].HeaderText = "Metode";

                // === KOLOM BARU DARI JOIN ===
                if (dgvTransaksi.Columns.Contains("namaproduk"))
                    dgvTransaksi.Columns["namaproduk"].HeaderText = "Item Dibeli";

                if (dgvTransaksi.Columns.Contains("jumlah"))
                    dgvTransaksi.Columns["jumlah"].HeaderText = "Qty";

                if (dgvTransaksi.Columns.Contains("totalharga"))
                    dgvTransaksi.Columns["totalharga"].HeaderText = "Total (Rp)";

                dgvTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message);
            }
        }

        private void dgvTransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validasi: Pastikan baris yg diklik bukan header, dan yg diklik kolom tombol "colEdit"
            // (Sesuaikan "colEdit" dengan nama tombol Edit di designer bapak)
            if (e.RowIndex >= 0 && dgvTransaksi.Columns.Contains("colEdit") && e.ColumnIndex == dgvTransaksi.Columns["colEdit"].Index)
            {
                DataGridViewRow row = dgvTransaksi.Rows[e.RowIndex];

                // === JURUS SAKTI (ANTI ERROR NAMA KOLOM) ===
                // Kita ambil data langsung dari 'DataRowView' (Sumber datanya).
                // Jadi mau nama kolom di tabel UI-nya apa aja, GAK NGARUH.
                // Yang penting nama di ["..."] SAMA dengan nama di QUERY DATABASE (Model Transaksi).

                System.Data.DataRowView itemAsli = (System.Data.DataRowView)row.DataBoundItem;

                string id = itemAsli["idtransaksi"].ToString();
                string tgl = itemAsli["tanggaltransaksi"].ToString();
                string akun = itemAsli["idakun"].ToString();
                string metode = itemAsli["metodepembayaran"].ToString();

                // Nah, ini pasti aman sekarang, karena di Query Transaksi.cs udah ada 'namaproduk'
                string namaProduk = itemAsli["namaproduk"].ToString();

                string status = itemAsli["status"].ToString();

                // Buka Pop-up
                FormTransaksiPeternak formPopUp = new FormTransaksiPeternak(id, tgl, akun, metode, namaProduk, status);
                formPopUp.ShowDialog();

                // Refresh Data
                LoadData();
            }
        }
    }
}

                // Buka Form Pop-up Edit
                // Pastikan FormTransaksiPeternak constructor-nya sudah dis