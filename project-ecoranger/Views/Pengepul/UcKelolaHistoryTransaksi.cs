using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project_ecoranger.Controller;
using project_ecoranger.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace project_ecoranger.Views
{
    public partial class UcKelolaHistoryTransaksi : UserControl
    {
        MainForm mainform;
        TransaksiContext transaksiContext;
        List<Transaksi> listHistoryTransaksi;
        public UcKelolaHistoryTransaksi(MainForm mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
            transaksiContext = new TransaksiContext();
        }
        public void SetSesion()
        {
            listHistoryTransaksi = transaksiContext.GetAllTransaksiForHistoryPengepul();
            SetHistoryTransaksi();
        }
        public void SetHistoryTransaksi()
        {
            dgvHistoryTransaksi.DataSource = listHistoryTransaksi;

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

        private void UcKelolaHistory_Load(object sender, EventArgs e)
        {

        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"Button berhasil di klik", "sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mainform.ShowPage(mainform.kelolaHistory);
        }
    }
}
