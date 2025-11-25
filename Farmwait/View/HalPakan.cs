using Farmwait.Controllers;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Farmwait.View
{
    public partial class HalPakan : Form
    {
        private PakanController controller;

        public HalPakan()
        {
            InitializeComponent();
            controller = new PakanController();

            this.Load += HalPakan_Load;
            btnTambah.Click += BtnTambah_Click;

            // Event Klik pada Tabel (Untuk tombol Edit)
            dgvPakan.CellContentClick += DgvPakan_CellContentClick;
        }

        private void HalPakan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // 1. Ambil Data dari Controller
            DataTable dt = controller.LoadDataPakan();
            dgvPakan.DataSource = dt;

            // 2. Tambahkan Kolom Tombol Edit (jika belum ada)
            if (!dgvPakan.Columns.Contains("btnEdit"))
            {
                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                btnEdit.HeaderText = "Aksi";
                btnEdit.Name = "btnEdit";
                btnEdit.Text = "EDIT";
                btnEdit.UseColumnTextForButtonValue = true; // Agar tulisan di tombol selalu "EDIT"
                dgvPakan.Columns.Add(btnEdit);
            }

            // Opsional: Sembunyikan ID jika tidak ingin dilihat user (tapi request Anda minta ditampilkan)
            // dgvPakan.Columns["idpakan"].Visible = false; 
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            FormPakan form = new FormPakan();
            // ID = 0, artinya Tambah Baru
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData(); // Refresh tabel setelah tambah
            }
        }

        private void DgvPakan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pastikan yang diklik adalah kolom tombol "btnEdit" dan bukan header (-1)
            if (e.ColumnIndex == dgvPakan.Columns["btnEdit"].Index && e.RowIndex >= 0)
            {
                // 1. Ambil data dari baris yang diklik
                DataGridViewRow row = dgvPakan.Rows[e.RowIndex];

                int id = Convert.ToInt32(row.Cells["idpakan"].Value);
                string nama = row.Cells["namapakan"].Value.ToString();
                int stok = Convert.ToInt32(row.Cells["stokpakan"].Value);
                int harga = Convert.ToInt32(row.Cells["hargapakan"].Value);

                // 2. Buka FormPakan dalam mode Edit
                FormPakan form = new FormPakan();

                // Masukkan data ke form
                form.SetDataUntukEdit(id, nama, stok, harga);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData(); // Refresh tabel setelah edit berhasil
                }
            }
        }
    }
}