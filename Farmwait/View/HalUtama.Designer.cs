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
            lblJudul = new Label();
            lblSelamatDatang = new Label();
            btnLogout = new Button();
            btnKelolaPakan = new Button();
            btnKelolaHewan = new Button();
            btnKelolaProduk = new Button();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.Location = new Point(30, 30);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(394, 45);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "FARMWAIT DASHBOARD";
            // 
            // lblSelamatDatang
            // 
            lblSelamatDatang.AutoSize = true;
            lblSelamatDatang.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelamatDatang.Location = new Point(38, 90);
            lblSelamatDatang.Name = "lblSelamatDatang";
            lblSelamatDatang.Size = new Size(200, 25);
            lblSelamatDatang.TabIndex = 1;
            lblSelamatDatang.Text = "Selamat Datang, User!";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Firebrick;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(950, 30);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(120, 45);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            //
            //btnKelolaPakan
            //
            btnKelolaPakan.BackColor = Color.ForestGreen;
            btnKelolaPakan.FlatStyle = FlatStyle.Flat;
            btnKelolaPakan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelolaPakan.ForeColor = Color.White;
            btnKelolaPakan.Location = new Point(38, 150);
            btnKelolaPakan.Name = "btnKelolaPakan";
            btnKelolaPakan.Size = new Size(200, 50);
            btnKelolaPakan.TabIndex = 3;
            btnKelolaPakan.Text = "KELOLA PAKAN";
            btnKelolaPakan.UseVisualStyleBackColor = false;
            btnKelolaPakan.Click += btnKelolaPakan_Click; // Event click
            //
            //btnKelolaHewan
            //
            btnKelolaHewan.BackColor = Color.Teal; 
            btnKelolaHewan.FlatStyle = FlatStyle.Flat;
            btnKelolaHewan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKelolaHewan.ForeColor = Color.White; 
            btnKelolaHewan.Location = new Point(38, 220);
            btnKelolaHewan.Name = "btnKelolaHewan";
            btnKelolaHewan.Size = new Size(200, 50);
            btnKelolaHewan.TabIndex = 4;
            btnKelolaHewan.Text = "KELOLA HEWAN";
            btnKelolaHewan.UseVisualStyleBackColor = false;
            btnKelolaHewan.Click += btnKelolaHewan_Click; // Event Click
            //
            //btnKelolaProduk
            //
            btnKelolaProduk.BackColor = Color.DarkGoldenrod; // Warna beda
            btnKelolaProduk.FlatStyle = FlatStyle.Flat;
            btnKelolaProduk.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnKelolaProduk.ForeColor = Color.White;
            btnKelolaProduk.Location = new Point(38, 290); // Jarak 70px kebawah
            btnKelolaProduk.Name = "btnKelolaProduk";
            btnKelolaProduk.Size = new Size(200, 50);
            btnKelolaProduk.TabIndex = 5;
            btnKelolaProduk.Text = "KELOLA PRODUK";
            btnKelolaProduk.UseVisualStyleBackColor = false;
            btnKelolaProduk.Click += btnKelolaProduk_Click;
            // 
            // HalUtama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1103, 726);
            Controls.Add(btnKelolaProduk);
            Controls.Add(btnKelolaHewan);
            Controls.Add(btnKelolaPakan); 
            Controls.Add(btnLogout);
            Controls.Add(lblSelamatDatang);
            Controls.Add(lblJudul);
            Name = "HalUtama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Farmwait - Halaman Utama";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJudul;
        public Label lblSelamatDatang;
        private Button btnLogout;
        private Button btnKelolaPakan;
        private Button btnKelolaHewan;
        private Button btnKelolaProduk;
    }
}