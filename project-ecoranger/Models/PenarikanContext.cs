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
                    VALUES (@tanggalPenarikan, @nominal, @idSaldo,@statusPenarikan, @nomorRekening, @idBank, );
                    """;
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("tanggalPenarikan", DateTime.Now);
                    cmd.Parameters.AddWithValue("nominal", nominal); // Placeholder for actual value
                    cmd.Parameters.AddWithValue("idSaldo", idSaldo); // Placeholder for actual value
                    cmd.Parameters.AddWithValue("statusPenarikan", idStatusPenarikan); // Placeholder for actual value
                    cmd.Parameters.AddWithValue("nomorRekening", nomorRekening); // Placeholder for actual value
                    cmd.Parameters.AddWithValue("idBank", idBank); // Default status
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
