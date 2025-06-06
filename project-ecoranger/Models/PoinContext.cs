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
        public void TambahPoinForTransaksi(int idTransaksi, decimal beratSampah)
        {
            PenyuplaiContext penyuplaiContext = new PenyuplaiContext();
            int idPenyuplai = penyuplaiContext.GetIdPenyuplaiUseTransaksi(idTransaksi);
            decimal? nominal = SetNominalPoinForTransaksi(beratSampah);
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
        public void KurangiPoin(int idPoin, decimal nominal)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string query = """
                    UPDATE poin set poin = poin - MONEY(@nominal) WHERE id_poin = @idPoin;
                    """;
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("idPoin", idPoin);
                    cmd.Parameters.AddWithValue("nominal", nominal);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public decimal? SetNominalPoinForTransaksi (decimal berat)
        {
            decimal poinTetap = 1000;
            decimal beratSampahPenyuplai = Math.Floor(berat);
            int pengali = 0;
            for (int i = 1; i <= beratSampahPenyuplai; i++)
            {
                if (i % 3 == 0)
                {
                    pengali++;
                }
            }
            decimal? nominal = pengali * poinTetap;
            return nominal;
        }
        public void CreatePoin(string username, string password)
        {
            int idPenyuplai;
            PenyuplaiContext penyuplaiContext = new PenyuplaiContext();
            penyuplaiContext.GetIdAfterRegist(username, password, out idPenyuplai);
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = """
                        insert into poin(poin, penyuplai_id_penyuplai) values (0, @idPenyuplai)
                        """;
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("idPenyuplai", idPenyuplai);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error : " + ex.Message);
                }
            }
        }
    }
}
