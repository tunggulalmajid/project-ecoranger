using project_ecoranger.Views;

namespace project_ecoranger
{
    public partial class MainForm : Form
    {
        UcLoadingScreen loadingScreen;
        public MainForm()
        {
            InitializeComponent();
            UcLoadingScreen loadingScreen = new UcLoadingScreen();
            this.Controls.Add(loadingScreen);

        }
    }
}
