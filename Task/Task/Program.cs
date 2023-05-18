using System.Data;
using System.Globalization;
using System.Threading.Channels;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test class Employee
            //Employee employee1 = new Employee("John", "Doe", 1, 3590m, "Developer");
            //employee1.GetFullName();
            //employee1.FirstName = "";
            //Console.WriteLine(employee1.FirstName);

            // Test class BankAccount
            BankAccount bankAccount = new BankAccount(3, "John", 20m);
            decimal deposit = bankAccount.Deposit(30m);
            Console.WriteLine(deposit);
            decimal withraw = bankAccount.Withdraw(80m);
            Console.WriteLine(withraw);

            // Test class Student
            Student student = new Student();
            string name = student.Name;
            double grade = student.Grade;
            string schoolame = student.SchoolName;
            Console.WriteLine(name);
            Console.WriteLine(grade);
            Console.WriteLine(schoolame);
            student.Grade = 15;
            Console.WriteLine(grade);

            Student student2 = new Student("John");

        }
    }

    //  Task 1: Create a simple Employee class.
    //  The class should have the following private properties:
    //  firstName,
    //  lastName,
    //  employeeId,
    //  salary,
    //  role.

    //  Implement a constructor that takes these values as parameters and initializes the properties.
    //  Implement public getters and setters for each of these properties.
    //  Make sure that the setter methods validate the inputs (for example, employeeId and salary cannot be negative, names should not be empty, etc.).
    //  Implement a method getFullName() that returns the full name of the employee.

    class Employee
    {
        // fields
        private string _firstName;
        private string _lastName;
        private int _employeeId;
        private decimal _salary;
        private string _role;

        public Employee(string firstname, string lastname, int employeeId, decimal salary, string role)
        {
            _firstName = firstname;
            _lastName = lastname;
            _employeeId = employeeId;
            _salary = salary;
            _role = role;
        }

        public string FirstName
        {
            get => _firstName;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Not a name");
                }
                _firstName = value;
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Not a lastname");
                }
                _lastName = value;
            }
        }

        public int EmployeeId
        {
            get => _employeeId;
            set
            {
                if (value <= 0)
                {
                    new ArgumentException("less or equal to 0");
                }
                _employeeId = value;
            }
        }
        public decimal Salary
        {
            get => _salary;
            set
            {
                if (value >= 0)
                {
                    _salary = value;
                }
                else
                {
                    throw new ArgumentException("less or equal to 0");
                }

            }
        }
        public string Role
        {
            get => _role;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Null or empty value");
                }
                _role = value;
            }
        }

        public void GetFullName() => Console.WriteLine($"{_firstName} {_lastName}");
    }

    //  Task 2: Create a BankAccount class.
    //  The class should have the following private properties:
    //  accountNumber,
    //  ownerName,
    //  balance.

    //  Implement a constructor that takes these values as parameters and initializes the properties.
    //  The initial balance should be 0.

    //  Implement public getters and setters for accountNumber and ownerName, but only a getter for balance(the balance should not be directly settable).
    //  Implement two methods: deposit(amount) and withdraw(amount).
    //  The deposit(amount) method should add the amount to the balance.
    //  The withdraw(amount) method should subtract the amount from the balance, but only if there are sufficient funds in the account.

    class BankAccount
    {
        private int _accountNumber;
        private string _ownerName;
        private decimal _balance;

        public BankAccount(int accountNumber, string ownerName, decimal balance = 0)
        {
            _accountNumber = accountNumber;
            _ownerName = ownerName;
            _balance = balance;
        }

        public int AccountNumber
        {
            get => _accountNumber;
            set
            {
                if (value > 0) _accountNumber = value;
                else throw new ArgumentException("less than 0");
            }
        }
        public string OwnerName
        {
            get => _ownerName;
            set
            {
                if (String.IsNullOrEmpty(value)) throw new ArgumentNullException("No name");
                else _ownerName = value;
            }
        }
        public decimal Balance
        {
            get => _balance;
        }

        public decimal Deposit(decimal amount)
        {
            return _balance += amount;
        }
        public decimal Withdraw(decimal amount)
        {
            if (Balance < amount)
            {
                Console.WriteLine("Not enough money");
            }
            else
            {
                _balance -= amount;
            }
            return Balance;
        }
    }

    //  Task 3: Building a Student Class with Overloaded Constructors

    //  Create a Student class. The class should have the following private properties:
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
        private string _name;
        private double _grade;
        public string SchoolName { get; set; }

        public Student()
        {
            _name = "Unnamed";
            _grade = 1;
            SchoolName = "Unknown";
        }

        public Student(string name) : this()
        {
            _name = name;
        }
        public Student(string name, double grade) : this(name)
        {
            _grade = grade;
        }
        public Student(string name, double grade, string schoolName) : this(name, grade)
        {
            SchoolName = schoolName;
        }


        public string Name
        {
            get => _name;
            set
            {
                if (String.IsNullOrEmpty(value)) throw new ArgumentNullException("Not a name");
                else _name = value;
            }
        }
        public double Grade
        {
            get => _grade;
            set
            {
                if (value < 1 || value > 12) throw new ArgumentException("grade should be between 1-12");
                else _grade = value;
            }
        }
    }
}