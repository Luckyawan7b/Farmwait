using System;
using System.Windows.Forms;

namespace Farmwait.View
{
    public partial class HalUtama : Form
    {
        private string userRole;
        public HalUtama(string role)
        {
            InitializeComponent();
            this.userRole = role;

            lblSelamatDatang.Text = $"Selamat Datang, {role}!";

            if (userRole != "Peternak")
            {
                btnKelolaPakan.Visible = false;
                btnKelolaHewan.Visible = false;
                btnKelolaProduk.Visible = false;
            }
        }

        private void btnKelolaPakan_Click(object sender, EventArgs e)
        {
            this.Hide();
            HalPakan formPakan = new HalPakan();
            formPakan.ShowDialog();
            this.Show();
        }
        private void btnKelolaHewan_Click(object sender, EventArgs e)
        {
            this.Hide();
            HalHewan formHewan = new HalHewan(); 
            formHewan.ShowDialog();
            this.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult tanya = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (tanya == DialogResult.Yes)
            {
                // Tutup form utama. 
                // Karena Program.cs menggunakan Loop, ini akan memicu Login muncul lagi.
                this.Close();
            }
        }

        private void btnKelolaProduk_Click(object sender, EventArgs e)
        {
            this.Hide();
            HalProduk formProduk = new HalProduk();
            formProduk.ShowDialog();
            this.Show();
        }
    }
}