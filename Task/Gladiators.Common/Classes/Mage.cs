using Gladiators.Common.Characters;
using Gladiators.Common.Characters.Enum;
using Gladiators.Common.SkillContracts;
using Gladiators.Common.Skills.Mage;

namespace Gladiators.Common.Classes
{
    public class Mage : Character
    {
        public Mage(string name, int armor, int crit, int dexterity, int intelligence, int strength, int vigor) : base()
        {
            Class = CharacterClassesEnum.Mage;
            SkillCooldown = 2;
            Name = name;
            Armor = armor;
            Crit = crit;
            Dexterity = dexterity;
            Intelligence = intelligence;
            Strength = strength;
            Vigor = vigor;

            Skills = new List<BaseSkill>() {
                new Earthshock(),
                new ShockWave(),
                new IceArrow()
            };

            CalculateStats();
        }

        #region Calculations

        protected override void CalculateDamage()
            => PhysicalDamage = Strength;
        protected override void CalculateMagicalDamage()
            => MagicalDamage = Intelligence + Intelligence / 2 + Intelligence * 2;

        protected override void CalculateHealth()
            => Health = Strength * 100;

        protected override void CalculateHealthRegen()
            => HealthRegen = Vigor;

        protected override void CalculateMana()
            => Mana = Intelligence * 2 * 50;

        protected override void CalculateManaRegen()
            => ManaRegen = Dexterity + 10;

        protected override void CalculateCritRate()
            => CritRate = 5;

        protected override void CalculateCritDamage()
            => CritDamage = PhysicalDamage * 10;

        #endregion

        #region Actions
        public override void Attack(Character target)
        {
            int dmgToTarget = PhysicalDamage;
            if (target is Warrior warriorTarget)
            {
                if (PhysicalDamage <= warriorTarget.Armor * 2)
                {
                    warriorTarget.Armor -= dmgToTarget;
                }
                else
                {
                    if (warriorTarget.Armor > 0)
                    {
                        dmgToTarget = Math.Abs(warriorTarget.Armor * 2 - PhysicalDamage);
                        warriorTarget.Armor -= dmgToTarget / 2;
                        warriorTarget.Health -= dmgToTarget;
                    }
                    else
                    {
                        warriorTarget.Armor = 0;
                        warriorTarget.Health -= dmgToTarget;
                    }

                }

                Console.WriteLine($"Attacker {Name} used normal attack on {target.Name} with {dmgToTarget} targets health is {warriorTarget.Health}");
            }
        }

        public override void UseSkill(BaseSkill skill, Character target)
        {
            if(Mana >= skill?.ManaCost)
            {
                skill.Use(this, target);
                return;
            }
            Attack(target);
            return;
        }

        #endregion
    }
}
