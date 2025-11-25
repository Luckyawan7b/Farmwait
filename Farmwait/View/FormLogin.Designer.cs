namespace Farmwait
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            tbUsernameLogin = new TextBox();
            tbPasswordLogin = new TextBox();
            btnLogin = new Button();
            linkLabelDaftar = new LinkLabel();
            SuspendLayout();
            // 
            // tbUsernameLogin
            // 
            tbUsernameLogin.Cursor = Cursors.IBeam;
            tbUsernameLogin.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsernameLogin.ForeColor = Color.Silver;
            tbUsernameLogin.Location = new Point(613, 338);
            tbUsernameLogin.Multiline = true;
            tbUsernameLogin.Name = "tbUsernameLogin";
            tbUsernameLogin.Size = new Size(401, 40);
            tbUsernameLogin.TabIndex = 0;
            tbUsernameLogin.Text = "Username";
            // 
            // tbPasswordLogin
            // 
            tbPasswordLogin.BackColor = SystemColors.Window;
            tbPasswordLogin.Cursor = Cursors.IBeam;
            tbPasswordLogin.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPasswordLogin.ForeColor = Color.Silver;
            tbPasswordLogin.Location = new Point(613, 413);
            tbPasswordLogin.Multiline = true;
            tbPasswordLogin.Name = "tbPasswordLogin";
            tbPasswordLogin.Size = new Size(401, 40);
            tbPasswordLogin.TabIndex = 1;
            tbPasswordLogin.Tag = "";
            tbPasswordLogin.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(192, 0, 0);
            btnLogin.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Transparent;
            btnLogin.Location = new Point(613, 501);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(401, 47);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkLabelDaftar
            // 
            linkLabelDaftar.AutoSize = true;
            linkLabelDaftar.BackColor = Color.Transparent;
            linkLabelDaftar.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabelDaftar.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabelDaftar.LinkColor = Color.FromArgb(128, 128, 255);
            linkLabelDaftar.Location = new Point(785, 570);
            linkLabelDaftar.Name = "linkLabelDaftar";
            linkLabelDaftar.Size = new Size(78, 15);
            linkLabelDaftar.TabIndex = 3;
            linkLabelDaftar.TabStop = true;
            linkLabelDaftar.Text = "Daftar Akun?";
            linkLabelDaftar.LinkClicked += linkLabelDaftar_LinkClicked;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1136, 825);
            Controls.Add(linkLabelDaftar);
            Controls.Add(btnLogin);
            Controls.Add(tbPasswordLogin);
            Controls.Add(tbUsernameLogin);
            DoubleBuffered = true;
            Name = "FormLogin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbUsernameLogin;
        private TextBox tbPasswordLogin;
        private Button btnLogin;
        private LinkLabel linkLabelDaftar;
    }
}
