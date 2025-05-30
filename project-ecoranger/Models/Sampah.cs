using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace project_ecoranger.Models
{
    public class Sampah
    {
        public int idSampah { get; set; }
        public string namaSampah { get; set; }
        public Decimal hargaSampah { get; set; }
        public int idKategoriSampah { get; set; }
        public string namaKategoriSampah { get; set; }

    }
}
