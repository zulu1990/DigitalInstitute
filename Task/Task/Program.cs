using System.Buffers.Text;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection.Metadata;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }


    public abstract class Character : IDisposable
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int AvailablePoints { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public int Shield { get; set; }
        public double CriticalStrikeChance { get; set; }
        public double AttackMissChance { get; set; }

        protected Character()
        {
            Name = "Default";
            Health = 100;
            Strength = 10;
            AvailablePoints = 10;
            EquippedWeapon = null;
            Shield = 0;
            CriticalStrikeChance = 0;
            AttackMissChance = 0;
        }

        protected Character(string name, int health, int strength, int availablePoints, int shield, double criticalStrikeChance, double attackMissChance)
        {
            Name = name;
            Health = health;
            Strength = strength;
            AvailablePoints = availablePoints;
            EquippedWeapon = null;
            Shield = shield;
            CriticalStrikeChance = criticalStrikeChance;
            AttackMissChance = attackMissChance;
        }

        public abstract void Attack(Character target);

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing && EquippedWeapon != null)
            {
                EquippedWeapon.Dispose();
            }
        }
    }

    public class Warrior : Character, ISkill
    {
        public int Armor { get; set; }

        public Warrior() : base()
        {
            Armor = 0;
        }

        public Warrior(string name, int health, int strength, int availablePoints, int shield, double criticalStrikeChance, double attackMissChance, int armor)
            : base(name, health, strength, availablePoints, shield, criticalStrikeChance, attackMissChance)
        {
            Armor = armor;
        }

        public override void Attack(Character target)
        {
            if (Health <= 0)
            {
                Console.WriteLine($"{Name} can't attack because their health is at 0.");
                return;
            }

            if (RandomGenerator.GetRandomDouble() <= AttackMissChance)
            {
                Console.WriteLine($"{Name} missed the attack on {target.Name}.");
                return;
            }

            int baseDamage = Strength;
            int bonusDamage = Armor > 50 ? 10 : 0;
            int totalDamage = baseDamage + bonusDamage;

            if (RandomGenerator.GetRandomDouble() <= CriticalStrikeChance)
            {
                totalDamage *= 2;
                Console.WriteLine($"Critical strike! {Name} dealt double damage.");
            }

            totalDamage -= target.Shield;
            totalDamage = Math.Max(0, totalDamage);

            target.Health -= totalDamage;

            Console.WriteLine($"{Name} attacked {target.Name} for {totalDamage} damage.");
        }

        public void UseSkill()
        {
            if (Health <= 0)
            {
                Console.WriteLine($"{Name} can't use a skill because their health is at 0.");
                return;
            }

            if (AvailablePoints < 5)
            {
                Console.WriteLine($"{Name} doesn't have enough available points to use a skill.");
                return;
            }

            Armor += 20;
            AvailablePoints -= 5;

            Console.WriteLine($"{Name} used a skill to increase Armor by 20. Current Armor: {Armor}");
        }
    }

    public class Mage : Character, ISkill
    {
        public int Mana { get; set; }

        public Mage() : base()
        {
            Mana = 100;
        }

        public Mage(string name, int health, int strength, int availablePoints, int shield, double criticalStrikeChance, double attackMissChance, int mana)
            : base(name, health, strength, availablePoints, shield, criticalStrikeChance, attackMissChance)
        {
            Mana = mana;
        }

        public override void Attack(Character target)
        {
            if (Health <= 0)
            {
                Console.WriteLine($"{Name} can't attack because their health is at 0.");
                return;
            }

            if (RandomGenerator.GetRandomDouble() <= AttackMissChance)
            {
                Console.WriteLine($"{Name} missed the attack on {target.Name}.");
                return;
            }

            int baseDamage = Strength;

            if (RandomGenerator.GetRandomDouble() <= CriticalStrikeChance)
            {
                baseDamage *= 2;
                Console.WriteLine($"Critical strike! {Name} dealt double damage.");
            }

            baseDamage -= target.Shield;
            baseDamage = Math.Max(0, baseDamage);

            target.Health -= baseDamage;

            Console.WriteLine($"{Name} attacked {target.Name} for {baseDamage} damage.");
        }

        public void UseSkill()
        {
            if (Health <= 0)
            {
                Console.WriteLine($"{Name} can't use a skill because their health is at 0.");
                return;
            }

            if (AvailablePoints < 5 || Mana < 20)
            {
                Console.WriteLine($"{Name} doesn't have enough available points or mana to use a skill.");
                return;
            }

            Mana -= 20;
            AvailablePoints -= 5;
            Strength += 10;

            Console.WriteLine($"{Name} used a skill to increase Strength by 10. Current Strength: {Strength}");
        }
    }

    public interface ISkill
    {
        void UseSkill();
    }

    public class Weapon : IDisposable
    {
        public string Name { get; set; }

        public Weapon(string name)
        {
            Name = name;
        }

        public void Dispose()
        {
            Console.WriteLine($"Weapon {Name} has been disposed.");
        }
    }

    public static class RandomGenerator
    {
        private static Random random = new Random();

        public static double GetRandomDouble()
        {
            return random.NextDouble();
        }
    }
}