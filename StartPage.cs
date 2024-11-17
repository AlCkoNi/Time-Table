using CRMStom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Table
{
    public partial class StartPage : Form
    {
        MainMenu mainMenu = new MainMenu();
        public StartPage()
        {
            InitializeComponent();

        }
        private void StartPage_Load(object sender, EventArgs e)
        {
            Wait();
        }
        private async void Wait()
        {
            await Task.Delay(5000); 
            mainMenu.Show();
            this.Hide(); 
        }
    }
}
