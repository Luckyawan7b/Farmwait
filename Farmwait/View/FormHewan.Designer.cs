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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHewan));
            tbJenisHewan = new TextBox();
            cbJenisKelamin = new ComboBox();
            tbBerat = new TextBox();
            tbUsia = new TextBox();
            cbPakan = new ComboBox();
            tbPorsi = new TextBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            lblJenis = new Label();
            lblJK = new Label();
            lblBerat = new Label();
            lblUsia = new Label();
            lblPakan = new Label();
            lblPorsi = new Label();
            SuspendLayout();
            // 
            // tbJenisHewan
            // 
            tbJenisHewan.Location = new Point(30, 100);
            tbJenisHewan.Name = "tbJenisHewan";
            tbJenisHewan.Size = new Size(200, 23);
            tbJenisHewan.TabIndex = 2;
            // 
            // cbJenisKelamin
            // 
            cbJenisKelamin.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJenisKelamin.Location = new Point(260, 100);
            cbJenisKelamin.Name = "cbJenisKelamin";
            cbJenisKelamin.Size = new Size(200, 23);
            cbJenisKelamin.TabIndex = 4;
            // 
            // tbBerat
            // 
            tbBerat.Location = new Point(30, 160);
            tbBerat.Name = "tbBerat";
            tbBerat.Size = new Size(200, 23);
            tbBerat.TabIndex = 6;
            // 
            // tbUsia
            // 
            tbUsia.Location = new Point(260, 160);
            tbUsia.Name = "tbUsia";
            tbUsia.Size = new Size(200, 23);
            tbUsia.TabIndex = 8;
            // 
            // cbPakan
            // 
            cbPakan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPakan.Location = new Point(30, 220);
            cbPakan.Name = "cbPakan";
            cbPakan.Size = new Size(200, 23);
            cbPakan.TabIndex = 10;
            // 
            // tbPorsi
            // 
            tbPorsi.Location = new Point(260, 220);
            tbPorsi.Name = "tbPorsi";
            tbPorsi.Size = new Size(200, 23);
            tbPorsi.TabIndex = 12;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.ForestGreen;
            btnSimpan.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(290, 280);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(170, 45);
            btnSimpan.TabIndex = 13;
            btnSimpan.Text = "SIMPAN";
            btnSimpan.UseVisualStyleBackColor = false;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.FromArgb(192, 0, 0);
            btnBatal.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold | FontStyle.Italic);
            btnBatal.ForeColor = Color.White;
            btnBatal.Location = new Point(30, 280);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(170, 45);
            btnBatal.TabIndex = 14;
            btnBatal.Text = "BATAL";
            btnBatal.UseVisualStyleBackColor = false;
            // 
            // lblJenis
            // 
            lblJenis.AutoSize = true;
            lblJenis.BackColor = Color.Transparent;
            lblJenis.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJenis.Location = new Point(30, 79);
            lblJenis.Name = "lblJenis";
            lblJenis.Size = new Size(85, 18);
            lblJenis.TabIndex = 15;
            lblJenis.Text = "Jenis Hewan";
            // 
            // lblJK
            // 
            lblJK.AutoSize = true;
            lblJK.BackColor = Color.Transparent;
            lblJK.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJK.Location = new Point(260, 79);
            lblJK.Name = "lblJK";
            lblJK.Size = new Size(93, 18);
            lblJK.TabIndex = 16;
            lblJK.Text = "Jenis Kelamin";
            // 
            // lblBerat
            // 
            lblBerat.AutoSize = true;
            lblBerat.BackColor = Color.Transparent;
            lblBerat.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBerat.Location = new Point(30, 139);
            lblBerat.Name = "lblBerat";
            lblBerat.Size = new Size(85, 18);
            lblBerat.TabIndex = 17;
            lblBerat.Text = "Berat (gram)";
            // 
            // lblUsia
            // 
            lblUsia.AutoSize = true;
            lblUsia.BackColor = Color.Transparent;
            lblUsia.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsia.Location = new Point(260, 139);
            lblUsia.Name = "lblUsia";
            lblUsia.Size = new Size(71, 18);
            lblUsia.TabIndex = 18;
            lblUsia.Text = "Usia (hari)";
            // 
            // lblPakan
            // 
            lblPakan.AutoSize = true;
            lblPakan.BackColor = Color.Transparent;
            lblPakan.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPakan.Location = new Point(30, 199);
            lblPakan.Name = "lblPakan";
            lblPakan.Size = new Size(79, 18);
            lblPakan.TabIndex = 19;
            lblPakan.Text = "Jenis Pakan";
            // 
            // lblPorsi
            // 
            lblPorsi.AutoSize = true;
            lblPorsi.BackColor = Color.Transparent;
            lblPorsi.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPorsi.Location = new Point(260, 199);
            lblPorsi.Name = "lblPorsi";
            lblPorsi.Size = new Size(79, 18);
            lblPorsi.TabIndex = 20;
            lblPorsi.Text = "Porsi Pakan";
            // 
            // FormHewan
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(500, 360);
            Controls.Add(lblPorsi);
            Controls.Add(lblPakan);
            Controls.Add(lblUsia);
            Controls.Add(lblBerat);
            Controls.Add(lblJK);
            Controls.Add(lblJenis);
            Controls.Add(tbJenisHewan);
            Controls.Add(cbJenisKelamin);
            Controls.Add(tbBerat);
            Controls.Add(tbUsia);
            Controls.Add(cbPakan);
            Controls.Add(tbPorsi);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormHewan";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }
        private TextBox tbJenisHewan, tbBerat, tbUsia, tbPorsi;
        private ComboBox cbJenisKelamin, cbPakan;
        private Button btnSimpan, btnBatal;
        private Label lblJenis;
        private Label lblJK;
        private Label lblBerat;
        private Label lblUsia;
        private Label lblPakan;
        private Label lblPorsi;
    }
}