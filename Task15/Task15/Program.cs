using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(SumOfNumbers());
        }

        //Task 1
        //Write a method in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
        //Test Data :
        //Enter a number: 1234
        //Expected Output :
        //The sum of the digits of the number 1234 is : 10
        public static int SumOfNumbers()
        {
            int sum = 0;
            int number = 1234;
            string numToString = number.ToString();
            char[] arr = numToString.ToCharArray();
            for(int i = 0; i < arr.Length; i++)
            {
                int intNum = int.Parse(arr[i].ToString());
                sum += intNum;
            }
            return sum;
        }

        //Write a method in C# Sharp to create a recursive function to calculate the Fibonacci number of a specific term.
        //Test Data :
        //Enter a number: 10
        //Expected Output :
        //The Fibonacci of 10 th term is 55
        //The Fibonacci sequence is a series of numbers in which each number is the sum of the two preceding ones, often starting with 0 and 1. That is, the sequence goes: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34
        public static int Fibonacci()
        {
            throw new NotImplementedException();
        }

        // Write C# method to draw the Chess board in console
        public static void DrawChessBoard()
        {

        }
    }
}