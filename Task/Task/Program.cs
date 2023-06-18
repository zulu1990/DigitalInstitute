using System;
using System.Collections;
using System.Collections.Generic;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyIntegerRange range1 = new MyIntegerRange(1, 5);
            foreach (int number in range1)
            {
                Console.WriteLine(number);
            }

        }
        //Task 1: Simple IEnumerable and IEnumerator Implementation
        //Create a simple class MyIntegerRange that represents a range of integers and implements IEnumerable<int>.
        //It should have two private fields for the start and end of the range.
        //It should use IEnumerator to iterate from the start to the end of the range.

        public class MyIntegerRange : IEnumerable<int>
        {
            private int start;
            private int end;

            public MyIntegerRange(int start, int end)
            {
                this.start = start;
                this.end = end;
            }

            public IEnumerator<int> GetEnumerator()
            {
                return new IntegerEnumerator(start, end);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            private class IntegerEnumerator : IEnumerator<int>
            {
                private int current;
                private int end;

                public IntegerEnumerator(int start, int end)
                {
                    current = start - 1;
                    this.end = end;
                }

                public int Current => current;

                object IEnumerator.Current => Current;

                public bool MoveNext()
                {
                    return ++current <= end;
                }

                public void Reset()
                {
                    current = current - 1;
                }

                public void Dispose()
                {
                }
            }
        }


        //Task 2: Using the 'yield' Keyword
        //Modify the MyIntegerRange class from the first task to use the yield keyword in its GetEnumerator() method instead of manually implementing an IEnumerator.



        //Task 3: Fibonacci Sequence with 'yield' (It's not that easy :P)
        //Create a method IEnumerable<int> Fibonacci(int n) that returns an IEnumerable sequence of the first n numbers in the Fibonacci series using the 'yield' keyword.
    }
}