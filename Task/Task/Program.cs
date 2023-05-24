using System.ComponentModel.DataAnnotations;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //test task 1
            Employee e = new Employee("tom", "ha", 15, 120, "sales");
            string x = e.GetFullName(e);
            Console.WriteLine(x);

            //test task 2
            BankAccount b = new BankAccount(15, "Tornike");
            b.deposit(1000);
            b.withdraw(500);
            Console.WriteLine(b.Balance);


            //test task 3
            Student student = new Student("tom");
            Console.WriteLine(student.Grade);
            

        }
    }

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
        private string firstName;
        private string lastName;
        private int employeeId;
        private int salary;
        private string role { get; set; }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    firstName = value;
                }
                else
                {
                    throw new Exception("incorrect");
                }
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    lastName = value;
                }
                else
                {
                    throw new Exception("incorrect");
                }
            }
        }

        public int EmployeeId
        {
            get { return employeeId; }
            set
            {
                if (value > 0)
                {
                    employeeId = value;
                }
                else
                {
                    throw new Exception("incorrect");
                }
            }
        }

        public int Salary
        {
            get { return salary; }
            set
            {
                if (value > 0)
                {
                    salary = value;
                }
                else
                {
                    throw new Exception("incorrect");
                }
            }
        }

        public Employee(string _firstName, string _lastName, int _employeeId, int _salary, string _role)
        {
            FirstName = _firstName;
            LastName = _lastName;
            EmployeeId = _employeeId;
            Salary = _salary;
            role = _role;
        }

        public string GetFullName(Employee e)
        {
            return firstName + " " + lastName;
        }


    }

    //Task 2
    //Create a BankAccount class. The class should have the following private properties:
    //accountNumber,
    //ownerName,
    //balance.

    //Implement a constructor that takes these values as parameters and initializes the properties.
    //The initial balance should be 0.

    //Implement public getters and setters for accountNumber and ownerName, but only a getter for balance(the balance should not be directly settable).
    //Implement two methods: deposit(amount) and withdraw(amount).
    //The deposit(amount) method should add the amount to the balance.
    //The withdraw(amount) method should subtract the amount from the balance, but only if there are sufficient funds in the account.

    class BankAccount
    {
        private int _accountNumber;
        private string _ownerName;
        private int _balance = 0;

        public int AccountNumber
        {
            get { return _accountNumber; }
            set
            {
                if (value > 0)
                {
                    _accountNumber = value;
                }
                else
                {
                    throw new Exception("invalid");
                }
            }
        }

        public string OwnerName
        {
            get { return _ownerName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _ownerName = value;
                }
                else
                {
                    throw new Exception("invalid");
                }
            }
        }

        public int Balance
        {
            get { return _balance; }
            set { }
        }

        public BankAccount(int accountnumber, string ownername)
        {
            AccountNumber = accountnumber;
            OwnerName = ownername;
        }

        public void deposit(int money)
        {
            _balance = _balance + money;
        }

        public void withdraw(int money)
        {
            if (money <= _balance)
            {
                _balance = _balance - money;
            }
            else
            {
                throw new Exception("invalid activity");
            }
        }



    }

    //Task 3: Building a Student Class with Overloaded Constructors

    //Create a Student class. The class should have the following private properties:
    //  name
    //  grade
    //  and a PUBLIC property SchoolName.
    // 1)Implement a constructor that takes no parameters and sets name to "Unnamed", grade to 1, and schoolName to "Unknown".

    // 2)Implement another constructor that takes one parameter for name and sets grade to 1, and schoolName to "Unknown".
    //  Use the this keyword to navigate from this constructor to the first constructor when no name is given.
    // 3) Implement another constructor that takes two parameters, one for name and one for grade, and sets schoolName to "Unknown".
    //  Use the this keyword to navigate from this constructor to the second constructor when only name is given, and to the first constructor when no parameters are given.
    // 4) Implement a final constructor that takes all three parameters and sets the corresponding properties.
    //  Use the this keyword to navigate from this constructor to the third constructor when schoolName is not given, to the second constructor when only name is given, and to the first constructor when no parameters are given.
    // 5) Implement public getters and setters for each of these properties.
    //  Make sure that the setter methods validate the inputs (for example, name should not be an empty string, grade should be between 1 and 12).

    class Student
    {
        //fields
        private string _name;
        private int _grade;
        public string _schoolname;


        //getters and setters
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }
        }
        public int Grade
        {
            get
            {
                return _grade;
            }
            set
            {
                if (value > 0 && value <= 12)
                {
                    _grade = value;
                }
            }
        }
        public string SchoolName
        {
            get
            {
                return _schoolname;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _schoolname = value;
                }
            }
        }

        //consturctors
        public Student()
        {
            Name = "Unnamed";
            Grade = 1;
            SchoolName = "Unknown";
        }

        public Student(string name) : this()
        {
            Name = name;
        }

        public Student(string name, int grade) : this()
        {
            Name = name;
            Grade = grade;
        }

        public Student(string name, int grade,  string schoolname) : this()
        {
            Name = name;
            Grade = grade;
            SchoolName = schoolname;
        }

    }
}