namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

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
        private string _firstName;
        private string _lastName;
        private int _employeeId;
        private double _salary;
        private string _role;

        public string Firstname
        {
            get => _firstName;

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("u didn't entered the name");

                _firstName = value;
            }
        }
        public string LastName
        {
            get => _lastName;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("u didn't entered the lname");

                _lastName = value;
            }
        }
        public int EmployeeId
        {
            get => _employeeId;
            set
            {
                if (_employeeId < 0)
                {
                    throw new Exception("employeeId is less then 0");
                }
                _employeeId = value;
            }
        }
        public double Salary
        {
            get => _salary;
            set
            {
                if (_salary < 0)
                    throw new Exception("salary is less then 0");

                _salary = value;

            }
        }
        public string Role
        {
            get => _role;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("role is empty");

                _role = value;
            }
        }


        public Employee(string firstname, string lastname, int employeeId, double salary, string role)
        {
            _firstName = firstname;
            _lastName = lastname;
            _employeeId = employeeId;
            _salary = salary;
            _role = role;
        }


        public string GetFullName() => $"{Firstname} {LastName}";

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
        private decimal _balance;

        public BankAccount(int accountNumber, string ownerName, decimal balance)
        {
            _accountNumber = accountNumber;
            _ownerName = ownerName;
            _balance = balance;
        }

        public int AccountNumber
        {
            get => _accountNumber;
            set => _accountNumber = value;
        }
        public string OwnerName
        {
            get => _ownerName;
            set => _ownerName = value;
        }
        public decimal Balance
        {
            get => _balance;
        }

        public void Deposit(decimal dep) => _balance += dep;

        public void Withdraw(decimal with)
        {
            if (with <= _balance)
                _balance -= with;

            else
                Console.WriteLine("cent do this operation");

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
        public string _scoolName;
        private string _name;
        private decimal _grade;

        public Student()
        {
            _name = "Unnamed";
            _grade = 1;
            _scoolName = "Unknown";
        }
        public Student(string name) : this()
        {
            _name = name;
        }

        public Student(string name, decimal grade) : this(name)
        {
            _grade = grade;
        }

        public Student(string name, decimal grade, string scoolName) : this(name, grade)
        {
            _scoolName = scoolName;
        }

        public string ScoolName
        {
            get => _scoolName;
            set
            {
                if (string.IsNullOrEmpty(_scoolName)) throw new Exception("_scoolName is empty or null");
                _scoolName = value;
            }
        }
        public decimal Grade
        {
            get => _grade;
            set
            {
                if (value < 1 || value > 12) throw new Exception("Grade is less then 1 or more then 12");
                _grade = value;
            }
        }
        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(_name)) throw new Exception("name is null or empty");
                _name = value;
            }
        }

    }
}