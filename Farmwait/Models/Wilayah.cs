using Npgsql;
using System;
using System.Collections.Generic;

namespace Farmwait.Models
{
    public class ComboBoxItem
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public override string ToString() => Nama;
    }

    // Class baru untuk menampung hirarki wilayah
    public class WilayahDetail
    {
        public int IdKabupaten { get; set; }
        public int IdKecamatan { get; set; }
        public int IdDesa { get; set; }
    }

    public class Wilayah
    {
        // ... (Method GetKabupaten, GetKecamatan, GetDesa biarkan seperti sebelumnya) ...
        // Tambahkan method GetKabupaten, GetKecamatan, GetDesa di sini jika belum ada atau copy dari file lama user.
        // Agar tidak membingungkan, saya tulis ulang full content class Wilayah yang sudah diupdate.

        public static List<ComboBoxItem> GetKabupaten()
        {
            List<ComboBoxItem> list = new List<ComboBoxItem>();
            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();
                string query = "SELECT idkabupaten, namakabupaten FROM public.kabupaten ORDER BY namakabupaten";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new ComboBoxItem
                            {
                                Id = Convert.ToInt32(reader["idkabupaten"]),
                                Nama = reader["namakabupaten"].ToString()
                            });
                        }
                    }
                }
            }
            return list;
        }

        public static List<ComboBoxItem> GetKecamatan(int idKab)
        {
            List<ComboBoxItem> list = new List<ComboBoxItem>();
            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();
                string query = "SELECT idkecamatan, namakecamatan FROM public.kecamatan WHERE idkab = @idkab ORDER BY namakecamatan";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idkab", idKab);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new ComboBoxItem
                            {
                                Id = Convert.ToInt32(reader["idkecamatan"]),
                                Nama = reader["namakecamatan"].ToString()
                            });
                        }
                    }
                }
            }
            return list;
        }

        public static List<ComboBoxItem> GetDesa(int idKec)
        {
            List<ComboBoxItem> list = new List<ComboBoxItem>();
            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();
                string query = "SELECT iddesa, namadesa FROM public.desa WHERE idkecamatan = @idkec ORDER BY namadesa";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idkec", idKec);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new ComboBoxItem
                            {
                                Id = Convert.ToInt32(reader["iddesa"]),
                                Nama = reader["namadesa"].ToString()
                            });
                        }
                    }
                }
            }
            return list;
        }

        // === TAMBAHAN BARU ===
        // Mencari ID Kec dan ID Kab berdasarkan ID Desa
        public static WilayahDetail GetDetailByDesa(int idDesa)
        {
            WilayahDetail w = null;
            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();
                // Join 3 tabel untuk dapat hirarki lengkap
                string query = @"
                    SELECT d.iddesa, k.idkecamatan, kab.idkabupaten
                    FROM public.desa d
                    JOIN public.kecamatan k ON d.idkecamatan = k.idkecamatan
                    JOIN public.kabupaten kab ON k.idkab = kab.idkabupaten
                    WHERE d.iddesa = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idDesa);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            w = new WilayahDetail();
                            w.IdDesa = Convert.ToInt32(reader["iddesa"]);
                            w.IdKecamatan = Convert.ToInt32(reader["idkecamatan"]);
                            w.IdKabupaten = Convert.ToInt32(reader["idkabupaten"]);
                        }
                    }
                }
            }
            return w;
        }
    }
}