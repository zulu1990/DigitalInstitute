using System.Runtime.CompilerServices;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstname = "firstname1", lastname = "lastname1", role = "engineer";
            int ID = 123456;
            double salary = 1500;
            Employee e = new Employee(firstname, lastname, ID, salary, role);
            Console.WriteLine(e.GetFullName());
            Console.WriteLine(e.getEmployeeId);
            Console.WriteLine(e.getRole);
            Console.WriteLine(e.getSalary);
            //=========================================
            Console.WriteLine();
            int acc_number = 212121;
            BankAccount b = new BankAccount(acc_number, "mike");
            double d = 100000;
            Console.WriteLine($"you have now:{b.Deposit(d)} on balance ");
            double w;
            Console.WriteLine("how much you want withdraw?");
            w = double.Parse(Console.ReadLine());
            
            
            Console.WriteLine($" blance left: {b.Withdraw(w)}");
            Console.WriteLine();
            ///////////////////////////////////////////
            
            Student s = new Student();

            s.Name = firstname;
            s.SchoolName = "schoool1";
            s.Grade = 55;
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
        private double salary;
        private string role;
        
        public Employee(string firstName, string lastName, int employeeId, double salary, string role)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.employeeId = employeeId;
            this.salary = salary;
            this.role = role;
        }

        public string getFirstName
        {
            set {
                if (string.IsNullOrEmpty(value)) { throw new ArgumentException("empty string"); }
                firstName = value; }
            get { return firstName; }
            
        }
        public string getLastName
        {
            set {
                if (string.IsNullOrEmpty(value)){ throw new ArgumentException("empty string"); }
                lastName = value; }
            get { return lastName; }
        }
        public int getEmployeeId
        {
            set
            {
                if (value <= 0){ throw new ArgumentException("cant be ngative value"); }
                employeeId = value; 
            }
            get { return employeeId; } 
        }
        public double getSalary {
            set {
                if (value <= 1000) { throw new ArgumentException("salary cant be less than 1000 gel"); }
                salary = value; }
            get { return salary; }
        }

        public string getRole
        {
            set {
                if (string.IsNullOrEmpty(value)) { throw new ArgumentException("empty string"); }
                role = value; }
            get { return role; }
            
        }
        //overload
        public string GetFullName()
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
        private int account_number;
        private string account_owner;
        private double balance;
        public BankAccount(int account_number, string account_owner)
        {
            this.account_number = account_number;
            this.account_owner = account_owner;
        }

        public int getAccountNumber
        {
            set => account_number = value;
            get => account_number; 
        }

        public string getAccountOwner
        {
            set=> account_owner = value;
            get => account_owner;
        }

        public double getBalance
        {
            get => balance;
        }
        public double Deposit(double amount)
        {
            if(amount <= 0) { throw new ArgumentException("wrong input"); }
            balance += amount;
            return balance;
        }

        public double Withdraw(double amount)
        {
            if (amount < 0 || amount > balance) { throw new ArgumentException("inssuficient balance"); }
            return balance-amount;
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

        public string SchoolName
        {
            set
            {
                if (string.IsNullOrEmpty(value)) { throw new ArgumentException("empty"); }
                name = value;
            }
        }

        public Student()
        {
            name = "uknown";
            SchoolName = "unamed";
            grade = 1;
        }

        public Student(string name) : this()
        {
            this.name = name;
            grade = 1;
            SchoolName = "uknown";
        }

        public Student(int grade, string name) : this(name)
        {
            this.grade = grade;
            this.name = name;
            SchoolName = "uknown";
        }

        public Student(int grade, string name, string schoolName) : this(grade, name)
        {
            this.name = name;
            SchoolName = schoolName;
            this.grade = grade;
        }

        public int Grade
        {
            get => grade;
            set
            {
                if (value <= 12 || value > 100) { throw new ArgumentException("invaliod grade inpiut"); }
                grade = value;
            }
        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value)) { throw new ArgumentException("empty"); }
                name = value;
            }
            get { return name; }
        }
    }
}