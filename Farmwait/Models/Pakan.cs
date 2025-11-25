using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Farmwait.Models
{
    // [PEWARISAN] Class Pakan mewarisi Id dan Nama dari ItemGudang
    public class Pakan : ItemGudang
    {
        // Property khusus milik Pakan
        public int Stok { get; set; }
        public int Harga { get; set; }

        // [POLIMORFISME] Override method dari induknya
        public override string GetInfoLengkap()
        {
            return $"Pakan: {Nama} | Stok: {Stok} | Harga: Rp{Harga}";
        }

        public bool SimpanKeDatabase()
        {
            try
            {
                using (var conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO public.pakan (namapakan, stokpakan, hargapakan) VALUES (@nama, @stok, @harga)";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", this.Nama);
                        cmd.Parameters.AddWithValue("@stok", this.Stok);
                        cmd.Parameters.AddWithValue("@harga", this.Harga);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Simpan: " + ex.Message);
                return false;
            }
        }

        public bool UpdateDatabase()
        {
            try
            {
                using (var conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE public.pakan SET namapakan=@nama, stokpakan=@stok, hargapakan=@harga WHERE idpakan=@id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", this.Nama);
                        cmd.Parameters.AddWithValue("@stok", this.Stok);
                        cmd.Parameters.AddWithValue("@harga", this.Harga);
                        cmd.Parameters.AddWithValue("@id", this.Id);
                        cmd.ExecuteNonQuery();
                        //tuman
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Update: " + ex.Message);
                return false;
            }
        }

        public static DataTable AmbilSemua()
        {
            DataTable dt = new DataTable();
            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT * FROM public.pakan ORDER BY idpakan ASC", conn))
                {
                    using (var reader = cmd.ExecuteReader()) dt.Load(reader);
                }
            }
            return dt;
        }
    }
}