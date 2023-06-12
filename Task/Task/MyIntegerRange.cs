using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    //Task 1: Simple IEnumerable and IEnumerator Implementation
    //Create a simple class MyIntegerRange that represents a range of integers and implements IEnumerable<int>.
    //It should have two private fields for the start and end of the range.
    //It should use IEnumerator to iterate from the start to the end of the range.

    internal class MyIntegerRange : IEnumerable<int>
    {
        private int Start { get; set; }
        private int End { get; set; }


        public MyIntegerRange(int start, int end)
        {
            if (start >= end)
            {
                throw new ArgumentException($"There is no numebrs between {start} and {end}");
            }
            Start = start;
            End = end;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new IntegerRangeEnumerator(Start, End);

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        //Task 2: Using the 'yield' Keyword
        //Modify the MyIntegerRange class from the first task to use the yield keyword in its GetEnumerator() method instead of manually implementing an IEnumerator.

        //public IEnumerator<int> GetEnumerator()
        //{
        //    for (int i = Start; i <= End; i++)
        //    {
        //        yield return i;
        //    }

        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return GetEnumerator();
        //}



        public class IntegerRangeEnumerator : IEnumerator<int>
        {
            private int _start;
            private int _end;
            private int _iterator;

            public static int _count = 0;

            public IntegerRangeEnumerator(int Start, int end)
            {
                _iterator = Start-1;
                _start = Start;
                _end = end;

            }

            public int Current => _iterator;

            object IEnumerator.Current => Current;


            public void Dispose()
            {
                // Can't understand what to dispose
            }

            public bool MoveNext()
            {
                if (_end > _iterator)
                {
                    _iterator++;
                    _count++;
                    return true;
                }
                return false;
            }

            public void Reset()
            {
                _iterator = _start;
            }
        }

    }
}
