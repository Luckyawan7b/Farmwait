using Farmwait.Controllers;
using System;
using System.Windows.Forms;

namespace Farmwait.View
{
    public partial class FormHewan : Form
    {
        private HewanController controller;
        private int idHewanCurrent = 0; // 0 = Tambah Baru

        public FormHewan()
        {
            InitializeComponent();
            controller = new HewanController();

            // Setup Event
            this.Load += FormHewan_Load;
            btnSimpan.Click += BtnSimpan_Click;
            btnBatal.Click += (s, e) => this.Close();
        }

        private void FormHewan_Load(object sender, EventArgs e)
        {
            // 1. Isi Dropdown Jenis Kelamin
            cbJenisKelamin.Items.Add("Jantan");
            cbJenisKelamin.Items.Add("Betina");

            // 2. Isi Dropdown Pakan (Ambil dari Database via Controller)
            cbPakan.DataSource = controller.GetListPakan();
            cbPakan.DisplayMember = "namapakan"; // Yang tampil text
            cbPakan.ValueMember = "idpakan";     // Yang disimpan ID

            // Default kosongkan pilihan jika mode tambah
            if (idHewanCurrent == 0)
            {
                cbPakan.SelectedIndex = -1;
                cbJenisKelamin.SelectedIndex = -1;
            }
        }

        // [ENKAPSULASI] Method Publik untuk mengisi form (Mode Edit)
        public void SetDataEdit(int id, string jenis, string jk, int berat, int usia, int idPakan, int porsi)
        {
            this.idHewanCurrent = id;
            this.Text = "Edit Data Hewan";

            // Isi Textbox (Private fields diakses dari dalam class)
            tbJenisHewan.Text = jenis;
            cbJenisKelamin.Text = jk; // Atau SelectedItem
            tbBerat.Text = berat.ToString();
            tbUsia.Text = usia.ToString();
            tbPorsi.Text = porsi.ToString();

            // Set Dropdown Pakan nanti saat Load selesai, tapi karena Load duluan, kita set SelectedValue
            // Kita lakukan sedikit trick agar ValueMember terset sebelum kita assign value
            this.Load += (s, e) => { cbPakan.SelectedValue = idPakan; };
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            // Kirim ke Controller
            bool sukses = controller.SimpanHewan(
                idHewanCurrent,
                tbJenisHewan.Text,
                cbJenisKelamin.Text,
                tbBerat.Text,
                tbUsia.Text,
                cbPakan.SelectedValue,
                tbPorsi.Text
            );

            if (sukses)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}