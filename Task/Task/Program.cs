using System.Buffers.Text;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection.Metadata;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Welcome to World Of Sharpcraft--");
            Console.WriteLine("Every stats maximum is 100, except availablepoints which is 50");
            Console.WriteLine("With available points you can increase your strength, mana, armor, health");

        }
    }


    abstract class Character
    {
        private string _name;
        private int _health;
        private int _strength;
        private int _availablepoints;


        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                if (value >= 0 && value <= 100){
                    _health = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public int Strength
        {
            get
            {
                return _strength;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _strength = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public int Availablepoints
        {
            get
            {
                return _availablepoints;
            }
            set
            {
                if (value >= 0 && value <= 50)
                {
                    _availablepoints = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }


        public Character(string name, int health, int strength, int availablepoints)
        {
            Name = name;
            Health = health;
            Strength = strength;
            Availablepoints = availablepoints;
        }

        public Character()
        {
            Name = "NOOB";
            Health = 5;
            Strength = 1;
            Availablepoints = 5;
        }

        public virtual void Attack(Character C)
        {

        }

    }

    class Warrior : Character
    {
        private int _armor;

        public int Armor
        {
            get
            {
                return _armor;  
            }
            set
            {
                if(value >= 0 && value <= 100)
                {
                    _armor = value;
                }
            }
        }

        public Warrior(string name, int health, int strength, int availablepoints, int armor) : base(name, health, strength, availablepoints)
        {
            Armor = armor;
        }

        public Warrior() : base() 
        {
            Armor = 1;
        }

        
        public override void Attack(Character C)
        {
            if (Health <= 0)
            {
                Console.WriteLine("Can not attack while health is 0");
            }
            else
            {
                //bonus damage doubled          
                if (Armor >= 20)
                {
                    C.Health = C.Health - Strength * 2;
                    Console.WriteLine($"you did {Strength * 2} damage to {C.Name}");
                }
                //default damage
                else
                {
                    C.Health = C.Health - Strength;
                    Console.WriteLine($"you did {Strength} damage to {C.Name}");
                }
            }
        }
    }

    class Mage : Character
    {
        private int _mana; 

        public int Mana
        {
            get
            {
                return _mana;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _mana = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

            public Mage(string name, int health, int strength, int availablepoints, int mana) : base(name, health, strength, availablepoints)
        {
            _mana = mana;
        }

        public Mage() : base()
        {
            _mana = 5;
        }

        //Mage's ability to attack costs 10 mana
        public override void Attack(Character C)
        {
            if (Health <= 0)
            {
                Console.WriteLine("Can not attack while health is 0");
            }
            else
            {
                if (Mana < 10)
                {
                    Console.WriteLine("Not enough mana");
                }
                else
                {
                    Mana = Mana - 10;
                    C.Health = C.Health - Strength;
                }
            }
        }
        
    }

        
}
