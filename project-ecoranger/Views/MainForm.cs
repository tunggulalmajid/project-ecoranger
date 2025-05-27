using System.Net;
using project_ecoranger.Views;

namespace project_ecoranger
{
    public partial class MainForm : Form
    {
        UcLoadingScreen loadingScreen;
        UcStartPage startPage;
        UcLogin loginPage;
        UcRegister registerpage;
        UcDashboardPengepul dashboardPengepul;
        UcKelolaPenyuplai kelolaPenyuplai;
        UcKelolaSubKategori kelolaSubKategori;
        UcKelolaLaporan kelolaLaporan;
        UcKelolaHistory kelolaHistory;
        UcKelolaHistoryTransaksi kelolaHistoryTransaksi;
        UcKelolaHistoryPenukaran kelolaHistoryPenukaran;
        UcKelolaHistoryPenarikan kelolaHistoryPenarikan;
        UcKelolaKonfirmasiTransaksi kelolaKonfirmasiTransaksi;
        UcKelolaKonfirmasiPenarikan kelolaKonfirmasiPenarikan;
        UcDashboardPenyuplai dashboardPenyuplai;
        UcDataDiriPenyuplai viewDataDiriPenyuplai;
        UcTransaksiPenyuplai viewTransaksiPenyuplai;
        UcHistoryPenyuplai viewHistoryPenyuplai;
        UcKeuanganPenyuplai viewKeuanganPenyuplai;

        System.Windows.Forms.Timer timer;
        public MainForm()
        {
            InitializeComponent();
            loadingScreen = new UcLoadingScreen();
            startPage = new UcStartPage(this);
            loginPage = new UcLogin(this);
            registerpage = new UcRegister(this);
            dashboardPengepul = new UcDashboardPengepul(this);
            kelolaPenyuplai = new UcKelolaPenyuplai(this);
            kelolaSubKategori = new UcKelolaSubKategori(this);
            kelolaLaporan = new UcKelolaLaporan(this);
            kelolaHistory = new UcKelolaHistory(this);
            dashboardPenyuplai = new UcDashboardPenyuplai(this);
            kelolaHistoryTransaksi = new UcKelolaHistoryTransaksi(this);
            kelolaHistoryPenarikan = new UcKelolaHistoryPenarikan(this);
            kelolaHistoryPenukaran = new UcKelolaHistoryPenukaran(this);
            kelolaKonfirmasiTransaksi = new UcKelolaKonfirmasiTransaksi(this);
            kelolaKonfirmasiPenarikan = new UcKelolaKonfirmasiPenarikan(this);
            viewDataDiriPenyuplai = new UcDataDiriPenyuplai(this);
            viewTransaksiPenyuplai = new UcTransaksiPenyuplai(this);
            viewHistoryPenyuplai = new UcHistoryPenyuplai(this);
            viewKeuanganPenyuplai = new UcKeuanganPenyuplai(this);



            //this.Controls.Add(dashboardPengepul);
            //this.Controls.Add(kelolaPenyuplai);
            //this.Controls.Add(kelolaSubKategori);
            //this.Controls.Add(kelolaLaporan);
            //this.Controls.Add(kelolaHistory);
            //this.Controls.Add(registerpage);
            //this.Controls.Add(startPage);
            //this.Controls.Add(loginPage);
            //this.Controls.Add(kelolaHistoryTransaksi);
            //this.Controls.Add(kelolaHistoryPenarikan);
            //this.Controls.Add(kelolaHistoryPenukaran);
            //this.Controls.Add(kelolaKonfirmasiTransaksi);
            //this.Controls.Add(kelolaKonfirmasiPenarikan);
            //this.Controls.Add(dashboardPenyuplai);
            this.Controls.Add(viewDataDiriPenyuplai);
            this.Controls.Add(viewKeuanganPenyuplai);
            this.Controls.Add(viewHistoryPenyuplai);
            this.Controls.Add(viewTransaksiPenyuplai);
            //HideAllPage();
            //this.Controls.Add(dashboardPengepul);

            this.Controls.Add(dashboardPenyuplai);
            //this.Controls.Add(loadingScreen);

            //timer = new System.Windows.Forms.Timer();
            //timer.Interval = 2500;
            //timer.Tick += timer_tick;
            //timer.Start();

        }
        public void HideAllPage()
        {
            foreach (Control control in this.Controls)
            {
                control.Visible = false;
            }
        }
        public void timer_tick(object sender, EventArgs e)
        {
            timer.Stop();
            ShowStartPage();

        }
        public void ShowStartPage()
        {
            HideAllPage();
            startPage.Visible = true;
        }
        public void ShowLoginPage()
        {
            HideAllPage();
            loginPage.Visible = true;
        }
        public void ShowRegisterPage()
        {
            HideAllPage();
            registerpage.Visible = true;
        }
        public void ShowDashboardPengepul()
        {
            HideAllPage();
            dashboardPengepul.Visible = true;
        }
        public void ShowKelolaPenyuplai()
        {
            HideAllPage();
            kelolaPenyuplai.Visible = true;
        }
        public void ShowKelolaSubKategori()
        {
            HideAllPage();
            kelolaSubKategori.Visible = true;
        }
        public void ShowKelolaLaporan()
        {
            HideAllPage();
            kelolaLaporan.Visible = true;
        }
        public void ShowKelolaHistory()
        {
            HideAllPage();
            kelolaHistory.Visible = true;
        }
        public void ShowKelolaHistoryTransaksi()
        {
            HideAllPage();
            kelolaHistoryTransaksi.Visible = true;
        }
        public void ShowKelolaHistorypenarikan()
        {
            HideAllPage();
            kelolaHistoryPenarikan.Visible = true;
        }
        public void ShowKelolaHistoryPenukaran()
        {
            HideAllPage();
            kelolaHistoryPenukaran.Visible = true;
        }
        public void ShowKelolaKonfirmasiTransaksi()
        {
            HideAllPage();
            kelolaKonfirmasiTransaksi.Visible = true;
        }
        public void ShowKelolaKonfirmasiPenarikan()
        {
            HideAllPage();
            kelolaKonfirmasiPenarikan.Visible = true;
        }
        public void ShowDashboardPenyuplai()
        {
            HideAllPage();
            dashboardPenyuplai.Visible = true;
        }
        public void ShowDataDiriPenyuplai()
        {
            HideAllPage();
            viewDataDiriPenyuplai.Visible = true;
        }
        public void ShowTransaksiPenyuplai()
        {
            HideAllPage();
            viewTransaksiPenyuplai.Visible = true;
        }
        public void ShowHistoryPenyuplai()
        {
            HideAllPage();
            viewHistoryPenyuplai.Visible = true;
        }
        public void ShowKeuanganPenyuplai()
        {
            HideAllPage();
            viewKeuanganPenyuplai.Visible = true;

        }
    }
}
