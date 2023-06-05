using System.Drawing;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
    // 1) Creating a Base Class and Derived Classes
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Color Color { get; set; }

        public virtual void Move()
        {
            Console.WriteLine("The animal moves.");
        }
    }
    public class Bird : Animal
    {
        public Bird(string name, int age, Color color)
        {
            Name = name;
            Age = age;
            Color = color;
        }

        public override void Move()
        {
            Console.WriteLine("The bird flies.");
        }
    }
    public class Cat : Animal
    {
        public Cat(string name, int age, Color color)
        {
            Name = name;
            Age = age;
            Color = color;
        }
        public override void Move()
        {
            Console.WriteLine("The cat runs.");
        }
    }
    public class Fish : Animal
    {
        public Fish(string name, int age, Color color)
        {
            Name = name;
            Age = age;
            Color = color;
        }
        public override void Move()
        {
            Console.WriteLine("The fish swims.");
        }
    }


    //Create an abstract base class called 'Animal' with properties like 'Name', 'Age' and 'Color'.
    //Implement a virtual method 'Move' which just outputs a default moving behavior(e.g., "The animal moves").
    //Now, create three derived classes 'Bird', 'Cat', and 'Fish'.
    //Override the 'Move' method in each derived class to output a specific moving behavior(e.g., "The bird flies", "The cat runs", "The fish swims").

    // 2) Using 'sealed' Keyword
    //Extend the above task.Make the 'Cat' class sealed.
    //Then try to inherit from 'Cat' and create another class 'Lion'.
    //The code should produce a compile-time error because a sealed class can't be inherited.
    public class Lion : Cat
    {
        public Lion(string name, int age, Color color) : base(name, age, color)
        {
        }
        public new void Move() => Console.WriteLine("I am running."); 
    }
    // 3) Using 'base' Keyword

    //Extend the first task even further.
    //In the 'Bird', 'Cat', and 'Fish' classes, besides overriding the 'Move' method,
    //also create another method called 'GetDetails'.
    //This method should output the details of the animal(name, age, and color).
    //In this 'GetDetails' method, use the base keyword to access properties of the base class.

    // 4) Try modeling other stuff with your knowledge (as much as you can!)
    public abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public virtual void Talk() => Console.WriteLine("I am talking.");
    }
    public sealed class Teacher : Person
    {
        public Teacher(string name, string surname, string subject, TeachingAssistant assistantName, List<Student> students)
        {
            Name = name;
            Surname = surname;
            Subject = subject;
            AssistantName = assistantName;
            Students = students;
        }
        public string Subject { get; set; }
        public TeachingAssistant AssistantName { get; set; }
        public List<Student> Students { get; set; }
        public override void Talk() => Console.WriteLine("I am teaching C#.");
        public void AddStudent(Student student) => Students.Add(student);
    }
    public sealed class TeachingAssistant : Person
    {
        public TeachingAssistant(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public void Testing(Student student)
        {
            Random random = new Random();
            Console.WriteLine($"{student.Name} {student.Surname} grade is: {random.Next(70, 100)} ");
        }
        public override void Talk() => Console.WriteLine("I help students.");
    }
    public sealed class Student : Person
    {
        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public override void Talk() => Console.WriteLine("I learned C#.");
    }


}