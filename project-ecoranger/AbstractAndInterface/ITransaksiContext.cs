using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project_ecoranger.Models;

namespace project_ecoranger.AbstractAndInterface
{
    internal interface ITransaksiContext
    {
        List<Transaksi> getAllTransaksiForPengepulDashboard(int idStatus);
        List<Transaksi> getAllTransaksiForConfirmation();
        void konfirmasiTransaksi(int idTransaksi, int statusTransaksi);
        List<Transaksi> GetAllTransaksiForHistoryPengepul();
        List<Transaksi> GetHistoryTransaksiForPenyuplai(int idPenyuplai);
    }
}
