using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class SortedCollection<T> where T : IComparable<T>
    {
        private List<T> list;
        public SortedCollection()
        {
            list = new List<T>();
        }

        public void Add(T item)
        {
            list.Add(item);
            list.Sort();
        }

        public T Get(int index)
        {
            return list[index];
        }

        public void DisplayCollection()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
