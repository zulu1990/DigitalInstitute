using System;

namespace Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfNumbers());
            CalculateFibonacci();
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
            Console.Write("Enter a number: ");
            string number = Console.ReadLine();

            int result = 0;
            foreach (var item in number)
            {
                result += item - '0';
            }
            return result;
        }

        //Write a method in C# Sharp to create a recursive function to calculate the Fibonacci number of a specific term.
        //Test Data :
        //Enter a number: 10
        //Expected Output :
        //The Fibonacci of 10 th term is 55
        //The Fibonacci sequence is a series of numbers in which each number is the sum of the two preceding ones, often starting with 0 and 1. That is, the sequence goes: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34
        public static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        static void CalculateFibonacci()
        {
            Console.Write("Enter a number: ");
            int term = int.Parse(Console.ReadLine());

            int fibNumber = Fibonacci(term);

            Console.WriteLine($"The Fibonacci of {term}th term is {fibNumber}");
        }

        // Write C# method to draw the Chess board in console
        public static void DrawChessBoard()
        {
            int boardSize = 8; // Adjust this value to change the size of the chessboard

            for (int row = 0; row < boardSize; row++)
            {
                for (int col = 0; col < boardSize; col++)
                {
                    if ((row + col) % 2 == 0)
                    {
                        Console.Write("██"); // Black square
                    }
                    else
                    {
                        Console.Write("  "); // White square
                    }
                }
                Console.WriteLine();
            }
        }
    }
}