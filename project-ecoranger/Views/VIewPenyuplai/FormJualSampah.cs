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
    public partial class FormJualSampah : Form
    {
        List<Models.Penyuplai> listdataPenyuplai;
        PenyuplaiContext penyuplaiContext;
        int idSampah, idPenyuplai;
        string namaPenyuplai, namaSampah, namaKategori;
        decimal hargaSampah;
        SampahContext sampahContext;
        public FormJualSampah(int idSampah, string namaSampah, string namaKategori, decimal hargaSampah, int idPenyuplai)
        {
            InitializeComponent();
            sampahContext = new SampahContext();
            this.idSampah = idSampah;
            this.namaSampah = namaSampah;
            this.namaKategori = namaKategori;
            this.hargaSampah = hargaSampah;
            this.idPenyuplai = idPenyuplai;
            penyuplaiContext = new PenyuplaiContext();
            listdataPenyuplai = penyuplaiContext.GetDataDiriPenyuplai(1);
            this.namaPenyuplai = listdataPenyuplai[0].nama;

            nama.Text = namaPenyuplai;
            sampah.Text = namaSampah;
            kategoriSampah.Text = namaKategori;
            lblhargaSampah.Text = $"Rp.{hargaSampah}";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnJual_Click(object sender, EventArgs e)
        {
            try
            {
                decimal beratSampah = Convert.ToDecimal(tbBerat.Text);
                if (beratSampah > 0)
                {
                    if(MessageBox.Show($"Apakah Anda yakin ingin menjual {beratSampah} kg sampah {namaSampah}?", "Konfirmasi Jual Sampah", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        sampahContext.JualSampah(idSampah, beratSampah, hargaSampah, idPenyuplai);
                        MessageBox.Show($"Sampah {namaSampah} seberat {beratSampah} kg berhasil dijual.", "Transaksi Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Berat sampah harus berupa angka yang valid.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
