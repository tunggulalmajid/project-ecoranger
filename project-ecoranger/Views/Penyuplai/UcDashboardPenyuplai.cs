using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_ecoranger.Views
{
    public partial class UcDashboardPenyuplai : UserControl
    {
        MainForm mainform;
        int idPenyuplai;
        public UcDashboardPenyuplai(MainForm mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
            setSesion(1);
        }
        public void setSesion(int id)
        {
            this.idPenyuplai = id;
            mainform.viewDataDiriPenyuplai.setSesion(id);
            mainform.viewTransaksiPenyuplai.setSesion(id);
            mainform.viewHistoryPenyuplai.setSesion(id);
            mainform.viewKeuanganPenyuplai.setSesion(id);
            mainform.viewHistoryTransaksiPenyuplai.setSesion(id);
            mainform.viewHistoryPenarikanPenyuplai.setSesion(id);
            mainform.viewHistoryPenukaranPoin.setSesion(id);
            label1.Text = $"Dashboard Penyediaan Barang{id}";
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
    }
}
