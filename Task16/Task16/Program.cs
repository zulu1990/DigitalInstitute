using System.Globalization;

namespace Task16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>() { 2, -3, 4, 112, 7, 9 };
            int result = SumOfNumbersInList(myList);
            Console.WriteLine(result);

            Console.WriteLine();
            List<string> distinctWords = new List<string>() { "hi", "hi", "hello", "HI", "bye","hi", "holla" };
            distinctWords = RemoveDuplicates(distinctWords);
            foreach(string d in distinctWords)
            {
                Console.WriteLine(d);
            }

            int sumMinMax = SumOfMinAndMax(myList);
            Console.WriteLine("\n"+ sumMinMax);
        }

        // Write method that accepts list of numbers and returns sum
        public static int SumOfNumbersInList(List<int> numbers)
        {
            int sum = 0;
            foreach(int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        // Write method that accepts list of strings and returns same list, but without duplicates
        public static List<string> RemoveDuplicates(List<string> words)
        {
            words = words.Distinct().ToList();
            return words;
        }

        // Write method that accepts list of numbers and returns sum of minimum and maximum numbers in this lists
        public static int SumOfMinAndMax(List<int> numbers)
        {
            int min = int.MaxValue;
            int max = int.MinValue;

            foreach( int num in numbers)
            {
                if(num<min) min = num;
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
            throw new NotImplementedException();
        }

        //Bonus points
        //write function that will accept 3D list and will return sum of all elements
        public static int SumOfAllLists(List<List<List<int>>> list3D)
        {
            throw new NotImplementedException();
        }
    }
}