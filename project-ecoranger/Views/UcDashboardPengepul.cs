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
    public partial class UcDashboardPengepul : UserControl
    {
        MainForm mainform;
        public UcDashboardPengepul(MainForm mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            mainform.ShowDashboardPengepul();
        }

        private void btnSubKategori_Click(object sender, EventArgs e)
        {
            mainform.ShowKelolaSubKategori();
        }
        private void btnPenyuplai_Click(object sender, EventArgs e)
        {
            mainform.ShowKelolaPenyuplai();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            mainform.ShowKelolaLaporan();
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            mainform.ShowKelolaHistory();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            mainform.ShowStartPage();
        }
    }
}
