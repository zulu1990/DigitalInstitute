using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    //Task 3: Fibonacci Sequence with 'yield' (It's not that easy :P)
    //Create a method IEnumerable<int> Fibonacci(int n) that returns
    //an IEnumerable sequence of the first n numbers in the Fibonacci series using the 'yield' keyword.
    public class Fibonacci
    {
        public IEnumerable<int> FibonacciNumbers(int n)
        {
            if (n == 0)
                yield return 0;
            if (n == 1)
            {
                yield return 0;
                yield return 1;
            }
            else
            {

                int prev = 0;
                int curr = 1;
                yield return prev;
                yield return curr;
                
                for (int i = 2; i <= n; i++)
                {
                    int next = prev + curr;
                    yield return next;
                    prev = curr;
                    curr = next;
                }


            }
        }
    }
}
