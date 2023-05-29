using Gladiators.Common.Characters;
using Gladiators.Common.SkillContracts;
using Gladiators.Common.SkillContracts.BasedOnClass;

namespace Gladiators.Common.Skills.Warrior
{
    public class Defence : IWarriorSkill
    {
        public string Name => "Defence";
        public int ManaCost => 10;

        public bool IsActive { get; set; } = true;

        public void Use(Character attacker)
        {
            IsActive = false;
            Console.WriteLine($"Attacker {attacker.Name} used {Name} old armor is {attacker.Armor} new armor is {attacker.Armor *= 2}");
        }

        public void Use(Character attacker, Character target)
        {
            throw new NotImplementedException();
        }
    }
}
