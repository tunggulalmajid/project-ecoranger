using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace project_ecoranger.Models
{
    internal class PoinContext
    {
        readonly string connStr;
        public PoinContext()
        {
            connStr = Connection.Connection.GetConnectionString();
        }
        public List<Poin> GetPoin(int idPenyuplai)
        {
            List<Poin> listPoin = new List<Poin>();
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string query = """
                    select id_poin, poin from poin where penyuplai_id_penyuplai = @idPenyuplai;
                    """;
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("idpenyuplai", idPenyuplai);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Poin poin = new Poin
                            {
                                idPoin = reader.GetInt32(0),
                                poin = reader.GetDecimal(1)
                            };
                            listPoin.Add(poin);
                        }
                    }
                }
                return listPoin;
            }
        }
        public void TambahPoin(int idPenyuplai, decimal nominal)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string query = """
                    UPDATE poin set poin = poin + MONEY(@nominal) WHERE penyuplai_id_penyuplai = @idPenyuplai;
                    """;
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("idPenyuplai", idPenyuplai);
                    cmd.Parameters.AddWithValue("nominal", nominal);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void KurangiPoin(int idPenyuplai, decimal nominal)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string query = """
                    UPDATE poin set poin = poin - MONEY(@nominal) WHERE penyuplai_id_penyuplai = @idPenyuplai;
                    """;
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("idPenyuplai", idPenyuplai);
                    cmd.Parameters.AddWithValue("nominal", nominal);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
