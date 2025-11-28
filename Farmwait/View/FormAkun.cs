using Farmwait.Controllers;
using Farmwait.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Farmwait.View
{
    public partial class FormAkun : Form
    {
        private AkunController controller;
        private int idAkunCurrent = 0; // 0 = Mode Tambah

        public FormAkun()
        {
            InitializeComponent();
            controller = new AkunController();

            this.Load += FormAkun_Load;
            btnSimpan.Click += BtnSimpan_Click;
        }

        private void FormAkun_Load(object sender, EventArgs e)
        {
            // 1. Setup Placeholder (Copy logic dari Register)
            AturPlaceholder(tbUsername, "Username");
            AturPlaceholder(tbNama, "Nama Lengkap");
            AturPlaceholder(tbEmail, "Email");
            AturPlaceholder(tbAlamat, "Alamat Detail");
            AturPlaceholder(tbNoTelp, "No Telp.");
            AturPlaceholderPassword(tbPassword, "Password");

            // 2. Setup Role (Hardcode pilihan)
            cbRole.Items.Add("Peternak");
            cbRole.Items.Add("Pembeli");
            cbRole.SelectedIndex = 1; // Default Pembeli

            // 3. Setup Wilayah
            LoadDataWilayah();
        }

        // === PUBLIC METHOD: Isi Form untuk Edit ===
        public void SetDataEdit(int id, string user, string pass, string nama, string email, string alamat, string telp, string role, int idDesa)
        {
            idAkunCurrent = id;
            //lblJudul.Text = "Edit Data Akun";

            // Isi Textbox dan matikan placeholder effect sementara
            SetTextValue(tbUsername, user);
            SetTextValue(tbNama, nama);
            SetTextValue(tbEmail, email);
            SetTextValue(tbAlamat, alamat);
            SetTextValue(tbNoTelp, telp);

            // Password & Role
            tbPassword.Text = pass;
            tbPassword.UseSystemPasswordChar = true;
            tbPassword.ForeColor = Color.Black;

            if (cbRole.Items.Contains(role))
            {
                cbRole.SelectedItem = role;
            }

            // Catatan untuk Wilayah:
            // Karena dropdown wilayah cascading (Kab->Kec->Desa), sulit untuk otomatis set selected value
            // tanpa memanggil database berantai. 
            // Jadi untuk Edit, kita biarkan user memilih ulang alamat JIKA ingin mengubahnya.
            // ID Desa lama tetap kita simpan di variabel sementara jika tidak diubah.
        }

        // Helper untuk set text tanpa placeholder mengganggu
        private void SetTextValue(TextBox tb, string val)
        {
            tb.Text = val;
            tb.ForeColor = Color.Black;
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            // Validasi Input Placeholder
            string u = tbUsername.Text == "Username" ? "" : tbUsername.Text;
            string p = tbPassword.Text == "Password" ? "" : tbPassword.Text;
            string n = tbNama.Text == "Nama Lengkap" ? "" : tbNama.Text;
            string em = tbEmail.Text == "Email" ? "" : tbEmail.Text;
            string a = tbAlamat.Text == "Alamat Detail" ? "" : tbAlamat.Text;
            string t = tbNoTelp.Text == "No Telp." ? "" : tbNoTelp.Text;

            int idDesa = 0;
            if (cbDesa.SelectedValue != null)
            {
                idDesa = Convert.ToInt32(cbDesa.SelectedValue);
            }
            else if (idAkunCurrent > 0)
            {
                // Jika user tidak ubah alamat saat edit, kita bisa handling disini atau wajibkan pilih ulang.
                // Untuk keamanan data, mari kita wajibkan user memilih ulang desa saat edit jika dropdown kosong.
                // Atau validasi di Controller.
            }

            // Panggil Controller
            // Kita gunakan UpdateAkun untuk Edit, dan Register untuk Tambah
            bool sukses = false;

            if (idAkunCurrent == 0) // MODE TAMBAH
            {
                sukses = controller.Register(u, p, n, em, a, t, cbDesa.SelectedItem);
                // Catatan: Anda mungkin perlu membuat method Register yang menerima Role juga di Controller
                // atau gunakan InsertAkunBaru khusus admin. 
                // Jika pakai Register biasa, Role otomatis 'Pembeli' (sesuai logic Akun.cs).
            }
            else // MODE EDIT
            {
                // Pastikan idDesa terpilih
                if (cbDesa.SelectedItem == null)
                {
                    MessageBox.Show("Mohon pilih ulang Desa/Alamat untuk konfirmasi.", "Info Edit");
                    return;
                }

                sukses = controller.UpdateAkun(idAkunCurrent, u, p, n, em, a, t, idDesa, cbRole.Text);
            }

            if (sukses)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        // ==========================================
        // LOGIKA WILAYAH (Sama persis Register)
        // ==========================================
        private void LoadDataWilayah()
        {
            cbKabupaten.DataSource = controller.LoadKabupaten();
            cbKabupaten.DisplayMember = "Nama";
            cbKabupaten.ValueMember = "Id";
            cbKabupaten.SelectedIndex = -1;

            cbKecamatan.Enabled = false;
            cbDesa.Enabled = false;

            cbKabupaten.SelectedIndexChanged += (s, e) =>
            {
                if (cbKabupaten.SelectedItem != null)
                {
                    int id = ((ComboBoxItem)cbKabupaten.SelectedItem).Id;
                    cbKecamatan.DataSource = controller.LoadKecamatan(id);
                    cbKecamatan.DisplayMember = "Nama";
                    cbKecamatan.ValueMember = "Id";
                    cbKecamatan.Enabled = true;
                    cbKecamatan.SelectedIndex = -1;
                    cbDesa.DataSource = null;
                }
            };

            cbKecamatan.SelectedIndexChanged += (s, e) =>
            {
                if (cbKecamatan.SelectedItem != null)
                {
                    int id = ((ComboBoxItem)cbKecamatan.SelectedItem).Id;
                    cbDesa.DataSource = controller.LoadDesa(id);
                    cbDesa.DisplayMember = "Nama";
                    cbDesa.ValueMember = "Id";
                    cbDesa.Enabled = true;
                }
            };
        }

        // ==========================================
        // LOGIKA PLACEHOLDER (Sama persis Register)
        // ==========================================
        private void AturPlaceholder(TextBox txt, string placeholder)
        {
            txt.Text = placeholder;
            txt.ForeColor = Color.Silver;
            txt.Enter += (s, e) => { if (txt.Text == placeholder) { txt.Text = ""; txt.ForeColor = Color.Black; } };
            txt.Leave += (s, e) => { if (string.IsNullOrWhiteSpace(txt.Text)) { txt.Text = placeholder; txt.ForeColor = Color.Silver; } };
        }

        private void AturPlaceholderPassword(TextBox txt, string placeholder)
        {
            txt.Text = placeholder;
            txt.ForeColor = Color.Silver;
            txt.UseSystemPasswordChar = false;
            txt.Enter += (s, e) => { if (txt.Text == placeholder) { txt.Text = ""; txt.ForeColor = Color.Black; txt.UseSystemPasswordChar = true; } };
            txt.Leave += (s, e) => { if (string.IsNullOrWhiteSpace(txt.Text)) { txt.Text = placeholder; txt.ForeColor = Color.Silver; txt.UseSystemPasswordChar = false; } };
        }

        private void FormAkun_Load_1(object sender, EventArgs e)
        {

        }
    }
}