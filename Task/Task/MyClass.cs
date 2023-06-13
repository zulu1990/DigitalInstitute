using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class MyClass<T,U>
    {
        public T First { get; set; }
        public U Second { get; set; }

        public void SetValues(T firs, U second)
        {
            First = firs;
            Second = second;
        }
        public (T firs, U second) GetValues()
        {
            return( First, Second);
        }

    }
}
