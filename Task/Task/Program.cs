using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace Task
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Task 1
            List<int> numbers = Enumerable.Range(1, 1000).ToList();
            Func<int, bool> isPrime = PrimeNumbers;
            List<int> primeNumbers = numbers.Where(isPrime).ToList();
            Console.WriteLine("Prime Numbers:");
            foreach (int num in primeNumbers)
            {
                Console.Write($"{num}, ");
            }

            // Task 2
            List<string> words = new List<string>() { "hello", "hi", "orange", "Hiii", "onion", "CSharp" };
            Func<string, bool> moreConsonant = MoreConsonantThanVowel;
            List<string> wordWithMoreConsonant = words.Where(moreConsonant).ToList();
            Console.WriteLine("\n\nList Of Words :");
            foreach (string word in words)
            {
                Console.Write($"{word}, ");
            }
            Console.WriteLine("\nList Of Words With More Consonant :");
            foreach (string word in wordWithMoreConsonant)
            {
                Console.Write($"{word}, ");
            }

            // Task 3
            List<(string, List<double>)> studentWithGrades = new List<(string Name, List<double> Grades)>
            {
               ( "Nick", new List<double>(){90.2, 100, 88, 75.5}),
               ( "Anna", new List<double>(){99.2, 80, 87.2, 99.99}),
               ( "John", new List<double>(){9.2, 70, 12, 75.5}),
               ( "Maria", new List<double>(){80.2, 98, 78, 100}),
               ( "Nick", new List<double>(){20.2, 45.2, 60.8, 0})
            };
            Func<List<double>, bool> filteringStudents = FilterStudents;
            List<(string, List<double>)> newList =
                studentWithGrades.Where(student => filteringStudents(student.Item2)).ToList();

            Console.WriteLine("\n\nList Of Students whos average score is more than 85");
            foreach (var student in newList)
            {
                Console.WriteLine($"Name: {student.Item1} Grades:  {string.Join("|", student.Item2)} ");
            }


            List<Employee> employees = new List<Employee>()
            {
                new Employee("Jack", "Sales", 9000.80),
                new Employee("Nick", "Marketing ", 2000.80),
                new Employee("Anna", "Sales", 4000.80),
                new Employee("Simon", "Sales", 6000),
                new Employee("Jack", "Finance ", 2000.80),
                new Employee("Nick", "IT  ", 2000.80),
                new Employee("Jack", "Sales ", 2000.80),
                new Employee("Maria", "Finance ", 2000.80)
            };
            Func<Employee, bool> salesDepartment = SalesDepartment;
            List<Employee> salesEmoloyee = employees.Where(emp => salesDepartment(emp)).ToList();
            Console.WriteLine("\nSales Department Employees");
            foreach (var salesDep in salesEmoloyee)
            {
                Console.WriteLine(salesDep.ToString());
            }
            Func<Employee, bool> filterBySalesDepAndSalary = FilterBySalesDepAndSalary;
            List<Employee> filteredEmployees = employees.Where(emp => filterBySalesDepAndSalary(emp)).ToList();
            Console.WriteLine("\nSales Department Employees with more than 5000$ salary");
            foreach (var emp in filteredEmployees)
            {
                Console.WriteLine(emp.ToString());
            }
        }


        

        #region Task1
        public static bool PrimeNumbers(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        #endregion Task 1

        #region Task 2

        public static bool MoreConsonantThanVowel(string text)
        {
            int countVowels = 0;
            int countConsonant = 0;
            foreach (char letter in text.ToLower())
            {
                if ("aeiou".Contains(letter)) countVowels++;
                else countConsonant++;
            }

            if (countConsonant > countVowels)
                return true;
            else
                return false;
        }
        #endregion Task 2



        #region Task 3

        public static bool FilterStudents(List<double> grades)
        {
            //double sum = 0;
            //double average = 0;
            //foreach (var grade in grades)
            //{
            //    sum += grade;
            //}
            //average = sum / grades.Count;

            double average = grades.Average();

            if (average > 85)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        #endregion Task 3


        #region task 4
        
        public static bool SalesDepartment(Employee employee)
        {
            return employee.Department == "Sales";
        }
        public static bool SalaryFilter(Employee employee)
        {
            return employee.Salary > 5000;
        }
        public static bool FilterBySalesDepAndSalary(Employee employee)
        {
            return SalesDepartment(employee) && SalaryFilter(employee);
        }


        public class Employee
        {
            public string Name { get; set; }
            public string Department { get; set; }
            public double Salary { get; set; }
            public Employee(string name, string department, double salary)
            {
                Name = name;
                Department = department;
                Salary = salary;
            }

            public override string ToString()
            {
                return $"Name: {Name} Department: {Department} Salary: {Salary}";
            }
        }

        #endregion task 4
    }





    // Before you start!!!!!!!!!!!!
    // you don't need to use the keyword "delegate" in any of these tasks (use FUNC!).
    // do a little reasearch about LINQ and "Where" method in LINQ
    // you will have to create 3 functions, that will be passed to the WHERE method.

    //  Task 1: Filtering Prime Numbers
    //  You have a list of numbers from 1 to 1000.
    //  You need to create a new list that only includes the prime numbers from the original list.
    //  Use a delegate to decide if a number is prime or not.
    //  This will involve checking every number from 2 to the square root of the number you're checking to see if it divides evenly.

    //  Task 2: Filtering Words Based on Consonant Count
    //  You have a list of different words.
    //  You need to make a new list that only includes the words where the count of consonants is greater than the count of vowels.
    //  In English, the vowels are A, E, I, O, U and sometimes Y. All the other letters are consonants.
    //  Use a delegate to decide if a word has more consonants than vowels.

    //  Task 3: Filtering Students Based on Average Grades
    //  You have a list of students, and each student has a name and a list of grades.
    //  You need to make a new list that only includes the students whose average grade is greater than 85.
    //  This will involve adding up all of a student's grades and dividing by the total number of grades to find the average.
    //  Use a delegate to decide if a student's average grade is greater than 85.


    //  Task 4: Filtering Employees by Department and Salary (Hard one)
    //  You have a list of workers.
    //  Each worker has a name, a department where they work, and a salary.
    //  You need to create a new list.
    //  This list should only have workers who work in the "Sales" department and earn more than $5000.
    //  To do this, you will create three functions:
    //  1) The first function will check if a worker is in the "Sales" department.
    //  2) The second function will check if a worker earns more than $5000.
    //  3)  After you create these two functions, you will create a third function.
    //      This function will combine the first two functions.
    //      If a worker passes both checks, they should be added to the new list.
    //  Use this THIRD(!!) function with the Where method to create your new list.
    //  This task will help you understand how to use multiple functions together to filter a list.
}