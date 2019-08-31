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
        private string _firstName;
        private string _lastName;
        private int _idNumber;
        private string _department;
        private string _position;

        public Employee(string FirstName, string LastName, int IdNumber, string Department, string Position)
        {
            _firstName = FirstName;
            _lastName = LastName;
            _idNumber = IdNumber;
            _department = Department;
            _position = Position;
        }

        public Employee(string FirstName, string LastName, int IdNumber)
        {
            _firstname = FirstName;
            _lastName = LastName;
            _idNumber = IdNumber;
            _department = "";
            _position = "";
        }

        public Employee()
        {
            _firstName = "";
            _lastName = "";
            _idNumber = 0;
            _department = "";
            _position = "";
        }

    }
}
