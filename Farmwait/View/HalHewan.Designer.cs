namespace Farmwait.View
{
    partial class HalHewan
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HalHewan));
            btnTambah = new Button();
            dgvHewan = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvHewan).BeginInit();
            SuspendLayout();
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.FromArgb(192, 0, 0);
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Nirmala UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(1007, 65);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(100, 43);
            btnTambah.TabIndex = 1;
            btnTambah.Text = "+ Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            // 
            // dgvHewan
            // 
            dgvHewan.AllowUserToAddRows = false;
            dgvHewan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHewan.BackgroundColor = Color.WhiteSmoke;
            dgvHewan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHewan.Location = new Point(30, 180);
            dgvHewan.Name = "dgvHewan";
            dgvHewan.ReadOnly = true;
            dgvHewan.RowTemplate.Height = 35;
            dgvHewan.Size = new Size(1077, 579);
            dgvHewan.TabIndex = 2;
            dgvHewan.CellContentClick += dgvHewan_CellContentClick_1;
            // 
            // HalHewan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1136, 825);
            Controls.Add(dgvHewan);
            Controls.Add(btnTambah);
            Name = "HalHewan";
            Text = "Halaman Hewan";
            ((System.ComponentModel.ISupportInitialize)dgvHewan).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnTambah;
        private DataGridView dgvHewan;
    }
}