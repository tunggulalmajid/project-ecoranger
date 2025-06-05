using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_ecoranger.Models
{
    internal class PenarikanSaldo
    {
        public int idPenarikanSaldo { get;set; }
        public DateTime tanggalPenarikan { get; set; }
        public decimal nominal { get; set; }    
        public string nama { get; set; }
        public  string nomorRekening { get; set; }
        public string namaBank { get; set; }
        public string statusPenarikan { get; set; }
    }
}
