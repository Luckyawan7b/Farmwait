namespace Farmwait.View
{
    partial class HalAkun
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // Komponen
            panelAdmin = new Panel();
            dgvAkun = new DataGridView();
            btnTambah = new Button();
            lblJudulAdmin = new Label();

            panelUser = new Panel();
            lblInfoUser = new Label(); 
            btnEditProfil = new Button();
            lblJudulUser = new Label();
            btnKembali = new Button();

            ((System.ComponentModel.ISupportInitialize)dgvAkun).BeginInit();
            panelAdmin.SuspendLayout();
            panelUser.SuspendLayout();
            SuspendLayout();

            // 
            // panelAdmin (Tampilan Tabel)
            // 
            panelAdmin.Controls.Add(dgvAkun);
            panelAdmin.Controls.Add(btnTambah);
            panelAdmin.Controls.Add(lblJudulAdmin);
            panelAdmin.Dock = DockStyle.Fill; // Penuhi layar
            panelAdmin.Visible = false; // Default hidden

            // dgvAkun
            dgvAkun.AllowUserToAddRows = false;
            dgvAkun.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAkun.Location = new Point(20, 80);
            dgvAkun.Size = new Size(750, 350);
            dgvAkun.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // btnTambah
            btnTambah.Text = "+ Tambah Akun";
            btnTambah.Location = new Point(650, 25);
            btnTambah.Size = new Size(120, 40);
            btnTambah.BackColor = Color.ForestGreen;
            btnTambah.ForeColor = Color.White;

            // 
            // panelUser
            // 
            panelUser.Controls.Add(lblInfoUser);
            panelUser.Controls.Add(btnEditProfil);
            panelUser.Controls.Add(btnKembali); // Tambahkan ke Panel
            panelUser.Controls.Add(lblJudulUser);
            panelUser.Dock = DockStyle.Fill;
            panelUser.Visible = false;

            // btnEditProfil
            btnEditProfil.Text = "EDIT PROFIL";
            btnEditProfil.Location = new Point(50, 400);
            btnEditProfil.Size = new Size(150, 40);
            btnEditProfil.BackColor = Color.Orange;
            btnEditProfil.ForeColor = Color.White;

            // 
            // btnKembali (Tombol Baru)
            // 
            btnKembali.Text = "KEMBALI KE TABEL";
            btnKembali.Location = new Point(220, 400); // Di sebelah tombol Edit
            btnKembali.Size = new Size(150, 40);
            btnKembali.BackColor = Color.Gray;
            btnKembali.ForeColor = Color.White;
            btnKembali.Visible = false; // Default hidden (hanya muncul utk admin)

            // lblInfoUser (Menampilkan Text Detail)
            lblInfoUser.Font = new Font("Segoe UI", 12F);
            lblInfoUser.Location = new Point(50, 80);
            lblInfoUser.Size = new Size(400, 300);
            lblInfoUser.Text = "Loading..."; // Nanti diisi kodingan

            // Form
            ClientSize = new Size(800, 500);
            Controls.Add(panelAdmin);
            Controls.Add(panelUser);
            Name = "HalAkun";
            Text = "Profil Akun";

            ((System.ComponentModel.ISupportInitialize)dgvAkun).EndInit();
            panelAdmin.ResumeLayout(false);
            panelUser.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel panelAdmin;
        private DataGridView dgvAkun;
        private Button btnTambah;
        private Label lblJudulAdmin;

        private Panel panelUser;
        private Label lblInfoUser;
        private Button btnEditProfil;
        private Button btnKembali;
        private Label lblJudulUser;
    }
}