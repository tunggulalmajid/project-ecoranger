using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace project_ecoranger.Models
{
    internal class PenukaranPoinContext
    {
        readonly string connStr;
        public PenukaranPoinContext()
        {
            connStr = Connection.Connection.GetConnectionString();
        }
        public void InsertPenukaranPoin(decimal nominal, int idPoin)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string query = """
                    INSERT INTO penukaran_poin (tanggal_penukaran, nominal, poin_id_poin) VALUES (@tanggalPenukaran,MONEY(@nominal), @idPoin);
                    """;
                using ( NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("tanggalPenukaran", DateTime.Now);
                    cmd.Parameters.AddWithValue("nominal", nominal);
                    cmd.Parameters.AddWithValue("idPoin", idPoin);
                    cmd.ExecuteNonQuery();
                }
            }

        }
        public List<PenukaranPoin> GetHistoryPenukaranForPenyuplai(int idPenyuplai)
        {
            List <PenukaranPoin> listPenukaranPoin = new List<PenukaranPoin>();
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = """
                    select pp.id_penukaran_poin, pp.tanggal_penukaran, pp.nominal, p.nama
                    from penukaran_poin pp
                    join poin on (poin_id_poin = id_poin)
                    join penyuplai p on (penyuplai_id_penyuplai = id_penyuplai)
                    WHERE id_penyuplai = @idPenyuplai
                    order by pp.tanggal_penukaran desc
                    """;
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("idPenyuplai", idPenyuplai);
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PenukaranPoin penukaranPoin = new PenukaranPoin
                                {
                                    idPenukaranPoin = reader.GetInt32(0),
                                    tanggalPenukaran = reader.GetDateTime(1),
                                    nominal = reader.GetDecimal(2),
                                    namaPenyuplai = reader.GetString(3)
                                };
                                listPenukaranPoin.Add(penukaranPoin);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error database: " + ex.Message);
                }
                return listPenukaranPoin;
            }
        }
    }
}
