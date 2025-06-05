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
        PenarikanContext penarikanContext;

        public FormTarikSaldo(int idPenyuplai)
        {
            InitializeComponent();
            saldoContext = new SaldoContext();
            penarikanContext = new PenarikanContext(); 
            listSaldo = saldoContext.getSaldo(idPenyuplai);
            bankContext = new BankcContext();
            listbank = bankContext.GetDataBank();
            this.idsaldo = listSaldo[0].idSaldo;
            this.saldo = listSaldo[0].saldo;

            saldoValue.Text = $"Rp.{saldo}";

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
            foreach (var bank in listbank)
            {
                cbBank.Items.Add(bank.namaBank);
            }
        }
        public int GetIdBank(string namaBank)
        {
            int idBank = 0;
            foreach (var bank in listbank)
            {
                if (bank.namaBank == namaBank)
                {
                    idBank = bank.idBank;
                    break;
                }
            }
            return idBank;
        }
        private void panel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTarik_Click(object sender, EventArgs e)
        {
            decimal nominal = cbNominal.SelectedItem != null ? Convert.ToDecimal(cbNominal.SelectedItem) : 0;
            string nomorRekening = tbRekening.Text;
            string namaBank = cbBank.SelectedItem != null ? cbBank.SelectedItem.ToString() : string.Empty;

            if (nominal <= 0 || string.IsNullOrEmpty(nomorRekening) || string.IsNullOrEmpty(namaBank))
            {
                MessageBox.Show("Mohon lengkapi semua field yang diperlukan.");
                return;
            }
            try
            {
                Int64 fixedNomorRekening = Convert.ToInt64(tbRekening.Text);

            }
            catch (FormatException)
            {
                MessageBox.Show("Nomor rekening harus berupa angka.");
                return;
            }

            if (nominal > saldo)
            {
                MessageBox.Show("Saldo tidak mencukupi untuk penarikan ini.");
            }

            else
            {
                MessageBox.Show($"Anda akan menarik saldo sebesar Rp.{nominal} ke rekening {nomorRekening} di bank {namaBank}.");
            }
        }
    }
}
