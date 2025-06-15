using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project_ecoranger.Models;

namespace project_ecoranger.AbstractAndInterface
{
    internal interface IBankContext
    {
        List<Bank> GetDataBank();
    }
}
