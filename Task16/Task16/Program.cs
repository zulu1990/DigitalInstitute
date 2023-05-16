namespace Task16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test the SumOfNumbersInList method
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            int sum = SumOfNumbersInList(numbers);
            Console.WriteLine("Sum of numbers: " + sum);

            // Test the RemoveDuplicates method
            List<string> words = new List<string> { "apple", "banana", "apple", "orange", "banana" };
            List<string> uniqueWords = RemoveDuplicates(words);
            Console.WriteLine("Unique words:");
            foreach (string word in uniqueWords)
            {
                Console.WriteLine(word);
            }

            // Test the SumOfMinAndMax method
            List<int> numbers2 = new List<int> { 5, 3, 9, 2, 7 };
            int minMaxSum = SumOfMinAndMax(numbers2);
            Console.WriteLine("Sum of min and max: " + minMaxSum);

            // Test the MostFrequendElement method
            List<int> numbers3 = new List<int> { 1, 2, 3, 2, 3, 3, 4, 5 };
            int mostFrequent = MostFrequendElement(numbers3);
            Console.WriteLine("Most frequent element: " + mostFrequent);

            // Test the SumOfAllLists method
            List<List<List<int>>> list3D = new() 
            {
                new List<List<int>>
                {
                    new List<int> { 1, 2, 3 },
                    new List<int> { 4, 5 },
                    new List<int> { 6 }
                },
                new List<List<int>>
                {
                    new List<int> { 7, 8 },
                    new List<int> { 9, 10, 11 }
                }
            };
            int sumOfAll = SumOfAllLists(list3D);
            Console.WriteLine("Sum of all elements in 3D list: " + sumOfAll);

            // Test the generic SumOfAllLists method
            List<object> genericList = new()
            {
                1,
                new List<int> { 2, 3 },
                new List<object>
                {
                    4,
                    new List<int> { 5, 6 }
                }
            };
            int genericSumOnlyList = SumOfAllLists(list3D);
            int genericSum = SumOfAllLists(genericList);
            Console.WriteLine("Sum of all List<int> type elements in generic list: " + genericSum);
            Console.WriteLine("Sum of all elements in generic list: " + genericSumOnlyList);
        }

        // Write method that accepts list of numbers and returns sum
        public static int SumOfNumbersInList(List<int> numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        // Write method that accepts list of strings and returns same list, but without duplicates
        public static List<string> RemoveDuplicates(List<string> words)
        {
            HashSet<string> uniqueWords = new();
            List<string> result = new();

            foreach (string word in words)
            {
                if (uniqueWords.Add(word))
                {
                    result.Add(word);
                }
            }

            return result;
        }

        // Write method that accepts list of numbers and returns sum of minimum and maximum numbers in this lists
        public static int SumOfMinAndMax(List<int> numbers)
        {
            //return numbers.Min() + numbers.Max(); or
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("The list is null or empty.");
            }
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 1; i < numbers.Count; i++)
            {
                int number = numbers[i];

                if (number < min)
                {
                    min = number;
                }

                if (number > max)
                {
                    max = number;
                }
            }

            return min + max;
        }

        // Find the most frequent element in list and return it
        public static int MostFrequendElement(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("The list is null or empty.");
            }

            Dictionary<int, int> frequencyMap = new();
            int mostFrequentElement = numbers[0];
            int maxFrequency = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                int number = numbers[i];

                if (frequencyMap.ContainsKey(number))
                {
                    frequencyMap[number]++;
                }
                else
                {
                    frequencyMap[number] = 1;
                }

                if (frequencyMap[number] > maxFrequency)
                {
                    maxFrequency = frequencyMap[number];
                    mostFrequentElement = number;
                }
            }

            return mostFrequentElement;
        }

        //Bonus points
        //write function that will accept 3D list and will return sum of all elements
        public static int SumOfAllLists(List<List<List<int>>> list3D)
        {
            int sum = 0;

            for (int i = 0; i < list3D.Count; i++)
            {
                for (int j = 0; j < list3D[i].Count; j++)
                {
                    for (int k = 0; k < list3D[i][j].Count; k++)
                    {
                        sum += list3D[i][j][k];
                    }
                }
            }

            return sum;
        }

        public static int SumOfAllLists<T>(List<T> list)
        {
            int sum = 0;
            foreach (var item in list)
            {
                if (item is List<int> subList)
                {
                    sum += subList.Sum();
                }
                else if (item is List<object> nestedList)
                {
                    sum += SumOfAllLists(nestedList);
                }
            }
            return sum;
        }
    }
}