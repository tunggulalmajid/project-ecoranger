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
        SaldoContext saldoContext;
        public FormTarikSaldo(int idPenyuplai)
        {
            saldoContext = new SaldoContext();
            this.idsaldo = saldoContext.GetIdSaldo(idPenyuplai);
            InitializeComponent();
        }
    }
}
