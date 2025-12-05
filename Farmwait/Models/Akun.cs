using Npgsql;
using System;
using System.Data;
using System.Windows.Forms; // Untuk MessageBox

namespace Farmwait.Models
{
    public class Akun
    {
        // ==========================================
        // 1. ENKAPSULASI: PRIVATE FIELDS (BACKING FIELDS)
        // ==========================================
        // Variable ini hanya bisa diakses di dalam class ini saja
        private int _idAkun;
        private string _username;
        private string _password;
        private string _nama;
        private string _alamat;
        private string _email;
        private string _telp;
        private int _idDesa;
        private string _role;

        // ==========================================
        // 2. ENKAPSULASI: PUBLIC PROPERTIES
        // ==========================================
        // Bagian ini yang diakses oleh class lain (Controller/View)

        public int IdAkun
        {
            get { return _idAkun; }
            set { _idAkun = value; }
        }

        public string Username
        {
            get { return _username; }
            set
            {
                // Contoh Validasi Enkapsulasi: Mencegah Username kosong
                if (!string.IsNullOrWhiteSpace(value))
                    _username = value;
                else
                    _username = "Unknown"; // Default value jika input error
            }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Nama
        {
            get { return _nama; }
            set { _nama = value; }
        }

        public string Alamat
        {
            get { return _alamat; }
            set { _alamat = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Telp
        {
            get { return _telp; }
            set { _telp = value; }
        }

        public int IdDesa
        {
            get { return _idDesa; }
            set { _idDesa = value; }
        }

        public string Role
        {
            get { return _role; }
            set { _role = value; }
        }

        // ==========================================
        // 3. METHODS (Logika Database Tetap Sama)
        // ==========================================

        public static bool Daftar(string username, string password, string nama, string email, string alamat, string telp, int idDesa)
        {
            try
            {
                using (var conn = Koneksi.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        INSERT INTO public.""akun"" 
                        (username, password, nama, alamat, email, telp, iddesa, role)
                        VALUES 
                        (@username, @password, @nama, @alamat, @email, @telp, @iddesa, 'Pembeli');
                    ";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@nama", nama);
                        cmd.Parameters.AddWithValue("@alamat", alamat);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@telp", telp);
                        cmd.Parameters.AddWithValue("@iddesa", idDesa);

                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Register: " + ex.Message);
                return false;
            }
        }

        public static Akun CekLogin(string username, string password)
        {
            Akun akunDitemukan = null;
            try
            {
                using (var conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT idakun, role FROM public.akun WHERE username = @u AND password = @p";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@u", username);
                        cmd.Parameters.AddWithValue("@p", password);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                akunDitemukan = new Akun();
                                // Mengakses Property Public
                                akunDitemukan.IdAkun = Convert.ToInt32(reader["idakun"]);
                                akunDitemukan.Role = reader["role"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Login: " + ex.Message);
            }
            return akunDitemukan;
        }

        public static DataTable AmbilSemuaAkun()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM public.akun ORDER BY idakun ASC";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader()) dt.Load(reader);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return dt;
        }

        public bool AmbilDetailById(int id)
        {
            try
            {
                using (var conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM public.akun WHERE idakun = @id";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Mapping ke Property Object (PBO)
                                // Kita gunakan 'this' untuk mengakses public properties
                                this.IdAkun = Convert.ToInt32(reader["idakun"]);
                                this.Username = reader["username"].ToString();
                                this.Password = reader["password"].ToString();
                                this.Nama = reader["nama"].ToString();
                                this.Alamat = reader["alamat"].ToString();
                                this.Email = reader["email"].ToString();
                                this.Telp = reader["telp"].ToString();
                                this.IdDesa = Convert.ToInt32(reader["iddesa"]);
                                this.Role = reader["role"].ToString();
                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return false;
        }

        public bool UpdateData()
        {
            try
            {
                using (var conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string query = @"UPDATE public.akun 
                                     SET username=@u, password=@p, nama=@n, alamat=@a, 
                                         email=@e, telp=@t, iddesa=@idD, role=@r 
                                     WHERE idakun=@id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        // Mengambil nilai dari Public Properties
                        cmd.Parameters.AddWithValue("@u", this.Username);
                        cmd.Parameters.AddWithValue("@p", this.Password);
                        cmd.Parameters.AddWithValue("@n", this.Nama);
                        cmd.Parameters.AddWithValue("@a", this.Alamat);
                        cmd.Parameters.AddWithValue("@e", this.Email);
                        cmd.Parameters.AddWithValue("@t", this.Telp);
                        cmd.Parameters.AddWithValue("@idD", this.IdDesa);
                        cmd.Parameters.AddWithValue("@r", this.Role);
                        cmd.Parameters.AddWithValue("@id", this.IdAkun);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Update: " + ex.Message);
                return false;
            }
        }
    }
}