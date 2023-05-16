using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        //Task 1
        //Write a method in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
        //Test Data :
        //Enter a number: 1234
        //Expected Output :
        //The sum of the digits of the number 1234 is : 10
        public static int SumOfNumbers()
        {
            Console.Write("Enter a Number: ");
            int i = Int32.Parse(Console.ReadLine());
            int sum = 0;
            string intsrostr = i.ToString();
            char[] chrs = intsrostr.ToCharArray();
            for (int k = 0; k < chrs.Length; k++)
            {
                int PrsedNum = int.Parse(chrs[k].ToString());
                sum += PrsedNum;
            }

            return sum;

        }

        //Write a method in C# Sharp to create a recursive function to calculate the Fibonacci number of a specific term.
        //Test Data :
        //Enter a number: 10
        //Expected Output :
        //The Fibonacci of 10 th term is 55
        //The Fibonacci sequence is a series of numbers in which each number is the sum of the two preceding ones, often starting with 0 and 1. That is, the sequence goes: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34
        public static int Fibonacci(int num)
        {
            
            
            if (num <= 1)
            {
                return num;
            }

            
            return Fibonacci(num - 1) + Fibonacci(num - 2);
        }

        
        public static void DrawChessBoard()
        {
            int size = 8; 

            ConsoleColor darkColor = ConsoleColor.Black;
            ConsoleColor lightColor = ConsoleColor.White;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    
                    ConsoleColor backgroundColor = (row + col) % 2 == 0 ? lightColor : darkColor;

                    
                    Console.BackgroundColor = backgroundColor;
                    Console.ForegroundColor = ConsoleColor.Black;

                    
                    Console.Write("  ");
                }

                Console.WriteLine();
            }

            
            Console.ResetColor();
        }

    }
}
