using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Farmwait.Models
{
    // [INHERITANCE] Produk adalah ItemGudang
    public class Produk : ItemGudang
    {
        // ==========================================
        // 1. ENKAPSULASI: PRIVATE FIELDS
        // ==========================================
        private string _jenisProduk;
        private int _idHewan;
        private int _jumlahProduk;
        private int _hargaProduk;

        // ==========================================
        // 2. ENKAPSULASI: PUBLIC PROPERTIES
        // ==========================================
        public string JenisProduk
        {
            get { return _jenisProduk; }
            set { _jenisProduk = value; }
        }

        public int IdHewan
        {
            get { return _idHewan; }
            set { _idHewan = value; }
        }

        public int JumlahProduk
        {
            get { return _jumlahProduk; }
            set
            {
                if (value < 0) _jumlahProduk = 0; // Stok tidak boleh minus
                else _jumlahProduk = value;
            }
        }

        public int HargaProduk
        {
            get { return _hargaProduk; }
            set
            {
                if (value < 0) _hargaProduk = 0; // Harga tidak boleh minus
                else _hargaProduk = value;
            }
        }


        // ==========================================
        // 3. METHODS
        // ==========================================

        // [ABSTRACTION] Implementasi method abstrak
        public override string GetInfoLengkap()
        {
            return $"{Nama} ({JenisProduk}) - Stok: {JumlahProduk}";
        }

        // [POLIMORFISME] Method Instance Tambah Data
        public bool TambahData()
        {
            try
            {
                using (var conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string query = @"INSERT INTO public.produk 
                                     (namaproduk, jenisproduk, idhewan, jumlahproduk, hargaproduk, is_deleted) 
                                     VALUES (@nama, @jenis, @idhewan, @jumlah, @harga, false)";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", this.Nama);
                        cmd.Parameters.AddWithValue("@jenis", this.JenisProduk);
                        cmd.Parameters.AddWithValue("@idhewan", this.IdHewan);
                        cmd.Parameters.AddWithValue("@jumlah", this.JumlahProduk);
                        cmd.Parameters.AddWithValue("@harga", this.HargaProduk);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Tambah Produk: " + ex.Message);
                return false;
            }
        }

        public static void KurangiStok(int idProduk, int jumlahDibeli)
        {
            try
            {
                using (var conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string sql = "UPDATE public.produk SET jumlahproduk = jumlahproduk - @dibeli WHERE idproduk = @id";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@dibeli", jumlahDibeli);
                        cmd.Parameters.AddWithValue("@id", idProduk);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { throw new Exception("Gagal update stok: " + ex.Message); }
        }

        public bool UpdateData()
        {
            try
            {
                using (var conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string query = @"UPDATE public.produk 
                                     SET namaproduk=@nama, jenisproduk=@jenis, idhewan=@idhewan, 
                                         jumlahproduk=@jumlah, hargaproduk=@harga 
                                     WHERE idproduk=@id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", this.Nama);
                        cmd.Parameters.AddWithValue("@jenis", this.JenisProduk);
                        cmd.Parameters.AddWithValue("@idhewan", this.IdHewan);
                        cmd.Parameters.AddWithValue("@jumlah", this.JumlahProduk);
                        cmd.Parameters.AddWithValue("@harga", this.HargaProduk);
                        cmd.Parameters.AddWithValue("@id", this.Id);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Update Produk: " + ex.Message);
                return false;
            }
        }

        public bool HapusData()
        {
            try
            {
                using (var conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE public.produk SET is_deleted = true WHERE idproduk = @id";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", this.Id);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Hapus Produk: " + ex.Message);
                return false;
            }
        }

        public static DataTable AmbilSemuaProduk()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT idproduk, namaproduk, jenisproduk, idhewan, jumlahproduk, hargaproduk 
                                     FROM public.produk 
                                     WHERE is_deleted = false 
                                     ORDER BY idproduk ASC";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader()) dt.Load(reader);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error Load Produk: " + ex.Message); }
            return dt;
        }
    }
}