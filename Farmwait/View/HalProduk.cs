using Farmwait.Controllers;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Farmwait.View
{
    public partial class HalProduk : Form
    {
        private ProdukController controller;

        public HalProduk()
        {
            InitializeComponent();
            controller = new ProdukController();

            this.Load += HalProduk_Load;
            dgvProduk.CellContentClick += DgvProduk_CellContentClick;
            btnTambah.Click += BtnTambah_Click;
        }

        private void HalProduk_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            // 1. Load Data (WHERE is_deleted = false)
            DataTable dt = controller.LoadData();
            dgvProduk.DataSource = dt;

            // 2. Tambah Tombol Aksi (Helper method biar rapi)
            AddButtonColumn("btnEdit", "EDIT", "Edit", Color.Orange);
            AddButtonColumn("btnHapus", "HAPUS", "Hapus", Color.Red);

            // 3. Sembunyikan Kolom Teknis
            if (dgvProduk.Columns.Contains("is_deleted")) dgvProduk.Columns["is_deleted"].Visible = false;
            //if (dgvProduk.Columns.Contains("idproduk")) dgvProduk.Columns["idproduk"].Visible = false; // Opsional
            //if (dgvProduk.Columns.Contains("idhewan")) dgvProduk.Columns["idhewan"].Visible = false; // Opsional

            // Rapikan Header
            if (dgvProduk.Columns.Contains("namaproduk")) dgvProduk.Columns["namaproduk"].HeaderText = "Nama Produk";
            if (dgvProduk.Columns.Contains("hargaproduk")) dgvProduk.Columns["hargaproduk"].HeaderText = "Harga (Rp)";
        }

        private void AddButtonColumn(string name, string text, string header, Color color)
        {
            if (!dgvProduk.Columns.Contains(name))
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = name;
                btn.Text = text;
                btn.HeaderText = header;
                btn.UseColumnTextForButtonValue = true;
                btn.DefaultCellStyle.BackColor = color;
                btn.DefaultCellStyle.ForeColor = Color.White;
                dgvProduk.Columns.Add(btn);
            }
        }

        private void DgvProduk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int idProduk = Convert.ToInt32(dgvProduk.Rows[e.RowIndex].Cells["idproduk"].Value);

            // === DELETE ===
            if (e.ColumnIndex == dgvProduk.Columns["btnHapus"].Index)
            {
                DialogResult tanya = MessageBox.Show(
                    "Yakin ingin menghapus produk ini?",
                    "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (tanya == DialogResult.Yes)
                {
                    // Panggil Controller Hapus
                    bool sukses = controller.HapusProduk(idProduk);
                    if (sukses)
                    {
                        MessageBox.Show("Produk berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshData(); // Data hilang dari tabel karena is_deleted=true
                    }
                }
            }

            // === EDIT ===
            if (e.ColumnIndex == dgvProduk.Columns["btnEdit"].Index)
            {
                // Ambil data row
                string nama = dgvProduk.Rows[e.RowIndex].Cells["namaproduk"].Value.ToString();
                string jenis = dgvProduk.Rows[e.RowIndex].Cells["jenisproduk"].Value.ToString();
                int idHewan = Convert.ToInt32(dgvProduk.Rows[e.RowIndex].Cells["idhewan"].Value);
                int jumlah = Convert.ToInt32(dgvProduk.Rows[e.RowIndex].Cells["jumlahproduk"].Value);
                int harga = Convert.ToInt32(dgvProduk.Rows[e.RowIndex].Cells["hargaproduk"].Value);

                // Buka Form Edit
                FormProduk form = new FormProduk();
                form.SetDataEdit(idProduk, nama, jenis, idHewan, jumlah, harga);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshData();
                }
            }
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            FormProduk form = new FormProduk();
            if (form.ShowDialog() == DialogResult.OK)
            {
                RefreshData();
            }
        }
    }
}