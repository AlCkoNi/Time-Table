using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class Search : Form
    {
        public Search(CultureInfo culture)
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            ResourceManager rm = new ResourceManager("Time-Table.Search", System.Reflection.Assembly.GetExecutingAssembly());

            this.Text = this.Text + " " + DateTime.Now.ToLongDateString();

            label11.Text = rm.GetString("label11.Text");
            
        }
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }
    }
}
