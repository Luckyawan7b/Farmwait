using Npgsql;
using System;
using System.Windows.Forms; // Untuk MessageBox

namespace Farmwait.Models
{
    public class Akun
    {
        // Tambahkan parameter lengkap sesuai form
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
        public static string CekLogin(string username, string password)
        {
            string role = null; // Default null jika gagal
            try
            {
                using (var conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    // Query cek user & pass
                    string query = "SELECT role FROM public.akun WHERE username = @u AND password = @p";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@u", username);
                        cmd.Parameters.AddWithValue("@p", password); // (Idealnya password di-hash)

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Jika ketemu, ambil role-nya (misal: "Peternak")
                                role = reader["role"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Login: " + ex.Message);
            }
            return role; // Mengembalikan Role jika sukses, atau null jika gagal
        }
    }


}