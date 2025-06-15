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

namespace project_ecoranger.Views
{
    public partial class FormTukarPoin : Form
    {
        int idPoin;
        int idPenyuplai;
        decimal poin;
        PoinContext poinContext;
        PenukaranPoinContext penukaranPoinContext;
        SaldoContext saldoContext;
        List<Poin> listPoin;

        MainForm mainform;

        public FormTukarPoin(MainForm mainform,int idPenyuplai)
        {
            InitializeComponent();
            this.idPenyuplai = idPenyuplai;
            poinContext = new PoinContext();
            penukaranPoinContext = new PenukaranPoinContext();
            saldoContext = new SaldoContext();
            this.mainform = mainform;

            listPoin = poinContext.GetPoin(idPenyuplai);


            this.idPoin = listPoin[0].idPoin;
            this.poin = listPoin[0].poin;

            SetPoinValue(poin);
            SetNominal();
        }

        public void SetPoinValue(decimal poin)
        {
            poinValue.Text = $"{poin}";
        }
        public void SetNominal()
        {
            for (decimal i = 20000; i <= 200000; i += 20000)
            {
                cbNominal.Items.Add(i);
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbNominal_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbHasil.Text = cbNominal.SelectedItem.ToString();
        }

        private void btnTukar_Click(object sender, EventArgs e)
        {
            decimal nominal = cbNominal.SelectedItem != null ? Convert.ToDecimal(cbNominal.SelectedItem) : 0;

            if (nominal == 0)
            {
                MessageBox.Show("Silahkan pilih nominal terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nominal > poin)
            {
                MessageBox.Show("Poin tidak mencukupi untuk penukaran ini", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                penukaranPoinContext.InsertPenukaranPoin(nominal, idPoin);
                poinContext.KurangiPoin(idPoin, nominal);
                saldoContext.TambahSaldoForPoin(idPenyuplai, nominal);
                MessageBox.Show($"Anda telah menukar {nominal} poin", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainform.dashboardPenyuplai.setSesion(idPenyuplai);
                this.Close();
                
            }
        }
        
    }
}
