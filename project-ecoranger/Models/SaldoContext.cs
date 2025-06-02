using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace project_ecoranger.Models
{
    internal class SaldoContext
    {
        readonly string connStr;
        public SaldoContext()
        {
            connStr = Connection.Connection.GetConnectionString();
        }
        public List<Saldo> getSaldo(int idPenyuplai)
        {
            List<Saldo> listSaldo = new List<Saldo>();
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string query = """
                    select id_saldo, saldo from saldo where penyuplai_id_penyuplai = @idPenyuplai;
                    """;
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("idPenyuplai", idPenyuplai);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Saldo saldo = new Saldo
                            {
                                idSaldo = reader.GetInt32(0),
                                saldo = reader.GetDecimal(1)
                            };
                            listSaldo.Add(saldo);
                        }
                    }
                }
                return listSaldo;
            }
        }
    }
}
