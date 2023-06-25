using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.ListExtentions
{
    public static class ListExtensions
    {
        public static void CustomForEach<T>(this List<T> list, Action<T> action)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            if (action == null)
                throw new ArgumentNullException(nameof(action));

            foreach (var item in list)
            {
                action(item);
            }
        }
    }
}
