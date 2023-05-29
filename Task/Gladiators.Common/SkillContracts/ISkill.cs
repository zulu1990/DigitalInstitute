using Gladiators.Common.Characters;

namespace Gladiators.Common.SkillContracts
{
    public interface ISkill
    {
        string Name { get; }
        bool IsActive { get; protected set; }
        int ManaCost { get; }
        void Use(Character attacker);
        void Use(Character attacker, Character target);
    }
}
