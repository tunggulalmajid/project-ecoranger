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

namespace project_ecoranger.Views
{
    public partial class FormUpdateAlamat : Form
    {
        int idPenyuplai;
        PenyuplaiContext penyuplai;
        public FormUpdateAlamat(int idPenyuplai)
        {
            InitializeComponent();
            this.idPenyuplai = idPenyuplai;
            penyuplai = new PenyuplaiContext();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string jalan = tbJalan.Text;
            string desa = tbDesa.Text;
            string kecamatan = tbKecamatan.Text;
            string kabupaten = tbKabupaten.Text;

            if (string.IsNullOrEmpty(jalan) || string.IsNullOrEmpty(desa) || string.IsNullOrEmpty(kecamatan) || string.IsNullOrEmpty(kabupaten))
            {
                MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (MessageBox.Show("Apakah Anda yakin ingin memperbarui alamat?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                penyuplai.UpdateAlamat(idPenyuplai, jalan, desa, kecamatan, kabupaten);
                MessageBox.Show("Alamat berhasil diperbarui", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
