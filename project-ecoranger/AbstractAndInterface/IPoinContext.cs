using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project_ecoranger.Models;

namespace project_ecoranger.AbstractAndInterface
{
    internal interface IPoinContext
    {
        List<Poin> GetPoin(int idPenyuplai);
        void TambahPoinForTransaksi(int idTransaksi, decimal beratSampah);
        void KurangiPoin(int idPoin, decimal nominal);
        decimal? SetNominalPoinForTransaksi(decimal berat);
        void CreatePoin(string username, string password);
    }
}
