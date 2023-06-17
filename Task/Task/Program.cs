using System;
using System.Collections.Generic;
using System.Data;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Task1Test();

            //Task 2
            Task2Test();

            //Task3
            Task3Test();

        }


        public static void Task1Test()
        {
            Pair<int, string> pair = new Pair<int, string>(5, "Dog");

            var oldPairValues = pair.GetValues();

            Console.WriteLine(oldPairValues.first);
            Console.WriteLine(oldPairValues.second);


            Pair<string, bool> pair1 = new Pair<string, bool>(default, default);

            pair1.SetValues("Text", true);
            var newPairValues = pair1.GetValues();

            Console.WriteLine(newPairValues.first);
            Console.WriteLine(newPairValues.second);
        }

        public static void Task2Test()
        {

            int a = 5;
            int b = 10;

            SwapUtility.Swap(ref a, ref b);
            Console.WriteLine($"{nameof(a)}: {a}");
            Console.WriteLine($"{nameof(b)}: {b}");

            string first = "Apple";
            string second = "Banana";

            SwapUtility.Swap(ref first,ref second);
            Console.WriteLine($"{nameof(first)}: {first}");
            Console.WriteLine($"{nameof(second)}: {second}");
        }

        public static void Task3Test()
        {
            SortedCollection<int> sortedIntCollection = new SortedCollection<int>();
            sortedIntCollection.Add(1);
            sortedIntCollection.Add(10);
            sortedIntCollection.Add(-5);
            sortedIntCollection.Add(-8);
            sortedIntCollection.Add(4);
            sortedIntCollection.Add(0);
            sortedIntCollection.Add(7);
            sortedIntCollection.DisplayCollection();

            Console.WriteLine();

            SortedCollection<string> sortedStringCollection = new SortedCollection<string>();
            sortedStringCollection.Add("Apple");
            sortedStringCollection.Add("Watermelon");
            sortedStringCollection.Add("Peach");
            sortedStringCollection.Add("Banana");
            sortedStringCollection.Add("Strawberry");
            sortedStringCollection.Add("Blueberry");
            sortedStringCollection.Add("Pineapple");
            sortedStringCollection.DisplayCollection();

            Console.WriteLine();

            SortedCollection<Cartrige> sortedCartrigeCollection = new SortedCollection<Cartrige>();
            sortedCartrigeCollection.Add(new Cartrige("6mm BR", 0.243));
            sortedCartrigeCollection.Add(new Cartrige(".220 Swift", 0.224));
            sortedCartrigeCollection.Add(new Cartrige(".26 Nosler", 0.264));
            sortedCartrigeCollection.Add(new Cartrige("6.8 Remington SPC", 0.277));
            sortedCartrigeCollection.Add(new Cartrige(".204 Ruger", 0.204));
            sortedCartrigeCollection.Add(new Cartrige(".416 Remington Magnum", 0.416));
            sortedCartrigeCollection.Add(new Cartrige(".17 HMR", 0.172));
            sortedCartrigeCollection.Add(new Cartrige(".50 BMG", 0.51));
            sortedCartrigeCollection.DisplayCollection();
        }

    }
    //Task 1
    //Generic Classes:
    //Create a generic class named Pair<T, U>.This class should represent a pair of two different types.
    //It should have two properties - First and Second - to hold the pair of items.

    //Include methods in the class:

    //SetValues(T first, U second): This method should set the values of First and Second.
    //GetValues(): This method should return a tuple of First and Second.
    //Test the Pair<T, U> class using different pair of data types(like integer and string, float and string etc.)
    //and demonstrate its functionality.


    //Task 2
    //Generic Methods:
    //Define a generic method Swap<T> within a non-generic class SwapUtility.
    //This method should take two references(ref parameters) to variables of a generic type and swap their values.
    //Create a test program which demonstrates swapping values of different types (like integer, string, etc.).

    //Task 3
    //Constraints in Generics:
    //Create a generic class SortedCollection<T> that maintains a sorted collection of items.
    //Use the constraint on T such that T implements IComparable<T>.
    //This is needed so that the items can be sorted.

    //The class should have the following methods:
    //AddItem(T item) : This method should add a new item to the collection and then ensure the collection remains sorted.
    //GetItem(int index): This method should return the item at the given index.
    //Test the SortedCollection<T> class with a simple custom class that implements IComparable<T>,
    //and show how the items are always sorted when added to the collection.

    //Task 4 do as much practice as you can with generics
    //I think you liked the previous assignment. try to appy generics to the previous RPG game ;)
}