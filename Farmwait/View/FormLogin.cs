using Farmwait.Controllers; // Panggil Controller
using Farmwait.View;
using System;
using System.Drawing; // PENTING: Untuk warna (Color)
using System.Windows.Forms;

namespace Farmwait
{
    public partial class FormLogin : Form
    {
        private AkunController controller;

        public string RolePengguna { get; private set; }
        public int IdPengguna { get; private set; }

        public FormLogin()
        {
            InitializeComponent();
            controller = new AkunController();
            this.Load += FormLogin_Load;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Pasang placeholder biar rapi
            AturPlaceholder(tbUsernameLogin, "Username");
            AturPlaceholderPassword(tbPasswordLogin, "Password");
        }

        // === LOGIKA PLACEHOLDER (Sama seperti Register) ===
        private void AturPlaceholder(TextBox txt, string placeholderText)
        {
            txt.Text = placeholderText;
            txt.ForeColor = Color.Silver;

            txt.Enter += (s, e) => {
                if (txt.Text == placeholderText)
                {
                    txt.Text = "";
                    txt.ForeColor = Color.Black;
                }
            };

            txt.Leave += (s, e) => {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.Text = placeholderText;
                    txt.ForeColor = Color.Silver;
                }
            };
        }

        private void AturPlaceholderPassword(TextBox txt, string placeholderText)
        {
            txt.Text = placeholderText;
            txt.ForeColor = Color.Silver;
            txt.UseSystemPasswordChar = false;

            txt.Enter += (s, e) => {
                if (txt.Text == placeholderText)
                {
                    txt.Text = "";
                    txt.ForeColor = Color.Black;
                    txt.UseSystemPasswordChar = true; // Jadi bintang-bintang
                }
            };

            txt.Leave += (s, e) => {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.Text = placeholderText;
                    txt.ForeColor = Color.Silver;
                    txt.UseSystemPasswordChar = false;
                }
            };
        }
        // ==================================================

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = tbUsernameLogin.Text == "Username" ? "" : tbUsernameLogin.Text;
            string pass = tbPasswordLogin.Text == "Password" ? "" : tbPasswordLogin.Text;

            // [TERIMA OBJEK AKUN]
            Farmwait.Models.Akun hasil = controller.Login(user, pass);

            if (hasil != null)
            {
                // SIMPAN ID DAN ROLE
                this.IdPengguna = hasil.IdAkun;
                this.RolePengguna = hasil.Role;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void linkLabelDaftar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormRegister formReg = new FormRegister();
            DialogResult hasil = formReg.ShowDialog();

            if (hasil == DialogResult.OK)
            {
                // Jika user habis daftar, biasanya disuruh login ulang.
                // Jadi kita munculkan form login lagi.
                this.Show();
                tbUsernameLogin.Focus(); // Arahkan kursor ke username
            }
            else
            {
                this.Show();
            }
        }
    }
}