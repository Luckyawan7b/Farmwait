using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Farmwait.Models
{
    // Transaksi berdiri sendiri, tidak perlu inherit ItemGudang 
    // karena Transaksi bukan "barang" di gudang.
    public class Transaksi
    {
        // ==========================================
        // 1. PROPERTIES (Sesuai kolom Database)
        // ==========================================
        public int IdTransaksi { get; set; }
        public DateTime TanggalTransaksi { get; set; }
        public int IdAkun { get; set; }
        public string MetodePembayaran { get; set; } // Varchar di DB
        public int IdProduk { get; set; }
        public string Status { get; set; } // Varchar di DB

        // ==========================================
        // 2. METHODS (Hanya Read / SELECT)
        // ==========================================

        // Fungsi Static agar bisa dipanggil tanpa perlu 'new Transaksi()'
        public static DataTable AmbilSemua()
        {
            DataTable dt = new DataTable();

            try
            {
                using (var conn = Koneksi.GetConnection())
                {
                    conn.Open();

                    // Query mengambil semua data transaksi
                    // Tips Dosen: Bisa ditambahkan JOIN kalau mau menampilkan Nama Akun & Produk
                    string sql = "SELECT * FROM public.transaksi ORDER BY idtransaksi ASC";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            // Load data langsung ke DataTable
                            dt.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data transaksi: " + ex.Message);
            }

            return dt;
        }

        // Opsional: Fitur Filter Berdasarkan ID Akun (Misal untuk melihat riwayat user tertentu)
        public static DataTable AmbilByAkun(int idAkun)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM public.transaksi WHERE idakun = @idakun ORDER BY tanggaltransaksi DESC";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@idakun", idAkun);
                        using (var reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filter akun: " + ex.Message);
            }
            return dt;
        }

        // Method untuk mengupdate status saja
        // Method untuk mengupdate status saja
        public static void UpdateStatus(int id, string statusBaru)
        {
            try
            {
                using (var conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE public.transaksi SET status = @status WHERE idtransaksi = @id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", statusBaru);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Lempar error biar ditangkap sama Form yang manggil
                throw new Exception(ex.Message);
            }
        }

    }
}