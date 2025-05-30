using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project_ecoranger.Models;

namespace project_ecoranger.Views
{
    public partial class UcHistoryPenyuplai : UserControl
    {
        MainForm mainform;
        int idPenyuplai;
        public UcHistoryPenyuplai(MainForm mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }
        public void setSesion(int id)
        {

            idPenyuplai = id;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            mainform.ShowPage(mainform.dashboardPenyuplai);
        }

        private void btnDataDiri_Click(object sender, EventArgs e)
        {
            mainform.ShowPage(mainform.viewDataDiriPenyuplai);
        }
        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            mainform.ShowPage(mainform.viewTransaksiPenyuplai);
        }

        private void btnHistoryPenyuplai_Click(object sender, EventArgs e)
        {
            mainform.ShowPage(mainform.viewHistoryPenyuplai);
        }

        private void BtnKeuangan_Click(object sender, EventArgs e)
        {
            mainform.ShowPage(mainform.viewKeuanganPenyuplai);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            mainform.ShowPage(mainform.startPage);
        }

        private void btnHistoryTransaksi_Click(object sender, EventArgs e)
        {
            mainform.ShowPage(mainform.viewHistoryTransaksiPenyuplai);
        }

        private void btnHistoryPenarikan_Click(object sender, EventArgs e)
        {
            mainform.ShowPage(mainform.viewHistoryPenarikanPenyuplai);
        }

        private void btnHistoryPenukaranPoin_Click(object sender, EventArgs e)
        {
            mainform.ShowPage(mainform.viewHistoryPenukaranPoin);

        }
    }
}
