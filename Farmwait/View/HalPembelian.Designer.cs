namespace Farmwait.View
{
    partial class HalPembelian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HalPembelian));
            dgvPembelian = new DataGridView();
            colIDProduk = new DataGridViewTextBoxColumn();
            colNamaProduk = new DataGridViewTextBoxColumn();
            jenisProduk = new DataGridViewTextBoxColumn();
            idHewan = new DataGridViewTextBoxColumn();
            jumlahProduk = new DataGridViewTextBoxColumn();
            hargaProduk = new DataGridViewTextBoxColumn();
            colBeli = new DataGridViewButtonColumn();
            produkBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvPembelian).BeginInit();
            ((System.ComponentModel.ISupportInitialize)produkBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvPembelian
            // 
            dgvPembelian.AutoGenerateColumns = false;
            dgvPembelian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPembelian.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPembelian.Columns.AddRange(new DataGridViewColumn[] { colIDProduk, colNamaProduk, jenisProduk, idHewan, jumlahProduk, hargaProduk, colBeli });
            dgvPembelian.DataSource = produkBindingSource;
            dgvPembelian.Location = new Point(37, 168);
            dgvPembelian.Name = "dgvPembelian";
            dgvPembelian.Size = new Size(1071, 492);
            dgvPembelian.TabIndex = 0;
            dgvPembelian.CellContentClick += dgvPembelian_CellContentClick;
            // 
            // colIDProduk
            // 
            colIDProduk.DataPropertyName = "idproduk";
            colIDProduk.HeaderText = "Id";
            colIDProduk.Name = "colIDProduk";
            // 
            // colNamaProduk
            // 
            colNamaProduk.DataPropertyName = "namaproduk";
            colNamaProduk.HeaderText = "Nama";
            colNamaProduk.Name = "colNamaProduk";
            // 
            // jenisProduk
            // 
            jenisProduk.DataPropertyName = "JenisProduk";
            jenisProduk.HeaderText = "JenisProduk";
            jenisProduk.Name = "jenisProduk";
            // 
            // idHewan
            // 
            idHewan.DataPropertyName = "IdHewan";
            idHewan.HeaderText = "IdHewan";
            idHewan.Name = "idHewan";
            // 
            // jumlahProduk
            // 
            jumlahProduk.DataPropertyName = "JumlahProduk";
            jumlahProduk.HeaderText = "JumlahProduk";
            jumlahProduk.Name = "jumlahProduk";
            // 
            // hargaProduk
            // 
            hargaProduk.DataPropertyName = "HargaProduk";
            hargaProduk.HeaderText = "HargaProduk";
            hargaProduk.Name = "hargaProduk";
            // 
            // colBeli
            // 
            colBeli.DataPropertyName = "colBeli";
            colBeli.HeaderText = "Aksi";
            colBeli.Name = "colBeli";
            colBeli.Text = "BELI";
            colBeli.UseColumnTextForButtonValue = true;
            // 
            // produkBindingSource
            // 
            produkBindingSource.DataSource = typeof(Models.Produk);
            // 
            // HalTransaksiPembeli
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1136, 825);
            Controls.Add(dgvPembelian);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HalTransaksiPembeli";
            Text = "HalTransaksiPembeli";
            Load += HalTransaksiPembeli_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPembelian).EndInit();
            ((System.ComponentModel.ISupportInitialize)produkBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPembelian;
        private BindingSource produkBindingSource;
        private DataGridViewTextBoxColumn idProduk;
        private DataGridViewTextBoxColumn namaProduk;
        private DataGridViewTextBoxColumn colIDProduk;
        private DataGridViewTextBoxColumn colNamaProduk;
        private DataGridViewTextBoxColumn jenisProduk;
        private DataGridViewTextBoxColumn idHewan;
        private DataGridViewTextBoxColumn jumlahProduk;
        private DataGridViewTextBoxColumn hargaProduk;
        private DataGridViewButtonColumn colBeli;
    }
}