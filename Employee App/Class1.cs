using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_App
{
    class Employee
    {
        //Field
        private string _name;
        private int _idNumber;
        private string _department;
        private string _position;

        public Employee(string Name, int IdNumber, string Department, string Position)
        {
            _name = Name;
            _idNumber = IdNumber;
            _department = Department;
            _position = Position;
        }

        public Employee(string Name, int IdNumber)
        {
            _name = Name;
            _idNumber = IdNumber;
            _department = "";
            _position = "";
        }

        public Employee()
        {
            _name = "";
            _idNumber = 0;
            _department = "";
            _position = "";
        }

        public string Name { set; get; }
        public int IdNumber { set; get; }
        public string Department { set; get; }
        public string Position { set; get; }
    }
}
