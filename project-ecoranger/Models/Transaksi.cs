using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_ecoranger.Models
{
    internal class Transaksi
    {
        public int idTransaksi { get; set; }
        public DateTime tanggalTransaksi { get; set; }
        public string namaPenyuplai {  get; set; }
        public string namaSampah {  get; set; }
        public decimal beratSampah { get; set; }
        public decimal hargaSampah { get; set; }
        public string  StatusTransaksi { get; set; }
        public decimal totalTransaksi { get; set; }

    }
}
