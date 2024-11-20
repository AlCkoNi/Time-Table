using CRMStom;
using Timer = System.Windows.Forms.Timer;

namespace Time_Table
{
    public partial class StartPage : Form
    {
        MainMenu mainMenu = new MainMenu();
        Timer timer = new Timer(); 
        public StartPage()
        {
            InitializeComponent();
            this.Opacity = 0;
            timer.Interval = 60; 
            timer.Tick += FadeInTimer_Tick!;
        }
        private void StartPage_Load(object sender, EventArgs e)
        {
            timer.Start(); 
            Wait(); 
        }
        private void FadeInTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.020; 
            }
            else
            {
                timer.Stop(); 
            }
        }
        private async void Wait()
        {
            await Task.Delay(5000); 
            mainMenu.Show();
            this.Hide(); 
        }
    }
}
