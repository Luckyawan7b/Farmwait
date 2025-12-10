using Farmwait.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace Farmwait.View
{
    public partial class HalTransaksi : Form
    {
        private string userRole;
        private int currentIdUser;

        public HalTransaksi()
        {
            InitializeComponent();
        }

        // Constructor Utama (Menerima Role dan ID)
        public HalTransaksi(string role, int idUser)
        {
            InitializeComponent();
            this.userRole = role;
            this.currentIdUser = idUser;
        }

        private void HalTransaksiPeternak_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                DataTable dt;

                if (userRole == "Peternak")
                {
                    dt = Transaksi.AmbilSemua();
                    if (dgvTransaksi.Columns.Contains("colEdit"))
                        dgvTransaksi.Columns["colEdit"].Visible = true;
                }
                else
                {
                    // Pembeli: Lihat Transaksi Sendiri
                    // Kita perlu method khusus di Model Transaksi (AmbilByAkunWithDetail)
                    // Untuk sementara kita pakai AmbilByAkun yang sudah ada atau buat baru
                    dt = Transaksi.AmbilByAkun(currentIdUser);

                    // Sembunyikan tombol Edit karena Pembeli tidak boleh ubah status
                    if (dgvTransaksi.Columns.Contains("colEdit"))
                        dgvTransaksi.Columns["colEdit"].Visible = false;
                }

                // Panggil data 
                dgvTransaksi.DataSource = dt;

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
            if (userRole != "Peternak") return;
            // Validasi: Pastikan baris yg diklik bukan header, dan yg diklik kolom tombol "colEdit"
            // (Sesuaikan "colEdit" dengan nama tombol Edit di designer bapak)
            if (e.RowIndex >= 0 && dgvTransaksi.Columns.Contains("colEdit") && e.ColumnIndex == dgvTransaksi.Columns["colEdit"].Index)
            {
                DataGridViewRow row = dgvTransaksi.Rows[e.RowIndex];

                // === JURUS SAKTI (ANTI ERROR NAMA KOLOM) ===
                // Kita ambil data langsung dari 'DataRowView' (Sumber datanya).
                // Jadi mau nama kolom di tabel UI-nya apa aja, GAK NGARUH.
                // Yang penting nama di ["..."] SAMA dengan nama di QUERY DATABASE (Model Transaksi).

                if (row.DataBoundItem is DataRowView itemAsli)
                {
                    string id = itemAsli["idtransaksi"].ToString();
                    string tgl = itemAsli["tanggaltransaksi"].ToString();
                    string akun = itemAsli["idakun"].ToString();
                    string metode = itemAsli["metodepembayaran"].ToString();
                    string namaProduk = itemAsli.DataView.Table.Columns.Contains("namaproduk") ? itemAsli["namaproduk"].ToString() : "-";
                    string status = itemAsli["status"].ToString();
                    // Buka Pop-up
                    FormTransaksiPeternak formPopUp = new FormTransaksiPeternak(id, tgl, akun, metode, namaProduk, status);
                    formPopUp.ShowDialog();

                    // Refresh Data
                    LoadData();
                }

                    //System.Data.DataRowView itemAsli = (System.Data.DataRowView)row.DataBoundItem;

                

                // Nah, ini pasti aman sekarang, karena di Query Transaksi.cs udah ada 'namaproduk'
                

                
            }
        }
    }
}

                // Buka Form Pop-up Edit
                // Pastikan FormTransaksiPeternak constructor-nya sudah dis