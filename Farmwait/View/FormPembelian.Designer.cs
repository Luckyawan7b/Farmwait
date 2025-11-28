namespace Farmwait.View
{
    partial class FormPembelian
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPembelian));
            tbIDTransaksi = new TextBox();
            lblIDTransaksi = new Label();
            tbTanggalTransaksi = new TextBox();
            lblIDAkun = new Label();
            tbIDAkun = new TextBox();
            lblNamaProduk = new Label();
            tbNamaProduk = new TextBox();
            lblJumlah = new Label();
            tbJumlah = new TextBox();
            lblTotalHarga = new Label();
            tbTotalHarga = new TextBox();
            btnBuatPesanan = new Button();
            btnBatal = new Button();
            lblMetodePembayaran = new Label();
            cbMetodePembayaran = new ComboBox();
            notifyIcon1 = new NotifyIcon(components);
            SuspendLayout();
            // 
            // tbIDTransaksi
            // 
            tbIDTransaksi.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbIDTransaksi.Location = new Point(376, 70);
            tbIDTransaksi.Name = "tbIDTransaksi";
            tbIDTransaksi.ReadOnly = true;
            tbIDTransaksi.Size = new Size(100, 27);
            tbIDTransaksi.TabIndex = 0;
            // 
            // lblIDTransaksi
            // 
            lblIDTransaksi.AutoSize = true;
            lblIDTransaksi.BackColor = Color.Transparent;
            lblIDTransaksi.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIDTransaksi.Location = new Point(290, 76);
            lblIDTransaksi.Name = "lblIDTransaksi";
            lblIDTransaksi.Size = new Size(80, 18);
            lblIDTransaksi.TabIndex = 1;
            lblIDTransaksi.Text = "ID Transaksi";
            // 
            // tbTanggalTransaksi
            // 
            tbTanggalTransaksi.BackColor = Color.FromArgb(255, 192, 192);
            tbTanggalTransaksi.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTanggalTransaksi.Location = new Point(335, 103);
            tbTanggalTransaksi.Name = "tbTanggalTransaksi";
            tbTanggalTransaksi.ReadOnly = true;
            tbTanggalTransaksi.Size = new Size(141, 27);
            tbTanggalTransaksi.TabIndex = 2;
            // 
            // lblIDAkun
            // 
            lblIDAkun.AutoSize = true;
            lblIDAkun.BackColor = Color.Transparent;
            lblIDAkun.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIDAkun.Location = new Point(11, 74);
            lblIDAkun.Name = "lblIDAkun";
            lblIDAkun.Size = new Size(56, 18);
            lblIDAkun.TabIndex = 3;
            lblIDAkun.Text = "ID Akun";
            // 
            // tbIDAkun
            // 
            tbIDAkun.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbIDAkun.Location = new Point(97, 70);
            tbIDAkun.Name = "tbIDAkun";
            tbIDAkun.ReadOnly = true;
            tbIDAkun.Size = new Size(100, 27);
            tbIDAkun.TabIndex = 4;
            // 
            // lblNamaProduk
            // 
            lblNamaProduk.AutoSize = true;
            lblNamaProduk.BackColor = Color.Transparent;
            lblNamaProduk.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNamaProduk.Location = new Point(11, 128);
            lblNamaProduk.Name = "lblNamaProduk";
            lblNamaProduk.Size = new Size(52, 18);
            lblNamaProduk.TabIndex = 5;
            lblNamaProduk.Text = "Produk";
            // 
            // tbNamaProduk
            // 
            tbNamaProduk.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNamaProduk.Location = new Point(97, 128);
            tbNamaProduk.Name = "tbNamaProduk";
            tbNamaProduk.ReadOnly = true;
            tbNamaProduk.Size = new Size(170, 27);
            tbNamaProduk.TabIndex = 6;
            // 
            // lblJumlah
            // 
            lblJumlah.AutoSize = true;
            lblJumlah.BackColor = Color.Transparent;
            lblJumlah.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJumlah.Location = new Point(11, 187);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(52, 18);
            lblJumlah.TabIndex = 7;
            lblJumlah.Text = "Jumlah";
            // 
            // tbJumlah
            // 
            tbJumlah.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbJumlah.Location = new Point(97, 183);
            tbJumlah.Name = "tbJumlah";
            tbJumlah.Size = new Size(46, 27);
            tbJumlah.TabIndex = 8;
            tbJumlah.TextChanged += tbJumlah_TextChanged;
            // 
            // lblTotalHarga
            // 
            lblTotalHarga.AutoSize = true;
            lblTotalHarga.BackColor = Color.Transparent;
            lblTotalHarga.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalHarga.Location = new Point(11, 244);
            lblTotalHarga.Name = "lblTotalHarga";
            lblTotalHarga.Size = new Size(76, 18);
            lblTotalHarga.TabIndex = 9;
            lblTotalHarga.Text = "Total Harga";
            lblTotalHarga.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbTotalHarga
            // 
            tbTotalHarga.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTotalHarga.Location = new Point(97, 240);
            tbTotalHarga.Name = "tbTotalHarga";
            tbTotalHarga.ReadOnly = true;
            tbTotalHarga.Size = new Size(100, 27);
            tbTotalHarga.TabIndex = 10;
            // 
            // btnBuatPesanan
            // 
            btnBuatPesanan.BackColor = Color.Green;
            btnBuatPesanan.Font = new Font("Nirmala UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btnBuatPesanan.ForeColor = SystemColors.ButtonHighlight;
            btnBuatPesanan.Location = new Point(291, 300);
            btnBuatPesanan.Name = "btnBuatPesanan";
            btnBuatPesanan.Size = new Size(149, 48);
            btnBuatPesanan.TabIndex = 11;
            btnBuatPesanan.Text = "BUAT PESANAN";
            btnBuatPesanan.UseVisualStyleBackColor = false;
            btnBuatPesanan.Click += btnBuatPesanan_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.FromArgb(192, 0, 0);
            btnBatal.Font = new Font("Nirmala UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btnBatal.ForeColor = SystemColors.ButtonHighlight;
            btnBatal.Location = new Point(108, 300);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(136, 48);
            btnBatal.TabIndex = 12;
            btnBatal.Text = "BATAL";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // lblMetodePembayaran
            // 
            lblMetodePembayaran.AutoSize = true;
            lblMetodePembayaran.BackColor = Color.Transparent;
            lblMetodePembayaran.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMetodePembayaran.Location = new Point(234, 244);
            lblMetodePembayaran.Name = "lblMetodePembayaran";
            lblMetodePembayaran.Size = new Size(138, 18);
            lblMetodePembayaran.TabIndex = 13;
            lblMetodePembayaran.Text = "Metode Pembayaran";
            lblMetodePembayaran.TextAlign = ContentAlignment.TopCenter;
            // 
            // cbMetodePembayaran
            // 
            cbMetodePembayaran.FormattingEnabled = true;
            cbMetodePembayaran.Items.AddRange(new object[] { "QRIS", "Cash", "Transfer", "E-Wallet" });
            cbMetodePembayaran.Location = new Point(386, 244);
            cbMetodePembayaran.Name = "cbMetodePembayaran";
            cbMetodePembayaran.Size = new Size(90, 23);
            cbMetodePembayaran.TabIndex = 14;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // FormPembelian
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(500, 360);
            Controls.Add(cbMetodePembayaran);
            Controls.Add(lblMetodePembayaran);
            Controls.Add(btnBatal);
            Controls.Add(btnBuatPesanan);
            Controls.Add(tbTotalHarga);
            Controls.Add(lblTotalHarga);
            Controls.Add(tbJumlah);
            Controls.Add(lblJumlah);
            Controls.Add(tbNamaProduk);
            Controls.Add(lblNamaProduk);
            Controls.Add(tbIDAkun);
            Controls.Add(lblIDAkun);
            Controls.Add(tbTanggalTransaksi);
            Controls.Add(lblIDTransaksi);
            Controls.Add(tbIDTransaksi);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPembelian";
            Text = "Form Pembelian";
            Load += FormPembelian_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbIDTransaksi;
        private Label lblIDTransaksi;
        private TextBox tbTanggalTransaksi;
        private Label lblIDAkun;
        private TextBox tbIDAkun;
        private Label lblNamaProduk;
        private TextBox tbNamaProduk;
        private Label lblJumlah;
        private TextBox tbJumlah;
        private Label lblTotalHarga;
        private TextBox tbTotalHarga;
        private Button btnBuatPesanan;
        private Button btnBatal;
        private Label lblMetodePembayaran;
        private ComboBox cbMetodePembayaran;
        private NotifyIcon notifyIcon1;
    }
}