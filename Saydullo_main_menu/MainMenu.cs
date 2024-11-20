using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Table.Saydullo_main_menu;

namespace CRMStom
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void ShowAddForm()
        {
            Add childForm = new Add();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Change_panel.Controls.Clear();
            Change_panel.Controls.Add(childForm);
            Change_panel.Tag = childForm;
            childForm.Show();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            ShowAddForm();
        }
        private void Search_btn_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.TopLevel = false;
            search.FormBorderStyle = FormBorderStyle.None;
            search.Dock = DockStyle.Fill;
            Change_panel.Controls.Clear();
            Change_panel.Controls.Add(search);
            Change_panel.Tag = search;
            search.Show();
        }

        private void Settings_btn_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.TopLevel = false;
            settings.FormBorderStyle = FormBorderStyle.None;
            settings.Dock = DockStyle.Fill;
            Change_panel.Controls.Clear();
            Change_panel.Controls.Add(settings);
            Change_panel.Tag = settings;
            settings.Show();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("salom");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {//ddscscsc

        }

        private void chiqish_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
