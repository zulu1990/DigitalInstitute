using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja
{
    public abstract class Character : IDisposable, ISkill
    {
        private bool disposedValue;
        private bool disposedValue1;

        public string Name { get; set; } = "Char";
        public int Health { get; set; } = 1000;
        public int Strength { get; set; } = 100;
        public int AvailablePoints { get; set; } = 0;

        public Character()
        {
            Name = "Char";
            Health = 0;
            Strength = 0;
            AvailablePoints = 0;
        }
        public Character(string name, int health, int strength, int availablePoints) : this()
        {
            Name = name;
            Health = health;
            Strength = strength;
            AvailablePoints = availablePoints;
        }
        public abstract int Attack(ref Warrior warrior);

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue1)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue1 = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~Character()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public int IncreaseArmor(ref int availablePoints)
        {
            if (availablePoints >= 20)
            {
                availablePoints -= 20;
                return 1;
            }
            return 0;
        }

        public int IncreaseStrength(ref int availablePoints)
        {
            if (availablePoints >= 50)
            {
                availablePoints -= 50;
                return 2;
            }
            return 0;
        }
    }
}
