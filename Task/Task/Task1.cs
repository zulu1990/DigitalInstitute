namespace Task
{
    internal class Task1
    {
        // Use only LINQ!!! in som ecases you will have to create some classes on your own!
        // easy
        //Use the Max method to find the highest number in a list of integers.
        //Use the OrderBy method to sort a list of words alphabetically.
        //Use the Count method to find out how many numbers in a list are greater than 50.
        //Use the First method to get the first word in a list of strings that has a length of 3 letters.
        //Use the Any method to check if any number in a list is a perfect square (the square of an integer).
        //Tasks with two LINQ methods:
        public static void Start()
        {
            FindMaxNumber();
            SortWordsAlphabetically();
            CountNumbersGreaterThan50();
            FindFirstWordWithThreeLetters();
            CheckForPerfectSquare();
        }
        static void FindMaxNumber()
        {
            List<int> numbers = new() { 10, 5, 20, 15 };
            int maxNumber = numbers.Max();
            Console.WriteLine($"Max number: {maxNumber}");
        }

        static void SortWordsAlphabetically()
        {
            List<string> words = new() { "banana", "apple", "cherry", "date" };
            var sortedWords = words.OrderBy(word => word);
            Console.WriteLine("Sorted words:");
            foreach (var word in sortedWords)
            {
                Console.WriteLine(word);
            }
        }

        static void CountNumbersGreaterThan50()
        {
            List<int> numbers = new() { 10, 55, 30, 70, 90 };
            int count = numbers.Count(number => number > 50);
            Console.WriteLine($"Count of numbers greater than 50: {count}");
        }

        static void FindFirstWordWithThreeLetters()
        {
            List<string> words = new() { "cat", "dog", "elephant", "rat" };
            string firstWord = words.FirstOrDefault(word => word.Length == 3)!;
            Console.WriteLine($"First word with 3 letters: {firstWord}");
        }

        static void CheckForPerfectSquare()
        {
            List<int> numbers = new() { 10, 16, 25, 30, 36 };
            bool hasPerfectSquare = numbers.Any(number => Math.Sqrt(number) % 1 == 0);
            Console.WriteLine($"Has perfect square number: {hasPerfectSquare}");
        }
    }
}
