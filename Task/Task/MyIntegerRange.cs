using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
