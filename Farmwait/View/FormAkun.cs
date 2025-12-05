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
        private int idAkunCurrent = 0;
        private int currentTargetIdDesa = 0; // Variabel baru untuk menampung ID Desa saat Edit

        public FormAkun()
        {
            InitializeComponent();
            controller = new AkunController();

            cbRole.Items.Add("Peternak");
            cbRole.Items.Add("Pembeli");

            this.Load += FormAkun_Load;
            btnSimpan.Click += BtnSimpan_Click;
        }

        private void FormAkun_Load(object sender, EventArgs e)
        {
            AturPlaceholder(tbUsername, "Username");
            AturPlaceholder(tbNama, "Nama Lengkap");
            AturPlaceholder(tbEmail, "Email");
            AturPlaceholder(tbAlamat, "Alamat Detail");
            AturPlaceholder(tbNoTelp, "No Telp.");
            AturPlaceholderPassword(tbPassword, "Password");

            if (idAkunCurrent == 0)
            {
                cbRole.SelectedIndex = 1;
            }

            // 1. Load Data Awal (Hanya Kabupaten)
            LoadDataWilayah();

            // 2. JIKA EDIT: Trigger seleksi otomatis cascading
            if (idAkunCurrent > 0 && currentTargetIdDesa > 0)
            {
                PreillWilayah(currentTargetIdDesa);
            }
        }

        // Method Baru: Mengisi Dropdown Cascading saat Edit
        private void PreillWilayah(int idDesa)
        {
            // Ambil Hirarki (Kab -> Kec -> Desa) dari DB
            var detail = controller.GetWilayahHierarchy(idDesa);

            if (detail != null)
            {
                // 1. Set Kabupaten
                cbKabupaten.SelectedValue = detail.IdKabupaten;

                // Secara teori, event SelectedIndexChanged akan jalan synchronous di WinForms.
                // Tapi untuk memastikan data Kec terisi sebelum kita set Value-nya:
                // Kita panggil manual LoadKecamatan kalau event-nya belum sempat ngisi (opsional, tapi aman)
                if (cbKecamatan.DataSource == null)
                {
                    cbKecamatan.DataSource = controller.LoadKecamatan(detail.IdKabupaten);
                    cbKecamatan.DisplayMember = "Nama";
                    cbKecamatan.ValueMember = "Id";
                    cbKecamatan.Enabled = true;
                }

                // 2. Set Kecamatan
                cbKecamatan.SelectedValue = detail.IdKecamatan;

                // Load Desa manual jika belum ketrigger event
                if (cbDesa.DataSource == null)
                {
                    cbDesa.DataSource = controller.LoadDesa(detail.IdKecamatan);
                    cbDesa.DisplayMember = "Nama";
                    cbDesa.ValueMember = "Id";
                    cbDesa.Enabled = true;
                }

                // 3. Set Desa
                cbDesa.SelectedValue = detail.IdDesa;
            }
        }

        public void SetDataEdit(int id, string user, string pass, string nama, string email, string alamat, string telp, string role, int idDesa)
        {
            idAkunCurrent = id;
            currentTargetIdDesa = idDesa; // Simpan ID Desa untuk diload nanti saat Form_Load

            SetTextValue(tbUsername, user);
            SetTextValue(tbNama, nama);
            SetTextValue(tbEmail, email);
            SetTextValue(tbAlamat, alamat);
            SetTextValue(tbNoTelp, telp);

            tbPassword.Text = pass;
            tbPassword.UseSystemPasswordChar = true;
            tbPassword.ForeColor = Color.Black;

            if (cbRole.Items.Contains(role))
            {
                cbRole.SelectedItem = role;
            }
        }

        private void SetTextValue(TextBox tb, string val)
        {
            tb.Text = val;
            tb.ForeColor = Color.Black;
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            string u = (tbUsername.Text == "Username" && tbUsername.ForeColor == Color.Silver) ? "" : tbUsername.Text;
            string p = (tbPassword.Text == "Password" && tbPassword.ForeColor == Color.Silver) ? "" : tbPassword.Text;
            string n = (tbNama.Text == "Nama Lengkap" && tbNama.ForeColor == Color.Silver) ? "" : tbNama.Text;
            string em = (tbEmail.Text == "Email" && tbEmail.ForeColor == Color.Silver) ? "" : tbEmail.Text;
            string a = (tbAlamat.Text == "Alamat Detail" && tbAlamat.ForeColor == Color.Silver) ? "" : tbAlamat.Text;
            string t = (tbNoTelp.Text == "No Telp." && tbNoTelp.ForeColor == Color.Silver) ? "" : tbNoTelp.Text;

            int idDesa = 0;
            if (cbDesa.SelectedValue != null)
            {
                idDesa = Convert.ToInt32(cbDesa.SelectedValue);
            }

            if (idAkunCurrent > 0 && cbDesa.SelectedItem == null)
            {
                MessageBox.Show("Mohon pilih ulang Desa/Alamat untuk konfirmasi perubahan.", "Info Edit");
                return;
            }

            bool sukses = false;

            if (idAkunCurrent == 0)
            {
                sukses = controller.Register(u, p, n, em, a, t, cbDesa.SelectedItem);
            }
            else
            {
                sukses = controller.UpdateAkun(idAkunCurrent, u, p, n, em, a, t, idDesa, cbRole.Text);
            }

            if (sukses)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

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
                if (cbKabupaten.SelectedItem != null && cbKabupaten.ValueMember != "")
                {
                    // Pastikan yang diambil Id (int), kadang saat load awal bisa error cast jika belum stabil
                    if (cbKabupaten.SelectedValue is int id)
                    {
                        cbKecamatan.DataSource = controller.LoadKecamatan(id);
                        cbKecamatan.DisplayMember = "Nama";
                        cbKecamatan.ValueMember = "Id";
                        cbKecamatan.Enabled = true;
                        cbKecamatan.SelectedIndex = -1;
                        cbDesa.DataSource = null;
                    }
                }
            };

            cbKecamatan.SelectedIndexChanged += (s, e) =>
            {
                if (cbKecamatan.SelectedItem != null && cbKecamatan.ValueMember != "")
                {
                    if (cbKecamatan.SelectedValue is int id)
                    {
                        cbDesa.DataSource = controller.LoadDesa(id);
                        cbDesa.DisplayMember = "Nama";
                        cbDesa.ValueMember = "Id";
                        cbDesa.Enabled = true;
                    }
                }
            };
        }

        private void AturPlaceholder(TextBox txt, string placeholder)
        {
            if (idAkunCurrent == 0 || string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Text = placeholder;
                txt.ForeColor = Color.Silver;
            }
            txt.Enter += (s, e) => { if (txt.Text == placeholder && txt.ForeColor == Color.Silver) { txt.Text = ""; txt.ForeColor = Color.Black; } };
            txt.Leave += (s, e) => { if (string.IsNullOrWhiteSpace(txt.Text)) { txt.Text = placeholder; txt.ForeColor = Color.Silver; } };
        }

        private void AturPlaceholderPassword(TextBox txt, string placeholder)
        {
            if (idAkunCurrent == 0 || string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Text = placeholder;
                txt.ForeColor = Color.Silver;
                txt.UseSystemPasswordChar = false;
            }
            txt.Enter += (s, e) => { if (txt.Text == placeholder && txt.ForeColor == Color.Silver) { txt.Text = ""; txt.ForeColor = Color.Black; txt.UseSystemPasswordChar = true; } };
            txt.Leave += (s, e) => { if (string.IsNullOrWhiteSpace(txt.Text)) { txt.Text = placeholder; txt.ForeColor = Color.Silver; txt.UseSystemPasswordChar = false; } };
        }
    }
}