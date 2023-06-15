using System.Collections;

namespace Task
{
    internal class Program
    {
        static void Main()
        {
            // Task 1: Simple IEnumerable and IEnumerator Implementation
            MyIntegerRange range = new(1, 5);
            foreach (int number in range)
            {
                Console.WriteLine(number);
            }

            // Task 2: Using the 'yield' Keyword
            MyIntegerRangeYield rangeYield = new MyIntegerRangeYield(1, 5);
            foreach (int number in rangeYield)
            {
                Console.WriteLine(number);
            }

            // Task 3: Fibonacci Sequence with 'yield'
            foreach (int number in Fibonacci(10))
            {
                Console.WriteLine(number);
            }
        }

        // Task 1: Simple IEnumerable and IEnumerator Implementation
        //Create a simple class MyIntegerRange that represents a range of integers and implements IEnumerable<int>.
        //It should have two private fields for the start and end of the range.
        //It should use IEnumerator to iterate from the start to the end of the range.
        public class MyIntegerRange : IEnumerable<int>
        {
            private readonly int start;
            private readonly int end;

            public MyIntegerRange(int start, int end)
            {
                this.start = start;
                this.end = end;
            }

            public IEnumerator<int> GetEnumerator()
            {
                return new IntegerRangeEnumerator(start, end);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
            private class IntegerRangeEnumerator : IEnumerator<int>
            {
                private int current;
                private readonly int end;

                public IntegerRangeEnumerator(int start, int end)
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
                    current = 0;
                }

                public void Dispose()
                {
                    // Dispose resources if needed
                }
            }
        }

        //Task 2: Using the 'yield' Keyword
        //Modify the MyIntegerRange class from the first task to use the yield keyword in its GetEnumerator() method instead of manually implementing an IEnumerator.

        public class MyIntegerRangeYield : IEnumerable<int>
        {
            private readonly int start;
            private readonly int end;

            public MyIntegerRangeYield(int start, int end)
            {
                this.start = start;
                this.end = end;
            }

            public IEnumerator<int> GetEnumerator()
            {
                for (int number = start; number <= end; number++)
                {
                    yield return number;
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        //Task 3: Fibonacci Sequence with 'yield' (It's not that easy :P)
        //Create a method IEnumerable<int> Fibonacci(int n) that returns an IEnumerable sequence of the first n numbers in the Fibonacci series using the 'yield' keyword.
        public static IEnumerable<int> Fibonacci(int n)
        {
            int previous = 0;
            int current = 1;

            for (int i = 0; i < n; i++)
            {
                yield return current;

                int temp = previous;
                previous = current;
                current = temp + current;
            }
        }
    }
}