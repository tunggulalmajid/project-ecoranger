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
    public partial class FormTukarPoin : Form
    {
        int idPoin;
        decimal poin;
        PoinContext poinContext;
        PenukaranPoinContext penukaranPoinContext;  
        List<Poin> listPoin;

        public FormTukarPoin(int idPenyuplai)
        {
            InitializeComponent();
            poinContext = new PoinContext();
            penukaranPoinContext = new PenukaranPoinContext();
            listPoin = poinContext.GetPoin(idPenyuplai);

            this.idPoin = listPoin[0].idPoin;
            this.poin = listPoin[0].poin;
        }
        
    }
}
