using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using project_ecoranger.AbstractAndInterface;
using project_ecoranger.Models;

namespace project_ecoranger.Controller
{
    internal class SaldoContext : ISaldoContext
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
        public void TambahSaldoForPoin(int idPenyuplai, decimal nominal)
        {
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
        public void KurangiSaldoForPenarikan(int idPenarikan, decimal nominal)
        {
            int idSaldo = GetIdSaldoForKonfirmasi(idPenarikan);
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string query = """
                    UPDATE saldo set saldo = saldo - MONEY(@nominal) WHERE id_saldo = @idSaldo;
                    """;
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("idSaldo", idSaldo);
                    cmd.Parameters.AddWithValue("nominal", nominal);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public int GetIdSaldoForKonfirmasi(int idPenarikan)
        {
            int idSaldo;
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT saldo_id_saldo FROM penarikan_saldo WHERE id_penarikan_saldo = @idPenarikan";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("idPenarikan", idPenarikan);
                        idSaldo = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error : " + ex.Message);
                }

            }
            return idSaldo;
        }
        public void CreateSaldo(string username, string password)
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
                        insert into saldo(saldo, penyuplai_id_penyuplai) values (0, @idPenyuplai)
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
