namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
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
        private decimal salary;
        private string role;

        public Employee(string firstName, string lastName, int employeeId, decimal salary, string role)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EmployeeId = employeeId;
            this.Salary = salary;
            this.Role = role;
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First name should not be empty or whitespace.");
                }
                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last name should not be empty or whitespace.");
                }
                lastName = value;
            }
        }

        public int EmployeeId
        {
            get { return employeeId; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Employee ID cannot be negative.");
                }
                employeeId = value;
            }
        }

        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary cannot be negative.");
                }
                salary = value;
            }
        }

        public string Role
        {
            get { return role; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Role should not be empty or whitespace.");
                }
                role = value;
            }
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
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
        private string accountNumber;
        private string ownerName;
        private decimal balance;

        public BankAccount(string accountNumber, string ownerName)
        {
            this.AccountNumber = accountNumber;
            this.OwnerName = ownerName;
            this.balance = 0;
        }

        public string AccountNumber
        {
            get { return accountNumber; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Account number should not be empty or whitespace.");
                }
                accountNumber = value;
            }
        }

        public string OwnerName
        {
            get { return ownerName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Owner name should not be empty or whitespace.");
                }
                ownerName = value;
            }
        }

        public decimal Balance
        {
            get { return balance; }
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount to deposit should be greater than zero.");
            }
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount to withdraw should be greater than zero.");
            }
            if (amount > balance)
            {
                throw new InvalidOperationException("Insufficient funds in the account.");
            }
            balance -= amount;
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
        {
            this.name = "Mishiko";
            this.grade = 1;
            this.SchoolName = "Bussines School";
        }

        public Student(string name) : this()
        {
            this.name = name;
        }

        public Student(string name, int grade) : this(name)
        {
            this.grade = grade;
        }

        public Student(string name, int grade, string schoolName) : this(name, grade)
        {
            this.SchoolName = schoolName;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name should not be empty or whitespace.");
                }
                name = value;
            }
        }

        public int Grade
        {
            get { return grade; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Grade should be between 1 and 12.");
                }
                grade = value;
            }
        }
    }

}