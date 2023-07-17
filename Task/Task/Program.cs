using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace Task
{
    internal class Program
    {

        public static int count = 0;
        static void Main(string[] args)
        {
            // Task 28
            // create a program that checks whether a given range of numbers is prime or not using multithreading.
            // The program should take an input range of numbers, split it into smaller chunks, and process each chunk concurrently using multithreading.
            // To achieve this, you'll use both threads and tasks.

            // works for range 0-1000. uses mutithreading each threads checks range of 200

            
            
            Console.WriteLine("enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            CountPrimes(number);

            Console.WriteLine($"form 0 to {number} there is {count} prime numbers");

        }

        public static void CountPrimes(int range) {
            if (range > 1000)
            {
                Console.WriteLine("Sorry but for know program can only count for range 0-1000");
                return;
            }
            if (range < 200)
            {
                Thread thread1 = new Thread(LessThan200);
                thread1.Start(range);
                thread1.Join();
            }
            else if (range < 400)
            {
                Thread thread1 = new Thread(LessThan200);
                Thread thread2 = new Thread(LessThan400);
                thread1.Start(200);
                thread2.Start(range);
                thread1.Join();
                thread2.Join();
            }
            else if (range < 600)
            {
                Thread thread1 = new Thread(LessThan200);
                Thread thread2 = new Thread(LessThan400);
                Thread thread3 = new Thread(LessThan600);
                thread1.Start(200);
                thread2.Start(400);
                thread3.Start(range);
                thread1.Join();
                thread2.Join();
                thread3.Join();
            }
            else if (range < 800)
            {
                Thread thread1 = new Thread(LessThan200);
                Thread thread2 = new Thread(LessThan400);
                Thread thread3 = new Thread(LessThan600);
                Thread thread4 = new Thread(LessThan800);
                thread1.Start(200);
                thread2.Start(400);
                thread3.Start(600);
                thread4.Start(range);
                thread1.Join();
                thread2.Join();
                thread3.Join();
                thread4.Join();
            }
            else if (range <= 1000)
            {
                Thread thread1 = new Thread(LessThan200);
                Thread thread2 = new Thread(LessThan400);
                Thread thread3 = new Thread(LessThan600);
                Thread thread4 = new Thread(LessThan800);
                Thread thread5 = new Thread(LessThan1000);
                thread1.Start(200);
                thread2.Start(400);
                thread3.Start(600);
                thread4.Start(800);
                thread5.Start(range);
                thread1.Join();
                thread2.Join();
                thread3.Join();
                thread4.Join();
                thread5.Join();
            }


        }

        private static void LessThan1000(object range)
        {
            int endRange = (int)range;
            for (int i = 200; i < endRange; i++)
            {
                if (IsPrime(i)) count++;
            }
        }

        private static void LessThan800(object range)
        {
            int endRange=(int)range;
            for (int i = 600; i < endRange; i++)
            {
                if (IsPrime(i)) count++;
            }
        }

        private static void LessThan600(object range)
        {
            int endRange=(int)range;
            for (int i = 400; i < endRange; i++)
            {
                if (IsPrime(i)) count++;
            }
        }

        private static void LessThan400(object range)
        {
            int endRange=(int)range;
            for(int i = 200; i < endRange; i++)
            {
                if (IsPrime(i)) count++;
            }
        }

        private static void LessThan200(object range)
        {
            int endRange=(int)range;
            for(int i = 0; i < endRange; i++)
            {
                if (IsPrime(i))
                {
                    count++;
                }
            }
        }
        private static bool IsPrime(int num)
        {
            if (num < 2)
            {
                return false;
            }
            for(int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
