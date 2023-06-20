namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
}