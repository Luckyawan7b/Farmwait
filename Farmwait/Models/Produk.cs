using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Farmwait.Models
{
    // [INHERITANCE] Produk adalah ItemGudang
    public class Produk : ItemGudang
    {
        // [ENCAPSULATION] Property khusus produk
        public string JenisProduk { get; set; }
        public int IdHewan { get; set; } // Relasi ke hewan asal
        public int JumlahProduk { get; set; }
        public int HargaProduk { get; set; }

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

        // [POLIMORFISME] Method Instance Update Data
        // Method untuk mengurangi stok setelah pembelian sukses
        public static void KurangiStok(int idProduk, int jumlahDibeli)
        {
            try
            {
                using (var conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    // Query UPDATE matematika sederhana (Stok Lama - Jumlah Beli)
                    string sql = "UPDATE public.produk SET jumlahproduk = jumlahproduk - @dibeli WHERE idproduk = @id";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@dibeli", jumlahDibeli);
                        cmd.Parameters.AddWithValue("@id", idProduk);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal update stok: " + ex.Message);
            }
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
        // [POLYMORPHISM] Method Instance untuk Soft Delete
        public bool HapusData()
        {
            try
            {
                using (var conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    // Soft Delete: is_deleted = true
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

        // Static Method: Load Data (WHERE is_deleted = false)
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
                        using (var reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Load Produk: " + ex.Message);
            }
            return dt;
        }
    }
}