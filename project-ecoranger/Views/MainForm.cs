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
        System.Windows.Forms.Timer timer;
        public MainForm()
        {
            InitializeComponent();
            loadingScreen = new UcLoadingScreen();
            startPage = new UcStartPage(this);
            loginPage = new UcLogin(this);
            registerpage = new UcRegister(this);

            this.Controls.Add(registerpage);
            this.Controls.Add(startPage);
            this.Controls.Add(loginPage);
            HideAllPage();
            this.Controls.Add(loadingScreen);

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 2500;
            timer.Tick += timer_tick;
            timer.Start();

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

    }
}
