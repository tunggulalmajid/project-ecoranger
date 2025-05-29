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
    public partial class UcDataDiriPenyuplai : UserControl
    {
        MainForm mainform;
        int idPenyuplai = 18;
        List<Penyuplai> DataDiriPenyuplai;
        PenyuplaiContext penyuplai;
        public UcDataDiriPenyuplai(MainForm mainform)
        {
            penyuplai = new PenyuplaiContext();
            InitializeComponent();
            this.mainform = mainform;
            LoadValue();
        }
        public void LoadValue()
        {
            try
            {
                DataDiriPenyuplai = penyuplai.GetDataDiriPenyuplai(idPenyuplai);
                nama.Text = $" NAMA : {DataDiriPenyuplai[0].nama}";
                nomorHp.Text = $" NOMOR TELEPON : {DataDiriPenyuplai[0].noTelp}";
                email.Text = $" EMAIL : {DataDiriPenyuplai[0].email}";
                alamat.Text = $" ALAMAT : {DataDiriPenyuplai[0].alamat}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEditDataNama_Click(object sender, EventArgs e)
        {
            FormUpdateDataDiri formUpdateDataDiri = new FormUpdateDataDiri(idPenyuplai);
            if(formUpdateDataDiri.ShowDialog() == DialogResult.OK)
            {
                LoadValue();
            }
        }

        private void btnEditAlamat_Click(object sender, EventArgs e)
        {
            FormUpdateAlamat formUpdateAlamat = new FormUpdateAlamat(idPenyuplai);
            if (formUpdateAlamat.ShowDialog() == DialogResult.OK)
            {
                LoadValue();
            }
        }
    }
}
