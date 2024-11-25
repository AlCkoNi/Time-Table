using CRMStom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Table.Saydullo_main_menu
{
    public partial class Settings : Form
    {
        public Settings(CultureInfo culture)
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            ResourceManager rm = new ResourceManager("Time-Table.Settings", System.Reflection.Assembly.GetExecutingAssembly());

            this.Text = this.Text + " " + DateTime.Now.ToLongDateString();

            label1.Text = rm.GetString("label1.Text");
            label2.Text = rm.GetString("label2.Text");
            button1.Text = rm.GetString("button1.Text");
            btnChangeMode.Text = rm.GetString("button2.Text");
        }
        public Settings()
        {
            InitializeComponent();
            InitializeUI("UIMode");
        }

        private void InitializeUI(string key)
        {
            try
            {
                var uiMode = ConfigurationManager.AppSettings[key];
                if (uiMode == "light")
                {
                    btnChangeMode.Text = "Enable Dark Mode";

                    this.ForeColor = Color.FromArgb(47, 54, 64);
                    this.BackColor = Color.FromArgb(245, 246, 250);
                    ConfigurationManager.AppSettings[key] = "dark";
                }
                else
                {
                    btnChangeMode.Text = "Enable Light Mode";

                    this.ForeColor = Color.FromArgb(245, 246, 250);
                    this.BackColor = Color.FromArgb(47, 54, 64);
                    ConfigurationManager.AppSettings[key] = "light";
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message); throw;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("English"))
            {
                MainMenu m = new MainMenu(new CultureInfo("en-US"));
                m.ShowDialog();
            }
            else if (comboBox1.Text.Equals("Русский"))
            {
                MainMenu m = new MainMenu(new CultureInfo("ru-RU"));
                m.ShowDialog();
            }
            else if (comboBox1.Text.Equals("O`zbek"))
            {
                MainMenu m = new MainMenu(new CultureInfo("uz-UZ"));
                m.ShowDialog();
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            InitializeUI("UIMode");//sdsd
        }
    }
}
