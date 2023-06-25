namespace Task
{
    internal class Program
    {
        // Before you start!!!!!!!!!!!!
        // you don't need to use the keyword "delegate" in any of these tasks (use FUNC!).
        // do a little reasearch about LINQ and "Where" method in LINQ
        // you will have to create 3 functions, that will be passed to the WHERE method.

        static void Main(string[] args)
        {
            WriteTasks("\nTask 1\n");
            Task1.Start();
            WriteTasks("\nTask 2\n");
            Task2.Start();
        }
        public static void WriteTasks(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
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