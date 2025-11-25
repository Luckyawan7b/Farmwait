using Farmwait.View;
using System;
using System.Windows.Forms;

namespace Farmwait
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // LOOPING APLIKASI
            while (true)
            {
                FormLogin loginForm = new FormLogin();
                DialogResult hasilLogin = loginForm.ShowDialog();

                if (hasilLogin == DialogResult.OK)
                {
                    string role = loginForm.RolePengguna;

                    // Jalankan HalUtama
                    // Application.Run akan menahan kode di sini sampai HalUtama di-close (Logout)
                    Application.Run(new HalUtama(role));

                    // Setelah HalUtama close, kode lanjut ke atas loop lagi (Buka Login baru)
                }
                else
                {
                    break;
                }
            }
        }
    }
}