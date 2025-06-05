using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            using (Npgsql.NpgsqlConnection conn = new Npgsql.NpgsqlConnection(connStr))
            {
                conn.Open();
                string query = """
                    INSERT INTO penukaran_poin (tanggal_penukaran, nominal, poin_id_poin) VALUES (MONEY(@nominal), @idPoin);
                    """;
                using (Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("tanggal_penukaran", DateTime.Now);
                    cmd.Parameters.AddWithValue("nominal", nominal);
                    cmd.Parameters.AddWithValue("idPoin", idPoin);
                    cmd.ExecuteNonQuery();
                }
            }

        }
    }
}
