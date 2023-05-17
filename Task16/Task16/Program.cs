namespace Task16
{
    internal class Program
    {
        static void Main(string[] args)
        {


        }

        // Write method that accepts list of numbers and returns sum
        public static int SumOfNumbersInList(List<int> numbers)
        {
            int sum = 0;

            if (numbers == null || numbers.Count == 0)
            {
                Console.WriteLine("The List Is Null Or Empty.");
                throw new ArgumentNullException();
            }
            else
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    sum += numbers[i];
                }
            }
            Console.WriteLine("Sum Of Numbers: " + sum);

            return sum;
        }

        // Write method that accepts list of strings and returns same list, but without duplicates
        public static List<string> RemoveDuplicates(List<string> words)
        {
            if (words == null || words.Count == 0)
            {
                throw new ArgumentNullException();
            }

            List<string> dstnct = words.Distinct().ToList();

            return dstnct;
        }

        // Write method that accepts list of numbers and returns sum of minimum and maximum numbers in this lists
        public static int SumOfMinAndMax(List<int> numbers)
        {
            int min = numbers[0];
            int max = numbers[0];


            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentNullException();
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                else if (numbers[i] > max)
                {
                    max = numbers[i];
                }

            }
            return min + max;

        }

        // Find the most frequent element in list and return it
        public static int MostFrequentElement(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentNullException();
            }

            Dictionary<int, int> frequencyDict = new Dictionary<int, int>();

            foreach (int num in numbers)
            {
                if (frequencyDict.ContainsKey(num))
                {
                    frequencyDict[num]++;
                }
                else
                {
                    frequencyDict[num] = 1;
                }
            }

            int mostFrequentElement = numbers[0];
            int highestFrequency = 1;

            foreach (int key in frequencyDict.Keys)
            {
                if (frequencyDict[key] > highestFrequency)
                {
                    mostFrequentElement = key;
                    highestFrequency = frequencyDict[key];
                }
            }

            return mostFrequentElement;
        }


        //Bonus points
        //write function that will accept 3D list and will return sum of all elements
        public static int SumOfAllLists(List<List<List<int>>> list3D)
        {
            throw new NotImplementedException();
        }
    }
}