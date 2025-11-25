using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Farmwait.Models
{
    // [PEWARISAN] Hewan mewarisi ItemGudang (Id & Nama)
    // Disini: Id = idhewan, Nama = jenishewan
    public class Hewan : ItemGudang
    {
        // [ENKAPSULASI] Properti public dengan private backing fields (implisit)
        public string JenisKelamin { get; set; }
        public int Berat { get; set; }
        public int Usia { get; set; }
        public int IdPakan { get; set; }
        public int PorsiPakan { get; set; }

        // [ABSTRAKSI] Implementasi method abstract dari parent
        public override string GetInfoLengkap()
        {
            return $"{Nama} ({JenisKelamin}) - {Berat}g";
        }

        // [POLIMORFISME] 
        public bool TambahData()
        {
            try
            {
                using (var conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string query = @"INSERT INTO public.hewan 
                                     (jenishewan, jeniskelamin, berat, usia, idpakan, porsipakan, is_deleted) 
                                     VALUES (@nama, @jk, @berat, @usia, @idpakan, @porsi, false)";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", this.Nama);
                        cmd.Parameters.AddWithValue("@jk", this.JenisKelamin);
                        cmd.Parameters.AddWithValue("@berat", this.Berat);
                        cmd.Parameters.AddWithValue("@usia", this.Usia);
                        cmd.Parameters.AddWithValue("@idpakan", this.IdPakan);
                        cmd.Parameters.AddWithValue("@porsi", this.PorsiPakan);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Tambah: " + ex.Message);
                return false;
            }
        }

        public bool UpdateData()
        {
            try
            {
                using (var conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    string query = @"UPDATE public.hewan 
                                     SET jenishewan=@nama, jeniskelamin=@jk, berat=@berat, 
                                         usia=@usia, idpakan=@idpakan, porsipakan=@porsi 
                                     WHERE idhewan=@id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", this.Nama);
                        cmd.Parameters.AddWithValue("@jk", this.JenisKelamin);
                        cmd.Parameters.AddWithValue("@berat", this.Berat);
                        cmd.Parameters.AddWithValue("@usia", this.Usia);
                        cmd.Parameters.AddWithValue("@idpakan", this.IdPakan);
                        cmd.Parameters.AddWithValue("@porsi", this.PorsiPakan);
                        cmd.Parameters.AddWithValue("@id", this.Id);
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

        public bool HapusData()
        {
            try
            {
                using (var conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    // Soft Delete Query
                    string query = "UPDATE public.hewan SET is_deleted = true WHERE idhewan = @id";

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
                MessageBox.Show("Gagal menghapus data: " + ex.Message);
                return false;
            }
        }

        // Static Method untuk Load Data (Hanya mengambil yang is_deleted = false)
        public static DataTable AmbilSemuaHewan()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = Koneksi.GetConnection())
                {
                    conn.Open();
                    // Filter: WHERE is_deleted = false
                    string query = @"SELECT 
                                        idhewan, jenishewan, jeniskelamin, berat, 
                                        usia, idpakan, porsipakan 
                                     FROM public.hewan 
                                     WHERE is_deleted = false 
                                     ORDER BY idhewan ASC";

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
                MessageBox.Show("Error Load Data: " + ex.Message);
            }
            return dt;
        }
    }
}