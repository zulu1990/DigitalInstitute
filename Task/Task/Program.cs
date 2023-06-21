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
            this.firstName = firstName;
            this.lastName = lastName;
            this.employeeId = employeeId;
            this.salary = salary;
            this.role = role;
        }
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrEmpty(firstName))
                    throw new Exception(message: "Please Write something! ");

                firstName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrEmpty(lastName))
                    throw new Exception(message: "Please Write something! ");

                lastName = value;
            }
        }
        public int EmployeeId
        {
            get { return employeeId; }
            set
            {
                if (employeeId < 0)
                    throw new Exception(message: "ID must not be a negative number! ");

                employeeId = value;

            }
        }
        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (salary < 0)
                    throw new Exception(message: "salary number must not be a negative number! ");

                salary = value;
            }
        }
        public string Role
        {
            get { return role; }
            set
            {
                if (string.IsNullOrEmpty(role))
                    throw new Exception(message: "Please Write something! ");

                role = value;
            }
        }
        public string getFullName()
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
        private int accountNumber;
        private string owenerName;
        private decimal balance;

        public BankAccount(int accountNumber, string owenerName, decimal balance)
        {
            this.accountNumber = accountNumber;
            this.owenerName = owenerName;
            balance = 0;
        }
        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        public string OwnerName
        {
            get { return owenerName; }
            set { owenerName = value; }
        }
        public decimal Balance
        {
            get { return balance; }
        }

        public void deposit(int amount)
        {
            balance += amount;
        }
        public void withdraw(int amount)
        {
            if (amount > 0)
            {
                balance -= amount;
            }
            else
            {
                throw new InvalidOperationException("Insufficient funds.");
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
        private string name;
        private int grade;
        public string SchoolName { get; set; }


        public Student()

        {
            name = "Unnamed";
            grade = 1;
            SchoolName = "Unknown";
        }
        public Student(string name)
            : this()

        {
            grade = 1; ;
            SchoolName = "Unknown";
        }

        public Student(string name, int grade)
            : this(name)          // aq ver gavige usaxelos rogor davukavshiro
        {
            SchoolName = "Unknown";
        }
        public Student(string name, int grade, string schoolName)
            : this(name, grade)
        {
            name = "Unnamed";
            grade = 1;
            SchoolName = "Unknown";
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(name))
                    throw new Exception(message: "Write something! ");
                name = value;
            }
        }
        public int Grade
        {
            get { return grade; }
            set
            {
                if (grade < 1)
                    throw new Exception(message: "Invalid grade number! ");
                if (grade > 12)
                    throw new Exception(message: "Invalid grade number! ");
            }
        }
        public string SchoolNAme
        {
            get { return SchoolName; }
            set
            {
                if (string.IsNullOrEmpty(SchoolName))
                    throw new Exception(message: "Write Something! ");

                SchoolName = value;
            }
        }
    }
}