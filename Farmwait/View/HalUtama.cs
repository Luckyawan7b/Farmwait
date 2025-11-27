using System;
using System.Windows.Forms;

namespace Farmwait.View
{
    public partial class HalUtama : Form
    {
        private string userRole;
        private int idUser;
        public HalUtama(string role, int idUser)
        {
            InitializeComponent();
            this.userRole = role;
            this.idUser = idUser;

            lblSelamatDatang.Text = $"Selamat Datang, {role}!";

            if (userRole != "Peternak")
            {
                btnKelolaPakan.Visible = false;
                btnKelolaHewan.Visible = false;
                btnKelolaProduk.Visible = false;
                btnKelolaTransaksi.Visible = false;
                btnTransaksi.Visible = true;
            }
            else
            {
                btnKelolaPakan.Visible = true;
                btnKelolaHewan.Visible = true;
                btnKelolaProduk.Visible = true;
                btnKelolaTransaksi.Visible = true;
                btnTransaksi.Visible = false;
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
        private void btnProfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            HalAkun formAkun = new HalAkun(this.userRole, this.idUser);
            formAkun.ShowDialog();
            this.Show();
        }

        private void btnKelolaTransaksi_Click(object sender, EventArgs e)
        {
            this.Hide();
            HalTransaksiPeternak transaksiPeternak = new HalTransaksiPeternak();
            transaksiPeternak.ShowDialog();
            this.Show();
        }
    }
}