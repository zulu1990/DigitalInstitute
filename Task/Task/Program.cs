namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        static void Easy()
        {
            // Use only LINQ!!! in som ecases you will have to create some classes on your own!
            // easy
            //Use the Max method to find the highest number in a list of integers.
            //Use the OrderBy method to sort a list of words alphabetically.
            //Use the Count method to find out how many numbers in a list are greater than 50.
            //Use the First method to get the first word in a list of strings that has a length of 3 letters.
            //Use the Any method to check if any number in a list is a perfect square (the square of an integer).
            //Tasks with two LINQ methods:

            List<int> myInts = Enumerable.Range(0, 10).ToList();
            List<string> myStrings = new() { "dato", "ako", "alexandre", "mariami" };

            int task1 = myInts.Max(x => x);

            List<string> task2 =
                (
                from x in myStrings
                orderby x
                select x
                ).ToList();

            int task3 = myInts.Count(x => x > 50);

            string task4 = myStrings.First(x => x.Length == 3);

            // 5 es ver vaketeb


            static void Medium()
            {
                // medium
                //Use the Where and Sum methods to add up all the numbers in a list that are greater than 10.
                //Use the Select and Average methods to find the average length of words in a list of strings.
                //Use the OrderByDescending and First methods to find the longest word in a list of strings.
                //Use the Where and Count methods to find out how many words in a list have more than 5 letters.
                //Use the Skip and Take methods to get the second half of a list (assume the list length is an even number).
                //Tasks with three LINQ methods:

                List<int> myInts = Enumerable.Range(0, 10).ToList();
                List<string> myStrings = new() { "dato", "ako", "alexandre", "mariami" };

                int task1 = myInts.Where(x => x > 50).Sum();

                double task2 = myInts.Select(x => x).Average();

                string task3 = myStrings.OrderBy(x => x).First();

                int task4 = myStrings.Count(x => x.Length > 5);

                // 5 es ver vaketeb

            }

            static void Hard()
            {
                List<int> myInts = Enumerable.Range(0, 10).ToList();
                List<string> myStrings = new() { "dato", "ako", "alexandre", "mariami" };

                double task1 = myInts.Where(x => x % 3 == 0).Average();

                int task2 = myInts.OrderBy(x => x).Skip(1).First();

                int task3 = myInts.Where(x => x > 20).Count();

                int task5 = myInts.Where(x => x < 100).Max();

            }

            static void CrazyAsian()
            {
                // crazy asian :D (without hints!) ]:)
                //Use LINQ to find the smallest number that is greater than 50 and its square root is a whole number.
                //Use LINQ to find the most frequent word in a list of strings.
                //Use LINQ to count the total number of letters in the words of a sentence that start with 'A'.
                //Use LINQ to sort the numbers in an array after the first number less than 5 and until the next number less than 5, and return the result as an array.
                //Use LINQ to find the most common length of words in an array of strings.

                List<int> myInts = Enumerable.Range(0, 100).ToList();
                List<string> myStrings = new() { "dato", "ako", "alexandre", "mariami" };

                int task1 = myInts.Where(x => x > 50).Min(); // memgoni egaa meore windadeba ver mivxvdi

                int task3 = myStrings.Where(x => x.StartsWith('a')).Sum(x => x.Length);

            }
        }
    }
}