using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    //Task 5: Interface Implementation with Inheritance
    //Create another class Mage that also inherits from Character and implements the ISkill interface.
    //Mage should have its own properties like Mana and a different implementation of UseSkill() - perhaps a spell that heals the character or increases their attack but also at the cost of AvailablePoints.

    internal class Mage : Character, ISkill
    {

        private int Mana { get; set; } = 0;
        public Mage():base() 
        {
            Mana = 10;
        }
        public Mage(string name, int health, int strength, int availablePoints, int mana)
            :base (name, health, strength, availablePoints)
        {
                Mana = mana;
        }
        public override void Attack(Character oponent)
        {
            throw new NotImplementedException();
        }

        // heal the character
        public void UseSkill(double strength)
        {
            if (Health > 10)
            {
                Console.WriteLine("You can't use this skill until your healt is above 10! use it when you really need it!\n");
                return;
            }
            if (AvailablePoints < 50)
            {
                Console.WriteLine("Not enough points. Your Character can't be healed by this method\n");
                return;
            }
            Health = 100;
            AvailablePoints -= 50;
        }
    }
}
