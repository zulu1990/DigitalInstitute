namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1
            CustomEnumerator();

            //Task2
            FibonacciWithYield();
        }

        public static void CustomEnumerator()
        {
            MyIntegerRange range = new MyIntegerRange(-10, 10);

            foreach (int i in range)
            {
                Console.WriteLine(i);
            }
        }

        public static void FibonacciWithYield()
        {
            foreach(var n in Fibonacci(15))
            {
                Console.WriteLine(n);
            }
        }

        public static IEnumerable<int> Fibonacci(int n)
        {
            int prevprev = 0;
            int prev = 1;
            int curr = prevprev + prev;

            for (int i = 0; i < n; i++)
            {
                yield return prevprev;
                prevprev = prev;
                prev = curr;
                curr = prevprev + prev;
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