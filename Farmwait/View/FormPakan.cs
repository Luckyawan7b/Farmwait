using Farmwait.Controllers;
using System;
using System.Windows.Forms;

namespace Farmwait.View
{
    public partial class FormPakan : Form
    {
        private PakanController controller;
        private int idPakanCurrent = 0;

        public FormPakan()
        {
            InitializeComponent();
            controller = new PakanController();

            // Mengamankan event handler
            btnSimpan.Click += (s, e) => ProsesSimpan();
            btnBatal.Click += (s, e) => this.Close();
        }

        // [ENKAPSULASI]
        // Dunia luar tidak boleh tahu ada TextBox bernama "tbNamaPakan".
        // Mereka hanya boleh menyuruh form ini untuk "IsiForm" melalui method public ini.
        public void SetDataUntukEdit(int id, string nama, int stok, int harga)
        {
            this.idPakanCurrent = id;
            this.tbNamaPakan.Text = nama;    // Akses private field diperbolehkan di dalam class sendiri
            this.tbStokPakan.Text = stok.ToString();
            this.tbHargaPakan.Text = harga.ToString();
            this.Text = "Edit Pakan";
        }

        private void ProsesSimpan()
        {
            // View hanya mengambil teks dan menyerahkan ke Controller
            bool sukses = controller.SimpanPakan(
                idPakanCurrent,
                tbNamaPakan.Text,
                tbStokPakan.Text,
                tbHargaPakan.Text
            );

            if (sukses)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {

        }
    }
}