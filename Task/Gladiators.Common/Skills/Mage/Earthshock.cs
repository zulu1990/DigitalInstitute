using Gladiators.Common.Characters;
using Gladiators.Common.Characters.Enum;
using Gladiators.Common.SkillContracts;
using Gladiators.Common.SkillContracts.BasedOnClass;

namespace Gladiators.Common.Skills.Mage
{
    public class Earthshock : BaseSkill, IMageSkill
    {
        const string name = "Earthshock";
        const int manaCost = 30;
        const int value = 45;
        public Earthshock() : base(name, manaCost, value) { }

        public override void Use(Character attacker, Character target)
        {
            base.UpdateCharacterManaAndSkillStat(attacker);

            Console.WriteLine($"Attacker {attacker.Name} used {Name}");

            int totalDamage = GetTotalDamage(attacker, target);

            Console.WriteLine($"Defender {target.Name}. Old defender health: {target.Health}. New defender health: {target.Health -= totalDamage} \n");
        }

        protected override int GetTotalDamage(Character attacker, Character target)
        {
            return target.Class switch
            {
                CharacterClassesEnum.Warrior => Value + attacker.MagicalDamage,
                CharacterClassesEnum.Mage => Value,
                CharacterClassesEnum.Archer => Value,
                _ => -1,
            };
        }

    }
}
