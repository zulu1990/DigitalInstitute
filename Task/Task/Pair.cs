using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Pair<T,U>
    {
        public T First { get; set; }
        public U Second { get; set; }

        public Pair(T first, U second)
        {
            First = first;
            Second = second;
        }

        public void SetValues(T first, U second) 
        {
            First = first;
            Second = second;
        }

        public (T first, U second) GetValues()
        {
            return (First, Second);
        }
    }
}
