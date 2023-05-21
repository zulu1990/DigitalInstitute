using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    //Task 1
    //Create a simple Employee class. The class should have the following private properties:
    //firstName,
    //lastName,
    //employeeId,
    //salary,
    //role.

    //Implement a constructor that takes these values as parameters and initializes the properties.
    //Implement public getters and setters for each of these properties.
    //Make sure that the setter methods validate the inputs (for example, employeeId and salary cannot be negative, names should not be empty, etc.).
    //Implement a method getFullName() that returns the full name of the employee.

    class Employee
    {
        private string _firstName;
        private string _lastName;
        private int _employeeId;
        private double _salary;
        private string _role;

        public string FirstName
        {
            get => _firstName;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _firstName = value;
                }
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _lastName = value;
                }
            }
        }

        public int EmployeeId
        {
            get => _employeeId;
            set
            {
                if (!(value < 0))
                {
                    _employeeId = value;
                }
            }
        }

        public double Salary
        {
            get => _salary;
            set
            {
                if (!(value < 0))
                {
                    _salary = value;
                }
            }
        }

        public string Role
        {
            get => _role;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _role = value;
                }
            }
        }

        public Employee(string firstName, string lastName, int employeeId, double salary, string role)
        {
            _firstName = firstName;
            _lastName = lastName;
            _employeeId = employeeId;
            _salary = salary;
            _role = role;
        }


        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
