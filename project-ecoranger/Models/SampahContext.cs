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
                    throw new Exception("Error retrieving sampah list: " + ex.Message);

                }
            }
        }
        public void JualSampah(int idSampah, decimal beratSampah, decimal hargaSampah, int idPenyuplai)
        {
            int idStatusTransaksi = 1;
            using (NpgsqlConnection  conn = new NpgsqlConnection(connStr))
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
    } 
}

