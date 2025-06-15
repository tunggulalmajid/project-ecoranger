using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using project_ecoranger.Models;

namespace project_ecoranger.AbstractAndInterface
{
    internal interface IPenyuplaiContext
    {
        bool LoginPenyuplai(string username, string password, out int idPenyuplai);
        void RegisterPenyuplai(string nama, BigInteger nomorTelepon, string email, string username, string password);
        void CreateAlamat(string username, string password);
        void GetIdAfterRegist(string username, string password, out int idPenyuplai);
        List<Penyuplai> GetDataDiriPenyuplai(int idPenyuplai);
        void UpdateDatadiri(int idPenyuplai, string nama, BigInteger nomorTelepon, string email);
        void UpdateAlamat(int idPenyuplai, string jalan, string desa, string kecamatan, string kabupaten);
        int GetJumlahPenyuplai();
        List<Penyuplai> GetAllPenyuplai();
        int GetIdPenyuplaiUseTransaksi(int idTransaksi);
    }
}
