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
    public partial class UcKelolaSubKategori : UserControl
    {
        MainForm mainform;
        SampahContext sampahContext;
        List<Sampah> listAllSampah;
        public UcKelolaSubKategori(MainForm mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }
        public void SetSesion()
        {
            sampahContext = new SampahContext();
            listAllSampah = sampahContext.GetListSampah();
            int jarak = 375;
            flowLayoutPanel1.Controls.Clear();
            foreach (var value in listAllSampah)
            {
                int id = value.idSampah;
                string namaSampah = value.namaSampah;
                decimal harga = value.hargaSampah;
                int idKategoriSampah = value.idKategoriSampah;
                string namaKategori = value.namaKategoriSampah;

                Panel fillCard2 = new Panel();
                Panel btnHapus = new Panel();
                Label judul = new Label();
                Label kategoriLabel = new Label();
                Label hargaSampahLabel = new Label();
                Label kategoriValue = new Label();
                Label hargaSampahValue = new Label();
                Panel btnEdit = new Panel();


                fillCard2.BackColor = Color.Transparent;
                fillCard2.BackgroundImage = Properties.Resources.fillCard;
                fillCard2.BackgroundImageLayout = ImageLayout.Zoom;
                fillCard2.Controls.Add(btnEdit);
                fillCard2.Controls.Add(btnHapus);
                fillCard2.Controls.Add(hargaSampahValue);
                fillCard2.Controls.Add(kategoriValue);
                fillCard2.Controls.Add(hargaSampahLabel);
                fillCard2.Controls.Add(kategoriLabel);
                fillCard2.Controls.Add(judul);
                fillCard2.Location = new Point(jarak, 200);
                fillCard2.Name = "fillCard2";
                fillCard2.Size = new Size(289, 344);
                fillCard2.TabIndex = 2;

                btnHapus.BackColor = Color.Transparent;
                btnHapus.BackgroundImage = Properties.Resources.btnHapus;
                btnHapus.BackgroundImageLayout = ImageLayout.Zoom;
                btnHapus.Location = new Point(23, 283);
                btnHapus.Name = "btnJual2";
                btnHapus.Size = new Size(122, 45);
                btnHapus.TabIndex = 3;
                btnHapus.Click += (s, e) =>
                {
                    if (MessageBox.Show("Apakah Anda yakin ingin menghapus sampah ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        sampahContext.HapusSampahForPengepul(id);
                        MessageBox.Show("Sampah berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SetSesion();
                    }
                };

                btnEdit.BackColor = Color.Transparent;
                btnEdit.BackgroundImage = Properties.Resources.btnEdit;
                btnEdit.BackgroundImageLayout = ImageLayout.Zoom;
                btnEdit.Location = new Point(150, 283);
                btnEdit.Name = "btnJual2";
                btnEdit.Size = new Size(122, 45);
                btnEdit.TabIndex = 3;
                btnEdit.Click += (s, e) =>
                {
                    FormEditSubKategori formEditSubKategori = new FormEditSubKategori(id, namaSampah, harga, idKategoriSampah, namaKategori);
                    if(formEditSubKategori.ShowDialog() == DialogResult.OK)
                    {
                        
                        SetSesion();
                    }
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
        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormTambahKategori formTambahKategori = new FormTambahKategori();
            formTambahKategori.ShowDialog();

        }

        private void btnTambahSubKategori_Click(object sender, EventArgs e)
        {
            FormTambahSubKategori formTambahSubKategori = new FormTambahSubKategori();
            if (formTambahSubKategori.ShowDialog() == DialogResult.OK)
            {
                flowLayoutPanel1.Controls.Clear();
                SetSesion();
            }
        }
    }
}
