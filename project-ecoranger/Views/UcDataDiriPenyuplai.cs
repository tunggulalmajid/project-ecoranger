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
    public partial class UcDataDiriPenyuplai : UserControl
    {
        MainForm mainform;
        public UcDataDiriPenyuplai(MainForm mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            mainform.ShowDashboardPenyuplai();
        }

        private void btnDataDiri_Click(object sender, EventArgs e)
        {
            mainform.ShowDataDiriPenyuplai();
        }
        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            mainform.ShowTransaksiPenyuplai();
        }

        private void btnHistoryPenyuplai_Click(object sender, EventArgs e)
        {
            mainform.ShowHistoryPenyuplai();
        }

        private void BtnKeuangan_Click(object sender, EventArgs e)
        {
            mainform.ShowKeuanganPenyuplai();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            mainform.ShowStartPage();
        }
    }
}
