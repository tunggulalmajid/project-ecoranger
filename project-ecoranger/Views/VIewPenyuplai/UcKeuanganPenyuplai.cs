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
    public partial class UcKeuanganPenyuplai : UserControl
    {
        MainForm mainform;
        int idPenyuplai;
        public UcKeuanganPenyuplai(MainForm mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            mainform.ShowPage(mainform.dashboardPenyuplai);
        }
        public void setSesion(int id)
        {

            idPenyuplai = id;
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

        private void btnTarikSaldo_Click(object sender, EventArgs e)
        {
            FormTarikSaldo viewTarikSaldo = new FormTarikSaldo(mainform ,idPenyuplai);
            viewTarikSaldo.ShowDialog();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            FormTukarPoin formTukarPoin = new FormTukarPoin(mainform,idPenyuplai);
            formTukarPoin.ShowDialog();
        }
    }
}
