namespace Farmwait.View
{
    partial class HalAkun
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HalAkun));
            panelAdmin = new Panel();
            dgvAkun = new DataGridView();
            lblJudulAdmin = new Label();
            panelUser = new Panel();
            lblInfoUser = new Label();
            btnEditProfil = new Button();
            btnKembali = new Button();
            lblJudulUser = new Label();
            panelAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAkun).BeginInit();
            panelUser.SuspendLayout();
            SuspendLayout();
            // 
            // panelAdmin
            // 
            panelAdmin.BackgroundImage = (Image)resources.GetObject("panelAdmin.BackgroundImage");
            panelAdmin.Controls.Add(dgvAkun);
            panelAdmin.Controls.Add(lblJudulAdmin);
            panelAdmin.Dock = DockStyle.Fill;
            panelAdmin.Location = new Point(0, 0);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(1136, 825);
            panelAdmin.TabIndex = 0;
            panelAdmin.Visible = false;
            panelAdmin.Paint += panelAdmin_Paint;
            // 
            // dgvAkun
            // 
            dgvAkun.AllowUserToAddRows = false;
            dgvAkun.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAkun.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAkun.Location = new Point(43, 153);
            dgvAkun.Name = "dgvAkun";
            dgvAkun.Size = new Size(1054, 640);
            dgvAkun.TabIndex = 0;
            // 
            // lblJudulAdmin
            // 
            lblJudulAdmin.Location = new Point(0, 0);
            lblJudulAdmin.Name = "lblJudulAdmin";
            lblJudulAdmin.Size = new Size(100, 23);
            lblJudulAdmin.TabIndex = 2;
            // 
            // panelUser
            // 
            panelUser.Controls.Add(lblInfoUser);
            panelUser.Controls.Add(btnEditProfil);
            panelUser.Controls.Add(btnKembali);
            panelUser.Controls.Add(lblJudulUser);
            panelUser.Dock = DockStyle.Fill;
            panelUser.Location = new Point(0, 0);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(1136, 825);
            panelUser.TabIndex = 1;
            panelUser.Visible = false;
            // 
            // lblInfoUser
            // 
            lblInfoUser.Font = new Font("Segoe UI", 12F);
            lblInfoUser.Location = new Point(50, 80);
            lblInfoUser.Name = "lblInfoUser";
            lblInfoUser.Size = new Size(400, 300);
            lblInfoUser.TabIndex = 0;
            lblInfoUser.Text = "Loading...";
            // 
            // btnEditProfil
            // 
            btnEditProfil.BackColor = Color.Orange;
            btnEditProfil.ForeColor = Color.White;
            btnEditProfil.Location = new Point(50, 400);
            btnEditProfil.Name = "btnEditProfil";
            btnEditProfil.Size = new Size(150, 40);
            btnEditProfil.TabIndex = 1;
            btnEditProfil.Text = "EDIT PROFIL";
            btnEditProfil.UseVisualStyleBackColor = false;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Gray;
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(220, 400);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(150, 40);
            btnKembali.TabIndex = 2;
            btnKembali.Text = "KEMBALI KE TABEL";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Visible = false;
            // 
            // lblJudulUser
            // 
            lblJudulUser.Location = new Point(0, 0);
            lblJudulUser.Name = "lblJudulUser";
            lblJudulUser.Size = new Size(100, 23);
            lblJudulUser.TabIndex = 3;
            // 
            // HalAkun
            // 
            ClientSize = new Size(1136, 825);
            Controls.Add(panelAdmin);
            Controls.Add(panelUser);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HalAkun";
            Text = "Profil Akun";
            panelAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAkun).EndInit();
            panelUser.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel panelAdmin;
        private DataGridView dgvAkun;
        private Label lblJudulAdmin;

        private Panel panelUser;
        private Label lblInfoUser;
        private Button btnEditProfil;
        private Button btnKembali;
        private Label lblJudulUser;
    }
}