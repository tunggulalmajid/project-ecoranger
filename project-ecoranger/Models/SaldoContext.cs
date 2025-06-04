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
        public void TambahSaldoForTransaksi(int idTransaksi, decimal nominal)
        {
            PenyuplaiContext penyuplaiContext = new PenyuplaiContext();
            int idPenyuplai = penyuplaiContext.GetIdPenyuplaiUseTransaksi(idTransaksi);
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string query = """
                    UPDATE saldo set saldo = saldo + MONEY(@nominal) WHERE penyuplai_id_penyuplai = @idPenyuplai;
                    """;
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("idPenyuplai", idPenyuplai);
                    cmd.Parameters.AddWithValue("nominal", nominal);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void KurangiSaldo(int idPenyuplai, decimal nominal)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string query = """
                    UPDATE saldo set saldo = saldo - MONEY(@nominal) WHERE penyuplai_id_penyuplai = @idPenyuplai;
                    """;
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("idPenyuplai", idPenyuplai);
                    cmd.Parameters.AddWithValue("nominal", nominal);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public int GetIdSaldo(int idPenyuplai)
        {
            int idSaldo = 0;
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string query = """
                    select id_saldo from saldo where penyuplai_id_penyuplai = @idPenyuplai;
                    """;
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("idPenyuplai", idPenyuplai);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idSaldo = reader.GetInt32(0);
                        }
                    }
                }
            }
            return idSaldo;
        }
    }
}
