using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace project_ecoranger.Models
{
    internal class PenarikanContext
    {
        readonly string connStr;
        public PenarikanContext()
        {
            connStr = Connection.Connection.GetConnectionString();
        }
        public void InsertPenarikanSaldo(decimal nominal, int idSaldo, int idStatusPenarikan, string nomorRekening, int idBank)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string query = """
                    INSERT INTO penarikan_saldo (tanggal_penarikan, nominal,saldo_id_saldo, status_penarikan_id_status_penarikan, nomor_rekening, id_bank )
                    VALUES (@tanggalPenarikan, @nominal, @idSaldo,@statusPenarikan, @nomorRekening, @idBank);
                    """;
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("tanggalPenarikan", DateTime.Now);
                    cmd.Parameters.AddWithValue("nominal", nominal); 
                    cmd.Parameters.AddWithValue("idSaldo", idSaldo); 
                    cmd.Parameters.AddWithValue("statusPenarikan", idStatusPenarikan); 
                    cmd.Parameters.AddWithValue("nomorRekening", nomorRekening); 
                    cmd.Parameters.AddWithValue("idBank", idBank);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<PenarikanSaldo> GetHistoryPenarikanSaldoForPenyuplai(int idPenyuplai)
        {
            List<PenarikanSaldo> listPenarikanSaldo = new List<PenarikanSaldo>();
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = """
                    select ps.id_penarikan_saldo, ps.tanggal_penarikan, ps.nominal, p.nama, ps.nomor_rekening, b.bank, sp.status_penarikan  from penarikan_saldo ps
                    join bank b ON B.id_bank = ps.id_bank
                    join status_penarikan sp on (status_penarikan_id_status_penarikan = id_status_penarikan)
                    join saldo s on (saldo_id_saldo = id_saldo)
                    join penyuplai p on (penyuplai_id_penyuplai = id_penyuplai)
                    where p.id_penyuplai = @idPenyuplai
                    order by ps.tanggal_penarikan desc
                    """;
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("idPenyuplai", idPenyuplai);
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PenarikanSaldo penarikanSaldo = new PenarikanSaldo{
                                    idPenarikanSaldo = reader.GetInt32(0),
                                    tanggalPenarikan = reader.GetDateTime(1),
                                    nominal = reader.GetDecimal(2),
                                    nama = reader.GetString(3),
                                    nomorRekening = reader.GetString(4),
                                    namaBank = reader.GetString(5),
                                    statusPenarikan = reader.GetString(6)
                                };
                                listPenarikanSaldo.Add(penarikanSaldo);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error database: " + ex.Message);
                }
                return listPenarikanSaldo;
            }
        }
        public List<PenarikanSaldo> GetHistoryPenarikanSaldoForPengepul()
        {
            List<PenarikanSaldo> listPenarikanSaldo = new List<PenarikanSaldo>();
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = """
                    select ps.id_penarikan_saldo, ps.tanggal_penarikan, ps.nominal, p.nama, ps.nomor_rekening, b.bank, sp.status_penarikan  from penarikan_saldo ps
                    join bank b ON B.id_bank = ps.id_bank
                    join status_penarikan sp on (status_penarikan_id_status_penarikan = id_status_penarikan)
                    join saldo s on (saldo_id_saldo = id_saldo)
                    join penyuplai p on (penyuplai_id_penyuplai = id_penyuplai)
                    where status_penarikan_id_status_penarikan <> 1
                    order by ps.tanggal_penarikan desc
                    """;
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PenarikanSaldo penarikanSaldo = new PenarikanSaldo
                                {
                                    idPenarikanSaldo = reader.GetInt32(0),
                                    tanggalPenarikan = reader.GetDateTime(1),
                                    nominal = reader.GetDecimal(2),
                                    nama = reader.GetString(3),
                                    nomorRekening = reader.GetString(4),
                                    namaBank = reader.GetString(5),
                                    statusPenarikan = reader.GetString(6)
                                };
                                listPenarikanSaldo.Add(penarikanSaldo);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error database: " + ex.Message);
                }
                return listPenarikanSaldo;
            }
        }
        public List<PenarikanSaldo> GetListPenarikanForKonfirmasi()
        {
            List<PenarikanSaldo> listPenarikanSaldo = new List<PenarikanSaldo>();
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = """
                    select ps.id_penarikan_saldo, ps.tanggal_penarikan, ps.nominal, p.nama, ps.nomor_rekening, b.bank, sp.status_penarikan  from penarikan_saldo ps
                    join bank b ON B.id_bank = ps.id_bank
                    join status_penarikan sp on (status_penarikan_id_status_penarikan = id_status_penarikan)
                    join saldo s on (saldo_id_saldo = id_saldo)
                    join penyuplai p on (penyuplai_id_penyuplai = id_penyuplai)
                    where status_penarikan_id_status_penarikan = 1
                    order by ps.tanggal_penarikan
                    """;
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PenarikanSaldo penarikanSaldo = new PenarikanSaldo
                                {
                                    idPenarikanSaldo = reader.GetInt32(0),
                                    tanggalPenarikan = reader.GetDateTime(1),
                                    nominal = reader.GetDecimal(2),
                                    nama = reader.GetString(3),
                                    nomorRekening = reader.GetString(4),
                                    namaBank = reader.GetString(5),
                                    statusPenarikan = reader.GetString(6)
                                };
                                listPenarikanSaldo.Add(penarikanSaldo);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error database: " + ex.Message);
                }
                return listPenarikanSaldo;
            }
        }
        public void KonfirmasiPenarikan (int idPenarikan, int idStatusPenarikan)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = """
                        update penarikan_saldo set status_penarikan_id_status_penarikan = @statusPenarikan where id_penarikan_saldo = @idPenarikan;
                        """;
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("idPenarikan", idPenarikan);
                        cmd.Parameters.AddWithValue("statusPenarikan", idStatusPenarikan);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Terjadi Kealahan Dalam Database : {ex.Message}");
                }
            }
        }
    }
    
}
