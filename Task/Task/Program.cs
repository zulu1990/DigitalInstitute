using System;
using System.Collections.Generic;
using System.Data;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 Test:
            Pair<int, string> pair1 = new Pair<int, string>();
            pair1.SetValues(10, "Hello");
            Tuple<int, string> values1 = pair1.GetValues();
            Console.WriteLine($"First: {values1.Item1}, Second: {values1.Item2}");

            Pair<float, string> pair2 = new Pair<float, string>();
            pair2.SetValues(3.14f, "World");
            Tuple<float, string> values2 = pair2.GetValues();
            Console.WriteLine($"First: {values2.Item1}, Second: {values2.Item2}");

            Pair<string, bool> pair3 = new Pair<string, bool>();
            pair3.SetValues("Beqa Kai Kaci Xar Dzmao", true);
            Tuple<string, bool> values3 = pair3.GetValues();
            Console.WriteLine($"First: {values3.Item1}, Second: {values3.Item2}");


            //Task 2 Test:
            int a = 5;
            int b = 10;
            string st = "Nika";
            string st1 = "Jaghmaidze";

            SwapUtility swapUtility = new SwapUtility();
            swapUtility.Swap(ref a, ref b);
            swapUtility.Swap(ref st, ref st1);

            Console.WriteLine($"a: {a}, b: {b}");
            Console.WriteLine($"str1: {st1}, str2: {st1}");



            //Task 3 Test:
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


    public class Pair<T,U>
    {
        public T First { set; private get; }
        public U Second { set; private get; }


        public void SetValues(T first, U second)
        {
            First = first;
            Second = second;
        }

        public Tuple<T,U> GetValues()
        {
            return new Tuple<T, U>(First, Second);
        }
    }

    //Task 2
    //Generic Methods:
    //Define a generic method Swap<T> within a non-generic class SwapUtility.
    //This method should take two references(ref parameters) to variables of a generic type and swap their values.
    //Create a test program which demonstrates swapping values of different types (like integer, string, etc.).

    public class SwapUtility
    {
        public void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }


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

 

    //es vergavakete :(  OOP meagrad michirs da armevaseba :D


}