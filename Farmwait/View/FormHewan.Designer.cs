namespace Farmwait.View
{
    partial class FormHewan
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
            lblJenis = new Label();
            tbJenisHewan = new TextBox();
            lblJK = new Label();
            cbJenisKelamin = new ComboBox();
            lblBerat = new Label();
            tbBerat = new TextBox();
            lblUsia = new Label();
            tbUsia = new TextBox();
            lblPakan = new Label();
            cbPakan = new ComboBox();
            lblPorsi = new Label();
            tbPorsi = new TextBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            panelHeader = new Panel();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader & lblJudul
            // 
            panelHeader.BackColor = Color.Teal;
            panelHeader.Controls.Add(lblJudul);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Size = new Size(500, 60);
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblJudul.ForeColor = Color.White;
            lblJudul.Location = new Point(12, 13);
            lblJudul.Text = "Form Data Hewan";
            // 
            // Input Fields
            // 
            lblJenis.Location = new Point(30, 80); lblJenis.Text = "Jenis Hewan (Cth: Ayam Broiler)";
            tbJenisHewan.Location = new Point(30, 100); tbJenisHewan.Size = new Size(200, 23);

            lblJK.Location = new Point(260, 80); lblJK.Text = "Jenis Kelamin";
            cbJenisKelamin.Location = new Point(260, 100); cbJenisKelamin.Size = new Size(200, 23);
            cbJenisKelamin.DropDownStyle = ComboBoxStyle.DropDownList;

            lblBerat.Location = new Point(30, 140); lblBerat.Text = "Berat (gram)";
            tbBerat.Location = new Point(30, 160); tbBerat.Size = new Size(200, 23);

            lblUsia.Location = new Point(260, 140); lblUsia.Text = "Usia (hari)";
            tbUsia.Location = new Point(260, 160); tbUsia.Size = new Size(200, 23);

            lblPakan.Location = new Point(30, 200); lblPakan.Text = "Jenis Pakan";
            cbPakan.Location = new Point(30, 220); cbPakan.Size = new Size(200, 23);
            cbPakan.DropDownStyle = ComboBoxStyle.DropDownList;

            lblPorsi.Location = new Point(260, 200); lblPorsi.Text = "Porsi Pakan (gram)";
            tbPorsi.Location = new Point(260, 220); tbPorsi.Size = new Size(200, 23);

            // Buttons
            btnSimpan.BackColor = Color.ForestGreen;
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(290, 280);
            btnSimpan.Size = new Size(170, 45);
            btnSimpan.Text = "SIMPAN";
            btnSimpan.UseVisualStyleBackColor = false;

            btnBatal.BackColor = Color.Firebrick;
            btnBatal.ForeColor = Color.White;
            btnBatal.Location = new Point(30, 280);
            btnBatal.Size = new Size(170, 45);
            btnBatal.Text = "BATAL";
            btnBatal.UseVisualStyleBackColor = false;

            // Form Setup
            ClientSize = new Size(500, 360);
            Controls.Add(panelHeader);
            Controls.Add(lblJenis); Controls.Add(tbJenisHewan);
            Controls.Add(lblJK); Controls.Add(cbJenisKelamin);
            Controls.Add(lblBerat); Controls.Add(tbBerat);
            Controls.Add(lblUsia); Controls.Add(tbUsia);
            Controls.Add(lblPakan); Controls.Add(cbPakan);
            Controls.Add(lblPorsi); Controls.Add(tbPorsi);
            Controls.Add(btnSimpan); Controls.Add(btnBatal);
            StartPosition = FormStartPosition.CenterScreen;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel panelHeader;
        private Label lblJudul, lblJenis, lblJK, lblBerat, lblUsia, lblPakan, lblPorsi;
        private TextBox tbJenisHewan, tbBerat, tbUsia, tbPorsi;
        private ComboBox cbJenisKelamin, cbPakan;
        private Button btnSimpan, btnBatal;
    }
}