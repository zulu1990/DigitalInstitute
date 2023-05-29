namespace Gladiators.Common.Contracts
{
    public interface ICharacterActions
    {
        /// <summary>
        /// Physical Attack
        /// </summary>
        long Attack();

        /// <summary>
        /// Magic Attack
        /// </summary>
        long MagicAttack();

        /// <summary>
        /// Skill Attack
        /// </summary>
        long AttackWithSkill();

        /// <summary>
        /// Character Death
        /// </summary>
        long Death();
    }
}
