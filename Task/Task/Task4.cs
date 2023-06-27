using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Task4
    {
        // crazy asian :D (without hints!) ]:)
        //Use LINQ to find the smallest number that is greater than 50 and its square root is a whole number.
        //Use LINQ to find the most frequent word in a list of strings.
        //Use LINQ to count the total number of letters in the words of a sentence that start with 'A'.
        //Use LINQ to sort the numbers in an array after the first number less than 5 and until the next number less than 5, and return the result as an array.
        //Use LINQ to find the most common length of words in an array of strings.
        public static void main()
        {
            Console.WriteLine("\n\ntasks without hint for LINQ");
            SmallestNumberGreaterThan50AndSquaredRoot();
            MostFrequentWord();
            CountLettersInWords();
            SortNumbersWithSomeCondition();
            MostCommonLength();
        }
        #region smallest number that is >50 and its square root is whole
        static void SmallestNumberGreaterThan50AndSquaredRoot()
        {
            List<int> numbers = new List<int> { 52, 61, 225, 98, 625, 1225, 8, 65, 16 };
            double number = 
                numbers.Where(num => num > 50 && Math.Sqrt(num) % 1 == 0).
                OrderBy(num => num).
                First();
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine($"\nsmallest number that is greater than 50 and its square root is a whole number: {number}");
        }
        #endregion smallest number that is >50 and its square root is whole

        #region find most frequent word in list
        static void MostFrequentWord()
        {
            List<string> words = new List<string> { "hi", "hello", "chair", "Hi", "chair", "hI", "bye" };
            // Thank u google ^_^
            string mostFrequent = words.Select(word=>word.ToLower()).GroupBy(word => word).OrderByDescending(word => word.Count()).
                Select(word => word.Key).First();

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("Most frequent word: " + mostFrequent);
        }
        #endregion merge a list of first names and a list of last names

        #region count letters in word that starts with "A"
        static void CountLettersInWords()
        {
            List<string> words = new List<string> { "Apple", "Ananas", "orange", "air", "Airplane", "Juice" };
            int sum = words.Where(word => word.StartsWith("A")).Sum(word => word.Length);
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("total number " + sum);
        }
        #endregion count letters in word that starts with "A"

        #region sort the numbers in an array after the first number less than 5 and until the next number less than 5
        static void SortNumbersWithSomeCondition()
        {
            List<int> numbers = new List<int> { 52, 61, 4, 225, 98, 625, 1225, 8, 65, 3, 16 };
            int[] sorted = numbers.SkipWhile(num => num > 5).TakeWhile(num => num > 5).OrderBy(num => num).ToArray();
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            // it doesn't print anything, why??????
            foreach (int n in sorted)
            {
                Console.Write(n + " ");
            }

        }
        #endregion sort the numbers in an array after the first number less than 5 and until the next number less than 5

        #region find the most common length of words in an array of strings.
        static void MostCommonLength()
        {
            List<string> words = new List<string> { "hi", "hello", "chair", "Hi", "chair", "hI", "bye", "abcnf" };
            int mostCommonLength = 
                words.Select(word=>word.Length).GroupBy(word => word).
                OrderByDescending(word => word.Count()).
                Select(word=>word.Key).First();

            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine("Most frequent word: " + mostCommonLength);
        }

        #endregion find the most common length of words in an array of strings.
    }
}
