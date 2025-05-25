using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace project_ecoranger.Views
{
    public partial class UcKelolaHistory : UserControl
    {
        MainForm mainform;
        public UcKelolaHistory(MainForm mainform)
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

        private void UcKelolaHistory_Load(object sender, EventArgs e)
        {

        }



        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Button berhasil di klik", "sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPenarikan_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Button berhasil di klik", "sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPenukaranPoin_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Button berhasil di klik", "sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKonfirmasiTransaksi_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Button berhasil di klik", "sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKonfirmasiPenarikan_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Button berhasil di klik", "sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
