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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HalPakan));
            dgvPakan = new DataGridView();
            btnTambah = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPakan).BeginInit();
            SuspendLayout();
            // 
            // dgvPakan
            // 
            dgvPakan.AllowUserToAddRows = false;
            dgvPakan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPakan.BackgroundColor = Color.White;
            dgvPakan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPakan.Location = new Point(36, 180);
            dgvPakan.Name = "dgvPakan";
            dgvPakan.ReadOnly = true;
            dgvPakan.RowTemplate.Height = 35;
            dgvPakan.Size = new Size(1046, 506);
            dgvPakan.TabIndex = 0;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.FromArgb(192, 0, 0);
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(962, 60);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(120, 40);
            btnTambah.TabIndex = 1;
            btnTambah.Text = "+ Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            // 
            // HalPakan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1136, 825);
            Controls.Add(btnTambah);
            Controls.Add(dgvPakan);
            Name = "HalPakan";
            Text = "Halaman Pakan";
            ((System.ComponentModel.ISupportInitialize)dgvPakan).EndInit();
            ResumeLayout(false);
        }

        private DataGridView dgvPakan;
        private Button btnTambah;
    }
}