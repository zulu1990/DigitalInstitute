using System.Diagnostics;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1
            Task1();


            //Task2
            Task2();
        }

        private static void Task1()
        {
            Random rand = new Random(10);

            List<int> randomInts = new List<int>();
            for(int i=0; i< 10000; i++) { randomInts.Add(rand.Next());}

            Stopwatch stopwatch = new Stopwatch();

            //1
            stopwatch.Start();
            randomInts.Sort();
            int max1 = randomInts.Last();
            stopwatch.Stop();
            Console.WriteLine("Seconds: "+stopwatch.Elapsed.TotalSeconds);
            Console.WriteLine(max1);

            //2
            stopwatch.Start();
            int max2 = randomInts.Max();
            stopwatch.Stop();
            Console.WriteLine("Seconds: " + stopwatch.Elapsed.TotalSeconds);
            Console.WriteLine(max2);

            //3
            stopwatch.Start();
            int max3 = randomInts.FindMax();
            stopwatch.Stop();
            Console.WriteLine("Seconds: " + stopwatch.Elapsed.TotalSeconds);
            Console.WriteLine(max3);
        }


        private static void Task2()
        {
            Random random = new Random(10);
            
            List<int> list = new List<int>();
            for(int i=0; i < 50_000; i++) { list.Add(random.Next(1,1000));}

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            int mostFrequent = list.FindMostFrequent();
            stopwatch.Stop();
            Console.WriteLine("Seconds: " + stopwatch.Elapsed.TotalSeconds);
            Console.WriteLine(mostFrequent);

        }


        

        // algorithms

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
    }
}
