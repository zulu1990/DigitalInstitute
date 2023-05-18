namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

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
        private string firstName;
        private string lastName;
        private int emoloyeeId;
        private decimal salary;
        private string role;
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    firstName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    lastName = value;
            }
        }
        public string Role
        {
            get { return role; }
            set
            {
                if (!string.IsNullOrEmpty(role))
                    role = value;
            }
        }
        public int EmployeeId
        {
            get { return emoloyeeId; }
            set
            {
                if (value >= 0)
                    emoloyeeId = value;
            }
        }
        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0)
                    salary = value;
            }
        }
        public Employee(string firstName, string lastName, int emoloyeeId, decimal salary, string role)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(role) || emoloyeeId < 0 || salary < 0)
                throw new ArgumentNullException();
            this.firstName = firstName;
            this.lastName = lastName;
            this.emoloyeeId = emoloyeeId;
            this.salary = salary;
            this.role = role;
        }
        public string GetFullName()
        {
            return $"{this.firstName} {this.lastName}";
        }
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
        private string _accountNumber;
        private string _ownerName;
        private decimal _balance;
        public BankAccount(string accountNumber, string ownerName, decimal balance)
        {
            _accountNumber = accountNumber;
            _ownerName = ownerName;
            _balance = balance;
        }
        public string AccountNumber
        {
            get { return _accountNumber; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _accountNumber = value;
            }
        }
        public string OwnerName
        {
            get { return _ownerName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _ownerName = value;
            }
        }
        public decimal Balance
        {
            get { return _balance; }
        }
        public bool Deposite(decimal amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                return true;
            }
            else
                return false;
        }
        public bool Withdraw(decimal amount)
        {
            if (amount > 0 && _balance >= amount)
            {
                _balance -= amount;
                return true;
            }
            else
                return false;
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
        private int _grade;
        public string SchoolName { get; set; }
        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _name = value;
            }
        }
        public int Grade
        {
            get { return _grade; }
            set
            {
                if(value >= 1 && value < 12)
                    _grade = value;
            }
        }

        public Student(string name, int grade, string schoolName) : this(name, grade)
        {
            SchoolName = schoolName;
        }

        public Student(string name, int grade) : this(name)
        {
            _grade = grade;
        }

        public Student(string name) : this()
        {
            _name = name;
        }
        public Student()
        {
            _name = "Unnamed";
            _grade = 1;
            SchoolName = "Unknown";
        }
    }
}