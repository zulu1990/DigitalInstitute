namespace Task16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //My custom 3Dlist 
            List<List<List<int>>> list = new List<List<List<int>>>{
                new List<List<int>> {
                    new List<int> {1,2,3},
                    new List<int> {4,5,6},
                    new List<int> {7,8,9}},

                new List<List<int>> {
                    new List<int> {10,11,12}, 
                    new List<int> {13,14,15}, 
                    new List<int> {16,17,18}},

                new List<List<int>> {
                    new List<int> {19,20,21}, 
                    new List<int> {22,23,24}, 
                    new List<int> {25,26,27}}
            };
         }

        // Write method that accepts list of numbers and returns sum
        public static int SumOfNumbersInList(List<int> numbers)
        {
            int sum = 0;
            foreach(int i in numbers)
            {
                sum += i;
            }
            return sum;
        }

        // Write method that accepts list of strings and returns same list, but without duplicates
        public static List<string> RemoveDuplicates(List<string> words)
        {
            for (int i = 0; i < words.Count; i++)
            {
                if (words.IndexOf(words[i],i+1) != -1)
                {
                    words.RemoveAt((words.IndexOf(words[i], i + 1)));
                }
            }
            return words;
        }

        // Write method that accepts list of numbers and returns sum of minimum and maximum numbers in this lists
        public static int SumOfMinAndMax(List<int> numbers)
        {
            //I did not want to use the List<T>.Min() and  List<T>.Max() methods, that would be too easy.

            int min = int.MaxValue;
            int max = int.MinValue;

            foreach (int i in numbers)
            {
                if (i < min)
                {
                    min = i;
                }
                if (i > max)
                {
                    max = i;
                }
            }

            return min+max;
        }

        // Find the most frequent element in list and return it
        public static int MostFrequendElement(List<int> numbers)
        {
            int maxCount = int.MinValue;
            int count = 1;
            int element = 0;

            for(int i=0; i<numbers.Count; i++)
            {
                for(int j=i+1; j<numbers.Count; j++)
                {
                    if (numbers[j] == numbers[i])
                    {
                        count++;
                    }
                }
                if(count > maxCount)
                {
                    maxCount = count;
                    element = numbers[i];
                }
                count = 1;
            }

            return element;
        }


        //Bonus points
        //write function that will accept 3D list and will return sum of all elements
        public static int SumOfAllLists(List<List<List<int>>> list3D)
        {
            int sum = 0;
            for(int x=0; x < list3D.Count; x++)
            {
                for (int y=0; y<list3D[x].Count; y++)
                {
                    for(int z=0; z<list3D[x][y].Count; z++)
                    {
                        sum = sum + list3D[x][y][z];
                    }
                }
            }
            return sum;
        }
    }
}