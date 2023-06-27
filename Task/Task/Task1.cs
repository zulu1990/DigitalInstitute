using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    // Use only LINQ!!! in som ecases you will have to create some classes on your own!
    // easy
    //Use the Max method to find the highest number in a list of integers.
    //Use the OrderBy method to sort a list of words alphabetically.
    //Use the Count method to find out how many numbers in a list are greater than 50.
    //Use the First method to get the first word in a list of strings that has a length of 3 letters.
    //Use the Any method to check if any number in a list is a perfect square (the square of an integer).
    internal class Task1
    {
        public static void main()
        {
            Console.WriteLine("easy tasks for LINQ");
            HighestNumber();
            SortAlpabetically();
            CountGreaterThan50();
            LengthOf3();
            PerfectSquare();
        }
        #region max number
        static void HighestNumber()
        {
            List<int> numbers = new List<int> { 2, 8, 6, 5, 19, 2, 12 };
            int max = numbers.Max();
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine($"\nMax number: {max}");
        }
        #endregion max number
        #region use of orderby
        static void SortAlpabetically()
        {
            List<string> words = new List<string> { "hello", "apple", "pen", "door", "window", "chair" };
            Console.WriteLine("original List");
            foreach (string word in words)
            {
                Console.Write($"{word}, ");
            }
            words = words.OrderBy(word => word).ToList();
            Console.WriteLine("\nsorted List");
            foreach (string word in words)
            {
                Console.Write($"{word}, ");
            }
        }
        #endregion use of orderby
        #region count
        static void CountGreaterThan50()
        {
            List<double> numbers = new List<double> { 12.3, 60, 65.1, 80, 12, 45, 87, 47.3 };
            int count = numbers.Count(num => num > 50);
            Console.WriteLine("\nlist of numbers");
            foreach (double n in numbers)
            {
                Console.Write($"{n}|");
            }
            Console.WriteLine("\nAmount of numbers greater than 50: " + count);

        }
        #endregion count
        #region First
        static void LengthOf3()
        {
            List<string> words = new List<string> { "hello", "apple", "pen", "door", "you", "window", "chair" };
            Console.WriteLine("original List");
            foreach (string word in words)
            {
                Console.Write($"{word}, ");
            }
            string wordWithLength3 = words.FirstOrDefault(w => w.Length == 3);
            Console.WriteLine($"\nFirst word with length of 3: {wordWithLength3}");
        }
        #endregion First
        #region Any
        static void PerfectSquare()
        {
            List<int> numbers = new List<int> { 19, 22, 16, 23, 44 };
            Console.WriteLine("original List");
            foreach (int number in numbers)
            {
                Console.Write($"{number}|");
            }
            bool perectSquare = numbers.Any(n => Math.Sqrt(n) % 1 == 0);
            Console.WriteLine($"\nIs in list the perfect square number: {perectSquare}");
        }
        #endregion Any
    }



}
