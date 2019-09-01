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
            //Create employee objects.
            Employee SusanMeyers = new Employee("Susan Meyers", 47899, "Accounting", "Vice President");
            Employee MarkJones = new Employee("Mark Jones", 39119);
            MarkJones.Department = "IT";
            MarkJones.Position = "Programmer";
            Employee JoyRogers = new Employee();
            JoyRogers.Name = "Joy Rogers";
            JoyRogers.IdNumber = 81774;
            JoyRogers.Department = "Manufacturing";
            JoyRogers.Position = "Engineer";

            //Grid setup
            dataGridView1.ColumnCount = 4;
            dataGridView1.RowCount = 3;
            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[1].Name = "ID Number";
            dataGridView1.Columns[2].Name = "Department";
            dataGridView1.Columns[3].Name = "Position";

            //Display data in grid
            dataGridView1.Rows[0].Cells[0].Value = SusanMeyers.Name;
            dataGridView1.Rows[0].Cells[1].Value = SusanMeyers.IdNumber;
            dataGridView1.Rows[0].Cells[2].Value = SusanMeyers.Department;
            dataGridView1.Rows[0].Cells[3].Value = SusanMeyers.Position;

            dataGridView1.Rows[1].Cells[0].Value = MarkJones.Name;
            dataGridView1.Rows[1].Cells[1].Value = MarkJones.IdNumber;
            dataGridView1.Rows[1].Cells[2].Value = MarkJones.Department;
            dataGridView1.Rows[1].Cells[3].Value = MarkJones.Position;

            dataGridView1.Rows[2].Cells[0].Value = JoyRogers.Name;
            dataGridView1.Rows[2].Cells[1].Value = JoyRogers.IdNumber;
            dataGridView1.Rows[2].Cells[2].Value = JoyRogers.Department;
            dataGridView1.Rows[2].Cells[3].Value = JoyRogers.Position;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
