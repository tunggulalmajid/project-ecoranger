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
    public partial class FormTambahKategori : Form
    {
        SampahContext sampahContext;
        public FormTambahKategori()
        {
            InitializeComponent();
            sampahContext = new SampahContext();
        }

        private void btnSimpan_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string namaKategori = tbKategori.Text;
            if (string.IsNullOrEmpty(namaKategori)) 
            { 
                MessageBox.Show("Nama kategori tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if(MessageBox.Show("Apakah Anda yakin ingin menambahkan kategori sampah ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sampahContext.TambahKategoriSampah(namaKategori);
                MessageBox.Show("Kategori sampah berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
