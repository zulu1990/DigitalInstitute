using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public enum ArmorType { NONE, LIGHT, HEAVY, MAGICAL };
    internal class Warrior : Character, ISkill
    {
        protected ArmorType Armor { get; set; }
        public Warrior() : base()
        {
            Armor = ArmorType.NONE;
        }
        public Warrior(string name, int health, int strength, int availablePoints, ArmorType armor) :
            base(name, health, strength, availablePoints)
        {
            Armor = armor;
        }

        public override void Attack(Character oponent)
        {
            if (this.Strength > 0 && this.Strength < 50)
            {
                oponent.Health -= oponent.Health * 0.1;
                AvailablePoints += 10;
            }
            else if (this.Strength >= 50 && this.Strength < 80)
            {
                oponent.Health -= oponent.Health * 0.2;
                AvailablePoints += 20;
            }
            else
            {
                oponent.Health -= oponent.Health * 0.3;
                AvailablePoints += 30;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"{nameof(Armor)}: {Armor}\n";
        }

        // UseSkill increases the Stregth of Warrior
        // with 1 Point we can increase Strength by 1
        public void UseSkill(double strength)
        {
            if (this.AvailablePoints >= strength) 
            {
                if (Strength+strength > 100)
                {
                    Strength -= strength;
                    throw new ArgumentOutOfRangeException("Strength can't be more than 100\n");
                }
                Strength += strength;
                AvailablePoints -= strength;
            }
            Console.WriteLine($"Not enough Points to increase Strength by {strength}");
        }
    }
}
//Task 2: Inheritance and Method Overriding
//Create a derived class Warrior that inherits from the Character class.
//Add a new property Armor.Override the Attack() method to include a bonus damage when Armor is above a certain value.

