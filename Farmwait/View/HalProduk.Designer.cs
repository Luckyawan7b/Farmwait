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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HalProduk));
            btnTambah = new Button();
            dgvProduk = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProduk).BeginInit();
            SuspendLayout();
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.FromArgb(192, 0, 0);
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(912, 48);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(184, 61);
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
            dgvProduk.Location = new Point(32, 177);
            dgvProduk.Name = "dgvProduk";
            dgvProduk.ReadOnly = true;
            dgvProduk.RowTemplate.Height = 35;
            dgvProduk.Size = new Size(1075, 586);
            dgvProduk.TabIndex = 2;
            // 
            // HalProduk
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1136, 825);
            Controls.Add(dgvProduk);
            Controls.Add(btnTambah);
            Name = "HalProduk";
            Text = "Halaman Produk";
            ((System.ComponentModel.ISupportInitialize)dgvProduk).EndInit();
            ResumeLayout(false);
        }
        private Button btnTambah;
        private DataGridView dgvProduk;
    }
}