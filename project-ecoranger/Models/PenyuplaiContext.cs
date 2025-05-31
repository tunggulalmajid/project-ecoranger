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
            connStr = Connection.Connection.GetConnectionString();
        }
        public bool LoginPenyuplai(string username, string password, out int idPenyuplai)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {


                    conn.Open();
                    string query = "SELECT * FROM penyuplai WHERE username = @username AND password = @password AND is_aktif = true";
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
                    throw new Exception();
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
        public void CreateAlamat(string username, string password)
        {
            int idPenyuplai;
            GetIdAfterRegist(username, password, out idPenyuplai);
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO alamat (penyuplai_id_penyuplai) VALUES (@idPenyuplai)";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("idPenyuplai", idPenyuplai);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Gagal membuat alamat penyuplai: " + ex.Message);
                }
            }
        }
        public void GetIdAfterRegist(string username, string password, out int idPenyuplai)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id_penyuplai FROM penyuplai WHERE username = @username AND password = @password";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("password", password);
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idPenyuplai = reader.GetInt32(reader.GetOrdinal("id_penyuplai"));
                            }
                            else
                            {
                                idPenyuplai = 0;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Gagal mendapatkan ID penyuplai: " + ex.Message);
                }
            }
        }
        public List<Penyuplai> GetDataDiriPenyuplai(int idPenyuplai)
        {
            List<Penyuplai> DataDiriPenyuplai = new List<Penyuplai>();
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "select p.nama, p.nomor_telepon, p.email, a.jalan || ', ' || a.desa || ', ' || a.kecamatan || ', ' || a.kabupaten as alamat , p.username, p.password from penyuplai p join alamat a on (penyuplai_id_penyuplai = id_Penyuplai) where id_penyuplai = @idPenyuplai";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("idPenyuplai", idPenyuplai);
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Penyuplai penyuplai = new Penyuplai
                                {
                                    nama = reader.GetString(reader.GetOrdinal("nama")),
                                    noTelp = reader.GetInt64(reader.GetOrdinal("nomor_telepon")),
                                    alamat = reader.IsDBNull(reader.GetOrdinal("alamat"))? null : reader.GetString(reader.GetOrdinal("alamat")),
                                    email = reader.GetString(reader.GetOrdinal("email")) ,
                                    username = reader.GetString(reader.GetOrdinal("username")),
                                    password = reader.GetString(reader.GetOrdinal("password"))
                                };
                                DataDiriPenyuplai.Add(penyuplai);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Gagal mengambil data diri penyuplai: " + ex.Message);
                }
                return DataDiriPenyuplai;
            }
        }
        public void UpdateDatadiri(int idPenyuplai, string nama, BigInteger nomorTelepon, string email)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE penyuplai SET nama = @nama, nomor_telepon = @nomorTelepon, email = @email WHERE id_penyuplai = @idPenyuplai";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("idPenyuplai", idPenyuplai);
                        cmd.Parameters.AddWithValue("nama", nama);
                        cmd.Parameters.AddWithValue("nomorTelepon", nomorTelepon);
                        cmd.Parameters.AddWithValue("email", email);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Gagal memperbarui data diri penyuplai: " + ex.Message);
                }
            }
        }
        public void UpdateAlamat (int idPenyuplai,string jalan, string desa, string kecamatan, string kabupaten)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE alamat SET jalan = @jalan, desa = @desa, kecamatan = @kecamatan, kabupaten = @kabupaten WHERE penyuplai_id_penyuplai = @idPenyuplai";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("jalan", jalan);
                        cmd.Parameters.AddWithValue("desa", desa);
                        cmd.Parameters.AddWithValue("kecamatan", kecamatan);
                        cmd.Parameters.AddWithValue("kabupaten", kabupaten);
                        cmd.Parameters.AddWithValue("idPenyuplai", idPenyuplai);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Gagal memperbarui alamat penyuplai: " + ex.Message);
                }
            }
        }
        public int GetJumlahPenyuplai()
        {
            int jumlahPenyuplai;
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(id_penyuplai) FROM penyuplai where is_aktif = true";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        jumlahPenyuplai = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Gagal mendapatkan jumlah penyuplai: " + ex.Message);
                }
            }
            return jumlahPenyuplai;
        }
        public List<Penyuplai> GetAllPenyuplai()
        {
            List<Penyuplai> listAllPenyuplai = new List<Penyuplai>();
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "select p.id_penyuplai, p.nama, p.nomor_telepon, p.email, a.jalan || ', ' || a.desa || ', ' || a.kecamatan || ', ' || a.kabupaten as alamat, p.username, p.password from penyuplai p join alamat a on (penyuplai_id_penyuplai = id_penyuplai) where is_aktif = true order by id_penyuplai ";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Penyuplai penyuplai = new Penyuplai
                                {
                                    idPenyuplai = reader.GetInt32(reader.GetOrdinal("id_penyuplai")),
                                    nama = reader.GetString(reader.GetOrdinal("nama")),
                                    noTelp = reader.GetInt64(reader.GetOrdinal("nomor_telepon")),
                                    alamat = reader.IsDBNull(reader.GetOrdinal("alamat")) ? null : reader.GetString(reader.GetOrdinal("alamat")),
                                    email = reader.GetString(reader.GetOrdinal("email")),
                                    username = reader.GetString(reader.GetOrdinal("username")),
                                    password = reader.GetString(reader.GetOrdinal("password"))
                                };
                                listAllPenyuplai.Add(penyuplai);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Gagal mengambil data diri penyuplai: " + ex.Message);
                }
                return listAllPenyuplai;
            }
        }
    }
}
