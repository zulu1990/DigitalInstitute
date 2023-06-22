using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;

namespace Task
{
    class Program
    {



        // Before you start!!!!!!!!!!!!
        // you don't need to use the keyword "delegate" in any of these tasks (use FUNC!).
        // do a little reasearch about LINQ and "Where" method in LINQ
        // you will have to create 3 functions, that will be passed to the WHERE method.

        //  Task 1: Filtering Prime Numbers
        //  You have a list of numbers from 1 to 1000.
        //  You need to create a new list that only includes the prime numbers from the original list.
        //  Use a delegate to decide if a number is prime or not.
        //  This will involve checking every number from 2 to the square root of the number you're checking to see if it divides evenly.

        static bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }




        //  Task 2: Filtering Words Based on Consonant Count
        //  You have a list of different words.
        //  You need to make a new list that only includes the words where the count of consonants is greater than the count of vowels.
        //  In English, the vowels are A, E, I, O, U and sometimes Y. All the other letters are consonants.
        //  Use a delegate to decide if a word has more consonants than vowels.


        static bool HasMoreConsonants(string word)
        {
            int vowelCount = word.Count(c => "AEIOUaeiou".Contains(c));
            int consonantCount = word.Length - vowelCount;

            return consonantCount > vowelCount;
        }


        //  Task 3: Filtering Students Based on Average Grades
        //  You have a list of students, and each student has a name and a list of grades.
        //  You need to make a new list that only includes the students whose average grade is greater than 85.
        //  This will involve adding up all of a student's grades and dividing by the total number of grades to find the average.
        //  Use a delegate to decide if a student's average grade is greater than 85.

        class Student
        {
            public string Name { get; set; }
            public List<int> Grades { get; set; }
        }

        static bool HasAverageGreaterThan85(Student student)
        {
            double average = student.Grades.Average();
            return average > 85;
        }


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

        static void Main(string[] args)
        {


            //Task 1

            List<int> numbers = Enumerable.Range(1, 1000).ToList();

            List<int> primeNumbers = numbers.Where(IsPrime).ToList();

            foreach (int prime in primeNumbers)
            {
                Console.WriteLine(prime);
            }


            //Task2

            List<string> words = new List<string> { "hello", "world", "programming", "is", "fun" };

            List<string> filteredWords = words.Where(HasMoreConsonants).ToList();

            foreach (string word in filteredWords)
            {
                Console.WriteLine(word);
            }



            //Task 3

            List<Student> students = new List<Student>
            {
            new Student { Name = "John", Grades = new List<int> { 80, 90, 95 } },
            new Student { Name = "Alice", Grades = new List<int> { 70, 75, 85 } },
            new Student { Name = "Bob", Grades = new List<int> { 90, 85, 80 } }
            };

            List<Student> filteredStudents = students.Where(HasAverageGreaterThan85).ToList();

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine(student.Name);
            }
        }

    } 
}