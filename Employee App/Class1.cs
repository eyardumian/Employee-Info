using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_App
{
    class Employee
    {
        //Fields
        private string _name;
        private int _idNumber;
        private string _department;
        private string _position;

        //Constructor with all 4 parameters
        public Employee(string Name, int IdNumber, string Department, string Position)
        {
            _name = Name;
            _idNumber = IdNumber;
            _department = Department;
            _position = Position;
        }
        //Constructor with 2 parameters
        public Employee(string Name, int IdNumber)
        {
            _name = Name;
            _idNumber = IdNumber;
            _department = "";
            _position = "";
        }
        //Parameterless constructor
        public Employee()
        {
            _name = "";
            _idNumber = 0;
            _department = "";
            _position = "";
        }
        //Properties
        public string Name
        {
            set
            {
                _name = value;
            }
            get
            {
                return _name;
            }
        }
        public int IdNumber
        {
            set
            {
                _idNumber = value;
            }
            get
            {
                return _idNumber;
            }
        }
        public string Department
        {
            set
            {
                _department = value;
            }
            get
            {
                return _department;
            }
        }
        public string Position
        {
            set
            {
                _position = value;
            }
            get
            {
                return _position;
            }
        }
    }
}
