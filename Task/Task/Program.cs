﻿namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var numbers in Fibonachi(10))
            {
                Console.WriteLine(numbers);

            }

        }
        //Task 1: Simple IEnumerable and IEnumerator Implementation
        //Create a simple class MyIntegerRange that represents a range of integers and implements IEnumerable<int>.
        //It should have two private fields for the start and end of the range.
        //It should use IEnumerator to iterate from the start to the end of the range.

        //Task 2: Using the 'yield' Keyword
        //Modify the MyIntegerRange class from the first task to use the yield keyword in its GetEnumerator() method instead of manually implementing an IEnumerator.

       

        public static IEnumerable<int> Fibonachi(int n)
        {
            //Task 3: Fibonacci Sequence with 'yield' (It's not that easy :P)
            //Create a method IEnumerable<int> Fibonacci(int n) that returns an IEnumerable sequence of the first n numbers in the Fibonacci series using the 'yield' keyword.

            if (n < 1)
                throw new ArgumentException("takeing number is less then 1");


            int x = 0;
            int y = 1;

            for(int i = 0; i < n; i++)
            {
                yield return y;


                int z = x + y;
                x = y;
                y = z;
            }
        }
    }

}