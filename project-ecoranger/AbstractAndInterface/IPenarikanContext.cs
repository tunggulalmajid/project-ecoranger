using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project_ecoranger.Models;

namespace project_ecoranger.AbstractAndInterface
{
    internal interface IPenarikanContext
    {
        void InsertPenarikanSaldo(decimal nominal, int idSaldo, int idStatusPenarikan, string nomorRekening, int idBank);
        List<PenarikanSaldo> GetHistoryPenarikanSaldoForPenyuplai(int idPenyuplai);
        List<PenarikanSaldo> GetHistoryPenarikanSaldoForPengepul();
        List<PenarikanSaldo> GetListPenarikanForKonfirmasi();
        void KonfirmasiPenarikan(int idPenarikan, int idStatusPenarikan);
    }
}
