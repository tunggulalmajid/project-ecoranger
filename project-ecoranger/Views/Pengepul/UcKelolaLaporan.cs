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
    public partial class UcKelolaLaporan : UserControl
    {
        MainForm mainform;
        LaporanContext laporanContext;
        decimal? totalBeratKeseluruhan, totalAset;

        List<Laporan> listAllLaporan;
        public UcKelolaLaporan(MainForm mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
            laporanContext = new LaporanContext();
            
        }
        public void SetSesion()
        {
            totalBeratKeseluruhan = laporanContext.GetTotalBeratkeseluruhanForPengepul();
            totalAset = laporanContext.GetTotalAsetForPengepul();
            listAllLaporan = laporanContext.GetDataLaporanForPengepul();
            SetTotalAset(); 
            SetTotalBerat();
            SetLaporan();
        }
        public void SetTotalBerat()
        {
            lblTotalBerat.Text = $"{totalBeratKeseluruhan} Kg";
        }
        public void SetTotalAset()
        {
            lblJumlahAset.Text = $"Rp.{totalAset}";
        }
        public void SetLaporan()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var value in listAllLaporan)
            {
                Panel fillCard2 = new Panel();
                Label judul = new Label();
                Label kategoriLabel = new Label();
                Label hargaSampahLabel = new Label();
                Label kategoriValue = new Label();
                Label totalBerat = new Label();
                Label totalBeratLabel = new Label();
                Label hargaSampahValue = new Label();


                fillCard2.BackColor = Color.Transparent;
                fillCard2.BackgroundImage = Properties.Resources.fillCard;
                fillCard2.BackgroundImageLayout = ImageLayout.Zoom;
                fillCard2.Controls.Add(hargaSampahValue);
                fillCard2.Controls.Add(kategoriValue);
                fillCard2.Controls.Add(hargaSampahLabel);
                fillCard2.Controls.Add(kategoriLabel);
                fillCard2.Controls.Add(totalBeratLabel);
                fillCard2.Controls.Add(totalBerat);
                fillCard2.Controls.Add(judul);
                fillCard2.Name = "fillCard2";
                fillCard2.Size = new Size(289, 344);
                fillCard2.TabIndex = 2;

                judul.AutoSize = true;
                judul.Font = new Font("Roboto Black", 20F, FontStyle.Bold);
                judul.ForeColor = SystemColors.Control;
                judul.Location = new Point(23, 17);
                judul.Name = "judul";
                judul.Size = new Size(113, 33);
                judul.TabIndex = 3;
                judul.Text = value.namaSampah;

                kategoriLabel.AutoSize = true;
                kategoriLabel.Font = new Font("Roboto Black", 12F, FontStyle.Bold);
                kategoriLabel.ForeColor = SystemColors.Control;
                kategoriLabel.Location = new Point(23, 100);
                kategoriLabel.Name = "kategoriLabel";
                kategoriLabel.Size = new Size(147, 19);
                kategoriLabel.TabIndex = 4;
                kategoriLabel.Text = "kategori Sampah : ";

                hargaSampahLabel.AutoSize = true;
                hargaSampahLabel.Font = new Font("Roboto Black", 12F, FontStyle.Bold);
                hargaSampahLabel.ForeColor = SystemColors.Control;
                hargaSampahLabel.Location = new Point(23, 170);
                hargaSampahLabel.Name = "hargaSampahLabel";
                hargaSampahLabel.Size = new Size(130, 19);
                hargaSampahLabel.TabIndex = 5;
                hargaSampahLabel.Text = "Total Aset : ";

                kategoriValue.AutoSize = true;
                kategoriValue.Font = new Font("Roboto Black", 20F, FontStyle.Bold);
                kategoriValue.ForeColor = SystemColors.Control;
                kategoriValue.Location = new Point(22, 115);
                kategoriValue.Name = "kategoriValue";
                kategoriValue.Size = new Size(113, 33);
                kategoriValue.TabIndex = 6;
                kategoriValue.Text = value.kategoriSampah;

                hargaSampahValue.AutoSize = true;
                hargaSampahValue.Font = new Font("Roboto Black", 20F, FontStyle.Bold);
                hargaSampahValue.ForeColor = SystemColors.Control;
                hargaSampahValue.Location = new Point(22, 190);
                hargaSampahValue.Name = "hargaSampahValue";
                hargaSampahValue.Size = new Size(113, 33);
                hargaSampahValue.TabIndex = 7;
                hargaSampahValue.Text = $"Rp.{value.totalAset}";

                totalBerat.AutoSize = true;
                totalBerat.Font = new Font("Roboto Black", 20F, FontStyle.Bold);
                totalBerat.ForeColor = SystemColors.Control;
                totalBerat.Location = new Point(22, 265);
                totalBerat.Name = "TotalBerat";
                totalBerat.Size = new Size(113, 33);
                totalBerat.TabIndex = 7;
                totalBerat.Text = $"{value.totalBerat} Kg";

                totalBeratLabel.AutoSize = true;
                totalBeratLabel.Font = new Font("Roboto Black", 12F, FontStyle.Bold);
                totalBeratLabel.ForeColor = SystemColors.Control;
                totalBeratLabel.Location = new Point(22, 250);
                totalBeratLabel.Name = "totalBeratLabel";
                totalBeratLabel.Size = new Size(147, 19);
                totalBeratLabel.TabIndex = 4;
                totalBeratLabel.Text = "Total Berat Sampah : ";

                this.Controls.Add(fillCard2);


                flowLayoutPanel1.Controls.Add(fillCard2);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            mainform.ShowPage(mainform.dashboardPengepul);
        }

        private void btnSubKategori_Click(object sender, EventArgs e)
        {
            mainform.ShowPage(mainform.kelolaSubKategori);
        }
        private void btnPenyuplai_Click(object sender, EventArgs e)
        {
            mainform.ShowPage(mainform.kelolaPenyuplai);
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            mainform.ShowPage(mainform.kelolaLaporan);
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            mainform.ShowPage(mainform.kelolaHistory);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            mainform.ShowPage(mainform.startPage);
        }
    }
}
