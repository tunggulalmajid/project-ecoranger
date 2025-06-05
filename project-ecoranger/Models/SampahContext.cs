using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace project_ecoranger.Models
{

    internal class SampahContext
    {
        private readonly string connStr;
        public SampahContext()
        {
            connStr = Connection.Connection.GetConnectionString();
        }
        public List<Sampah> GetListSampah()
        {
            List<Sampah> listSampah = new List<Sampah>();
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = """
                    select sk.id_sub_kategori_sampah, sk.sub_kategori_sampah, sk.harga, k.id_kategori_sampah, k.kategori_sampah
                    from sub_kategori_sampah sk
                    join kategori_sampah k on (kategori_sampah_id_kategori_sampah = k.id_kategori_sampah)
                    where is_ditawarkan = true
                    order by sk.id_sub_kategori_sampah
                    """;
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Sampah sampah = new Sampah
                                {
                                    idSampah = reader.GetInt32(reader.GetOrdinal("id_sub_kategori_sampah")),
                                    namaSampah = reader.GetString(reader.GetOrdinal("sub_kategori_sampah")),
                                    hargaSampah = reader.GetDecimal(reader.GetOrdinal("harga")),
                                    idKategoriSampah = reader.GetInt32(reader.GetOrdinal("id_kategori_sampah")),
                                    namaKategoriSampah = reader.GetString(reader.GetOrdinal("kategori_sampah"))
                                };
                                listSampah.Add(sampah);
                            }
                        }
                    }
                    return listSampah;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error Database: " + ex.Message);

                }
            }
        }
        public void JualSampah(int idSampah, decimal beratSampah, decimal hargaSampah, int idPenyuplai)
        {
            int idStatusTransaksi = 1;
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = """
                    INSERT INTO transaksi (tanggal_transaksi,sub_kategori_sampah_id_sub_kategori_sampah, berat_sampah, harga, penyuplai_id_penyuplai, status_transaksi_id_status_transaksi)
                    VALUES (@tanggal_transaksi,@idSampah, @beratSampah, @hargaSampah, @idPenyuplai, @idStatusTransaksi)
                    """;
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("tanggal_transaksi", DateTime.Now);
                        cmd.Parameters.AddWithValue("idSampah", idSampah);
                        cmd.Parameters.AddWithValue("beratSampah", beratSampah);
                        cmd.Parameters.AddWithValue("hargaSampah", hargaSampah);
                        cmd.Parameters.AddWithValue("idPenyuplai", idPenyuplai);
                        cmd.Parameters.AddWithValue("idStatusTransaksi", idStatusTransaksi);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error inserting sampah transaction: " + ex.Message);
                }
            }
        }
        public void HapusSampahForPengepul(int idSampah)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = """
                    Update sub_kategori_sampah SET is_ditawarkan = false WHERE id_sub_kategori_sampah = @idSampah
                    """;
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("idSampah", idSampah);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error : {ex.Message}");
                }
            }
        }
        public List<Sampah> GetAllKategoriSampah()
        {
            List<Sampah> listSampah = new List<Sampah>();
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = """
                    select * from kategori_sampah;
                    """;
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Sampah sampah = new Sampah
                                {
                                    idKategoriSampah = reader.GetInt32(reader.GetOrdinal("id_kategori_sampah")),
                                    namaKategoriSampah = reader.GetString(reader.GetOrdinal("kategori_sampah"))
                                };
                                listSampah.Add(sampah);
                            }
                        }
                    }
                    return listSampah;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error retrieving sampah list: " + ex.Message);

                }
            }
        }
        public void UpdateSubKategori(int idSampah, string namaSampah, decimal hargaSampah, int idKategoriSampah)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = """
                    Update sub_kategori_sampah SET sub_kategori_sampah = @namaSampah, harga = @hargaSampah, kategori_sampah_id_kategori_sampah = @idKategoriSampah WHERE id_sub_kategori_sampah = @idSampah;
                    """;
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("namaSampah", namaSampah);
                        cmd.Parameters.AddWithValue("hargaSampah", hargaSampah);
                        cmd.Parameters.AddWithValue("idKategoriSampah", idKategoriSampah);
                        cmd.Parameters.AddWithValue("idSampah", idSampah);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error : {ex.Message}");
                }
            }
        }
        public void TambahSubKategori(string namaSampah, decimal hargaSampah, int idKategoriSampah)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = """
                    INSERT INTO sub_kategori_sampah (sub_kategori_sampah, harga, kategori_sampah_id_kategori_sampah)
                    VALUES (@namaSampah, @hargaSampah, @idKategoriSampah);
                    """;
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("namaSampah", namaSampah);
                        cmd.Parameters.AddWithValue("hargaSampah", hargaSampah);
                        cmd.Parameters.AddWithValue("idKategoriSampah", idKategoriSampah);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error : {ex.Message}");
                }
            }
        }
        public void TambahKategoriSampah(string namaKategoriSampah)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = """
                    INSERT INTO kategori_sampah (kategori_sampah)
                    VALUES (@namaKategoriSampah);
                    """;
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("namaKategoriSampah", namaKategoriSampah);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error : {ex.Message}");
                }
            }


        }
        public List<Sampah> GetListSampahForDashboard(int idPenyuplai)
        {
            List<Sampah> listSampah = new List<Sampah>();
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = """
                    select sk.id_sub_kategori_sampah, sk.sub_kategori_sampah, sk.harga, k.id_kategori_sampah, k.kategori_sampah
                    from sub_kategori_sampah sk
                    join kategori_sampah k on (kategori_sampah_id_kategori_sampah = k.id_kategori_sampah)
                    join transaksi tr on (sub_kategori_sampah_id_sub_kategori_sampah = id_sub_kategori_sampah)
                    where is_ditawarkan = true and penyuplai_id_penyuplai = @idPenyuplai
                    group by sk.id_sub_kategori_sampah, sk.sub_kategori_sampah, sk.harga, k.id_kategori_sampah, k.kategori_sampah
                    order by count(tr.id_transaksi) desc
                    limit 5
                    """;
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("idpenyuplai", idPenyuplai);
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Sampah sampah = new Sampah
                                {
                                    idSampah = reader.GetInt32(reader.GetOrdinal("id_sub_kategori_sampah")),
                                    namaSampah = reader.GetString(reader.GetOrdinal("sub_kategori_sampah")),
                                    hargaSampah = reader.GetDecimal(reader.GetOrdinal("harga")),
                                    idKategoriSampah = reader.GetInt32(reader.GetOrdinal("id_kategori_sampah")),
                                    namaKategoriSampah = reader.GetString(reader.GetOrdinal("kategori_sampah"))
                                };
                                listSampah.Add(sampah);
                            }
                        }
                    }
                    return listSampah;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error Database: " + ex.Message);

                }
            }
        }
    }
}

