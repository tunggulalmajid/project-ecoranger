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
    public partial class UcRegister : UserControl
    {
        MainForm mainForm;
        public UcRegister(MainForm mainForm)
        {
            InitializeComponent();
            cbRole.Items.Add("Pengepul");
            cbRole.Items.Add("Penyuplai");
            this.mainForm = mainForm;
        }

        private void UcRegister_Load(object sender, EventArgs e)
        {

        }

        private void tbNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string nama = tbNama.Text;
            string nomotTelepon = tbNomorTelepon.Text;
            string email = tbEmail.Text;
            string role = cbRole.SelectedItem.ToString();
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string konfirmasiPassword = tbKonfirmasiPw.Text;
            string jalan = tbJalan.Text;
            string desa = tbDesa.Text;
            string kecamatan = tbKecamatan.Text;
            string kabupaten = tbKabupaten.Text;

            MessageBox.Show($"berhasil register silahkan lakukan login", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnToLogin_Click(object sender, EventArgs e)
        {
            mainForm.ShowPage(mainForm.loginPage);
        }
    }
}
