namespace Farmwait.View
{
    partial class FormAkun
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tbUsername = new TextBox();
            tbNama = new TextBox();
            tbEmail = new TextBox();
            tbAlamat = new TextBox();
            cbKabupaten = new ComboBox();
            cbKecamatan = new ComboBox();
            cbDesa = new ComboBox();
            tbPassword = new TextBox();
            tbNoTelp = new TextBox();
            btnSimpan = new Button();
            cbRole = new ComboBox(); // Tambahan untuk Role
            panelHeader = new Panel();
            lblJudul = new Label();

            panelHeader.SuspendLayout();
            SuspendLayout();

            // 
            // panelHeader (Agar terlihat seperti form Admin lain)
            // 
            panelHeader.BackColor = Color.ForestGreen;
            panelHeader.Controls.Add(lblJudul);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Size = new Size(500, 60);

            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblJudul.ForeColor = Color.White;
            lblJudul.Location = new Point(12, 13);
            lblJudul.Text = "Form Data Akun";

            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Calibri", 12F);
            tbUsername.ForeColor = Color.Silver;
            tbUsername.Location = new Point(30, 80);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(350, 27);
            tbUsername.Text = "Username"; // Placeholder awal

            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Calibri", 12F);
            tbPassword.ForeColor = Color.Silver;
            tbPassword.Location = new Point(30, 120);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(350, 27);
            tbPassword.Text = "Password";

            // 
            // tbNama
            // 
            tbNama.Font = new Font("Calibri", 12F);
            tbNama.ForeColor = Color.Silver;
            tbNama.Location = new Point(30, 160);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(350, 27);
            tbNama.Text = "Nama Lengkap";

            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Calibri", 12F);
            tbEmail.ForeColor = Color.Silver;
            tbEmail.Location = new Point(30, 200);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(350, 27);
            tbEmail.Text = "Email";

            // 
            // cbRole (Tambahan: Admin bisa pilih Role)
            // 
            cbRole.Font = new Font("Calibri", 12F);
            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRole.Location = new Point(30, 240);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(350, 27);
            // Item role akan diisi di kode

            // 
            // Wilayah (Kabupaten, Kecamatan, Desa)
            // 
            cbKabupaten.Font = new Font("Calibri", 12F, FontStyle.Italic);
            cbKabupaten.ForeColor = Color.Black;
            cbKabupaten.Location = new Point(30, 280);
            cbKabupaten.Size = new Size(110, 27);
            cbKabupaten.Text = "Kabupaten";

            cbKecamatan.Font = new Font("Calibri", 12F, FontStyle.Italic);
            cbKecamatan.ForeColor = Color.Black;
            cbKecamatan.Location = new Point(150, 280);
            cbKecamatan.Size = new Size(110, 27);
            cbKecamatan.Text = "Kecamatan";

            cbDesa.Font = new Font("Calibri", 12F, FontStyle.Italic);
            cbDesa.ForeColor = Color.Black;
            cbDesa.Location = new Point(270, 280);
            cbDesa.Size = new Size(110, 27);
            cbDesa.Text = "Desa";

            // 
            // tbAlamat
            // 
            tbAlamat.Font = new Font("Calibri", 12F);
            tbAlamat.ForeColor = Color.Silver;
            tbAlamat.Location = new Point(30, 320);
            tbAlamat.Name = "tbAlamat";
            tbAlamat.Size = new Size(350, 27);
            tbAlamat.Text = "Alamat Detail";

            // 
            // tbNoTelp
            // 
            tbNoTelp.Font = new Font("Calibri", 12F);
            tbNoTelp.ForeColor = Color.Silver;
            tbNoTelp.Location = new Point(30, 360);
            tbNoTelp.Name = "tbNoTelp";
            tbNoTelp.Size = new Size(350, 27);
            tbNoTelp.Text = "No Telp.";

            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.ForestGreen;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Calibri", 14F, FontStyle.Bold);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(30, 410);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(350, 45);
            btnSimpan.Text = "SIMPAN";
            btnSimpan.UseVisualStyleBackColor = false;

            // Form Setup
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 500);
            Controls.Add(panelHeader);
            Controls.Add(tbUsername);
            Controls.Add(tbPassword);
            Controls.Add(tbNama);
            Controls.Add(tbEmail);
            Controls.Add(cbRole);
            Controls.Add(cbKabupaten);
            Controls.Add(cbKecamatan);
            Controls.Add(cbDesa);
            Controls.Add(tbAlamat);
            Controls.Add(tbNoTelp);
            Controls.Add(btnSimpan);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kelola Akun";

            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel panelHeader;
        private Label lblJudul;
        private TextBox tbUsername, tbNama, tbEmail, tbAlamat, tbPassword, tbNoTelp;
        private ComboBox cbKabupaten, cbKecamatan, cbDesa, cbRole;
        private Button btnSimpan;
    }
}