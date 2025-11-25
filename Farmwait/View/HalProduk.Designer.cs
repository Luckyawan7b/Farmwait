namespace Farmwait.View
{
    partial class HalProduk
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblJudul = new Label();
            btnTambah = new Button();
            dgvProduk = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProduk).BeginInit();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblJudul.Location = new Point(20, 20);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(265, 37);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Manajemen Produk";
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.ForestGreen;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(650, 25);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(120, 40);
            btnTambah.TabIndex = 1;
            btnTambah.Text = "+ Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            // 
            // dgvProduk
            // 
            dgvProduk.AllowUserToAddRows = false;
            dgvProduk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduk.BackgroundColor = Color.White;
            dgvProduk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduk.Location = new Point(20, 80);
            dgvProduk.Name = "dgvProduk";
            dgvProduk.ReadOnly = true;
            dgvProduk.RowTemplate.Height = 35;
            dgvProduk.Size = new Size(750, 350);
            dgvProduk.TabIndex = 2;
            // 
            // HalProduk
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProduk);
            Controls.Add(btnTambah);
            Controls.Add(lblJudul);
            Name = "HalProduk";
            Text = "Halaman Produk";
            ((System.ComponentModel.ISupportInitialize)dgvProduk).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblJudul;
        private Button btnTambah;
        private DataGridView dgvProduk;
    }
}