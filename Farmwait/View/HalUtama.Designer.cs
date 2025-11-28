namespace Farmwait.View
{
    partial class HalUtama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HalUtama));
            lblSelamatDatang = new Label();
            btnLogout = new Button();
            btnKelolaPakan = new Button();
            btnKelolaHewan = new Button();
            btnKelolaProduk = new Button();
            btnProfil = new Button();
            btnKelolaTransaksi = new Button();
            btnTransaksi = new Button();
            SuspendLayout();
            // 
            // lblSelamatDatang
            // 
            lblSelamatDatang.AutoSize = true;
            lblSelamatDatang.BackColor = Color.Transparent;
            lblSelamatDatang.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelamatDatang.Location = new Point(65, 292);
            lblSelamatDatang.Name = "lblSelamatDatang";
            lblSelamatDatang.Size = new Size(197, 25);
            lblSelamatDatang.TabIndex = 1;
            lblSelamatDatang.Text = "Selamat Datang, User!";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(915, 57);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(178, 68);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnKelolaPakan
            // 
            btnKelolaPakan.BackColor = Color.FromArgb(255, 192, 128);
            btnKelolaPakan.FlatAppearance.BorderSize = 0;
            btnKelolaPakan.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnKelolaPakan.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKelolaPakan.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKelolaPakan.FlatStyle = FlatStyle.Flat;
            btnKelolaPakan.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold);
            btnKelolaPakan.ForeColor = Color.Black;
            btnKelolaPakan.Location = new Point(175, 524);
            btnKelolaPakan.Name = "btnKelolaPakan";
            btnKelolaPakan.Size = new Size(342, 102);
            btnKelolaPakan.TabIndex = 3;
            btnKelolaPakan.Text = "KELOLA PAKAN";
            btnKelolaPakan.UseVisualStyleBackColor = false;
            btnKelolaPakan.Click += btnKelolaPakan_Click;
            // 
            // btnKelolaHewan
            // 
            btnKelolaHewan.BackColor = Color.FromArgb(255, 192, 128);
            btnKelolaHewan.FlatAppearance.BorderSize = 0;
            btnKelolaHewan.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnKelolaHewan.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKelolaHewan.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKelolaHewan.FlatStyle = FlatStyle.Flat;
            btnKelolaHewan.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold);
            btnKelolaHewan.ForeColor = Color.Black;
            btnKelolaHewan.Location = new Point(634, 522);
            btnKelolaHewan.Name = "btnKelolaHewan";
            btnKelolaHewan.Size = new Size(297, 104);
            btnKelolaHewan.TabIndex = 4;
            btnKelolaHewan.Text = "KELOLA HEWAN";
            btnKelolaHewan.UseVisualStyleBackColor = false;
            btnKelolaHewan.Click += btnKelolaHewan_Click;
            // 
            // btnKelolaProduk
            // 
            btnKelolaProduk.BackColor = Color.FromArgb(255, 192, 128);
            btnKelolaProduk.FlatAppearance.BorderSize = 0;
            btnKelolaProduk.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnKelolaProduk.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKelolaProduk.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKelolaProduk.FlatStyle = FlatStyle.Flat;
            btnKelolaProduk.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold);
            btnKelolaProduk.ForeColor = Color.Black;
            btnKelolaProduk.Location = new Point(175, 654);
            btnKelolaProduk.Name = "btnKelolaProduk";
            btnKelolaProduk.Size = new Size(342, 109);
            btnKelolaProduk.TabIndex = 5;
            btnKelolaProduk.Text = "KELOLA PRODUK";
            btnKelolaProduk.UseVisualStyleBackColor = false;
            btnKelolaProduk.Click += btnKelolaProduk_Click;
            // 
            // btnProfil
            // 
            btnProfil.BackColor = Color.Transparent;
            btnProfil.BackgroundImage = Properties.Resources.profil;
            btnProfil.BackgroundImageLayout = ImageLayout.Zoom;
            btnProfil.Cursor = Cursors.Hand;
            btnProfil.FlatAppearance.BorderSize = 0;
            btnProfil.FlatStyle = FlatStyle.Flat;
            btnProfil.Location = new Point(750, 76);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(50, 45);
            btnProfil.TabIndex = 6;
            btnProfil.UseVisualStyleBackColor = false;
            btnProfil.Click += btnProfil_Click;
            // 
            // btnKelolaTransaksi
            // 
            btnKelolaTransaksi.BackColor = Color.FromArgb(255, 192, 128);
            btnKelolaTransaksi.FlatAppearance.BorderSize = 0;
            btnKelolaTransaksi.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnKelolaTransaksi.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnKelolaTransaksi.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnKelolaTransaksi.FlatStyle = FlatStyle.Flat;
            btnKelolaTransaksi.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold);
            btnKelolaTransaksi.ForeColor = Color.Black;
            btnKelolaTransaksi.Location = new Point(634, 656);
            btnKelolaTransaksi.Name = "btnKelolaTransaksi";
            btnKelolaTransaksi.Size = new Size(297, 104);
            btnKelolaTransaksi.TabIndex = 7;
            btnKelolaTransaksi.Text = "KELOLA TRANSAKSI";
            btnKelolaTransaksi.UseVisualStyleBackColor = false;
            btnKelolaTransaksi.Click += btnKelolaTransaksi_Click;
            // 
            // btnTransaksi
            // 
            btnTransaksi.BackColor = Color.FromArgb(255, 192, 128);
            btnTransaksi.FlatAppearance.BorderSize = 0;
            btnTransaksi.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnTransaksi.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTransaksi.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnTransaksi.FlatStyle = FlatStyle.Flat;
            btnTransaksi.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold);
            btnTransaksi.ForeColor = Color.Black;
            btnTransaksi.Location = new Point(411, 347);
            btnTransaksi.Name = "btnTransaksi";
            btnTransaksi.Size = new Size(297, 104);
            btnTransaksi.TabIndex = 8;
            btnTransaksi.Text = "TRANSAKSI";
            btnTransaksi.UseVisualStyleBackColor = false;
            btnTransaksi.Click += btnTransaksi_Click;
            // 
            // HalUtama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1136, 825);
            Controls.Add(btnTransaksi);
            Controls.Add(btnKelolaTransaksi);
            Controls.Add(btnProfil);
            Controls.Add(btnKelolaProduk);
            Controls.Add(btnKelolaHewan);
            Controls.Add(btnKelolaPakan);
            Controls.Add(btnLogout);
            Controls.Add(lblSelamatDatang);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HalUtama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Farmwait - Halaman Utama";
            Load += HalUtama_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label lblSelamatDatang;
        private Button btnLogout;
        private Button btnKelolaPakan;
        private Button btnKelolaHewan;
        private Button btnKelolaProduk;
        private Button btnProfil;
        private Button btnKelolaTransaksi;
        private Button btnTransaksi;
    }
}