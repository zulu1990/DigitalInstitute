namespace Task16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1) Write method that accepts list of numbers and returns sum
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            int sum = SumOfNumbersInList(numbers);
            Console.WriteLine("The sum of the numbers is: " + sum);

            // 2) Write method that accepts list of strings and returns same list, but without duplicates
            List<string> strings = new List<string> { "banana", "apple", "orange" };
            List<string> uniqueString = RemoveDuplicates(strings);
            Console.WriteLine("strings without duplicate: ");

            foreach (string str in uniqueString)
            {
                Console.WriteLine(str);
            }
            // 3) Write method that accepts list of numbers and returns sum of minimum and maximum numbers in this lists

            List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int minAndMax = SumOfMinAndMax(nums);
            Console.WriteLine("Sum of minimum and maximum elemments: " + minAndMax);

            // 4) // Find the most frequent element in list and return it

            List<int> list = new List<int> { 1, 2, 3, 4, 1, 2, 2, 7 };
            int MFE = MostFrequendElement(list);
            Console.WriteLine("Most frequend element is: " + MFE);

            //5) write function that will accept 3D list and will return sum of all elements
            List<List<List<int>>> threeDList = new List<List<List<int>>>
            {
                new List<List<int>>
                {
                    new List<int> { 1, 2, 3 },
                    new List<int> { 4, 5, 6 },
                    new List<int> { 7, 8, 9 }
                },
                new List<List<int>>
                {
                    new List<int> { 10, 11, 12 },
                    new List<int> { 13, 14, 15 },
                    new List<int> { 16, 17, 18 }
                }
            };

            int sum = SumOfAllLists(threeDList);
            Console.WriteLine("Sum of all elements: " + sum);

        // Write method that accepts list of numbers and returns sum
        public static int SumOfNumbersInList(List<int> numbers)
        {
            int sum = 0;
            foreach(int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        // Write method that accepts list of strings and returns same list, but without duplicates
        public static List<string> RemoveDuplicates(List<string> words)
        {
            List<string> uniqueString = new List<string>();

            foreach (string str in words)
            {
                if (!uniqueString.Contains(str))
                {
                    uniqueString.Add(str);
                }
            }
            return uniqueString;
        }

        // Write method that accepts list of numbers and returns sum of minimum and maximum numbers in this lists
        public static int SumOfMinAndMax(List<int> numbers)
        {
            int min = numbers.Min();
            int max = numbers.Max();

            int sum = min + max;

            return sum;
        }

        // Find the most frequent element in list and return it
        public static int MostFrequendElement(List<int> numbers)
        {
            var groupedNumbers = numbers.GroupBy(n => n);

            int mostFrequent = groupedNumbers
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key)
                .FirstOrDefault();

            return mostFrequent;
        }

        //Bonus points
        //write function that will accept 3D list and will return sum of all elements
        public static int SumOfAllLists(List<List<List<int>>> list3D)
        {
         int sum = 0;

         foreach(List<list<int>> secondDimension in list3D)
                {
                    foreach(List<int> thirdDimersion in secondDimension)
                    {
                        foreach(int element in thirdDimersion)
                        {
                            sum += element;
                        }
                    }
                }
         return sum;
        }
    }
}