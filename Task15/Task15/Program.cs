using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        //Task 1
        //Write a method in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
        //Test Data :
        //Enter a number: 1234
        //Expected Output :
        //The sum of the digits of the number 1234 is : 10
        public static int SumOfNumbers(int number)
        {
            int sum = 0;

            while(number > 0)
            {
                sum += number % 10;
                number = number / 10;  
            }

            return sum;

        }

        //Write a method in C# Sharp to create a recursive function to calculate the Fibonacci number of a specific term.
        //Test Data :
        //Enter a number: 10
        //Expected Output :
        //The Fibonacci of 10 th term is 55
        //The Fibonacci sequence is a series of numbers in which each number is the sum of the two preceding ones, often starting with 0 and 1. That is, the sequence goes: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34
        public static int Fibonacci(int number)
        {
            if (number == 1) return 0;
            if (number == 2) return 1;

            return Fibonacci(number-1)+Fibonacci(number-2);
        }

        // Write C# method to draw the Chess board in console
        public static void DrawChessBoard()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            for(int i=0; i < 8; i++)
            {
                for(int j=0 ; j < 8; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    Console.Write("[]");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}