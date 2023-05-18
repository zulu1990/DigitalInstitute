using System.Collections.Generic;

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
            if (numbers.Count == 0) throw new ArgumentException();     
            else return numbers.Sum();
            
        }

        // Write method that accepts list of strings and returns same list, but without duplicates
        public static List<string> RemoveDuplicates(List<string> words)
        {
            if (words.Count == 0) throw new ArgumentException();
            else  return words.Distinct().ToList(); 

        }

        // Write method that accepts list of numbers and returns sum of minimum and maximum numbers in this lists
        public static int SumOfMinAndMax(List<int> numbers)
        {
            if (numbers.Count == 0) throw new ArgumentException();
            else return numbers.Max() + numbers.Min();
        }

        // Find the most frequent element in list and return it
        public static int MostFrequendElement(List<int> numbers)
        {
            if (numbers.Count == 0) throw new ArgumentException();

            else
            {
                int counter1 = 0;
                int counter2 = 0;
                int returnnumber = 0;

                foreach (int i in numbers)                        //bubble sort algorithm
                {                                                         //++
                    foreach (int j in numbers)                    // swap algorithm    
                    {                                                    //==
                        if (j == i)                               // D.Mamardashvili algorithm

                            counter1++;

                        if (counter1 > counter2)
                        {
                            counter2 = counter1;
                            returnnumber = i;
                        }
                    }
                    counter1 = 0;
                }
                return returnnumber;
            }

        }

        //Bonus points
        //write function that will accept 3D list and will return sum of all elements
        public static int SumOfAllLists(List<List<List<int>>> list3D)
        {
            if (list3D.Count == 0) throw new ArgumentException();
            else
            {
                int sum = 0;

                foreach (var number in list3D)
                    foreach (var list in number)                    
                        sum += list.Sum();
                
                return sum;
            }
        }
    }
}