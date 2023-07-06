using System.Diagnostics;

namespace Task
{
    internal class Program
    {
        // Task 1
        // create random class with seed for example 10 (seeds are important to generate same values) var rand = new Random(10);
        // generate list with 10000 random integer
        // use different algorithm to find Max Value
        //     1) use Sort method and then First to get max value
        //     2) use prebuilt Max Method
        //     3) use your own algorithm -> create function that takes list as parameter and returns maximum value. Do not use any prebuilt functions.
        //     4) use Stopwatch class to get required time for each algorithm


        // Task 2
        // you have list that contains 50_000 integers from 1 to 1000
        // write function that finds number that is repeated most times in list
        // use stopwatch to calculate time took to complete task

        public static void Main()
        {
            // Task 1 
            MaxValue1();
            MaxValue2();
            MaxValue3();
            MaxValue4();

            Console.WriteLine();
            Console.WriteLine();

            // Task 2 
            Task2LINQ();

            Console.WriteLine();
            Console.WriteLine();

            Task2Algoritm(); // it's to slow 


        }
        public static List<int> RandomIntsList()
        {
            List<int> list = new List<int>();
            Random random = new Random();

            for (int i = 0; i < 50_000; i++)
                list.Add(random.Next(0, 1000));

            return list;
        }

        public static void MaxValue1()
        {
            Stopwatch sw = Stopwatch.StartNew();

            List<int> ints = RandomIntsList();
            ints.Sort();

            int MaxValue = ints[^1];
            sw.Stop();

            Console.WriteLine(sw.ElapsedMilliseconds + " millseconds");

        }

        public static void MaxValue2()
        {
            Stopwatch sw = Stopwatch.StartNew();

            List<int> ints = RandomIntsList();
            int MaxValue = int.MinValue;

            foreach (int i in ints)
                if (i > MaxValue)
                    MaxValue = i;

            sw.Stop();

            Console.WriteLine(sw.ElapsedMilliseconds + " millseconds");
        }

        public static void MaxValue3()
        {
            Stopwatch sw = Stopwatch.StartNew();
            List<int> ints = RandomIntsList();

            int MaxValue = ints[0];

            for (int i = 0; i < ints.Count; i++)
                if (ints[i] > MaxValue)
                    MaxValue = ints[i];

            sw.Stop();

            Console.WriteLine(sw.ElapsedMilliseconds + " millseconds");

        }

        public static void MaxValue4()
        {
            Stopwatch sw = Stopwatch.StartNew();

            List<int> ints = RandomIntsList();
            int MaxValue = ints[0];

            foreach (int i in ints)
                MaxValue = Math.Max(MaxValue, i);

            sw.Stop();

            Console.WriteLine(sw.ElapsedMilliseconds + " millseconds");

        }

        public static void Task2LINQ()
        {
            Stopwatch sw = Stopwatch.StartNew();

            List<int> list = RandomIntsList();

            var max = list.GroupBy(id => id).OrderByDescending(id => id.Count()).Select(g => new { mostTimeRepeadedNumber = g.Key, Count = g.Count() }).First();

            Console.WriteLine(max.mostTimeRepeadedNumber);

            sw.Stop();

            Console.WriteLine(sw.ElapsedMilliseconds + " millseconds");

        }

        public static void Task2Algoritm()
        {
            Stopwatch sw = Stopwatch.StartNew();

            List<int> list = RandomIntsList();

            int mostTimeRepeadedNumberCount = 0;
            int mostTimeRepeadedNumber = 0;

            for (int i = 0; i < list.Count; i++)
            {
                int count = 0;


                for (int j = 0; j < list.Count; j++)
                    if (list[j] == list[i])
                        count++;


                if (mostTimeRepeadedNumberCount < count)
                {
                    mostTimeRepeadedNumberCount = count;
                    mostTimeRepeadedNumber = i;
                }
            }

            Console.WriteLine($"{mostTimeRepeadedNumber} is number , {Environment.NewLine}" +
                $"{mostTimeRepeadedNumberCount} is howe much time we have seen this number");

            sw.Stop();

            Console.WriteLine(sw.ElapsedMilliseconds + " millseconds");
        }

    }
}