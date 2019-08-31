using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee SusanMeyers = new Employee(Susan, Meyers, 47899, Accounting, Vice President);
            Employee MarkJones = new Employee(Mark, Jones, 39119, IT, Programmer);
            Employee JoyRogers = new Employee(Joy, Rogers, 81774, Manufacturing, Engineer);

            
        }
    }
}
