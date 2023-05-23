using System.Data;

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
        private string _firstname;
        private string _lastname;
        private int _employeeId;
        private decimal _salary;
        private string _role;

        public Employee(string firstName, string lastName, int employeeId, decimal salary, string role)
        {
            _firstname = firstName;
            _lastname = lastName;
            _employeeId = employeeId;
            _salary = salary;
            _role = role;
        }

        public string firstName
        {
            get { return _firstname; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("You Didnt Entered The Name Try Again: ");

                _firstname = value;
            }
        }

        public string lastName
        {
            get { return _lastname; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("You Didnt Entered The LastName");

                _lastname = value; 
            }
        }

        public int employeeId
        {
            get { return _employeeId; }
            set 
            {
                if (_employeeId < 0)
                    throw new Exception("EmployeeId Is Less Than 0");

                _employeeId = value; 
            }
        }

        public decimal salary
        {
            get { return _salary; }
            set 
            {
                if (_salary < 0)
                    throw new Exception("Salary Is Less Than 0");

                _salary = value; 
            }
        }

        public string role
        {
            get { return _role; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("You Didnt Entered The Role");

                _role = value; 
            }
        }

        public string GetFullName()
        {
            return $"{firstName} {lastName}";
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
        private decimal _accountNumber;
        private string _ownerName;
        private decimal _balance;

        public BankAccount(decimal accountNumber, string ownerName)
        {
            _accountNumber = accountNumber;
            _ownerName = ownerName;
            _balance = 0;
        }

        public decimal accaountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        public string ownerName
        {
            get { return _ownerName; }
            set { _ownerName = value; }
        }

        public decimal balance
        {
            get { return _balance; }
        }

        public void Deposit(decimal amount)
        {
           _balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                _balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds in the account.");
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

    public class Student
    {
        private string name;
        private int grade;
        public string SchoolName { get; set; }

        public Student()
            : this("Unnamed", 1, "Unknown")
        {
        }

        public Student(string name)
            : this(name, 1, "Unknown")
        {
        }

        public Student(string name, int grade)
            : this(name, grade, "Unknown")
        {
        }

        public Student(string name, int grade, string schoolName)
        {
            SetName(name);
            SetGrade(grade);
            SchoolName = schoolName;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be empty.");
            }

            name = value;
        }

        public int GetGrade()
        {
            return grade;
        }

        public void SetGrade(int value)
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException("Grade should be between 1 and 12.");
            }

            grade = value;
        }
    }

}