using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    abstract class Animal
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set;}
        public abstract string Species { get; init; }


        public Animal(String name)
        {
            Name = name;
            Age = 0;
            Color = "unknown";
        }

        public Animal(String name, int age) :this(name)
        {
            Age = age;
        }

        public Animal(String name, int age, string color):this(name,age)
        {
            Color = color;
        }

        public virtual void Move()
        {
            Console.WriteLine("The animal moves");
        }

        public abstract void GetDetails();
    }
}
