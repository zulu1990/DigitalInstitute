using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Task 1: Filtering Prime Numbers
        List<int> numbers = Enumerable.Range(1, 1000).ToList();
        List<int> primeNumbers = FilterList(numbers, IsPrime);
        Console.WriteLine("Prime Numbers:");
        Console.WriteLine(string.Join(", ", primeNumbers));

        // Task 2: Filtering Words Based on Consonant Count
        List<string> words = new List<string> { "hello", "world", "apple", "banana", "orange", "computer" };
        List<string> filteredWords = FilterList(words, HasMoreConsonantsThanVowels);
        Console.WriteLine("Words with more consonants than vowels:");
        Console.WriteLine(string.Join(", ", filteredWords));

        // Task 3: Filtering Students Based on Average Grades
        List<Student> students = new List<Student>
        {
            new Student("Alice", new List<int> { 90, 85, 92 }),
            new Student("Bob", new List<int> { 80, 75, 88 }),
            new Student("Charlie", new List<int> { 95, 88, 92 }),
            new Student("David", new List<int> { 87, 92, 79 })
        };
        List<Student> filteredStudents = FilterList(students, HasAverageGradeGreaterThan85);
        Console.WriteLine("Students with average grade greater than 85:");
        foreach (Student student in filteredStudents)
        {
            Console.WriteLine(student.Name);
        }

        // Task 4: Filtering Employees by Department and Salary
        List<Employee> employees = new List<Employee>
        {
            new Employee("Alice", "Sales", 6000),
            new Employee("Bob", "Sales", 4000),
            new Employee("Charlie", "HR", 5500),
            new Employee("David", "Sales", 7000)
        };
        List<Employee> filteredEmployees = employees.Where(IsInSalesDepartmentAndEarnsMoreThan5000).ToList();
        Console.WriteLine("Employees in Sales department earning more than $5000:");
        foreach (Employee employee in filteredEmployees)
        {
            Console.WriteLine($"{employee.Name} - {employee.Department} - ${employee.Salary}");
        }
    }

    // Delegate for Task 1: Filtering Prime Numbers
    static bool IsPrime(int number)
    {
        if (number < 2)
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

    // Delegate for Task 2: Filtering Words Based on Consonant Count
    static bool HasMoreConsonantsThanVowels(string word)
    {
        int consonantCount = word.Count(c => !IsVowel(c));
        int vowelCount = word.Count(c => IsVowel(c));
        return consonantCount > vowelCount;
    }

    static bool IsVowel(char c)
    {
        char lowerCaseChar = char.ToLower(c);
        return lowerCaseChar == 'a' || lowerCaseChar == 'e' || lowerCaseChar == 'i' || lowerCaseChar == 'o' || lowerCaseChar == 'u';
    }

    // Delegate for Task 3: Filtering Students Based on Average Grades
    static bool HasAverageGradeGreaterThan85(Student student)
    {
        double averageGrade = student.Grades.Average();
        return averageGrade > 85;
    }

    // Delegate for Task 4: Filtering Employees by Department and Salary
    static bool IsInSalesDepartmentAndEarnsMoreThan5000(Employee employee)
    {
        return employee.Department == "Sales" && employee.Salary > 5000;
    }

    // Generic method to filter a list using a delegate
    static List<T> FilterList<T>(List<T> list, Func<T, bool> filterDelegate)
    {
        return list.Where(filterDelegate).ToList();
    }
}

class Student
{
    public string Name { get; set; }
    public List<int> Grades { get; set; }

    public Student(string name, List<int> grades)
    {
        Name = name;
        Grades = grades;
    }
}

class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }
    public int Salary { get; set; }

    public Employee(string name, string department, int salary)
    {
        Name = name;
        Department = department;
        Salary = salary;
    }
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
