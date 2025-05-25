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
        UcDashboardPenyuplai dashboardPenyuplai;
        System.Windows.Forms.Timer timer;
        public MainForm()
        {
            InitializeComponent();
            //loadingScreen = new UcLoadingScreen();
            //startPage = new UcStartPage(this);
            //loginPage = new UcLogin(this);
            //registerpage = new UcRegister(this);
            dashboardPengepul = new UcDashboardPengepul(this);
            kelolaPenyuplai = new UcKelolaPenyuplai(this);
            kelolaSubKategori = new UcKelolaSubKategori(this);
            kelolaLaporan = new UcKelolaLaporan(this);
            kelolaHistory = new UcKelolaHistory(this);
            dashboardPenyuplai = new UcDashboardPenyuplai();

            
            //this.Controls.Add(dashboardPengepul);
            this.Controls.Add(kelolaPenyuplai);
            this.Controls.Add(kelolaSubKategori);
            this.Controls.Add(kelolaLaporan);
            this.Controls.Add(kelolaHistory);
            //this.Controls.Add(dashboardPenyuplai);

            //this.Controls.Add(registerpage);
            //this.Controls.Add(startPage);
            //this.Controls.Add(loginPage);
            HideAllPage();
            this.Controls.Add(dashboardPengepul);

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

    }
}
