using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Farmwait.Models
{
    public class Transaksi
    {
        // ==========================================
        // 1. ENKAPSULASI: PRIVATE FIELDS
        // ==========================================
        private int _idTransaksi;
        private DateTime _tanggalTransaksi;
        private int _idAkun;
        private string _metodePembayaran;
        private int _idProduk;
        private string _status;
        private int _jumlah;
        private int _totalHarga;

        // ==========================================
        // 2. ENKAPSULASI: PUBLIC PROPERTIES
        // ==========================================
        public int IdTransaksi
        {
            get { return _idTransaksi; }
            set { _idTransaksi = value; }
        }

        public DateTime TanggalTransaksi
        {
            get { return _tanggalTransaksi; }
            set { _tanggalTransaksi = value; }
        }

        public int IdAkun
        {
            get { return _idAkun; }
            set { _idAkun = value; }
        }

        public string MetodePembayaran
        {
            get { return _metodePembayaran; }
            set { _metodePembayaran = value; }
        }

        public int IdProduk
        {
            get { return _idProduk; }
            set { _idProduk = value; }
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        // Tambahan Property untuk Jumlah & Total (sesuai database)
        public int Jumlah
        {
            get { return _jumlah; }
            set { _jumlah = value; }
        }

        public int TotalHarga
        {
            get { return _totalHarga; }
            set { _totalHarga = value; }
        }

        // ==========================================
        // 3. METHODS
        // ==========================================

        // Method AmbilSemua yang SUDAH DIMODIFIKASI dengan JOIN
        public static DataTable AmbilSemua()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = Koneksi.GetConnection())
                {
                    conn.Open();

                    // QUERY JOIN: Mengambil namaproduk dari tabel produk
                    string sql = @"
                        SELECT 
                            t.idtransaksi, 
                            t.tanggaltransaksi, 
                            t.idakun, 
                            t.metodepembayaran, 
                            p.namaproduk,   -- Ambil Nama Produk
                            t.jumlah,       -- Ambil Jumlah
                            t.totalharga, 
                            t.status
                        FROM public.transaksi t
                        JOIN public.produk p ON t.idproduk = p.idproduk
                        ORDER BY t.idtransaksi ASC";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        using (var reader = cmd.ExecuteReader()) dt.Load(reader);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Gagal mengambil data transaksi: " + ex.Message); }
            return dt;
        }

        public static void TambahTransaksi(DateTime tgl, int idAkun, string metode, int idProduk, int jumlah, int total)
        {
            try
            {
                using (var conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string sql = @"INSERT INTO public.transaksi 
                                   (tanggaltransaksi, idakun, metodepembayaran, idproduk, status, jumlah, totalharga) 
                                   VALUES 
                                   (@tgl, @idakun, @metode, @idproduk, 'Proses', @jumlah, @total)";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@tgl", tgl);
                        cmd.Parameters.AddWithValue("@idakun", idAkun);
                        cmd.Parameters.AddWithValue("@metode", metode);
                        cmd.Parameters.AddWithValue("@idproduk", idProduk);
                        cmd.Parameters.AddWithValue("@jumlah", jumlah);
                        cmd.Parameters.AddWithValue("@total", total);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal simpan ke database: " + ex.Message);
            }
        }

        public static DataTable AmbilByAkun(int idAkun)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    // Untuk user history, sementara kita pakai SELECT * dulu
                    // Kalau mau nama produk juga, bisa di-JOIN-kan seperti AmbilSemua
                    string sql = @"
                        SELECT 
                            t.idtransaksi, 
                            t.tanggaltransaksi, 
                            t.idakun, 
                            t.metodepembayaran, 
                            p.namaproduk,   -- Penting: Ambil Nama Produk
                            t.jumlah,       -- Penting: Ambil Jumlah
                            t.totalharga, 
                            t.status
                        FROM public.transaksi t
                        JOIN public.produk p ON t.idproduk = p.idproduk
                        WHERE t.idakun = @idakun
                        ORDER BY t.tanggaltransaksi DESC";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@idakun", idAkun);
                        using (var reader = cmd.ExecuteReader()) dt.Load(reader);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error filter akun: " + ex.Message); }
            return dt;
        }

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
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}