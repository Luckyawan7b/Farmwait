using Farmwait.View; // Pastikan namespace ini ada untuk mengakses FormLogin & HalUtama
using System;
using System.Windows.Forms;

namespace Farmwait
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Buat instance Form Login
            FormLogin loginForm = new FormLogin();

            // 2. Tampilkan Login sebagai Dialog
            // ShowDialog() akan menahan kode di sini sampai FormLogin ditutup
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // 3. Jika Login memberikan sinyal OK (Berhasil),
                // Maka jalankan HalUtama sebagai form utama aplikasi
                Application.Run(new HalUtama());
            }
            else
            {
                // Jika user menutup login (tanda silang) atau cancel, aplikasi berhenti total.
                Application.Exit();
            }
        }
    }
}