using System.Text;
using static Task.MyIntegerRange;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyIntegerRange myInts = new MyIntegerRange(10, 45);
            foreach (int ints in myInts)
            {
                Console.WriteLine(ints);

            }
            Console.WriteLine($"amount of numbers from 10 to 45: " + IntegerRangeEnumerator._count); // it won't work for task 2



            Fibonacci f = new Fibonacci();

            Console.WriteLine();
            int i = 0;
            foreach (int fib in f.FibonacciNumbers(9))
            {
                Console.WriteLine($"{i}: "+fib);
                i++;
            }


        }
        //Task 1: Simple IEnumerable and IEnumerator Implementation
        //Create a simple class MyIntegerRange that represents a range of integers and implements IEnumerable<int>.
        //It should have two private fields for the start and end of the range.
        //It should use IEnumerator to iterate from the start to the end of the range.

        //Task 2: Using the 'yield' Keyword
        //Modify the MyIntegerRange class from the first task to use the yield keyword in its GetEnumerator() method instead of manually implementing an IEnumerator.

        //Task 3: Fibonacci Sequence with 'yield' (It's not that easy :P)
        //Create a method IEnumerable<int> Fibonacci(int n) that returns an IEnumerable sequence of the first n numbers in the Fibonacci series using the 'yield' keyword.
    }
}