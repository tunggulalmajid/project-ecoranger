using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using project_ecoranger.AbstractAndInterface;

namespace project_ecoranger.Controller
{
    internal class PengepulContext : IPengepulContext
    {
        readonly string connStr;
        public PengepulContext()
        {
            connStr = Connection.Connection.GetConnectionString();
        }
        public bool LoginPengepul(string username, string password)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT id_pengepul FROM pengepul WHERE username = @username AND password = @password ";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }

            }
        }
    }
}
