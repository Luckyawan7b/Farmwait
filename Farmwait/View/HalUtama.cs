using System;
using System.Windows.Forms;

namespace Farmwait.View
{
    public partial class HalUtama : Form
    {
        private string userRole;

        // Constructor menerima parameter role
        public HalUtama(string role)
        {
            InitializeComponent();
            this.userRole = role;

            // 1. UBAH LABEL SESUAI ROLE
            lblSelamatDatang.Text = $"Selamat Datang, {role}!";

            // 2. Logika Hak Akses (Hanya Peternak yang bisa lihat tombol Kelola Pakan)
            if (userRole != "Peternak")
            {
                btnKelolaPakan.Visible = false;
            }
        }

        private void btnKelolaPakan_Click(object sender, EventArgs e)
        {
            this.Hide();
            HalPakan formPakan = new HalPakan();
            formPakan.ShowDialog();
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
    }
}