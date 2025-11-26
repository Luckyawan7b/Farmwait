namespace Farmwait.View
{
    partial class FormPakan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPakan));
            lblNama = new Label();
            tbNamaPakan = new TextBox();
            lblStok = new Label();
            tbStokPakan = new TextBox();
            lblHarga = new Label();
            tbHargaPakan = new TextBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            SuspendLayout();
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.BackColor = Color.Transparent;
            lblNama.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            lblNama.Location = new Point(40, 90);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(107, 23);
            lblNama.TabIndex = 1;
            lblNama.Text = "Nama Pakan";
            // 
            // tbNamaPakan
            // 
            tbNamaPakan.Font = new Font("Segoe UI", 12F);
            tbNamaPakan.Location = new Point(40, 114);
            tbNamaPakan.Name = "tbNamaPakan";
            tbNamaPakan.Size = new Size(410, 29);
            tbNamaPakan.TabIndex = 2;
            // 
            // lblStok
            // 
            lblStok.AutoSize = true;
            lblStok.BackColor = Color.Transparent;
            lblStok.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            lblStok.Location = new Point(40, 160);
            lblStok.Name = "lblStok";
            lblStok.Size = new Size(96, 23);
            lblStok.TabIndex = 3;
            lblStok.Text = "Stok Pakan";
            // 
            // tbStokPakan
            // 
            tbStokPakan.Font = new Font("Segoe UI", 12F);
            tbStokPakan.Location = new Point(40, 184);
            tbStokPakan.Name = "tbStokPakan";
            tbStokPakan.Size = new Size(410, 29);
            tbStokPakan.TabIndex = 4;
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.BackColor = Color.Transparent;
            lblHarga.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
            lblHarga.Location = new Point(40, 230);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(144, 23);
            lblHarga.TabIndex = 5;
            lblHarga.Text = "Harga Pakan (Rp)";
            // 
            // tbHargaPakan
            // 
            tbHargaPakan.Font = new Font("Segoe UI", 12F);
            tbHargaPakan.Location = new Point(40, 254);
            tbHargaPakan.Name = "tbHargaPakan";
            tbHargaPakan.Size = new Size(410, 29);
            tbHargaPakan.TabIndex = 6;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.ForestGreen;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold | FontStyle.Italic);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(280, 320);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(170, 45);
            btnSimpan.TabIndex = 7;
            btnSimpan.Text = "SIMPAN";
            btnSimpan.UseVisualStyleBackColor = false;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Firebrick;
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold | FontStyle.Italic);
            btnBatal.ForeColor = Color.White;
            btnBatal.Location = new Point(40, 320);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(170, 45);
            btnBatal.TabIndex = 9;
            btnBatal.Text = "BATAL";
            btnBatal.UseVisualStyleBackColor = false;
            // 
            // FormPakan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(500, 400);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(tbHargaPakan);
            Controls.Add(lblHarga);
            Controls.Add(tbStokPakan);
            Controls.Add(lblStok);
            Controls.Add(tbNamaPakan);
            Controls.Add(lblNama);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPakan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Input Data Pakan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblNama;
        public System.Windows.Forms.TextBox tbNamaPakan; // Public agar bisa diakses Controller nanti
        private System.Windows.Forms.Label lblStok;
        public System.Windows.Forms.TextBox tbStokPakan;
        private System.Windows.Forms.Label lblHarga;
        public System.Windows.Forms.TextBox tbHargaPakan;
        public System.Windows.Forms.Button btnSimpan;
        public System.Windows.Forms.Button btnBatal;
    }
}