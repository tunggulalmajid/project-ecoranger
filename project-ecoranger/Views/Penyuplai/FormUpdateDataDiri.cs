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
    public partial class FormUpdateDataDiri : Form
    {
        int idPenyuplai;
        PenyuplaiContext penyuplai;

        public FormUpdateDataDiri(int idPenyuplai)
        {
            InitializeComponent();
            this.idPenyuplai = idPenyuplai;
            penyuplai = new PenyuplaiContext();
        }


        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string nama = tbNama.Text;
            string NoTelp = tbNoTelp.Text;
            string email = tbEmail.Text;

            if (string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(tbNoTelp.Text) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Email tidak valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else 
            {
                Int64 NomorTelepon = Convert.ToInt64(NoTelp);
                if (MessageBox.Show("Apakah Anda yakin ingin memperbarui data diri?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    penyuplai.UpdateDatadiri(idPenyuplai, nama, NomorTelepon, email);
                    MessageBox.Show("Data berhasil diperbarui", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                }
            }
            

        }
    }
}
