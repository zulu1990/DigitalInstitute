namespace Task
{
    internal class Task2
    {
        // medium
        //Use the Where and Sum methods to add up all the numbers in a list that are greater than 10.
        //Use the Select and Average methods to find the average length of words in a list of strings.
        //Use the OrderByDescending and First methods to find the longest word in a list of strings.
        //Use the Where and Count methods to find out how many words in a list have more than 5 letters.
        //Use the Skip and Take methods to get the second half of a list (assume the list length is an even number).
        //Tasks with three LINQ methods:
        public static void Start()
        {
            SumNumbersGreaterThan10();
            AverageWordLength();
            FindLongestWord();
            CountWordsWithMoreThan5Letters();
            GetSecondHalfOfList();
        }

        static void SumNumbersGreaterThan10()
        {
            List<int> numbers = new List<int> { 5, 10, 15, 20, 25 };
            int sum = numbers.Where(number => number > 10).Sum();
            Console.WriteLine($"Sum of numbers greater than 10: {sum}");
        }

        static void AverageWordLength()
        {
            List<string> words = new List<string> { "apple", "banana", "cherry", "date" };
            double averageLength = words.Select(word => word.Length).Average();
            Console.WriteLine($"Average word length: {averageLength}");
        }

        static void FindLongestWord()
        {
            List<string> words = new List<string> { "cat", "elephant", "dog", "giraffe" };
            string longestWord = words.OrderByDescending(word => word.Length).First();
            Console.WriteLine($"Longest word: {longestWord}");
        }

        static void CountWordsWithMoreThan5Letters()
        {
            List<string> words = new List<string> { "apple", "banana", "cherry", "date" };
            int count = words.Where(word => word.Length > 5).Count();
            Console.WriteLine($"Count of words with more than 5 letters: {count}");
        }

        static void GetSecondHalfOfList()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            var secondHalf = numbers.Skip(numbers.Count / 2).Take(numbers.Count / 2);
            Console.WriteLine("Second half of the list:");
            foreach (var number in secondHalf)
            {
                Console.WriteLine(number);
            }
        }
    }
}
