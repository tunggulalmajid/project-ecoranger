using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project_ecoranger.Models;

namespace project_ecoranger.AbstractAndInterface
{
    internal interface ISampahContext
    {
        List<Sampah> GetListSampah();
        void JualSampah(int idSampah, decimal beratSampah, decimal hargaSampah, int idPenyuplai);
        void HapusSampahForPengepul(int idSampah);
        List<Sampah> GetAllKategoriSampah();
        void UpdateSubKategori(int idSampah, string namaSampah, decimal hargaSampah, int idKategoriSampah);
        void TambahSubKategori(string namaSampah, decimal hargaSampah, int idKategoriSampah);
        void TambahKategoriSampah(string namaKategoriSampah);
        List<Sampah> GetListSampahForDashboard(int idPenyuplai);
    }
}
