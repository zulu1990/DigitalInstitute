using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    // medium
    //Use the Where and Sum methods to add up all the numbers in a list that are greater than 10.
    //Use the Select and Average methods to find the average length of words in a list of strings.
    //Use the OrderByDescending and First methods to find the longest word in a list of strings.
    //Use the Where and Count methods to find out how many words in a list have more than 5 letters.
    //Use the Skip and Take methods to get the second half of a list (assume the list length is an even number).
    internal class Task2
    {
        public static void main()
        {
            Console.WriteLine("\n\nmedium tasks for LINQ");
            SumNumbersGreaterThan10();
            AverageLengthOfWords();
            LongestWordInList();
            CountLetters();
            SecondHalfOfList();
        }

        #region sum of numbers greater than 10
        static void SumNumbersGreaterThan10()
        {
            List<int> numbers = new List<int> { 2, 8, 6, 5, 19, 2, 12 };
            int sum = numbers.Where(n => n > 10).Sum();
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine($"\nsum of numbers which are greater than 10: {sum}");
        }
        #endregion sum of numbers greater than 10
        #region average length of words
        static void AverageLengthOfWords()
        {
            List<string> words = new List<string> { "hello", "apple", "pen", "door", "window", "chair" };
            Console.Write("List: ");
            foreach (string word in words)
            {
                Console.Write($"{word}, ");
            }
            double average = words.Select(w => w.Length).Average();
            Console.WriteLine($"\naverage length of words: {average}"); 
        }
        #endregion average length of words
        #region longest word in list
        static void LongestWordInList()
        {
            List<string> words = new List<string> { "hello", "apple", "pen", "door", "window", "chair" };
            Console.Write("List: ");
            foreach (string w in words)
            {
                Console.Write($"{w}, ");
            }
            var word = words.OrderByDescending(w => w.Length).First();
            Console.WriteLine($"\nlongest word: {word}");
        }
        #endregion longest word in list
        #region how many words in a list have more than 5 letters
        static void CountLetters()
        {
            List<string> words = new List<string> { "hello", "apple", "pen","orange", "door", "window", "chair" };
            Console.Write("List: ");
            foreach (string w in words)
            {
                Console.Write($"{w}, ");
            }
            int count = words.Where(w => w.Length > 5).Count();
            Console.WriteLine($"\nnumber of words with more than 5 letters: {count}");
        }
        #endregion how many words in a list have more than 5 letters
        #region second half of a list
        static void SecondHalfOfList()
        {
            List<string> words = new List<string> { "hello", "apple", "pen", "orange", "door", "window"};
            Console.Write("List: ");
            foreach (string w in words)
            {
                Console.Write($"{w}, ");
            }
            var secondHalf = words.Skip(words.Count / 2).TakeWhile(w => w != null);
            Console.Write("\nsecond half of list: ");
            foreach (var str in secondHalf)
            {
                Console.Write($"{str}, ");
            }
        }
        #endregion second half of a list
    }
}
