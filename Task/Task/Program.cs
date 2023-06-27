using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Threading;
using System.Xml.Linq;
using System.Xml;
using System;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1.main();
            Task2.main();
        }
    }
    // Use only LINQ!!! in som ecases you will have to create some classes on your own!
    // easy
    //Use the Max method to find the highest number in a list of integers.
    //Use the OrderBy method to sort a list of words alphabetically.
    //Use the Count method to find out how many numbers in a list are greater than 50.
    //Use the First method to get the first word in a list of strings that has a length of 3 letters.
    //Use the Any method to check if any number in a list is a perfect square (the square of an integer).
    //Tasks with two LINQ methods:

    // medium
    //Use the Where and Sum methods to add up all the numbers in a list that are greater than 10.
    //Use the Select and Average methods to find the average length of words in a list of strings.
    //Use the OrderByDescending and First methods to find the longest word in a list of strings.
    //Use the Where and Count methods to find out how many words in a list have more than 5 letters.
    //Use the Skip and Take methods to get the second half of a list (assume the list length is an even number).
    //Tasks with three LINQ methods:

    // hard
    //Use the Where, Select, and Average methods to find the average value of numbers in a list that are divisible by 3.
    //Use the OrderBy, Reverse, and First methods to find the second smallest number in a list of integers.
    //Use the Where, GroupBy, and Count methods to find out how many unique numbers in a list are greater than 20.
    //Use the Select, Concat, and ToArray methods to merge a list of first names and a list of last names into a single array, with each element being "firstname_lastname".
    //Use the Where, OrderByDescending, and First methods to find the largest number in a list that is less than 100.
    //Tasks with four LINQ methods:

    // crazy asian :D (without hints!) ]:)
    //Use LINQ to find the smallest number that is greater than 50 and its square root is a whole number.
    //Use LINQ to find the most frequent word in a list of strings.
    //Use LINQ to count the total number of letters in the words of a sentence that start with 'A'.
    //Use LINQ to sort the numbers in an array after the first number less than 5 and until the next number less than 5, and return the result as an array.
    //Use LINQ to find the most common length of words in an array of strings.
}