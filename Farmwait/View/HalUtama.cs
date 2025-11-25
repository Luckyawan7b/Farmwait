using System;
using System.Windows.Forms;

namespace Farmwait.View
{
    public partial class HalUtama : Form
    {
        public HalUtama()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Konfirmasi sebelum logout
            DialogResult tanya = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (tanya == DialogResult.Yes)
            {
                // Tutup form utama, aplikasi akan kembali ke Program.cs dan selesai
                this.Close();

                // Jika ingin restart aplikasi ke halaman login lagi:
                // Application.Restart();
            }
        }
    }
}