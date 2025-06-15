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
    public partial class FormTarikSaldo : Form
    {

        int idsaldo;
        decimal saldo;
        int idPenyuplai;
        SaldoContext saldoContext;
        BankcContext bankContext;
        List<Bank> listbank;
        List<Saldo> listSaldo;
        PenarikanContext penarikanContext;
        MainForm mainform;

        public FormTarikSaldo(MainForm mainform, int idPenyuplai)
        {
            InitializeComponent();
            saldoContext = new SaldoContext();
            penarikanContext = new PenarikanContext(); 
            listSaldo = saldoContext.getSaldo(idPenyuplai);
            bankContext = new BankcContext();
            this.mainform = mainform;
            this.idPenyuplai = idPenyuplai;

            listbank = bankContext.GetDataBank();
            this.idsaldo = listSaldo[0].idSaldo;
            this.saldo = listSaldo[0].saldo;

            saldoValue.Text = $"Rp.{saldo}";

            SetValueNominal();
            SetValueBank();
        }
        public void SetValueNominal()
        {
            for (int i = 50000; i <= 500000; i += 50000)
            {
                cbNominal.Items.Add(i);
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
            int idStatusPenarikan = 1;

            if (nominal == 0 || string.IsNullOrEmpty(nomorRekening) || string.IsNullOrEmpty(namaBank))
            {
                MessageBox.Show("Mohon lengkapi semua field yang diperlukan.");
                return;
            }
            if (nomorRekening.Length < 10 || nomorRekening.Length > 15)
            {
                MessageBox.Show("Nomor rekening harus terdiri dari 10 hingga 15 digit.");
            }
            else
            {
                try
                {
                    Int64 fixedNomorRekening = Convert.ToInt64(tbRekening.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Nomor rekening harus berupa angka.");
                    return;
                }

                int idBank = GetIdBank(namaBank);
                if (nominal > saldo)
                {
                    MessageBox.Show("Saldo tidak mencukupi untuk penarikan ini.");
                }
                else
                {
                    penarikanContext.InsertPenarikanSaldo(nominal, idsaldo, idStatusPenarikan, nomorRekening, idBank);
                    MessageBox.Show($"Permintaan penarikan Saldo sebesar Rp.{nominal} ke rekening {nomorRekening} dalam bank {namaBank} Berhasil Dikirim ke admin, silahkan tunggu konfirmasi.", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mainform.dashboardPenyuplai.setSesion(idPenyuplai);
                    this.Close();
                }
            }
           
        }
    }
}
