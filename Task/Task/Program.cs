using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;

namespace Task
{
    internal class Program
    {
        //  Task 1: Filtering Prime Numbers
        //  You have a list of numbers from 1 to 1000.
        //  You need to create a new list that only includes the prime numbers from the original list.
        //  Use a delegate to decide if a number is prime or not.
        //  This will involve checking every number from 2 to the square root of the number you're checking to see if it divides evenly.

        Func<List<int>, List<int>> Task1 = input => input.Where(x => x % 2 == 0).ToList();

        //   Task 2: Filtering Words Based on Consonant Count
        //  You have a list of different words.
        //  You need to make a new list that only includes the words where the count of consonants is greater than the count of vowels.
        //  In English, the vowels are A, E, I, O, U and sometimes Y. All the other letters are consonants.
        //  Use a delegate to decide if a word has more consonants than vowels.



        Func<List<string>, List<string>> Task2 = input =>
        {

            char[] myCharacters = { 'A', 'E', 'I', 'O', 'U' };
            List<string> output = new List<string>();

            foreach (string word in input)
            {
                int vowelCount = 0;
                int consonantCount = 0;

                foreach (char leter in word.ToUpper())
                {
                    if (myCharacters.Contains(leter)) vowelCount++;

                    else consonantCount++;

                }

                if (vowelCount > consonantCount) output.Add(word);

            }

            return output;
        };


        // Task 3: Filtering Students Based on Average Grades
        //  You have a list of students, and each student has a name and a list of grades.
        //  You need to make a new list that only includes the students whose average grade is greater than 85.
        //  This will involve adding up all of a student's grades and dividing by the total number of grades to find the average.
        //  Use a delegate to decide if a student's average grade is greater than 85.

        Func<Dictionary<string, Dictionary<string, decimal>>, List<string>> Task3 = studentInfo =>
        {
            // dict must dave student "name" kay , "Subject and grade"  subject is value of name grade is value for subject
            List<string> output = new List<string>();

            foreach (KeyValuePair<string, Dictionary<string, decimal>> subject in studentInfo)
            {
                string name = subject.Key;
                decimal countAvg = 0;

                foreach (var grade in subject.Value)
                    countAvg += grade.Value;

                if (countAvg > 85)
                    output.Add(name);

            }

            return output;
        };



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

        static Func<Worker, bool> IsinSalesDepartment = worker => worker.Department == "Sales";

        static Func<Worker, bool> EarnsMoreThan5000 = worker => worker.Salary > 5000;

        static Func<List<Worker>, List<Worker>> Filter = workers =>
        workers.Where(worker => IsinSalesDepartment(worker) && EarnsMoreThan5000(worker)).ToList();
        class Worker
        {
            public string Name { get; set; }
            public string Department { get; set; }
            public decimal Salary { get; set; }

            public Worker(string mame, string department, decimal salary)
            {
                Name = mame;
                Department = department;
                Salary = salary;
            }
        }
        static void Main(string[] args)
        {
        }
    }


}