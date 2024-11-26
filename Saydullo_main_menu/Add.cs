using System.Globalization;
using System.Resources;
using Time_Table.db;

namespace Time_Table.Saydullo_main_menu
{
    public partial class Add : Form
    {
        public Add(CultureInfo culture)
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            ResourceManager rm = new ResourceManager("Time-Table.Add", System.Reflection.Assembly.GetExecutingAssembly());

            this.Text = this.Text + " " + DateTime.Now.ToLongDateString();

            label1.Text = rm.GetString("label1.Text");
            label2.Text = rm.GetString("label2.Text");
            label3.Text = rm.GetString("label3.Text");
            label4.Text = rm.GetString("label4.Text");
            label5.Text = rm.GetString("label5.Text");
            label6.Text = rm.GetString("label6.Text");
            label7.Text = rm.GetString("label7.Text");
            label8.Text = rm.GetString("label8.Text");
            label9.Text = rm.GetString("label9.Text");
            label10.Text = rm.GetString("label10.Text");
        }
        public Add()
        {
            InitializeComponent();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Add_Load(object sender, EventArgs e)
        {

        }
        private void name_box_TextChanged(object sender, EventArgs e)//name box
        {

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)//year of birth
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)//phone numper 
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//doctor choise 
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)//tashxis
        {

        }
        private void textBox7_TextChanged(object sender, EventArgs e)//skidka
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)//keldi
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)//info
        {

        }
        private void textBox8_TextChanged(object sender, EventArgs e)//all sum
        {

        }
        private void button1_Click(object sender, EventArgs e)//ADD buton
        {
            /*db_finctions dbf = new db_finctions();
            user_info newUser = new user_info
            {
                id = 6,
                date_to_visit = "12",
                name = "q",
                date_to_born = "12",
                tel = 1,
                doxtr = 1,
                tashxis = "Примерный диагноз",
                skidka = 10,
                keldi = "Да",
                obshynarh = "Общая информация"
            };
             dbf.add_user_to_db(newUser);*/
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)//show users
        {
            db_finctions dbf = new db_finctions();
            var allUsers = await dbf.doxtr_wive();
            foreach (var user in allUsers)
            {
                foreach (var column in user)
                {
                    string text1 = $" {column.Key}: " + "{" + $"{column.Value}" + "}";
                    dataGridView1.Text = text1;
                }
            }
        }        
    }
}
