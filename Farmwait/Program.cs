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

            while (true)
            {
                FormLogin loginForm = new FormLogin();
                DialogResult hasilLogin = loginForm.ShowDialog();

                if (hasilLogin == DialogResult.OK)
                {
                    string role = loginForm.RolePengguna;
                    int idUser = loginForm.IdPengguna;

                    Application.Run(new HalUtama(role, idUser));
                }
                else
                {
                    break;
                }
            }
        }
    }
}