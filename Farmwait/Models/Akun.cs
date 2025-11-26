using Npgsql;
using System;
using System.Data;
using System.Windows.Forms; // Untuk MessageBox

namespace Farmwait.Models
{
    public class Akun
    {
        public int IdAkun { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public string Email { get; set; }
        public string Telp { get; set; }
        public int IdDesa { get; set; }
        public string Role { get; set; }

        public static bool Daftar(string username, string password, string nama, string email, string alamat, string telp, int idDesa)
        {
            try
            {
                using (var conn = Koneksi.GetConnection())
                {
                    conn.Open();

                    // Query insert lengkap
                    string query = @"
                        INSERT INTO public.""akun"" 
                        (username, password, nama, alamat, email, telp, iddesa, role)
                        VALUES 
                        (@username, @password, @nama, @alamat, @email, @telp, @iddesa, 'Pembeli');
                    ";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password); // Sebaiknya di-hash di real app
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
                                // Buat objek akun baru untuk menampung hasil
                                akunDitemukan = new Akun();
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