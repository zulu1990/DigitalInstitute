using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Pair<T, U>
    {
        private T? First { get; set; }
        private U? Second { get; set; }

        public void SetValues(T first, U second)
        {
            First = first;
            Second = second;
        }
        public (T, U) GetValues()
        {
            return (First, Second);
        }

    }
}
