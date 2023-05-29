using Gladiators.Common.Characters;
using Gladiators.Common.SkillContracts;
using Gladiators.Common.SkillContracts.BasedOnClass;

namespace Gladiators.Common.Skills.Warrior
{
    public class FireSword : IWarriorSkill
    {
        public string Name => "Fire Sword";

        public int ManaCost => 30;

        public bool IsActive { get; set; } = true;

        public void Use(Character attacker)
        {
            IsActive= false;
            Console.WriteLine($"Attacker {attacker.Name} used {Name} old Damage is {attacker.PhysicalDamage} new Damage is {attacker.PhysicalDamage += 20}");
        }

        public void Use(Character attacker, Character target)
        {
            throw new NotImplementedException();
        }

    }
}
