using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal A = new Cat("misa",1,"Grey");
            A.GetDetails();

        }
    }
    // 1) Creating a Base Class and Derived Classes

    //Create an abstract base class called 'Animal' with properties like 'Name', 'Age' and 'Color'.
    //Implement a virtual method 'Move' which just outputs a default moving behavior(e.g., "The animal moves").
    //Now, create three derived classes 'Bird', 'Cat', and 'Fish'.
    //Override the 'Move' method in each derived class to output a specific moving behavior(e.g., "The bird flies", "The cat runs", "The fish swims").

    abstract class Animal
    {
        //Base fields
        protected string _name;
        protected int _age;
        protected string _color;

        //get,set
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        //Base Constr
        public Animal(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
        }

        public abstract void Move();
        public virtual void GetDetails()
        {
            Console.WriteLine($"{Name} {Age} {Color}");
        }
    }

    class Bird : Animal
    {
        public Bird(string name, int age, string color) : base(name, age, color) { }

        public override void Move()
        {
            Console.WriteLine("Bird flies");
        }

        
    }

    sealed class Cat : Animal
    {

        public Cat(string name, int age, string color) : base(name, age, color) { }
        public override void Move()
        {
            Console.WriteLine("Cat runs");
        }
               
    }

    class Fish : Animal
    {

        public Fish(string name, int age, string color) : base(name, age, color) { }
        public override void Move()
        {
            Console.WriteLine("Fish swims");
        }

        //test
        public override void GetDetails()
        {
            Console.WriteLine($"{Name} {Age} {Color}");
        }

    }

    /*
    class Lion : Cat
    {
        public override void Move()
        {
            Console.WriteLine("Lion roars");
        }
    }
    */



    // 2) Using 'sealed' Keyword
    //Extend the above task.Make the 'Cat' class sealed.
    //Then try to inherit from 'Cat' and create another class 'Lion'.
    //The code should produce a compile-time error because a sealed class can't be inherited.

    // 3) Using 'base' Keyword

    //Extend the first task even further.
    //In the 'Bird', 'Cat', and 'Fish' classes, besides overriding the 'Move' method,
    //also create another method called 'GetDetails'.ww
    //This method should output the details of the animal(name, age, and color).
    //In this 'GetDetails' method, use the base keyword to access properties of the base class.

    // 4) Try modeling other stuff with your knowledge (as much as you can!)
}