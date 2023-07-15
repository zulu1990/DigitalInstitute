using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public static class ListValueFinder
    {
        
        
        public static int FindMax(this List<int> list)
        {
            int max = int.MinValue;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > max) max = list[i];
            }

            return max;
        }


        public static int FindMostFrequent(this List<int> list)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (map.ContainsKey(list[i]))
                {
                    map[list[i]]++;
                }
                else
                {
                    map.Add(list[i], 1);
                }
            }

            int max = int.MinValue;
            int num = 0;
            foreach(KeyValuePair<int, int> pair in map)
            {
                if(pair.Value > max) max = pair.Value;
                num = pair.Key;
            }
            return num;
        }

    }
}
