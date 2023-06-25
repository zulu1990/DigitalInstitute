namespace Task
{
    internal class Task3
    {
        public static void AverageOfDivisibleByThree(List<int> numbers)
        {
            double average = numbers.Where(number => number % 3 == 0).Select(number => number).Average();
            Console.WriteLine($"Average of numbers divisible by 3: {average}");
        }

        public static void SecondSmallestNumber(List<int> numbers)
        {
            int secondSmallest = numbers.OrderBy(number => number).Reverse().Skip(1).First();
            Console.WriteLine($"Second smallest number: {secondSmallest}");
        }

        public static void CountUniqueNumbersGreaterThan20(List<int> numbers)
        {
            int count = numbers.Where(number => number > 20).GroupBy(number => number).Count();
            Console.WriteLine($"Count of unique numbers greater than 20: {count}");
        }

        public static void MergeNames(List<string> firstNames, List<string> lastNames)
        {
            string[] mergedNames = firstNames.SelectMany(firstName => lastNames, (firstName, lastName) => $"{firstName}_{lastName}").ToArray();
            Console.WriteLine("Merged names:");
            foreach (var name in mergedNames)
            {
                Console.WriteLine(name);
            }
        }

        public static void LargestNumberLessThan100(List<int> numbers)
        {
            int largestNumber = numbers.Where(number => number < 100).OrderByDescending(number => number).First();
            Console.WriteLine($"Largest number less than 100: {largestNumber}");
        }

        // hard
        //Use the Where, Select, and Average methods to find the average value of numbers in a list that are divisible by 3.
        //Use the OrderBy, Reverse, and First methods to find the second smallest number in a list of integers.
        //Use the Where, GroupBy, and Count methods to find out how many unique numbers in a list are greater than 20.
        //Use the Select, Concat, and ToArray methods to merge a list of first names and a list of last names into a single array, with each element being "firstname_lastname".
        //Use the Where, OrderByDescending, and First methods to find the largest number in a list that is less than 100.
        //Tasks with four LINQ methods:
        public static void Start()
        {
            List<int> numbers = new() { 10, 25, 30, 40, 50, 60 };
            List<string> firstNames = new() { "John", "Alice", "Michael" };
            List<string> lastNames = new() { "Doe", "Smith", "Johnson" };

            AverageOfDivisibleByThree(numbers);
            SecondSmallestNumber(numbers);
            CountUniqueNumbersGreaterThan20(numbers);
            MergeNames(firstNames, lastNames);
            LargestNumberLessThan100(numbers);
        }
    }
}
