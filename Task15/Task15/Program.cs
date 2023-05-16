using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //test of task1
            int sumofnumbers = SumOfNumbers(1234);
            Console.WriteLine(sumofnumbers);
            //test of task2
            int fibonacci = Fibonacci(10);
            Console.WriteLine(fibonacci);
            //test of task3
            const int boardSize = 8;

            for (int row = 0; row < boardSize; row++)
            {
                for (int col = 0; col < boardSize; col++)
                {
                    // Alternate the color of the squares based on row and column indices
                    if ((row + col) % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    // Display a placeholder piece at each square
                    Console.Write("X ");
                }

                // Reset colors and move to the next line for the next row
                Console.ResetColor();
                Console.WriteLine();
            }

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }

        //Task 1
        //Write a method in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
        //Test Data :
        //Enter a number: 1234
        //Expected Output :
        //The sum of the digits of the number 1234 is : 10
        public static int SumOfNumbers(int input)
        {
            int sum = 0;
            string num = input.ToString();
            for(int i = 0; i <num.Length; i++)
            {
                int temporary = int.Parse(num[i].ToString());
                sum += temporary;
            }
            return sum;
        }

        //Write a method in C# Sharp to create a recursive function to calculate the Fibonacci number of a specific term.
        //Test Data :
        //Enter a number: 10
        //Expected Output :
        //The Fibonacci of 10 th term is 55
        //The Fibonacci sequence is a series of numbers in which each number is the sum of the two preceding ones, often starting with 0 and 1. That is, the sequence goes: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34
        public static int Fibonacci(int input)
        {
            if(input == 0) return 0;
            if(input == 1) return 1;
            else
            {
                return Fibonacci(input-1) + Fibonacci(input-2);
            }
        }

        // Write C# method to draw the Chess board in console
        public static void DrawChessBoard()
        {
            
        }
    }
}