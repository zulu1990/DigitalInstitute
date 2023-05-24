using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird("jeka", 12, "mwvane");
            bird.Move();
            bird.GetDetails();
        }

        

        abstract class Animal
        {
            protected string _name;
            protected int _age;
            protected string _color;

            public Animal(string name, int age, string color)
            {
                _name = name;
                _age = age;
                _color = color;

            }
            public void GetDetails()
            {
                Console.WriteLine($"{nameof(_name)} : {_name} {Environment.NewLine}" +
                                  $"{nameof(_age)} : {_age} {Environment.NewLine}" +
                                  $"{nameof(_color)} : {_color} ");
            }

            public virtual void Move() => Console.WriteLine("The animal moves");

        }



        class Bird : Animal
        {
            public Bird(string name, int age, string color) : base(name, age, color)
            {

            }

            public override void Move()
            {
                Console.WriteLine("The bird flies");
                base.Move();
            }


        }



        sealed class Cat : Animal
        {
            public Cat(string name, int age, string color) : base(name, age, color)
            {

            }

            public override void Move()
            {
                Console.WriteLine("The cat runs");
                base.Move();
            }


        }


        class Fish : Animal
        {
            public Fish(string name, int age, string color) : base(name, age, color)
            {

            }

            public override void Move()
            {
                Console.WriteLine("The fish swims");
                base.Move();
            }



        }






    }
}