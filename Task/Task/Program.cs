using System.ComponentModel.DataAnnotations;

namespace Task
{
    internal class Program
    {

        #region Classes

        public enum ColorType
        {
            White,
            Black,
            Red,
            Green,
            Blue,
            Yellow,
        }

        public abstract class Animal
        {
            protected string _name { get; set; }
            protected int _age { get; set; }
            protected ColorType _colorTypeId { get; set; }

            public Animal(string name, int age, ColorType colorTypeId)
            {
                _name = name;
                _age = age;
                _colorTypeId = colorTypeId;
            }

            public abstract void Move();
        }

        public class Bird : Animal
        {
            public Bird(string name, int age, ColorType colorTypeId) : base(name, age, colorTypeId)
            {
            }

            public override void Move()
            {
                Console.WriteLine("The bird flies");
            }

            public void GetDetails()
            {
                Console.WriteLine($"Name: {_name}, Age: {_age}, Color: {Enum.GetName(typeof(ColorType), _colorTypeId)}");
            }
        }

        public class Cat : Animal
        {
            public Cat(string name, int age, ColorType colorTypeId) : base(name, age, colorTypeId)
            {
            }

            public override void Move()
            {
                Console.WriteLine("The cat runs");
            }

            public void GetDetails()
            {
                Console.WriteLine($"Name: {_name}, Age: {_age}, Color: {Enum.GetName(typeof(ColorType), _colorTypeId)}");
            }
        }

        public class Fish : Animal
        {
            public Fish(string name, int age, ColorType colorTypeId) : base(name, age, colorTypeId)
            {
            }

            public override void Move()
            {
                Console.WriteLine("The fish swims");
            }

            public void GetDetails()
            {
                Console.WriteLine($"Name: {_name}, Age: {_age}, Color: {Enum.GetName(typeof(ColorType), _colorTypeId)}");
            }
        }
        class Lion
        {

        }
        #endregion
        // HomeWork 18
        static void Main(string[] args)
        {
            Bird bird = new("Sparrow", 1, ColorType.Red);
            bird.Move();
            bird.GetDetails();
            Console.WriteLine();

            Cat cat = new("Tom", 2, ColorType.Black);
            cat.Move();
            cat.GetDetails();
            Console.WriteLine();

            Fish fish = new("Nemo", 1, ColorType.Blue);
            fish.Move();
            fish.GetDetails();
        }

        // 4 Bonus 
        //public static void Main()
        //{
        //    Game ticTacToe = new TicTacToe();
        //    Game chess = new Chess();
        //    Console.Write("Write how many players will play(1 - 5): ");
        //    Game snakeAndLadder = new SnakeAndLadder(int.Parse(Console.ReadLine()));

        //    PlayGame(ticTacToe);
        //    PlayGame(chess);
        //    PlayGame(snakeAndLadder);
        //}

        //public static void PlayGame(Game game)
        //{
        //    game.Play();
        //    Console.WriteLine();
        //}
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