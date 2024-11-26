using System.Globalization;
using System.Resources;
using Time_Table.db;
using static Time_Table.db.db_finctions;

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//doctor choise 
        {

        }

        private void name_box_TextChanged(object sender, EventArgs e)//name box
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addtodb();
        }
        public async Task addtodb()
        {
            db_finctions dbf = new db_finctions();
            user_info newUser = new user_info
            {
                id = 5,
                date_to_visit = "2024-12-01",
                name = "KALIVAN",
                date_to_born = "2000-01-01",
                tel = 123456789,
                doxtr = 1,
                tashxis = "Примерный диагноз",
                skidka = 10,
                keldi = "Да",
                obshynarh = "Общая информация"
            };
            await dbf.add_user_to_db(newUser);
        }
    }
}
