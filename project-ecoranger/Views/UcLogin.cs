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
        public UcLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UcLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            MessageBox.Show($"Selamat datang {username} ", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
