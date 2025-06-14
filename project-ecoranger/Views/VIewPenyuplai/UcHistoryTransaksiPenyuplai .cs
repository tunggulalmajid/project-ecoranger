﻿using System;
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

namespace project_ecoranger.Views
{
    public partial class UcHistoryTransaksiPenyuplai : UserControl
    {
        MainForm mainform;
        int idPenyuplai;
        TransaksiContext transaksiContext;
        List<Transaksi> listHistoryTransaksi;
        public UcHistoryTransaksiPenyuplai(MainForm mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
            transaksiContext = new TransaksiContext();
        }
        public void setSesion(int id)
        {
            idPenyuplai = id;
            LoadData(idPenyuplai);
        }
        public void LoadData(int idPenyuplai)
        {
            listHistoryTransaksi = transaksiContext.GetHistoryTransaksiForPenyuplai(idPenyuplai);
            dgvHistoryTransaksi.DataSource = listHistoryTransaksi;

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
        private void btnKembali_Click(object sender, EventArgs e)
        {
            mainform.ShowPage(mainform.viewHistoryPenyuplai);
        }
    }
}
