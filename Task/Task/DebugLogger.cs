using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public static class DebugLogger
    {
        public static void LogMessage(string message)
        {
#if DEBUG
            
            Console.WriteLine($"{DateTime.Now}: {message}");
#endif
        }
    }
}
