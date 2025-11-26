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
            panelHeader = new Panel();
            lblJudul = new Label();
            lblNama = new Label(); tbNama = new TextBox();
            lblJenis = new Label(); cbJenis = new ComboBox();
            lblHewan = new Label(); cbHewan = new ComboBox();
            lblJumlah = new Label(); tbJumlah = new TextBox();
            lblHarga = new Label(); tbHarga = new TextBox();
            btnSimpan = new Button(); btnBatal = new Button();

            panelHeader.SuspendLayout();
            SuspendLayout();

            // Header
            panelHeader.BackColor = Color.DarkGoldenrod;
            panelHeader.Controls.Add(lblJudul);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Size = new Size(500, 60);

            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblJudul.ForeColor = Color.White;
            lblJudul.Location = new Point(12, 13);
            lblJudul.Text = "Form Data Produk";

            // Inputs
            lblNama.Location = new Point(30, 80); lblNama.Text = "Nama Produk";
            tbNama.Location = new Point(30, 100); tbNama.Size = new Size(410, 23);

            lblJenis.Location = new Point(30, 140); lblJenis.Text = "Jenis Produk";
            cbJenis.Location = new Point(30, 160); cbJenis.Size = new Size(190, 23);
            cbJenis.DropDownStyle = ComboBoxStyle.DropDownList;

            lblHewan.Location = new Point(250, 140); lblHewan.Text = "Hewan Asal";
            cbHewan.Location = new Point(250, 160); cbHewan.Size = new Size(190, 23);
            cbHewan.DropDownStyle = ComboBoxStyle.DropDownList;

            lblJumlah.Location = new Point(30, 200); lblJumlah.Text = "Jumlah Stok";
            tbJumlah.Location = new Point(30, 220); tbJumlah.Size = new Size(190, 23);

            lblHarga.Location = new Point(250, 200); lblHarga.Text = "Harga (Rp)";
            tbHarga.Location = new Point(250, 220); tbHarga.Size = new Size(190, 23);

            // Buttons
            btnSimpan.BackColor = Color.ForestGreen;
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(270, 280);
            btnSimpan.Size = new Size(170, 45);
            btnSimpan.Text = "SIMPAN";
            btnSimpan.Click += btnSimpan_Click;

            //btnBatal.BackColor = Color.Firebrick;
            //btnBatal.ForeColor = Color.White;
            //btnBatal.Location = new Point(30, 280);
            //btnBatal.Size = new Size(170, 45);
            //btnBatal.Text = "BATAL";
            //btnBatal.

            // Form
            ClientSize = new Size(500, 360);
            Controls.Add(panelHeader);
            Controls.Add(lblNama); Controls.Add(tbNama);
            Controls.Add(lblJenis); Controls.Add(cbJenis);
            Controls.Add(lblHewan); Controls.Add(cbHewan);
            Controls.Add(lblJumlah); Controls.Add(tbJumlah);
            Controls.Add(lblHarga); Controls.Add(tbHarga);
            Controls.Add(btnSimpan); Controls.Add(btnBatal);
            StartPosition = FormStartPosition.CenterScreen;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel panelHeader;
        private Label lblJudul, lblNama, lblJenis, lblHewan, lblJumlah, lblHarga;
        private TextBox tbNama, tbJumlah, tbHarga;
        private ComboBox cbJenis, cbHewan;
        private Button btnSimpan, btnBatal;
    }
}