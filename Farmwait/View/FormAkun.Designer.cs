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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAkun));
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
            cbRole = new ComboBox();
            SuspendLayout();
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Calibri", 12F);
            tbUsername.ForeColor = Color.Silver;
            tbUsername.Location = new Point(30, 80);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(350, 27);
            tbUsername.TabIndex = 1;
            tbUsername.Text = "Username";
            // 
            // tbNama
            // 
            tbNama.Font = new Font("Calibri", 12F);
            tbNama.ForeColor = Color.Silver;
            tbNama.Location = new Point(30, 160);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(350, 27);
            tbNama.TabIndex = 3;
            tbNama.Text = "Nama Lengkap";
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Calibri", 12F);
            tbEmail.ForeColor = Color.Silver;
            tbEmail.Location = new Point(30, 200);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(350, 27);
            tbEmail.TabIndex = 4;
            tbEmail.Text = "Email";
            // 
            // tbAlamat
            // 
            tbAlamat.Font = new Font("Calibri", 12F);
            tbAlamat.ForeColor = Color.Silver;
            tbAlamat.Location = new Point(30, 320);
            tbAlamat.Name = "tbAlamat";
            tbAlamat.Size = new Size(350, 27);
            tbAlamat.TabIndex = 9;
            tbAlamat.Text = "Alamat Detail";
            // 
            // cbKabupaten
            // 
            cbKabupaten.Font = new Font("Calibri", 12F, FontStyle.Italic);
            cbKabupaten.ForeColor = Color.Black;
            cbKabupaten.Location = new Point(30, 280);
            cbKabupaten.Name = "cbKabupaten";
            cbKabupaten.Size = new Size(110, 27);
            cbKabupaten.TabIndex = 6;
            cbKabupaten.Text = "Kabupaten";
            // 
            // cbKecamatan
            // 
            cbKecamatan.Font = new Font("Calibri", 12F, FontStyle.Italic);
            cbKecamatan.ForeColor = Color.Black;
            cbKecamatan.Location = new Point(150, 280);
            cbKecamatan.Name = "cbKecamatan";
            cbKecamatan.Size = new Size(110, 27);
            cbKecamatan.TabIndex = 7;
            cbKecamatan.Text = "Kecamatan";
            // 
            // cbDesa
            // 
            cbDesa.Font = new Font("Calibri", 12F, FontStyle.Italic);
            cbDesa.ForeColor = Color.Black;
            cbDesa.Location = new Point(270, 280);
            cbDesa.Name = "cbDesa";
            cbDesa.Size = new Size(110, 27);
            cbDesa.TabIndex = 8;
            cbDesa.Text = "Desa";
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Calibri", 12F);
            tbPassword.ForeColor = Color.Silver;
            tbPassword.Location = new Point(30, 120);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(350, 27);
            tbPassword.TabIndex = 2;
            tbPassword.Text = "Password";
            // 
            // tbNoTelp
            // 
            tbNoTelp.Font = new Font("Calibri", 12F);
            tbNoTelp.ForeColor = Color.Silver;
            tbNoTelp.Location = new Point(30, 360);
            tbNoTelp.Name = "tbNoTelp";
            tbNoTelp.Size = new Size(350, 27);
            tbNoTelp.TabIndex = 10;
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
            btnSimpan.TabIndex = 11;
            btnSimpan.Text = "SIMPAN";
            btnSimpan.UseVisualStyleBackColor = false;
            // 
            // cbRole
            // 
            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRole.Font = new Font("Calibri", 12F);
            cbRole.Location = new Point(30, 240);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(350, 27);
            cbRole.TabIndex = 5;
            // 
            // FormAkun
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(420, 500);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAkun";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kelola Akun";
            Load += FormAkun_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }
        private TextBox tbUsername, tbNama, tbEmail, tbAlamat, tbPassword, tbNoTelp;
        private ComboBox cbKabupaten, cbKecamatan, cbDesa, cbRole;
        private Button btnSimpan;
    }
}