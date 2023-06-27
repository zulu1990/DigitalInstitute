using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    //Use the Where, Select, and Average methods to find the average value of numbers in a list that are divisible by 3.
    //Use the OrderBy, Reverse, and First methods to find the second smallest number in a list of integers.
    //Use the Where, GroupBy, and Count methods to find out how many unique numbers in a list are greater than 20.
    //Use the Select, Concat, and ToArray methods to merge a list of first names and a list of last names into a single array, with each element being "firstname_lastname".
    //Use the Where, OrderByDescending, and First methods to find the largest number in a list that is less than 100.
    internal class Task3
    {
        public static void main()
        {
            Console.WriteLine("\n\nhard tasks for LINQ");
            AverageDivisibleBy3();
            SecondSmallestNumber();
            CountUniqueNumbersGreaterThan20();
            ConcatFirstAndLastNames();
            LargestNumverLessThan100();

        }
        #region average value of numbers in a list that are divisible by 3
        static void AverageDivisibleBy3()
        {
            List<int> numbers = new List<int> { 2, 8, 6, 5, 19, 2, 12 };
            double average = numbers.Select(w => w).Where(w => w % 3 == 0).Average();
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine($"\naverage of numbers which are divisiblae by 3: {average}");
        }
        #endregion average value of numbers in a list that are divisible by 3
        #region second smallest number in list
        static void SecondSmallestNumber()
        {
            List<int> numbers = new List<int> { 2, 8, 6, 5, 19, 1, 12 };
            double secondSmallestNumber = numbers.OrderByDescending(n => n).Reverse().Skip(1).First();
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine($"\nsecond smallest number in list: {secondSmallestNumber}");
        }
        #endregion second smallest number in list
        #region count unique numbers greater than 20
        static void CountUniqueNumbersGreaterThan20()
        {
            List<int> numbers = new List<int> { 2, 25, 6, 25, 19, 1, 22 };
            int count = numbers.Where(n => n > 20).GroupBy(n => n).Count();
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine($"\nnumber of unique numbers greater than 20: {count}");
        }
        #endregion count unique numbers greater than 20
        #region merge a list of first names and a list of last names
        static void ConcatFirstAndLastNames()
        {
            List<string> firstName = new List<string> { "Jack", "Nick", "Anna", "Simon" };
            List<string> lastName = new List<string> { "Windward", "Hailey", "Smith", "Brown" };

            string[] fullNames = firstName.Select((name, index) => $"{name}_{lastName[index]}").ToArray();

            foreach (string fullname in fullNames)
            {
                Console.WriteLine(fullname);
            }
        }
        #endregion merge a list of first names and a list of last names
        #region largest number in list that is less than 100
        static void LargestNumverLessThan100()
        {
            List<int> numbers = new List<int> { 2, 8, 6, 5, 19, 2, 12 };
            int largestNumberLessThan100 = 
                numbers.Where(num => num < 100).OrderByDescending(num => num).First();
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine($"\nlargest number which is less than 100: {largestNumberLessThan100}");
        }
        #endregion largest number in list that is less than 100
    }
}
