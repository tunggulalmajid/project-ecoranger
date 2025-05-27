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
    public partial class UcLogin : UserControl
    {
        MainForm mainForm;
        public UcLogin(MainForm mainForm)
        {
            InitializeComponent();
            cbRole.Items.Add("Admin");
            cbRole.Items.Add("Pengepul");
            cbRole.Items.Add("Penyuplai");
            this.mainForm = mainForm;
        }

        private void btnLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UcLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //string username = tbUsername.Text;
            //string password = tbPassword.Text;
            //string role = cbRole.SelectedItem.ToString();

            mainForm.ShowPage(mainForm.dashboardPenyuplai);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnToRegister_Click(object sender, EventArgs e)
        {
            mainForm.ShowPage(mainForm.registerpage);
        }
    }
}
