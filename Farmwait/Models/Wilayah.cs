using Npgsql;
using System.Collections.Generic;

namespace Farmwait.Models
{
    // Class pembantu untuk ComboBox
    public class ComboBoxItem
    {
        public int Id { get; set; }
        public string Nama { get; set; }

        public override string ToString()
        {
            return Nama;
        }
    }

    public class Wilayah
    {
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
    }
}