using Farmwait.Controllers;
using Farmwait.Models;
using System;
using System.Data;
using System.Drawing; 
using System.Windows.Forms;

namespace Farmwait.View
{
    public partial class HalHewan : Form
    {
        private HewanController controller;

        public HalHewan()
        {
            InitializeComponent();
            controller = new HewanController();

            this.Load += HalHewan_Load;
            dgvHewan.CellContentClick += DgvHewan_CellContentClick;
            btnTambah.Click += BtnTambah_Click;
        }

        private void HalHewan_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            // 1. Ambil Data
            DataTable dt = controller.LoadData();
            dgvHewan.DataSource = dt;

            // 2. Tambah Tombol EDIT (Jika belum ada)
            if (!dgvHewan.Columns.Contains("btnEdit"))
            {
                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                btnEdit.Name = "btnEdit";
                btnEdit.HeaderText = "Edit";
                btnEdit.Text = "EDIT";
                btnEdit.UseColumnTextForButtonValue = true;
                btnEdit.DefaultCellStyle.BackColor = Color.Orange; // Warna tombol Edit
                dgvHewan.Columns.Add(btnEdit);
            }

            // 3. Tambah Tombol HAPUS (Jika belum ada)
            if (!dgvHewan.Columns.Contains("btnHapus"))
            {
                DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn();
                btnHapus.Name = "btnHapus";
                btnHapus.HeaderText = "Hapus";
                btnHapus.Text = "HAPUS";
                btnHapus.UseColumnTextForButtonValue = true;
                btnHapus.DefaultCellStyle.BackColor = Color.Red; // Warna tombol Hapus
                btnHapus.DefaultCellStyle.ForeColor = Color.White;
                dgvHewan.Columns.Add(btnHapus);
            }

            // 4. Sembunyikan Header is_deleted (Jika terbawa di query select *)
            // Meskipun di query kita tidak select is_deleted, jaga-jaga jika nanti diubah
            if (dgvHewan.Columns.Contains("is_deleted"))
            {
                dgvHewan.Columns["is_deleted"].Visible = false;
            }

            // Opsional: Rapikan Judul Header
            if (dgvHewan.Columns.Contains("jenishewan")) dgvHewan.Columns["jenishewan"].HeaderText = "Jenis Hewan";
            if (dgvHewan.Columns.Contains("jeniskelamin")) dgvHewan.Columns["jeniskelamin"].HeaderText = "Kelamin";
        }

        private void DgvHewan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Ambil Data Baris
            int id = Convert.ToInt32(dgvHewan.Rows[e.RowIndex].Cells["idhewan"].Value);

            // LOGIKA HAPUS NGAB
            if (e.ColumnIndex == dgvHewan.Columns["btnHapus"].Index)
            {
                DialogResult tanya = MessageBox.Show(
                    "Apakah Anda yakin ingin menghapus data hewan ini?",
                    "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (tanya == DialogResult.Yes)
                {
                    // Panggil Controller
                    bool sukses = controller.HapusHewan(id);

                    if (sukses)
                    {
                        MessageBox.Show("Data berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshData(); // PENTING: Refresh tabel agar data yang dihapus hilang
                    }
                }
            }

            // === LOGIKA EDIT ===
            if (e.ColumnIndex == dgvHewan.Columns["btnEdit"].Index)
            {
                // Ambil data detail dari baris tabel
                string jenis = dgvHewan.Rows[e.RowIndex].Cells["jenishewan"].Value.ToString();
                string jk = dgvHewan.Rows[e.RowIndex].Cells["jeniskelamin"].Value.ToString();
                int berat = Convert.ToInt32(dgvHewan.Rows[e.RowIndex].Cells["berat"].Value);
                int usia = Convert.ToInt32(dgvHewan.Rows[e.RowIndex].Cells["usia"].Value);
                int idPakan = Convert.ToInt32(dgvHewan.Rows[e.RowIndex].Cells["idpakan"].Value);
                int porsi = Convert.ToInt32(dgvHewan.Rows[e.RowIndex].Cells["porsipakan"].Value);

                // Buka Form Edit
                FormHewan form = new FormHewan();
                form.SetDataEdit(id, jenis, jk, berat, usia, idPakan, porsi);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshData();
                }
            }
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            FormHewan form = new FormHewan();
            if (form.ShowDialog() == DialogResult.OK)
            {
                RefreshData(); // Refresh tabel setelah simpan
            }
        }

        private void dgvHewan_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}