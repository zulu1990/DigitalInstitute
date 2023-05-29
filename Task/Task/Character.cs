using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal abstract class Character
    {
        // Properties
        public string Name { get; set; }
        public double Health { get; set; }
        public double Strength { get; set; }
        public double AvailablePoints { get; set; }

        // Constructors
        public Character()
        {
            Name = "Default";
            Health = 100;
            Strength = 100;
            AvailablePoints = 0;
        }
        public Character(string name, int health, int strength, int availablePoints)
        {
            Name = name;
            Health = health;
            Strength = strength;
            AvailablePoints = availablePoints;
        }

        public abstract void Attack(Character oponent);

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}\n{nameof(Health)}: {Health}\n" +
                $"{nameof(Strength)}: {Strength}\n {nameof(AvailablePoints)}: {AvailablePoints}\n";
        }
    }
}
//Task 1: Classes and Constructors
//Create a class Character with properties like Name, Health, Strength, and AvailablePoints.
//Implement two constructors - a default constructor that assigns some default values and another constructor which accepts values for the properties.
//The AvailablePoints property is the total points a player can distribute between Health and Strength.

