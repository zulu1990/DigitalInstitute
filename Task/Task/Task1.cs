using Task.FilterExtention;

namespace Task
{
    internal class Task1
    {
        //  Task 1: Filtering Prime Numbers
        //  You have a list of numbers from 1 to 1000.
        //  You need to create a new list that only includes the prime numbers from the original list.
        //  Use a delegate to decide if a number is prime or not.
        //  This will involve checking every number from 2 to the square root of the number you're checking to see if it divides evenly.
        public static void Start()
        {
            List<int> numbers = GetNumbers();

            IEnumerable<int> primeNumbersOne = PrimeFilter(numbers, IsPrime);

            IEnumerable<int> primeNumbersTwo = numbers.PrimeFilterAsExtention(IsPrime);

            PrintSideBySide(primeNumbersOne, primeNumbersTwo);
        }

        private static void PrintSideBySide(IEnumerable<int> list1, IEnumerable<int> list2)
        {
            using var iterator1 = list1.GetEnumerator();
            using var iterator2 = list2.GetEnumerator();

            while (iterator1.MoveNext() && iterator2.MoveNext())
            {
                string formattedNumber1 = iterator1.Current <= 99 ? $" {iterator1.Current}" : iterator1.Current.ToString();
                string formattedNumber2 = iterator2.Current <= 99 ? $" {iterator2.Current}" : iterator2.Current.ToString();

                Console.WriteLine($"{formattedNumber1} - {formattedNumber2}");
            }
        }

        private static List<int> GetNumbers()
            => Enumerable.Range(0, 999).Select(_ => RandomNumber()).ToList();

        private static int RandomNumber()
        {
            var rnd = new Random();
            return rnd.Next(10, 1000);
        }

        private static IEnumerable<int> PrimeFilter(IEnumerable<int> numbers, Func<int, bool> predicate)
        {
            List<int> result = new();

            foreach (var number in numbers)
            {
                if (predicate(number))
                {
                    result.Add(number);
                }
            }
            return result;
        }

        private static bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                    return false;
            }

            return true;
        }
    }
}
