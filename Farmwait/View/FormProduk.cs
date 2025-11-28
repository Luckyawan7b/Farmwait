using Farmwait.Controllers;
using System;
using System.Windows.Forms;

namespace Farmwait.View
{
    public partial class FormProduk : Form
    {
        private ProdukController controller;
        private int idProdukCurrent = 0; // 0 = Tambah

        public FormProduk()
        {
            InitializeComponent();
            controller = new ProdukController();
            this.Load += FormProduk_Load;
        }

        private void FormProduk_Load(object sender, EventArgs e)
        {
            // 1. Isi Dropdown Jenis Produk (Hardcode kategori umum)
            cbJenis.Items.Add("Ayam");
            cbJenis.Items.Add("Sapi");
            cbJenis.Items.Add("Kambing");
            cbJenis.Items.Add("Telur");
            cbJenis.Items.Add("Susu");

            // 2. Isi Dropdown Hewan Asal (Ambil dari DB via Controller)
            cbHewan.DataSource = controller.GetListHewan();
            cbHewan.DisplayMember = "jenishewan"; // Tampilkan nama hewan
            cbHewan.ValueMember = "idhewan";      // Simpan ID-nya

            if (idProdukCurrent == 0)
            {
                cbJenis.SelectedIndex = -1;
                cbHewan.SelectedIndex = -1;
            }
        }

        // [ENKAPSULASI] Public method untuk isi form dari luar (Edit Mode)
        public void SetDataEdit(int id, string nama, string jenis, int idHewan, int jumlah, int harga)
        {
            this.idProdukCurrent = id;
            this.Text = "Edit Produk";

            tbNama.Text = nama;
            cbJenis.Text = jenis;
            tbJumlah.Text = jumlah.ToString();
            tbHarga.Text = harga.ToString();

            // Set Dropdown Hewan saat load nanti
            this.Load += (s, e) => { cbHewan.SelectedValue = idHewan; };
        }



        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProduk_Load_1(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            bool sukses = controller.SimpanProduk(
                idProdukCurrent,
                tbNama.Text,
                cbJenis.Text,
                cbHewan.SelectedValue,
                tbJumlah.Text,
                tbHarga.Text
            );

            if (sukses)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}