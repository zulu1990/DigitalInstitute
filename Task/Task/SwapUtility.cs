using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class SwapUtility
    {
        public static void Swap<T>(ref T value1, ref T value2)
        {
            T temp = value1;
            value1 = value2;
            value2 = temp;
        }
    }
}
