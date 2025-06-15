using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project_ecoranger.Models;

namespace project_ecoranger.AbstractAndInterface
{
    internal interface IPenukaranPoinContext
    {
        void InsertPenukaranPoin(decimal nominal, int idPoin);
        List<PenukaranPoin> GetHistoryPenukaranForPenyuplai(int idPenyuplai);
        List<PenukaranPoin> GetHistoryPenukaranForPengepul();
    }
}
