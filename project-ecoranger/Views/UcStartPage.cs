using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_ecoranger.Views
{
    public partial class UcStartPage : UserControl
    {
        public UcStartPage()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to EcoRanger! Click on the buttons to navigate through the application.", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to EcoRanger! Click on the buttons to navigate through the application.", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
