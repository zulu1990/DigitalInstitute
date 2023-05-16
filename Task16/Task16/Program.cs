using System.ComponentModel;
using System.Globalization;

namespace Task16
{
    internal class Program
    {
        static void Main(string[] args)
        {   ///////////////////
            List<int> myList = new List<int>() { 2, -3, 4, 112, 7, 9, 112, 5, 9 };
            int result = SumOfNumbersInList(myList);
            Console.WriteLine(result);

            ////////////////////
            Console.WriteLine();
            List<string> distinctWords = new List<string>() { "hi", "hi", "hello", "HI", "bye", "hi", "holla" };
            distinctWords = RemoveDuplicates(distinctWords);
            foreach (string d in distinctWords)
            {
                Console.WriteLine(d);
            }

            ////////////////////
            int sumMinMax = SumOfMinAndMax(myList);
            Console.WriteLine("\n" + sumMinMax);

            ////////////////
            Console.WriteLine();
            int mostFrequendEelemnt = MostFrequendElement(myList);
            Console.WriteLine(mostFrequendEelemnt);

            /////////////////
            Console.WriteLine();
            List<List<List<int>>> lisOfList = new List<List<List<int>>>
            {
                new List<List<int>>
                {
                    new List<int> { 1,2,3},
                    new List<int>{7,1}
                },
                new List<List<int>>
                {
                    new List<int> { 8,9},
                    new List<int> {1,1,1}
                }
            };
            int sumOfList3D = SumOfAllLists(lisOfList);
            Console.WriteLine(sumOfList3D);
        }

        // Write method that accepts list of numbers and returns sum
        public static int SumOfNumbersInList(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("Empty List");
            }
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        // Write method that accepts list of strings and returns same list, but without duplicates
        public static List<string> RemoveDuplicates(List<string> words)
        {
            if (words == null || words.Count == 0)
            {
                throw new ArgumentException("Empty List");
            }
            words = words.Distinct().ToList();
            return words;
        }

        // Write method that accepts list of numbers and returns sum of minimum and maximum numbers in this lists
        public static int SumOfMinAndMax(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("Empty List");
            }
            int min = int.MaxValue;
            int max = int.MinValue;

            foreach (int num in numbers)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }
            return min + max;

            // solution #2
            numbers.Sort();
            // return numbers[0] + numbers[numbers.Count - 1];
        }

        // Find the most frequent element in list and return it
        public static int MostFrequendElement(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("Empty List");
            }

            int frequentElement = numbers[0];
            int maxFrequence = 1;
            for (int i = 0; i < numbers.Count; i++)
            {
                int currentFrequence = 1;

                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[j] == numbers[i])
                    {
                        currentFrequence++;
                    }
                }

                if (currentFrequence > maxFrequence)
                {
                    frequentElement = numbers[i];
                    maxFrequence = currentFrequence;
                }
            }
            return frequentElement;
        }

        //Bonus points
        //write function that will accept 3D list and will return sum of all elements
        public static int SumOfAllLists(List<List<List<int>>> list3D)
        {
            if (list3D == null || list3D.Count == 0)
            {
                throw new ArgumentException("Empty List");
            }

            int sum = 0;

            for(int i = 0; i < list3D.Count; i++)
            {
                for(int j = 0; j < list3D[i].Count; j++)
                {
                    for(int k = 0; k < list3D[i][j].Count; k++)
                    {
                        sum += list3D[i][j][k];
                    }
                }
            }

            return sum;
        }
    }
}