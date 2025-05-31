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
    public partial class UcTransaksiPenyuplai : UserControl
    {
        MainForm mainform;
        int idPenyuplai;
        SampahContext sampahContext;
        List<Sampah> listSampah;

        public UcTransaksiPenyuplai(MainForm mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
            sampahContext = new SampahContext();
            listSampah = sampahContext.GetListSampah();
            getCard(listSampah);
        }
        public void getCard(List<Sampah> sampah)
        {
            int jarak = 375;
            foreach (var value in sampah)
            {
                int id = value.idSampah;
                string namaSampah = value.namaSampah;
                decimal harga = value.hargaSampah;
                int idKategoriSampah = value.idKategoriSampah;
                string namaKategori = value.namaKategoriSampah;

                Panel fillCard2 = new Panel();
                Panel btnJual2 = new Panel();
                Label judul = new Label();
                Label kategoriLabel = new Label();
                Label hargaSampahLabel = new Label();
                Label kategoriValue = new Label();
                Label hargaSampahValue = new Label();


                fillCard2.BackColor = Color.Transparent;
                fillCard2.BackgroundImage = Properties.Resources.fillCard;
                fillCard2.BackgroundImageLayout = ImageLayout.Zoom;
                fillCard2.Controls.Add(btnJual2);
                fillCard2.Controls.Add(hargaSampahValue);
                fillCard2.Controls.Add(kategoriValue);
                fillCard2.Controls.Add(hargaSampahLabel);
                fillCard2.Controls.Add(kategoriLabel);
                fillCard2.Controls.Add(judul);
                fillCard2.Location = new Point(jarak, 200);
                fillCard2.Name = "fillCard2";
                fillCard2.Size = new Size(289, 344);
                fillCard2.TabIndex = 2;

                btnJual2.BackColor = Color.Transparent;
                btnJual2.BackgroundImage = Properties.Resources.btnCardJual;
                btnJual2.BackgroundImageLayout = ImageLayout.Zoom;
                btnJual2.Location = new Point(23, 283);
                btnJual2.Name = "btnJual2";
                btnJual2.Size = new Size(245, 44);
                btnJual2.TabIndex = 3;
                btnJual2.Click += (s, e) =>
                {
                    JualSampah(id, namaSampah, namaKategori, harga, idPenyuplai);
                };

                judul.AutoSize = true;
                judul.Font = new Font("Roboto Black", 20F, FontStyle.Bold);
                judul.ForeColor = SystemColors.Control;
                judul.Location = new Point(23, 17);
                judul.Name = "judul";
                judul.Size = new Size(113, 33);
                judul.TabIndex = 3;
                judul.Text = namaSampah;

                kategoriLabel.AutoSize = true;
                kategoriLabel.Font = new Font("Roboto Black", 12F, FontStyle.Bold);
                kategoriLabel.ForeColor = SystemColors.Control;
                kategoriLabel.Location = new Point(23, 155);
                kategoriLabel.Name = "kategoriLabel";
                kategoriLabel.Size = new Size(147, 19);
                kategoriLabel.TabIndex = 4;
                kategoriLabel.Text = "kategori Sampah : ";

                hargaSampahLabel.AutoSize = true;
                hargaSampahLabel.Font = new Font("Roboto Black", 12F, FontStyle.Bold);
                hargaSampahLabel.ForeColor = SystemColors.Control;
                hargaSampahLabel.Location = new Point(23, 222);
                hargaSampahLabel.Name = "hargaSampahLabel";
                hargaSampahLabel.Size = new Size(130, 19);
                hargaSampahLabel.TabIndex = 5;
                hargaSampahLabel.Text = "Harga Sampah : ";

                kategoriValue.AutoSize = true;
                kategoriValue.Font = new Font("Roboto Black", 20F, FontStyle.Bold);
                kategoriValue.ForeColor = SystemColors.Control;
                kategoriValue.Location = new Point(22, 178);
                kategoriValue.Name = "kategoriValue";
                kategoriValue.Size = new Size(113, 33);
                kategoriValue.TabIndex = 6;
                kategoriValue.Text = namaKategori;

                hargaSampahValue.AutoSize = true;
                hargaSampahValue.Font = new Font("Roboto Black", 20F, FontStyle.Bold);
                hargaSampahValue.ForeColor = SystemColors.Control;
                hargaSampahValue.Location = new Point(22, 242);
                hargaSampahValue.Name = "hargaSampahValue";
                hargaSampahValue.Size = new Size(113, 33);
                hargaSampahValue.TabIndex = 7;
                hargaSampahValue.Text = $"Rp.{harga}";

                this.Controls.Add(fillCard2);

                jarak += fillCard2.Height + 5;

            }

        }
        private void JualSampah(int idSampah, string namaSampah ,string namaKategori, decimal hargaSampah, int idPenyuplai)
        {
            FormJualSampah formJualSampah = new FormJualSampah(idSampah, namaSampah, namaKategori, hargaSampah, idPenyuplai);
            formJualSampah.ShowDialog();
        }
        public void setSesion(int id)
        {
            this.idPenyuplai = id;

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            mainform.ShowPage(mainform.dashboardPenyuplai);
        }

        private void btnDataDiri_Click(object sender, EventArgs e)
        {
            mainform.ShowPage(mainform.viewDataDiriPenyuplai);
        }
        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            mainform.ShowPage(mainform.viewTransaksiPenyuplai);
        }

        private void btnHistoryPenyuplai_Click(object sender, EventArgs e)
        {
            mainform.ShowPage(mainform.viewHistoryPenyuplai);
        }

        private void BtnKeuangan_Click(object sender, EventArgs e)
        {
            mainform.ShowPage(mainform.viewKeuanganPenyuplai);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            mainform.ShowPage(mainform.startPage);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
