using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Table;

namespace CRMStom
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void Data1_Add_custom_Click(object sender, EventArgs e)
        {
            ShowChildForm();
            Console.WriteLine("alom");
            Console.WriteLine("salom");
        }
        private void ShowChildForm()
        {
            DataADD childForm = new DataADD();
            childForm.TopLevel = false; // TopLevel-ni false qilib belgilash
            childForm.FormBorderStyle = FormBorderStyle.None; // Chegarani olib tashlash
            childForm.Dock = DockStyle.Fill; // Formani Panelga to'liq sig'dirish
            Asosiy_panel.Controls.Clear(); // Avvalgi kontrollarni o'chirish
            Asosiy_panel.Controls.Add(childForm); // Panelga qo'shish
            Asosiy_panel.Tag = childForm;
            childForm.Show();
        }
        private void label2_Click(object sender, EventArgs e)
        {

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

        
    }
}
