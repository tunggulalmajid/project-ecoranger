using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project_ecoranger.Models;

namespace project_ecoranger.AbstractAndInterface
{
    internal interface ISaldoContext
    {
        List<Saldo> getSaldo(int idPenyuplai);
        void TambahSaldoForTransaksi(int idTransaksi, decimal nominal);
        void TambahSaldoForPoin(int idPenyuplai, decimal nominal);
        void KurangiSaldoForPenarikan(int idPenarikan, decimal nominal);
        int GetIdSaldoForKonfirmasi(int idPenarikan);
        void CreateSaldo(string username, string password);
    }
}
