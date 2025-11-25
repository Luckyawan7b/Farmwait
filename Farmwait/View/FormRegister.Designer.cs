namespace Farmwait.View
{
    partial class FormRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            tbUsernameRegister = new TextBox();
            tbNamaRegister = new TextBox();
            tbEmailRegister = new TextBox();
            tbAlamatRegister = new TextBox();
            cbKabupatenRegister = new ComboBox();
            cbKecamatanRegister = new ComboBox();
            cbDesaRegister = new ComboBox();
            tbPassword = new TextBox();
            tbNoTelp = new TextBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // tbUsernameRegister
            // 
            tbUsernameRegister.Cursor = Cursors.IBeam;
            tbUsernameRegister.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsernameRegister.ForeColor = Color.Silver;
            tbUsernameRegister.Location = new Point(634, 222);
            tbUsernameRegister.Multiline = true;
            tbUsernameRegister.Name = "tbUsernameRegister";
            tbUsernameRegister.Size = new Size(401, 40);
            tbUsernameRegister.TabIndex = 1;
            tbUsernameRegister.Text = "Username";
            // 
            // tbNamaRegister
            // 
            tbNamaRegister.Cursor = Cursors.IBeam;
            tbNamaRegister.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNamaRegister.ForeColor = Color.Silver;
            tbNamaRegister.Location = new Point(634, 337);
            tbNamaRegister.Multiline = true;
            tbNamaRegister.Name = "tbNamaRegister";
            tbNamaRegister.Size = new Size(401, 40);
            tbNamaRegister.TabIndex = 3;
            tbNamaRegister.Text = "Nama";
            // 
            // tbEmailRegister
            // 
            tbEmailRegister.Cursor = Cursors.IBeam;
            tbEmailRegister.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmailRegister.ForeColor = Color.Silver;
            tbEmailRegister.Location = new Point(634, 392);
            tbEmailRegister.Multiline = true;
            tbEmailRegister.Name = "tbEmailRegister";
            tbEmailRegister.Size = new Size(401, 40);
            tbEmailRegister.TabIndex = 4;
            tbEmailRegister.Text = "Email";
            // 
            // tbAlamatRegister
            // 
            tbAlamatRegister.Cursor = Cursors.IBeam;
            tbAlamatRegister.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbAlamatRegister.ForeColor = Color.Silver;
            tbAlamatRegister.Location = new Point(634, 514);
            tbAlamatRegister.Multiline = true;
            tbAlamatRegister.Name = "tbAlamatRegister";
            tbAlamatRegister.Size = new Size(401, 40);
            tbAlamatRegister.TabIndex = 8;
            tbAlamatRegister.Text = "Alamat";
            // 
            // cbKabupatenRegister
            // 
            cbKabupatenRegister.Font = new Font("Calibri", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cbKabupatenRegister.ForeColor = Color.Silver;
            cbKabupatenRegister.FormattingEnabled = true;
            cbKabupatenRegister.Location = new Point(634, 462);
            cbKabupatenRegister.Name = "cbKabupatenRegister";
            cbKabupatenRegister.Size = new Size(120, 27);
            cbKabupatenRegister.TabIndex = 5;
            cbKabupatenRegister.Text = "Kabupaten";
            // 
            // cbKecamatanRegister
            // 
            cbKecamatanRegister.Font = new Font("Calibri", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cbKecamatanRegister.ForeColor = Color.Silver;
            cbKecamatanRegister.FormattingEnabled = true;
            cbKecamatanRegister.Location = new Point(779, 462);
            cbKecamatanRegister.Name = "cbKecamatanRegister";
            cbKecamatanRegister.Size = new Size(109, 27);
            cbKecamatanRegister.TabIndex = 6;
            cbKecamatanRegister.Text = "Kecamatan";
            // 
            // cbDesaRegister
            // 
            cbDesaRegister.Font = new Font("Calibri", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cbDesaRegister.ForeColor = Color.Silver;
            cbDesaRegister.FormattingEnabled = true;
            cbDesaRegister.Location = new Point(910, 462);
            cbDesaRegister.Name = "cbDesaRegister";
            cbDesaRegister.Size = new Size(125, 27);
            cbDesaRegister.TabIndex = 7;
            cbDesaRegister.Text = "Desa";
            // 
            // tbPassword
            // 
            tbPassword.Cursor = Cursors.IBeam;
            tbPassword.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.ForeColor = Color.Silver;
            tbPassword.Location = new Point(634, 281);
            tbPassword.Multiline = true;
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(401, 40);
            tbPassword.TabIndex = 2;
            tbPassword.Text = "Password";
            // 
            // tbNoTelp
            // 
            tbNoTelp.Cursor = Cursors.IBeam;
            tbNoTelp.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNoTelp.ForeColor = Color.Silver;
            tbNoTelp.Location = new Point(634, 573);
            tbNoTelp.Multiline = true;
            tbNoTelp.Name = "tbNoTelp";
            tbNoTelp.Size = new Size(401, 40);
            tbNoTelp.TabIndex = 9;
            tbNoTelp.Text = "No Telp.";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(192, 0, 0);
            btnRegister.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.Transparent;
            btnRegister.Location = new Point(634, 632);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(401, 47);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1136, 825);
            Controls.Add(btnRegister);
            Controls.Add(tbNoTelp);
            Controls.Add(tbPassword);
            Controls.Add(cbDesaRegister);
            Controls.Add(cbKecamatanRegister);
            Controls.Add(cbKabupatenRegister);
            Controls.Add(tbAlamatRegister);
            Controls.Add(tbEmailRegister);
            Controls.Add(tbNamaRegister);
            Controls.Add(tbUsernameRegister);
            Name = "FormRegister";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbUsernameRegister;
        private TextBox tbNamaRegister;
        private TextBox tbEmailRegister;
        private TextBox tbAlamatRegister;
        private ComboBox cbKabupatenRegister;
        private ComboBox cbKecamatanRegister;
        private ComboBox cbDesaRegister;
        private TextBox tbPassword;
        private TextBox tbNoTelp;
        private Button btnRegister;
    }
}