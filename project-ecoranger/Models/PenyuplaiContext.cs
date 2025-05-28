using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace project_ecoranger.Models
{
    internal class PenyuplaiContext
    {
        public readonly string connStr;
        public PenyuplaiContext()
        {
            connStr = "Host=localhost;Username=postgres;Password=Gunungsari;Database=ecorangerv2";
        }
        public bool LoginPenyuplai(string username, string password, out int idPenyuplai)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {


                    conn.Open();
                    string query = "SELECT * FROM penyuplai WHERE username = @username AND password = @password";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("password", password);
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idPenyuplai = reader.GetInt32(reader.GetOrdinal("id_penyuplai"));
                                return true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                }
            }

            idPenyuplai = 0;
            return false;
        }
        public void RegisterPenyuplai(string nama, BigInteger nomorTelepon, string email, string username, string password)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO penyuplai (nama, nomor_telepon, email, username, password) VALUES (@nama, @nomorTelepon, @email, @username, @password)";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("nama", nama);
                        cmd.Parameters.AddWithValue("nomorTelepon", nomorTelepon);
                        cmd.Parameters.AddWithValue("email", email);
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("password", password);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Gagal melakukan registrasi penyuplai: " + ex.Message);
                }
            }
        }
    }
}
