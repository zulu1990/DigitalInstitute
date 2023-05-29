
namespace Task
{
    public class Mage : Character, ISkill
    {

        private int mana;

        // Mage can use Mana only 3 time
        private int Mana
        {
            get => mana;
            set
            {
                if (value < 0 || value > 3)
                {
                    throw new InvalidDataException("Mana should be between 0-3");
                }
                mana = value;
            }
        }

        // Constructors
        public Mage() : base()
        {
            Mana = 3;
        }
        public Mage(string name) : base(name) { }
        public Mage(string name, double health, double strength, double availablePoints, int mana)
            : base(name, health, strength, availablePoints)
        {
            Mana = mana;
        }

        public override void Attack(Character warrior)
        {
            if (Health == 0)
            {
                Console.WriteLine("your Health is at 0; You can't use skill!");
                return;
            }

            if (warrior == null)
            {
                Console.WriteLine("who are you fighting? This warrior doesn't exist\n");
                return;
            }
            if (this.Strength > 0 && this.Strength < 50)
            {
                warrior.Health -= 10;
                AvailablePoints += 10;
            }
            else if (this.Strength >= 50 && this.Strength < 80)
            {
                warrior.Health -= 20;
                AvailablePoints += 20;
            }
            else
            {
                warrior.Health -= 30;
                AvailablePoints += 30;
            }

            if (warrior.AvailablePoints < 0)
            {
                Console.WriteLine("Mage is winner!\n");
            }
        }

        // skill, that is spell and heals the Character. It can't heal more than 3 times
        public void UseSkill()
        {
            if (Health == 0)
            {
                Console.WriteLine("your Health is at 0; You can't use skill!");
                return;
            }

            if (Mana != 0)
            {
                if (Health < 10)
                {
                    Console.WriteLine("You can't use this skill until your health is more than 10! use it when you really need it!\n");
                    return;
                }
                if (AvailablePoints < 50)
                {
                    Console.WriteLine("Not enough points. Your Character can't ne healed\n");
                    return;
                }
                Health = 100;
                AvailablePoints -= 50;
                Mana -= 1;
            }
        }
        public override string ToString()
        {
            string coloredMana = $"\u001b[32m{Mana}\u001b[0m";
            string coloredInfo = $"\u001b[34m**** Mage info ****\u001b[0m";
            return $"{coloredInfo}\n"+ base.ToString() + $"{nameof(Mana)}: {coloredMana}\n";
        }
    }
}
