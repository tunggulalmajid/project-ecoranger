using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_ecoranger.AbstractAndInterface
{
    internal interface IPengepulContext
    {
        bool LoginPengepul(string username, string password);
    }
}
