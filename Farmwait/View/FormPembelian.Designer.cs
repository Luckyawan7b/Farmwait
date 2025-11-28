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
            lblBuatPesanan = new Button();
            button1 = new Button();
            lblMetodePembayaran = new Label();
            cbMetodePembayaran = new ComboBox();
            notifyIcon1 = new NotifyIcon(components);
            SuspendLayout();
            // 
            // tbIDTransaksi
            // 
            tbIDTransaksi.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbIDTransaksi.Location = new Point(98, 12);
            tbIDTransaksi.Name = "tbIDTransaksi";
            tbIDTransaksi.ReadOnly = true;
            tbIDTransaksi.Size = new Size(100, 27);
            tbIDTransaksi.TabIndex = 0;
            // 
            // lblIDTransaksi
            // 
            lblIDTransaksi.AutoSize = true;
            lblIDTransaksi.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIDTransaksi.Location = new Point(12, 18);
            lblIDTransaksi.Name = "lblIDTransaksi";
            lblIDTransaksi.Size = new Size(80, 18);
            lblIDTransaksi.TabIndex = 1;
            lblIDTransaksi.Text = "ID Transaksi";
            // 
            // tbTanggalTransaksi
            // 
            tbTanggalTransaksi.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTanggalTransaksi.Location = new Point(304, 18);
            tbTanggalTransaksi.Name = "tbTanggalTransaksi";
            tbTanggalTransaksi.ReadOnly = true;
            tbTanggalTransaksi.Size = new Size(173, 27);
            tbTanggalTransaksi.TabIndex = 2;
            // 
            // lblIDAkun
            // 
            lblIDAkun.AutoSize = true;
            lblIDAkun.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIDAkun.Location = new Point(12, 69);
            lblIDAkun.Name = "lblIDAkun";
            lblIDAkun.Size = new Size(56, 18);
            lblIDAkun.TabIndex = 3;
            lblIDAkun.Text = "ID Akun";
            // 
            // tbIDAkun
            // 
            tbIDAkun.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbIDAkun.Location = new Point(98, 65);
            tbIDAkun.Name = "tbIDAkun";
            tbIDAkun.ReadOnly = true;
            tbIDAkun.Size = new Size(100, 27);
            tbIDAkun.TabIndex = 4;
            // 
            // lblNamaProduk
            // 
            lblNamaProduk.AutoSize = true;
            lblNamaProduk.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNamaProduk.Location = new Point(12, 123);
            lblNamaProduk.Name = "lblNamaProduk";
            lblNamaProduk.Size = new Size(52, 18);
            lblNamaProduk.TabIndex = 5;
            lblNamaProduk.Text = "Produk";
            // 
            // tbNamaProduk
            // 
            tbNamaProduk.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNamaProduk.Location = new Point(98, 123);
            tbNamaProduk.Name = "tbNamaProduk";
            tbNamaProduk.ReadOnly = true;
            tbNamaProduk.Size = new Size(213, 27);
            tbNamaProduk.TabIndex = 6;
            // 
            // lblJumlah
            // 
            lblJumlah.AutoSize = true;
            lblJumlah.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJumlah.Location = new Point(12, 182);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(52, 18);
            lblJumlah.TabIndex = 7;
            lblJumlah.Text = "Jumlah";
            // 
            // tbJumlah
            // 
            tbJumlah.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbJumlah.Location = new Point(98, 178);
            tbJumlah.Name = "tbJumlah";
            tbJumlah.Size = new Size(46, 27);
            tbJumlah.TabIndex = 8;
            tbJumlah.TextChanged += tbJumlah_TextChanged;
            // 
            // lblTotalHarga
            // 
            lblTotalHarga.AutoSize = true;
            lblTotalHarga.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalHarga.Location = new Point(12, 239);
            lblTotalHarga.Name = "lblTotalHarga";
            lblTotalHarga.Size = new Size(76, 18);
            lblTotalHarga.TabIndex = 9;
            lblTotalHarga.Text = "Total Harga";
            lblTotalHarga.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbTotalHarga
            // 
            tbTotalHarga.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTotalHarga.Location = new Point(98, 235);
            tbTotalHarga.Name = "tbTotalHarga";
            tbTotalHarga.ReadOnly = true;
            tbTotalHarga.Size = new Size(100, 27);
            tbTotalHarga.TabIndex = 10;
            // 
            // lblBuatPesanan
            // 
            lblBuatPesanan.Location = new Point(304, 300);
            lblBuatPesanan.Name = "lblBuatPesanan";
            lblBuatPesanan.Size = new Size(115, 34);
            lblBuatPesanan.TabIndex = 11;
            lblBuatPesanan.Text = "Buat Pesanan";
            lblBuatPesanan.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(135, 300);
            button1.Name = "button1";
            button1.Size = new Size(115, 34);
            button1.TabIndex = 12;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblMetodePembayaran
            // 
            lblMetodePembayaran.AutoSize = true;
            lblMetodePembayaran.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMetodePembayaran.Location = new Point(235, 239);
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
            cbMetodePembayaran.Location = new Point(387, 239);
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
            ClientSize = new Size(500, 360);
            Controls.Add(cbMetodePembayaran);
            Controls.Add(lblMetodePembayaran);
            Controls.Add(button1);
            Controls.Add(lblBuatPesanan);
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
            Name = "FormPembelian";
            Text = "FormPembelian";
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
        private Button lblBuatPesanan;
        private Button button1;
        private Label lblMetodePembayaran;
        private ComboBox cbMetodePembayaran;
        private NotifyIcon notifyIcon1;
    }
}