namespace Farmwait.View
{
    partial class FormTransaksiPeternak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransaksiPeternak));
            lblIDTransaksi = new Label();
            lblTanggalTransaksi = new Label();
            lblIDAkun = new Label();
            lblMetodePembayaran = new Label();
            lblStatus = new Label();
            cbStatus = new ComboBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            tbIDTransaksi = new TextBox();
            tbTanggalTransaksi = new TextBox();
            tbIDAkun = new TextBox();
            tbMetodePembayaran = new TextBox();
            lblIDProduk = new Label();
            tbIDProduk = new TextBox();
            SuspendLayout();
            // 
            // lblIDTransaksi
            // 
            lblIDTransaksi.AutoSize = true;
            lblIDTransaksi.BackColor = Color.Transparent;
            lblIDTransaksi.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIDTransaksi.Location = new Point(20, 113);
            lblIDTransaksi.Name = "lblIDTransaksi";
            lblIDTransaksi.Size = new Size(88, 19);
            lblIDTransaksi.TabIndex = 0;
            lblIDTransaksi.Text = "ID Transaksi";
            // 
            // lblTanggalTransaksi
            // 
            lblTanggalTransaksi.AutoSize = true;
            lblTanggalTransaksi.BackColor = Color.Transparent;
            lblTanggalTransaksi.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTanggalTransaksi.Location = new Point(20, 158);
            lblTanggalTransaksi.Name = "lblTanggalTransaksi";
            lblTanggalTransaksi.Size = new Size(125, 19);
            lblTanggalTransaksi.TabIndex = 1;
            lblTanggalTransaksi.Text = "Tanggal Transaksi";
            // 
            // lblIDAkun
            // 
            lblIDAkun.AutoSize = true;
            lblIDAkun.BackColor = Color.Transparent;
            lblIDAkun.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIDAkun.Location = new Point(20, 207);
            lblIDAkun.Name = "lblIDAkun";
            lblIDAkun.Size = new Size(59, 19);
            lblIDAkun.TabIndex = 2;
            lblIDAkun.Text = "ID Akun";
            // 
            // lblMetodePembayaran
            // 
            lblMetodePembayaran.AutoSize = true;
            lblMetodePembayaran.BackColor = Color.Transparent;
            lblMetodePembayaran.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMetodePembayaran.Location = new Point(262, 110);
            lblMetodePembayaran.Name = "lblMetodePembayaran";
            lblMetodePembayaran.Size = new Size(143, 19);
            lblMetodePembayaran.TabIndex = 3;
            lblMetodePembayaran.Text = "Metode Pembayaran";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(262, 208);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 19);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status";
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Proses", "Dikirim", "Selesai" });
            cbStatus.Location = new Point(383, 203);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(108, 23);
            cbStatus.TabIndex = 5;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Green;
            btnSimpan.Font = new Font("Nirmala UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(98, 278);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(129, 47);
            btnSimpan.TabIndex = 6;
            btnSimpan.Text = "SIMPAN";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click_1;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.FromArgb(192, 0, 0);
            btnBatal.Font = new Font("Nirmala UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = Color.White;
            btnBatal.Location = new Point(262, 278);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(129, 47);
            btnBatal.TabIndex = 7;
            btnBatal.Text = "BATAL";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click_1;
            // 
            // tbIDTransaksi
            // 
            tbIDTransaksi.Location = new Point(159, 110);
            tbIDTransaksi.Name = "tbIDTransaksi";
            tbIDTransaksi.ReadOnly = true;
            tbIDTransaksi.Size = new Size(77, 23);
            tbIDTransaksi.TabIndex = 8;
            // 
            // tbTanggalTransaksi
            // 
            tbTanggalTransaksi.Location = new Point(159, 155);
            tbTanggalTransaksi.Name = "tbTanggalTransaksi";
            tbTanggalTransaksi.ReadOnly = true;
            tbTanggalTransaksi.Size = new Size(77, 23);
            tbTanggalTransaksi.TabIndex = 9;
            // 
            // tbIDAkun
            // 
            tbIDAkun.Location = new Point(159, 204);
            tbIDAkun.Name = "tbIDAkun";
            tbIDAkun.ReadOnly = true;
            tbIDAkun.Size = new Size(77, 23);
            tbIDAkun.TabIndex = 10;
            // 
            // tbMetodePembayaran
            // 
            tbMetodePembayaran.Location = new Point(414, 106);
            tbMetodePembayaran.Name = "tbMetodePembayaran";
            tbMetodePembayaran.ReadOnly = true;
            tbMetodePembayaran.Size = new Size(77, 23);
            tbMetodePembayaran.TabIndex = 11;
            // 
            // lblIDProduk
            // 
            lblIDProduk.AutoSize = true;
            lblIDProduk.BackColor = Color.Transparent;
            lblIDProduk.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIDProduk.Location = new Point(262, 158);
            lblIDProduk.Name = "lblIDProduk";
            lblIDProduk.Size = new Size(95, 19);
            lblIDProduk.TabIndex = 12;
            lblIDProduk.Text = "Nama Produk";
            // 
            // tbIDProduk
            // 
            tbIDProduk.Location = new Point(383, 154);
            tbIDProduk.Name = "tbIDProduk";
            tbIDProduk.ReadOnly = true;
            tbIDProduk.Size = new Size(108, 23);
            tbIDProduk.TabIndex = 13;
            // 
            // FormTransaksiPeternak
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(500, 360);
            Controls.Add(tbIDProduk);
            Controls.Add(lblIDProduk);
            Controls.Add(tbMetodePembayaran);
            Controls.Add(tbIDAkun);
            Controls.Add(tbTanggalTransaksi);
            Controls.Add(tbIDTransaksi);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(cbStatus);
            Controls.Add(lblStatus);
            Controls.Add(lblMetodePembayaran);
            Controls.Add(lblIDAkun);
            Controls.Add(lblTanggalTransaksi);
            Controls.Add(lblIDTransaksi);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormTransaksiPeternak";
            Text = "FormTransaksiPeternak";
            Load += FormTransaksiPeternak_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIDTransaksi;
        private Label lblTanggalTransaksi;
        private Label lblIDAkun;
        private Label lblMetodePembayaran;
        private Label lblStatus;
        private ComboBox cbStatus;
        private Button btnSimpan;
        private Button btnBatal;
        private TextBox tbIDTransaksi;
        private TextBox tbTanggalTransaksi;
        private TextBox tbIDAkun;
        private TextBox tbMetodePembayaran;
        private Label lblIDProduk;
        private TextBox tbIDProduk;
    }
}