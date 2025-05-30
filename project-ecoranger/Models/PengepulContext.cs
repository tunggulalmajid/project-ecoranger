using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace project_ecoranger.Models
{
    internal class PengepulContext
    {
        readonly string connStr;
        public PengepulContext()
        {
            connStr = Connection.Connection.GetConnectionString();
        }
        public bool LoginPengepul(string username, string password, out int idPengepul)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT id_pengepul FROM pengepul WHERE username = @username AND password = @password";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idPengepul = reader.GetInt32(0);
                            return true;
                        }
                        else
                        {
                            idPengepul = 0;
                            return false;
                        }
                    }
                }
            
            }
        }
    }
}
