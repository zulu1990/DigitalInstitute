using System;
using System.Net.NetworkInformation;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird();
            bird.Name = "Sparrow";
            bird.Age = 2;
            bird.Color = "Gray";
            bird.Move();

            Cat cat = new Cat();
            cat.Name = "Tom";
            cat.Age = 5;
            cat.Color = "Black";
            cat.Move();

            Fish fish = new Fish();
            fish.Name = "Nemo";
            fish.Age = 1;
            fish.Color = "Orange";
            fish.Move();

            Lion lion = new Lion();
            lion.Name = "Mirrage";
            lion.Age = 1;
            lion.Color = "Black";
            lion.Move();
        }
        abstract class Animal
        {
            public string Name;
            public int Age;
            public string Color;

            public virtual void Move()
            {
                Console.WriteLine("The animal moves");

            }
        }
        class Bird : Animal
        {
            public override void Move()
            {
                Console.WriteLine("The bird flies. ");
            }
            public void GetDetails()
            {
                Console.WriteLine($"Name{base.Name}, Age{base.Age}, Color{base.Color}");
            }
        }
        sealed class Cat : Animal
        {
            public override void Move()
            {
                Console.WriteLine("The cat runs. ");
            }
            public void GetDetails()
            {
                Console.WriteLine($"Name{base.Name}, Age{base.Age}, Color{base.Color}");
            }
        }
        class Fish : Animal
        {
            public override void Move()
            {
                Console.WriteLine("The fish swims");
            }
            public void GetDetails()
            {
                Console.WriteLine($"Name{base.Name}, Age{base.Age}, Color{base.Color}");
            }
        }
        class Lion : Animal
        {
            public override void Move()
            {
                Console.WriteLine("The Lion roars");
            }
            public void GetDetails()
            {
                Console.WriteLine($"Name{base.Name}, Age{base.Age}, Color{base.Color}");
            }
        }
    }
}


    // 1) Creating a Base Class and Derived Classes

    //Create an abstract base class called 'Animal' with properties like 'Name', 'Age' and 'Color'.
    //Implement a virtual method 'Move' which just outputs a default moving behavior(e.g., "The animal moves").
    //Now, create three derived classes 'Bird', 'Cat', and 'Fish'.
    //Override the 'Move' method in each derived class to output a specific moving behavior(e.g., "The bird flies", "The cat runs", "The fish swims").

    // 2) Using 'sealed' Keyword
    //Extend the above task.Make the 'Cat' class sealed.
    //Then try to inherit from 'Cat' and create another class 'Lion'.
    //The code should produce a compile-time error because a sealed class can't be inherited.

    // 3) Using 'base' Keyword

    //Extend the first task even further.
    //In the 'Bird', 'Cat', and 'Fish' classes, besides overriding the 'Move' method,
    //also create another method called 'GetDetails'.
    //This method should output the details of the animal(name, age, and color).
    //In this 'GetDetails' method, use the base keyword to access properties of the base class.

    // 4) Try modeling other stuff with your knowledge (as much as you can!
}