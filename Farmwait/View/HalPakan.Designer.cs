namespace Farmwait.View
{
    partial class HalPakan
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvPakan = new DataGridView();
            btnTambah = new Button();
            lblJudul = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPakan).BeginInit();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblJudul.Location = new Point(20, 20);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(250, 37);
            lblJudul.Text = "Daftar Stok Pakan";
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
            // dgvPakan
            // 
            dgvPakan.AllowUserToAddRows = false;
            dgvPakan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPakan.BackgroundColor = Color.White;
            dgvPakan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPakan.Location = new Point(20, 80);
            dgvPakan.Name = "dgvPakan";
            dgvPakan.ReadOnly = true; // Biar tidak diedit langsung di grid
            dgvPakan.RowTemplate.Height = 35; // Tinggi baris biar tombol Edit muat
            dgvPakan.Size = new Size(750, 350);
            dgvPakan.TabIndex = 0;
            // 
            // HalPakan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblJudul);
            Controls.Add(btnTambah);
            Controls.Add(dgvPakan);
            Name = "HalPakan";
            Text = "Halaman Pakan";
            ((System.ComponentModel.ISupportInitialize)dgvPakan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dgvPakan;
        private Button btnTambah;
        private Label lblJudul;
    }
}