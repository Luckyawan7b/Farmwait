using Farmwait.Controllers;
using Farmwait.Models; // Pastikan namespace ini ada untuk ComboBoxItem
using System;
using System.Drawing; // Perlu untuk Color
using System.Windows.Forms;

namespace Farmwait.View
{
    public partial class FormRegister : Form
    {
        private AkunController controller;

        public FormRegister()
        {
            InitializeComponent();
            controller = new AkunController();

            // Event Load
            this.Load += FormRegister_Load;
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            // 1. Setup Placeholder untuk semua TextBox
            AturPlaceholder(tbUsernameRegister, "Username");
            AturPlaceholder(tbNamaRegister, "Nama");
            AturPlaceholder(tbEmailRegister, "Email");
            AturPlaceholder(tbAlamatRegister, "Alamat");
            AturPlaceholder(tbNoTelp, "No Telp.");

            // Khusus Password butuh penanganan ekstra (biar tulisan 'Password' terbaca, tapi isinya bintang2)
            AturPlaceholderPassword(tbPassword, "Password");

            // 2. Setup Data ComboBox (Wilayah)
            LoadDataWilayah();
        }

        // === LOGIKA PLACEHOLDER ===
        private void AturPlaceholder(TextBox txt, string placeholderText)
        {
            // Set kondisi awal
            txt.Text = placeholderText;
            txt.ForeColor = Color.Silver;

            // Saat masuk (klik/tab ke textbox)
            txt.Enter += (s, e) =>
            {
                if (txt.Text == placeholderText)
                {
                    txt.Text = "";
                    txt.ForeColor = Color.Black; // Ubah warna jadi hitam saat ngetik
                }
            };

            // Saat keluar (klik tempat lain)
            txt.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.Text = placeholderText;
                    txt.ForeColor = Color.Silver; // Balikin warna abu-abu
                }
            };
        }

        private void AturPlaceholderPassword(TextBox txt, string placeholderText)
        {
            // Set awal
            txt.Text = placeholderText;
            txt.ForeColor = Color.Silver;
            txt.UseSystemPasswordChar = false; // Biar tulisan "Password" terbaca

            txt.Enter += (s, e) =>
            {
                if (txt.Text == placeholderText)
                {
                    txt.Text = "";
                    txt.ForeColor = Color.Black;
                    txt.UseSystemPasswordChar = true; // Aktifkan mode password (bintang/bulat)
                }
            };

            txt.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.Text = placeholderText;
                    txt.ForeColor = Color.Silver;
                    txt.UseSystemPasswordChar = false; // Matikan mode password biar terbaca "Password"
                }
            };
        }
        // ==========================

        private void LoadDataWilayah()
        {
            // Isi ComboBox Kabupaten
            cbKabupatenRegister.DataSource = controller.LoadKabupaten();
            cbKabupatenRegister.DisplayMember = "Nama";
            cbKabupatenRegister.ValueMember = "Id";

            cbKabupatenRegister.SelectedIndex = -1;
            cbKecamatanRegister.Enabled = false;
            cbDesaRegister.Enabled = false;

            // Event listener dropdown
            cbKabupatenRegister.SelectedIndexChanged += CbKabupatenRegister_SelectedIndexChanged;
            cbKecamatanRegister.SelectedIndexChanged += CbKecamatanRegister_SelectedIndexChanged;
        }

        private void CbKabupatenRegister_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKabupatenRegister.SelectedItem != null)
            {
                ComboBoxItem selectedKab = (ComboBoxItem)cbKabupatenRegister.SelectedItem;

                cbKecamatanRegister.Enabled = true;
                cbKecamatanRegister.DataSource = controller.LoadKecamatan(selectedKab.Id);
                cbKecamatanRegister.DisplayMember = "Nama";
                cbKecamatanRegister.ValueMember = "Id";
                cbKecamatanRegister.SelectedIndex = -1;

                cbDesaRegister.DataSource = null;
                cbDesaRegister.Enabled = false;
            }
        }

        private void CbKecamatanRegister_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKecamatanRegister.SelectedItem != null)
            {
                ComboBoxItem selectedKec = (ComboBoxItem)cbKecamatanRegister.SelectedItem;

                cbDesaRegister.Enabled = true;
                cbDesaRegister.DataSource = controller.LoadDesa(selectedKec.Id);
                cbDesaRegister.DisplayMember = "Nama";
                cbDesaRegister.ValueMember = "Id";
                cbDesaRegister.SelectedIndex = -1;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Validasi: Jangan sampai teks placeholder ikut tersimpan ke database
            string username = tbUsernameRegister.Text == "Username" ? "" : tbUsernameRegister.Text;
            string nama = tbNamaRegister.Text == "Nama" ? "" : tbNamaRegister.Text;
            string email = tbEmailRegister.Text == "Email" ? "" : tbEmailRegister.Text;
            string alamat = tbAlamatRegister.Text == "Alamat" ? "" : tbAlamatRegister.Text;
            string password = tbPassword.Text == "Password" ? "" : tbPassword.Text;
            string telp = tbNoTelp.Text == "No Telp." ? "" : tbNoTelp.Text;

            bool isRegistered = controller.Register(
                username,
                password,
                nama,
                email,
                alamat,
                telp,
                cbDesaRegister.SelectedItem
            );

            if (isRegistered)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}