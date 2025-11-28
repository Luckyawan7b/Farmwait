namespace Farmwait.View
{
    partial class FormProduk
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduk));
            tbNama = new TextBox();
            cbJenis = new ComboBox();
            cbHewan = new ComboBox();
            tbJumlah = new TextBox();
            tbHarga = new TextBox();
            btnBatal = new Button();
            btnSimpan = new Button();
            lblNamaProduk = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // tbNama
            // 
            tbNama.Location = new Point(30, 100);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(410, 23);
            tbNama.TabIndex = 2;
            // 
            // cbJenis
            // 
            cbJenis.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJenis.Location = new Point(30, 160);
            cbJenis.Name = "cbJenis";
            cbJenis.Size = new Size(190, 23);
            cbJenis.TabIndex = 4;
            // 
            // cbHewan
            // 
            cbHewan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHewan.Location = new Point(250, 160);
            cbHewan.Name = "cbHewan";
            cbHewan.Size = new Size(190, 23);
            cbHewan.TabIndex = 6;
            // 
            // tbJumlah
            // 
            tbJumlah.Location = new Point(30, 220);
            tbJumlah.Name = "tbJumlah";
            tbJumlah.Size = new Size(190, 23);
            tbJumlah.TabIndex = 8;
            // 
            // tbHarga
            // 
            tbHarga.Location = new Point(250, 220);
            tbHarga.Name = "tbHarga";
            tbHarga.Size = new Size(190, 23);
            tbHarga.TabIndex = 10;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.FromArgb(192, 0, 0);
            btnBatal.Font = new Font("Nirmala UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btnBatal.ForeColor = Color.White;
            btnBatal.Location = new Point(50, 280);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(170, 45);
            btnBatal.TabIndex = 12;
            btnBatal.Text = "BATAL";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Green;
            btnSimpan.Font = new Font("Nirmala UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(272, 280);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(168, 45);
            btnSimpan.TabIndex = 13;
            btnSimpan.Text = "SIMPAN";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // lblNamaProduk
            // 
            lblNamaProduk.AutoSize = true;
            lblNamaProduk.BackColor = Color.Transparent;
            lblNamaProduk.Location = new Point(30, 82);
            lblNamaProduk.Name = "lblNamaProduk";
            lblNamaProduk.Size = new Size(80, 15);
            lblNamaProduk.TabIndex = 14;
            lblNamaProduk.Text = "Nama Produk";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(30, 142);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 15;
            label1.Text = "Jenis Produk";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(250, 142);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 16;
            label2.Text = "Hewan Asal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(30, 202);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 17;
            label3.Text = "Jumlah Stok";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(250, 202);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 18;
            label4.Text = "Harga (Rp)";
            // 
            // FormProduk
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(500, 360);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblNamaProduk);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            Controls.Add(tbNama);
            Controls.Add(cbJenis);
            Controls.Add(cbHewan);
            Controls.Add(tbJumlah);
            Controls.Add(tbHarga);
            Name = "FormProduk";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormProduk_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }
        private TextBox tbNama, tbJumlah, tbHarga;
        private ComboBox cbJenis, cbHewan;
        private Button btnBatal;
        private Button btnSimpan;
        private Label lblNamaProduk;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}