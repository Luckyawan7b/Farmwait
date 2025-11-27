namespace Farmwait.View
{
    partial class HalTransaksiPeternak
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
            components = new System.ComponentModel.Container();
            dgvTransaksi = new DataGridView();
            transaksiBindingSource = new BindingSource(components);
            idTransaksi = new DataGridViewTextBoxColumn();
            tanggalTransaksi = new DataGridViewTextBoxColumn();
            idAkun = new DataGridViewTextBoxColumn();
            metodePembayaran = new DataGridViewTextBoxColumn();
            idProduk = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transaksiBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvTransaksi
            // 
            dgvTransaksi.AutoGenerateColumns = false;
            dgvTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransaksi.Columns.AddRange(new DataGridViewColumn[] { idTransaksi, tanggalTransaksi, idAkun, metodePembayaran, idProduk, status, colEdit });
            dgvTransaksi.DataSource = transaksiBindingSource;
            dgvTransaksi.Location = new Point(24, 118);
            dgvTransaksi.Name = "dgvTransaksi";
            dgvTransaksi.Size = new Size(1076, 550);
            dgvTransaksi.TabIndex = 0;
            dgvTransaksi.CellContentClick += dgvTransaksi_CellContentClick;
            // 
            // transaksiBindingSource
            // 
            transaksiBindingSource.DataSource = typeof(Models.Transaksi);
            // 
            // idTransaksi
            // 
            idTransaksi.DataPropertyName = "IdTransaksi";
            idTransaksi.HeaderText = "IdTransaksi";
            idTransaksi.Name = "idTransaksi";
            // 
            // tanggalTransaksi
            // 
            tanggalTransaksi.DataPropertyName = "TanggalTransaksi";
            tanggalTransaksi.HeaderText = "TanggalTransaksi";
            tanggalTransaksi.Name = "tanggalTransaksi";
            // 
            // idAkun
            // 
            idAkun.DataPropertyName = "IdAkun";
            idAkun.HeaderText = "IdAkun";
            idAkun.Name = "idAkun";
            // 
            // metodePembayaran
            // 
            metodePembayaran.DataPropertyName = "MetodePembayaran";
            metodePembayaran.HeaderText = "MetodePembayaran";
            metodePembayaran.Name = "metodePembayaran";
            // 
            // idProduk
            // 
            idProduk.DataPropertyName = "IdProduk";
            idProduk.HeaderText = "IdProduk";
            idProduk.Name = "idProduk";
            // 
            // status
            // 
            status.DataPropertyName = "Status";
            status.HeaderText = "Status";
            status.Name = "status";
            // 
            // colEdit
            // 
            colEdit.DataPropertyName = "IdTransaksi";
            colEdit.HeaderText = "Aksi";
            colEdit.Name = "colEdit";
            colEdit.Text = "EDIT";
            colEdit.UseColumnTextForButtonValue = true;
            // 
            // HalTransaksiPeternak
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 825);
            Controls.Add(dgvTransaksi);
            Name = "HalTransaksiPeternak";
            Text = "HalTransaksiPeternak";
            Load += HalTransaksiPeternak_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).EndInit();
            ((System.ComponentModel.ISupportInitialize)transaksiBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTransaksi;
        private BindingSource transaksiBindingSource;
        private DataGridViewTextBoxColumn idTransaksi;
        private DataGridViewTextBoxColumn tanggalTransaksi;
        private DataGridViewTextBoxColumn idAkun;
        private DataGridViewTextBoxColumn metodePembayaran;
        private DataGridViewTextBoxColumn idProduk;
        private DataGridViewTextBoxColumn status;
        private DataGridViewButtonColumn colEdit;
    }
}