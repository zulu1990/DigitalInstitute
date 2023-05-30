using System.Threading;

namespace Task
{
    public enum ArmorType { NONE, LIGHT, HEAVY, MAGICAL };
    public class Warrior : Character, ISkill
    {
        private ArmorType _armor;
        public ArmorType Armor {
            get => _armor;
            set
            {
                if(!Enum.IsDefined(typeof(ArmorType), value))
                {
                    throw new ArgumentException("Invalid Armor! That armor doesn't exist");
                }
                _armor = value;
            }
        }
        public Warrior() : base()
        {
            Armor = ArmorType.NONE;
        }
        public Warrior(string name, double health, double strength, double availablePoints, ArmorType armor) :
            base(name, health, strength, availablePoints)
        {
            Armor = armor;
        }

        public override void Attack(Character mage)
        {
            if (mage is Warrior)
            {
                Console.WriteLine("Warriors can't Attack to each other!\n");
                return;
            }

            if (Health == 0)
            {
                Console.WriteLine("your Health is at 0; You can't use skill!");
                return;
            }
            if (this.Strength > 0 && this.Strength < 50)
            {
                mage.Health -= 10;
                AvailablePoints += 10;
            }
            else if (this.Strength >= 50 && this.Strength < 80)
            {
                mage.Health -= 20;
                AvailablePoints += 20;
            }
            else
            {
                mage.Health -= 30;
                AvailablePoints += 30;
            }
            if (mage.Health < 0)
            {
                Console.WriteLine("Warrior is winner!\n");
            }
        }

        // UseSkill
        // if Warrior has LIGHT, HEAVY, MAGICAL armor she/he can increase Health
        public void UseSkill()
        {
            if (Health == 0)
            {
                Console.WriteLine($"{Name} Health is at 0; You can't use skill!\n");
                return;
            }
            switch (Armor)
            {
                case ArmorType.LIGHT:
                    Health += Health * 0.2; break;
                case ArmorType.HEAVY:
                    Health += Health * 0.4; break;
                case ArmorType.MAGICAL:
                    Health += Health * 0.5; break;
                default:
                    Console.WriteLine("This skill can't be used\n"); break;
            }
            if (Health > 100)
            {
                throw new ArgumentOutOfRangeException("Health can't be more than 100. You can't use this skill, untill you aren't enough demaged\n");
            }

            AvailablePoints -= 20;
            Console.WriteLine($"{Name} used skill\n");
        }

        public override string ToString()
        {
            string coloredArmor = $"\u001b[32m{Armor}\u001b[0m";
            string coloredInfo = $"\u001b[33m**** Warrior info ****\u001b[0m";
            return $"{coloredInfo}\n" + base.ToString() + $"{nameof(Armor)}: {coloredArmor}\n";
        }
    }
}

