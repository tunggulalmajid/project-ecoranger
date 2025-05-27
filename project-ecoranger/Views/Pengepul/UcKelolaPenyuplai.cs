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
    public partial class UcKelolaPenyuplai : UserControl
    {
        MainForm mainform;
        public UcKelolaPenyuplai(MainForm mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            mainform.ShowPage(mainform.dashboardPengepul);
        }

        private void btnSubKategori_Click(object sender, EventArgs e)
        {
            mainform.ShowPage(mainform.kelolaSubKategori);
        }
        private void btnPenyuplai_Click(object sender, EventArgs e)
        {
            mainform.ShowPage(mainform.kelolaPenyuplai);
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            mainform.ShowPage(mainform.kelolaLaporan);
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            mainform.ShowPage(mainform.kelolaHistory);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            mainform.ShowPage(mainform.startPage);
        }
    }
}
