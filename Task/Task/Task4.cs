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
        public static void Start()
        {
            FirstGreaterThan50AndSqrtIsWholeNumber();
            FrequentWordInList();
            NumberOfLettersStartingWIthA();
            ComplexThingy();
            CommonLength();
        }

        static void FirstGreaterThan50AndSqrtIsWholeNumber()
        {
            int result = Enumerable.Range(1, 10000)
            .FirstOrDefault(number => number > 50 && Math.Sqrt(number) % 1 == 0);

            Console.WriteLine($"Smallest number greater than 50 with whole number square root: {result}");
        }
        static void FrequentWordInList()
        {
            List<string> words = new(10)
            {
                "word",
                "delegate",
                "delegate",
                "delegate",
                "word",
                "property",
                "field",
                "field",
                "method",
                "property"
            };

            string mostFrequentWord = words.GroupBy(word => word).OrderByDescending(word => word.Count()).Select(x => x.Key).First();
            Console.WriteLine($"The most frequent word in a list of strings is {mostFrequentWord}");
        }
        static void NumberOfLettersStartingWIthA()
        {
            List<string> words = new()
            {
                "apple", "banana", "avocado", "apricot", "pineapple", "grape", "apartment", "kiwi", "almond"
            };
            int numberOfLettersStartingWithA = words.Where(x => x.StartsWith('a')).SelectMany(x => x).Count();
            Console.WriteLine($"Number of letters which words starts with A is : {numberOfLettersStartingWithA}");
        }

        static void ComplexThingy()
        {
            int[] numbers = { 8, 3, 2, 9, 4, 1, 7, 6, 5, 10 };

            var sortedNumbers = numbers
                .SkipWhile(num => num >= 5)
                .TakeWhile(num => num >= 5)
                .OrderBy(num => num)
                .ToArray();

            Console.WriteLine("Sorted numbers after the first number less than 5 until the next number less than 5:");
            foreach (var number in sortedNumbers)
            {
                Console.WriteLine(number);
            }
        }
        static void CommonLength()
        {
            List<string> words = new() { "apple", "banana", "orange", "grape", "kiwi", "pear" };
            int commonLength = words.Select(x => x.Length).GroupBy(x => x).OrderByDescending(x => x.Count()).Select(x => x.Key).First();
            Console.WriteLine($"Common word Length is {commonLength}");
        }
    }
}
