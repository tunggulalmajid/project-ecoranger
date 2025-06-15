using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using project_ecoranger.AbstractAndInterface;

namespace project_ecoranger.Models
{
    internal class BankcContext : IBankContext
    {
        readonly string connStr;
        public BankcContext()
        {
            connStr = Connection.Connection.GetConnectionString();
        }
        public List<Bank> GetDataBank()
        {
            List<Bank> listBank = new List<Bank>();
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string query = """
                    select * from bank 
                    """;
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader()) 
                    {
                        while (reader.Read()) { 
                            Bank bank = new Bank
                            {
                                idBank = reader.GetInt32(0),
                                namaBank = reader.GetString(1)
                            };
                            listBank.Add(bank);
                        }
                    }
                }
                return listBank;
            }
        }
    }
}
