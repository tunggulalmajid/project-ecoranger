using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using project_ecoranger.Views.Penyuplai;

namespace project_ecoranger.Models
{
    internal class BankcContext
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

                    """;
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {

                }
                return listBank;
            }
        }
    }
}
