using Farmwait.Controllers;
using Farmwait.Models;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Farmwait.View
{
    public partial class HalAkun : Form
    {
        private AkunController controller;
        private string userRole;
        private int currentUserId;
        private int selectedUserId;

        // Constructor menerima Role DAN ID User
        public HalAkun(string role, int idUser)
        {
            InitializeComponent();
            controller = new AkunController();
            this.userRole = role;
            this.currentUserId = idUser;

            this.Load += HalAkun_Load;

            // Event Handlers
            dgvAkun.CellContentClick += DgvAkun_CellContentClick;
            //btnTambah.Click += btnTambah_Click;
            btnEditProfil.Click += BtnEditProfil_Click;

            btnKembali.Click += (s, e) =>
            {
                panelUser.Visible = false;
                panelAdmin.Visible = true;
            };
        }

        private void HalAkun_Load(object sender, EventArgs e)
        {
            if (userRole == "Peternak")
            {
                // Admin mulai dari Tabel
                panelAdmin.Visible = true;
                panelUser.Visible = false;
                LoadTableData();
            }
            else
            {
                // User mulai dari Card
                panelAdmin.Visible = false;
                panelUser.Visible = true;

                // User biasa tidak butuh tombol kembali
                btnKembali.Visible = false;

                LoadUserProfile(this.currentUserId); // Load diri sendiri
            }
        }

        // ==========================================
        // LOGIKA ADMIN (TABEL)
        // ==========================================
        private void LoadTableData()
        {
            DataTable dt = controller.LoadSemuaAkun();
            dgvAkun.DataSource = dt;

            if (!dgvAkun.Columns.Contains("btnDetail"))
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.Name = "btnDetail";
                btn.HeaderText = "Aksi";
                btn.Text = "DETAIL";
                btn.UseColumnTextForButtonValue = true;
                btn.DefaultCellStyle.BackColor = Color.DodgerBlue;
                btn.DefaultCellStyle.ForeColor = Color.White;
                dgvAkun.Columns.Add(btn);
            }

            // Sembunyikan Kolom yang Tidak Diperlukan
            if (dgvAkun.Columns.Contains("password")) dgvAkun.Columns["password"].Visible = false;
            if (dgvAkun.Columns.Contains("email")) dgvAkun.Columns["email"].Visible = false;
            if (dgvAkun.Columns.Contains("telp")) dgvAkun.Columns["telp"].Visible = false;
            if (dgvAkun.Columns.Contains("iddesa")) dgvAkun.Columns["iddesa"].Visible = false;
            if (dgvAkun.Columns.Contains("role")) dgvAkun.Columns["role"].Visible = false;

            if (dgvAkun.Columns.Contains("idakun"))
            {
                dgvAkun.Columns["idakun"].HeaderText = "ID";
                dgvAkun.Columns["idakun"].Width = 50; // Kecilkan kolom ID
            }
            if (dgvAkun.Columns.Contains("username")) dgvAkun.Columns["username"].HeaderText = "Username";
            if (dgvAkun.Columns.Contains("nama")) dgvAkun.Columns["nama"].HeaderText = "Nama Lengkap";
            if (dgvAkun.Columns.Contains("alamat")) dgvAkun.Columns["alamat"].HeaderText = "Alamat";

        }

        private void DgvAkun_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validasi: Pastikan baris index >= 0 (bukan header)
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == dgvAkun.Columns["btnDetail"].Index)
            {
                // Ambil ID Akun yang dipilih
                int idDipilih = Convert.ToInt32(dgvAkun.Rows[e.RowIndex].Cells["idakun"].Value);

                panelAdmin.Visible = false;
                panelUser.Visible = true;
                btnKembali.Visible = true;

                LoadUserProfile(idDipilih);
            }
        }
        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormAkun form = new FormAkun();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadTableData();
                MessageBox.Show("Akun baru berhasil ditambahkan.");
            }
        }

        // ==========================================
        // LOGIKA USER (CARD / PROFIL PRIBADI)
        // ==========================================
        private void LoadUserProfile(int idTarget)
        {
            this.selectedUserId = idTarget;

            Akun akun = controller.LoadDetailAkun(idTarget);
            if (akun != null)
            {
                string info = "";
                info += $"ID Akun    : {akun.IdAkun}\n\n";
                info += $"Username   : {akun.Username}\n\n";
                info += $"Nama       : {akun.Nama}\n\n";
                info += $"Email      : {akun.Email}\n\n";
                info += $"Alamat     : {akun.Alamat}\n\n";
                info += $"Role       : {akun.Role}\n";

                lblInfoUser.Text = info;
            }
        }

        private void BtnEditProfil_Click(object sender, EventArgs e)
        {
            // Edit akun yang SEDANG DILIHAT (selectedUserId)
            Akun akun = controller.LoadDetailAkun(this.selectedUserId);

            if (akun != null)
            {
                FormAkun form = new FormAkun();
                form.SetDataEdit(
                    akun.IdAkun, akun.Username, akun.Password, akun.Nama,
                    akun.Email, akun.Alamat, akun.Telp, akun.Role, akun.IdDesa
                );

                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Refresh tampilan Card
                    LoadUserProfile(this.selectedUserId);

                    // Jika Admin, refresh juga tabelnya di background biar update
                    if (userRole == "Peternak") LoadTableData();

                    MessageBox.Show("Data akun berhasil diperbarui!");
                }
            }
        }

        private void panelAdmin_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}