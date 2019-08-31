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

            Employee SusanMeyers = new Employee("Susan Meyers", 47899, "Accounting", "Vice_President");
            Employee MarkJones = new Employee("Mark Jones", 39119);
            MarkJones.Department = "IT";
            MarkJones.Position = "Programmer";
            Employee JoyRogers = new Employee();
            JoyRogers.Name = "Joy Rogers";
            JoyRogers.IdNumber = 81774;
            JoyRogers.Department = "Manufacturing";
            JoyRogers.Position = "Engineer";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
