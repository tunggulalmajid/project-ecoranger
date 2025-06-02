using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace project_ecoranger.Models
{
    internal class LaporanContext
    {
        readonly string connStr;
        public LaporanContext() 
        { 
            connStr = Connection.Connection.GetConnectionString();
        }
        public List<Laporan> GetDataLaporanForPengepul()
        {
            List<Laporan> listAllLaporan = new List<Laporan>(); 
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = """
                    select  sk.sub_kategori_sampah, k.kategori_sampah, sk.harga * sum(tr.berat_sampah) as aset,sum(tr.berat_sampah) as berat from transaksi tr
                    join sub_kategori_sampah sk on (sub_kategori_sampah_id_sub_kategori_sampah = id_sub_kategori_sampah)
                    join kategori_sampah k on (kategori_sampah_id_kategori_sampah = id_kategori_sampah)
                    where tr.status_transaksi_id_status_transaksi = 2
                    group by sk.sub_kategori_sampah, k.kategori_sampah, sk.harga
                    """;
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                               Laporan laporan = new Laporan{
                                   namaSampah = reader.GetString(0),
                                   kategoriSampah = reader.GetString(1),
                                   totalAset = reader.GetDecimal(2),
                                   totalBerat = reader.GetDecimal(3)
                               };
                                listAllLaporan.Add(laporan);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                }
                
            }
            return listAllLaporan;
        }
        public decimal GetTotalBeratkeseluruhanForPengepul()
        {
            decimal totalBeratKeseluruhan = 0;
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string query = """
                    select sum(berat_sampah) from transaksi where status_transaksi_id_status_transaksi = 2;
                    """;
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            totalBeratKeseluruhan = reader.GetDecimal(0);
                        }
                        
                    }
                }
            }
            return totalBeratKeseluruhan;
        }
        public decimal GetTotalAsetForPengepul()
        {
            decimal totalAset = 0;
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                string query = """
                    select sum (harga * berat_sampah) from transaksi where status_transaksi_id_status_transaksi = 2;
                    """;
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            totalAset = reader.GetDecimal(0);
                        }

                    }
                }
            }
            return totalAset;
        }
    }
}
