﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using project_ecoranger.AbstractAndInterface;
using project_ecoranger.Models;

namespace project_ecoranger.Controller
{
    internal class TransaksiContext : ITransaksiContext
    {
        readonly string connStr;
        public TransaksiContext()
        {
            connStr = Connection.Connection.GetConnectionString();
        }
        public List<Transaksi> getAllTransaksiForPengepulDashboard(int idStatus)
        {
            List<Transaksi> listAllTransaksi = new List<Transaksi>();
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = """
                        select tr.id_transaksi, tr.tanggal_transaksi,p.nama, sk.sub_kategori_sampah, tr.berat_sampah, tr.harga , st.status_transaksi  
                        from transaksi tr join sub_kategori_sampah sk on (sub_kategori_sampah_id_sub_kategori_sampah = id_sub_kategori_sampah) 
                        join status_transaksi st on (status_transaksi_id_status_transaksi = id_status_transaksi) 
                        join penyuplai p on (penyuplai_id_penyuplai = id_penyuplai) 
                        where status_transaksi_id_status_transaksi = @idStatus
                        order by tr.tanggal_transaksi
                        limit 3;
                        """;
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("idStatus", idStatus);


                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Transaksi transaksi = new Transaksi
                                {
                                    idTransaksi = reader.GetInt32(reader.GetOrdinal("id_transaksi")),
                                    tanggalTransaksi = reader.GetDateTime(reader.GetOrdinal("tanggal_transaksi")),
                                    namaPenyuplai = reader.GetString(reader.GetOrdinal("nama")),
                                    namaSampah = reader.GetString(reader.GetOrdinal("sub_kategori_sampah")),
                                    beratSampah = reader.GetDecimal(reader.GetOrdinal("berat_sampah")),
                                    hargaSampah = reader.GetDecimal(reader.GetOrdinal("harga")),
                                    StatusTransaksi = reader.GetString(reader.GetOrdinal("status_transaksi"))
                                };
                                listAllTransaksi.Add(transaksi);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Terjadi Kealahan Dalam Database : {ex.Message}");
                }
            }
            return listAllTransaksi;
        }
        public List<Transaksi> getAllTransaksiForConfirmation()
        {
            List<Transaksi> listAllTransaksi = new List<Transaksi>();
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = """
                        select tr.id_transaksi, tr.tanggal_transaksi,p.nama, sk.sub_kategori_sampah, tr.berat_sampah, tr.harga , st.status_transaksi  
                        from transaksi tr join sub_kategori_sampah sk on (sub_kategori_sampah_id_sub_kategori_sampah = id_sub_kategori_sampah) 
                        join status_transaksi st on (status_transaksi_id_status_transaksi = id_status_transaksi) 
                        join penyuplai p on (penyuplai_id_penyuplai = id_penyuplai) 
                        where status_transaksi_id_status_transaksi = 1
                        order by tr.tanggal_transaksi
                        """;
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Transaksi transaksi = new Transaksi
                                {
                                    idTransaksi = reader.GetInt32(reader.GetOrdinal("id_transaksi")),
                                    tanggalTransaksi = reader.GetDateTime(reader.GetOrdinal("tanggal_transaksi")),
                                    namaPenyuplai = reader.GetString(reader.GetOrdinal("nama")),
                                    namaSampah = reader.GetString(reader.GetOrdinal("sub_kategori_sampah")),
                                    beratSampah = reader.GetDecimal(reader.GetOrdinal("berat_sampah")),
                                    hargaSampah = reader.GetDecimal(reader.GetOrdinal("harga")),
                                    StatusTransaksi = reader.GetString(reader.GetOrdinal("status_transaksi"))
                                };
                                listAllTransaksi.Add(transaksi);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Terjadi Kealahan Dalam Database : {ex.Message}");
                }
            }
            return listAllTransaksi;
        }
        public void konfirmasiTransaksi(int idTransaksi, int statusTransaksi)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = """
                        update transaksi set status_transaksi_id_status_transaksi = @statusTransaksi where id_transaksi = @idTransaksi;
                        """;
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("idTransaksi", idTransaksi);
                        cmd.Parameters.AddWithValue("statusTransaksi", statusTransaksi);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Terjadi Kealahan Dalam Database : {ex.Message}");
                }
            }
        }
        public List<Transaksi> GetAllTransaksiForHistoryPengepul()
        {
            List<Transaksi> listHistoryTransaksi = new List<Transaksi>();
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = """
                    select tr.id_transaksi, tr.tanggal_transaksi,p.nama, sk.sub_kategori_sampah, tr.berat_sampah, tr.harga , tr.berat_sampah * tr.harga as Total_Harga, st.status_transaksi  
                    from transaksi tr join sub_kategori_sampah sk on (sub_kategori_sampah_id_sub_kategori_sampah = id_sub_kategori_sampah) 
                    join status_transaksi st on (status_transaksi_id_status_transaksi = id_status_transaksi) 
                    join penyuplai p on (penyuplai_id_penyuplai = id_penyuplai) 
                    where status_transaksi_id_status_transaksi <> 1
                    order by tr.tanggal_transaksi desc
                    """;
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Transaksi transaksi = new Transaksi
                                {
                                    idTransaksi = reader.GetInt32(reader.GetOrdinal("id_transaksi")),
                                    tanggalTransaksi = reader.GetDateTime(reader.GetOrdinal("tanggal_transaksi")),
                                    namaPenyuplai = reader.GetString(reader.GetOrdinal("nama")),
                                    namaSampah = reader.GetString(reader.GetOrdinal("sub_kategori_sampah")),
                                    beratSampah = reader.GetDecimal(reader.GetOrdinal("berat_sampah")),
                                    hargaSampah = reader.GetDecimal(reader.GetOrdinal("harga")),
                                    totalTransaksi = reader.GetDecimal(reader.GetOrdinal("Total_Harga")),
                                    StatusTransaksi = reader.GetString(reader.GetOrdinal("status_transaksi"))
                                };
                                listHistoryTransaksi.Add(transaksi);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Terjadi Kesalahan Dalam Database : {ex.Message}");
                }

                return listHistoryTransaksi;
            }
        }
        public List<Transaksi> GetHistoryTransaksiForPenyuplai(int idPenyuplai)
        {
            List<Transaksi> listHistoryTransaksi = new List<Transaksi>();
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = """
                    select tr.id_transaksi, tr.tanggal_transaksi,p.nama, sk.sub_kategori_sampah, tr.berat_sampah, tr.harga , tr.berat_sampah * tr.harga as Total_Harga, st.status_transaksi  
                    from transaksi tr join sub_kategori_sampah sk on (sub_kategori_sampah_id_sub_kategori_sampah = id_sub_kategori_sampah) 
                    join status_transaksi st on (status_transaksi_id_status_transaksi = id_status_transaksi) 
                    join penyuplai p on (penyuplai_id_penyuplai = id_penyuplai) 
                    where p.id_penyuplai = @idPenyuplai
                    order by tr.tanggal_transaksi desc
                    """;
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("idPenyuplai", idPenyuplai);
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Transaksi transaksi = new Transaksi
                                {
                                    idTransaksi = reader.GetInt32(reader.GetOrdinal("id_transaksi")),
                                    tanggalTransaksi = reader.GetDateTime(reader.GetOrdinal("tanggal_transaksi")),
                                    namaPenyuplai = reader.GetString(reader.GetOrdinal("nama")),
                                    namaSampah = reader.GetString(reader.GetOrdinal("sub_kategori_sampah")),
                                    beratSampah = reader.GetDecimal(reader.GetOrdinal("berat_sampah")),
                                    hargaSampah = reader.GetDecimal(reader.GetOrdinal("harga")),
                                    totalTransaksi = reader.GetDecimal(reader.GetOrdinal("Total_Harga")),
                                    StatusTransaksi = reader.GetString(reader.GetOrdinal("status_transaksi"))
                                };
                                listHistoryTransaksi.Add(transaksi);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Terjadi Kesalahan Dalam Database : {ex.Message}");
                }
                return listHistoryTransaksi;
            }
        }
    }
}
