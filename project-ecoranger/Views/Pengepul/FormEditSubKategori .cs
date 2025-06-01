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
    public partial class FormEditSubKategori : Form
    {
        SampahContext sampahContext;
        List<Sampah> listKategori;
        int idSampah;
        public FormEditSubKategori(int id, string namaSampah, decimal harga, int idKategoriSampah, string namaKategori)
        {
            InitializeComponent();
            this.idSampah = id;
            sampahContext = new SampahContext();
            List<Sampah> listKategori = sampahContext.GetAllKategoriSampah();
            String pilihKategoriAwal = "";
            foreach (var kategori in listKategori)
            {
                if (kategori.idKategoriSampah == idKategoriSampah)
                {
                    pilihKategoriAwal += kategori.namaKategoriSampah;
                }
                cbListKategori.Items.Add(kategori.namaKategoriSampah);
            }
            cbListKategori.SelectedItem = pilihKategoriAwal;
            tbHarga.Text = harga.ToString();
            tbSubKategori.Text = namaSampah;
        }

        private void btnSimpan_Paint(object sender, PaintEventArgs e)
        {
            


        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string namaSampah = tbSubKategori.Text;
            string hargaSampah = tbHarga.Text;
            int idKategori = cbListKategori.SelectedIndex + 1;
            decimal harga = 0;

            if (string.IsNullOrEmpty(namaSampah) || string.IsNullOrEmpty(hargaSampah))
            {
                MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(hargaSampah, out harga))
            {
                MessageBox.Show("Harga harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (MessageBox.Show("Apakah Anda yakin ingin memperbarui sub kategori sampah ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sampahContext.UpdateSubKategori(idSampah, namaSampah, harga, idKategori);
                MessageBox.Show("Sub kategori sampah berhasil diperbarui", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            DialogResult = DialogResult.OK;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
