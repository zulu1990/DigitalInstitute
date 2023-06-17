using System.Collections.Generic;
using System;
using System.Runtime.Intrinsics.X86;
using System.Threading;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    //    Task 1: Use a Delegate to Add Numbers
    //Make a delegate that can represent a method.
    //This method should take in two numbers, add them together, and give back the result.
    //Then, create this method and show how you can use the delegate to "point" to this method and use it.

    //Task 2: Make a Delegate Do Multiple Things
    //Take the delegate from Task 1, and show how you can make it do more than one thing.
    //Make a few more methods that can also add two numbers together.
    //Then, make the delegate use all these methods one after the other.

    //Task 3: Make a Delegate Use a 'Nameless' Function
    //Show how to use a delegate with a function that doesn't have a name.
    //This is called an "anonymous function" or a "lambda".
    //This function should also be able to add two numbers and give back the result.

    //Task 4: Use an Action Delegate
    //Action is a type of delegate that takes in parameters but does not return anything.
    //Create an Action delegate that takes in two integer parameters and prints their sum to the console.
    //Call this Action and verify that it works correctly.

    //Task 5: Use a Func Delegate(More challenging)
    //Func is a type of delegate that takes in parameters and returns a value.
    //Create a Func delegate that takes in two integer parameters and returns their sum.
    //Then, create another Func delegate that takes in three parameters: two integers and the previous Func delegate.
    //This Func should use the delegate to add the two integers and then multiply the result by 2.
    //Call this Func and verify that it works correctly.
}