using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_ecoranger.Models
{
    internal class PenukaranPoin
    {
        public int idPenukaranPoin { get; set; }
        public DateTime tanggalPenukaran { get; set; }
        public decimal nominal { get; set; }
        public string namaPenyuplai { get; set; }
    }
}
