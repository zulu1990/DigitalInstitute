using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfNumbers());

            Console.WriteLine(Fibonacci(10));

            DrawChessBoard();
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
        public static int Fibonacci(int n)
        {

            if(n <=1 )
            {
                return n;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);

        }

        // Write C# method to draw the Chess board in console
        public static void DrawChessBoard()
        {
            for(int i = 0; i < 8; i++)
            {
                Console.Write("===");
            }
            Console.WriteLine();
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if ((row + col) % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write("   ");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("   ");
                    }
                }

                Console.WriteLine();
            }
            

            Console.ResetColor();

            for (int i = 0; i < 8; i++)
            {
                Console.Write("===");
            }
        }
    }
}