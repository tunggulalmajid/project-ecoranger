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
    public partial class FormTarikSaldo : Form
    {

        int idsaldo;
        decimal saldo;
        SaldoContext saldoContext;
        BankcContext bankContext;
        List<Bank> listbank;
        List<Saldo> listSaldo;
        
        public FormTarikSaldo(int idPenyuplai)
        {
            InitializeComponent();
            saldoContext = new SaldoContext();
            listSaldo = saldoContext.getSaldo(idPenyuplai);
            this.idsaldo = listSaldo[0].idSaldo;
            this.saldo = listSaldo[0].saldo;

            saldoValue.Text = $"Rp.{saldo}";

            bankContext = new BankcContext();
            SetValueNominal();
            SetValueBank();
        }
        public void SetValueNominal()
        {
            List<decimal> nominal = [50000, 100000, 150000, 200000, 250000, 300000, 350000, 400000];
            foreach (decimal value in nominal)
            {
                cbNominal.Items.Add(value);
            }
        }
        public void SetValueBank()
        {
            List<Bank> listbank = bankContext.GetDataBank();
            foreach (var bank in listbank)
            {
                cbBank.Items.Add(bank.namaBank);
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
