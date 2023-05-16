using System.ComponentModel;

namespace Task16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 10, 20, 30, 40, 40, 50, 10, 10, 10, 70, 88 };
            List<string> words = new List<string> { "lol", "lol", "lala", "XD", "kaka", "iiii", "XD" };

            //test task 1
            int result1 = SumOfNumbersInList(numbers);
            Console.WriteLine(result1);

            //test task 2 (not sure if this is right)
            List<string> result2 = RemoveDuplicates(words);
            for(int i = 0; i < result2.Count; i++)
            {
                Console.WriteLine(result2[i]);
            }

            //test task 3
            int result3 = SumOfMinAndMax(numbers);
            Console.WriteLine(result3);

            //test task 4
            int result4 = MostFrequendElement(numbers);
            Console.WriteLine(result4);

        }

        // Write method that accepts list of numbers and returns sum
        public static int SumOfNumbersInList(List<int> numbers)
        {
            int sum = 0;
            foreach( int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        // Write method that accepts list of strings and returns same list, but without duplicates
        public static List<string> RemoveDuplicates(List<string> words)
        {
            
            for(int i = 0; i < words.Count; i++)
            {
                for(int k = 0; k < words.Count; k++)
                {
                    if (words[i] == words[k] && i != k)
                    {
                        words.RemoveAt(i);
                    }
                }
            }


            return words;
        }

        // Write method that accepts list of numbers and returns sum of minimum and maximum numbers in this lists
        public static int SumOfMinAndMax(List<int> numbers)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            for(int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            numbers.Add(max);
            numbers.Add(min);

            return max + min;
        }

        // Find the most frequent element in list and return it
        public static int MostFrequendElement(List<int> numbers)
        {
            int counter = 0;
            int MAXcounter = 0;
            int index = 0;

            for(int i = 0; i < numbers.Count; i++)
            {
                for(int k = 0; k < numbers.Count; k++)
                {
                    if (numbers[i] == numbers[k])
                    {
                        counter++; 
                    }
                }
                if(counter > MAXcounter)
                {
                    MAXcounter = counter;
                    index = i;
                }
            }
            return numbers[index];
        }

        //Bonus points
        //write function that will accept 3D list and will return sum of all elements
        public static int SumOfAllLists(List<List<List<int>>> list3D)
        {
            throw new NotImplementedException();
        }
    }
}