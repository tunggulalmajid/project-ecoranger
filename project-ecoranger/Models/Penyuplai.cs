using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using project_ecoranger.AbstractAndInterface;

namespace project_ecoranger.Models
{
    internal class Penyuplai : AbsUser
    {
        public int idPenyuplai { get; set; }
        public string nama { get; set; }
        public BigInteger noTelp { get; set; }
        public string alamat { get; set; }
        public string email { get; set; }
    }
}
