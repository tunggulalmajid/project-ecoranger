using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace project_ecoranger.Models
{
    internal class TransaksiContext
    {
        readonly string connStr;
        public TransaksiContext() 
        {
            connStr = Connection.Connection.GetConnectionString();
        }
        public List<Transaksi> getAllTransaksi()
        {
            List<Transaksi> listAllTransaksi = new List<Transaksi>();
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string query = "select tr.id_transaksi, tr.tanggal_transaksi,p.nama, sk.sub_kategori_sampah, tr.berat_sampah, tr.harga , st.status_transaksi  from transaksi tr\r\njoin sub_kategori_sampah sk on (sub_kategori_sampah_id_sub_kategori_sampah = id_sub_kategori_sampah)\r\njoin status_transaksi st on (status_transaksi_id_status_transaksi = id_status_transaksi)\r\njoin penyuplai p on (penyuplai_id_penyuplai = id_penyuplai)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query,conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) 
                        {
                            Transaksi transaksi = new Transaksi{
                                
                            };                     
                        }
                    }
                }
            }
            return listAllTransaksi;
        }
    }
}
