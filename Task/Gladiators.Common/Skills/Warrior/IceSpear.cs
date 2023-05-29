using Gladiators.Common.Characters;
using Gladiators.Common.SkillContracts.BasedOnClass;

namespace Gladiators.Common.Skills.Warrior
{
    public class IceSpear : IWarriorSkill
    {
        public string Name => "Ice Spear";

        public int ManaCost => 20;
        public bool IsActive { get; set; } = true;

        public void Use(Character attacker)
        {
            IsActive = true;
            Console.WriteLine($"Attacker {attacker.Name} used {Name} old Damage is {attacker.PhysicalDamage} new Damage is {attacker.PhysicalDamage += 10}");
        }

        public void Use(Character attacker, Character target)
        {
            throw new NotImplementedException();
        }
    }
}
