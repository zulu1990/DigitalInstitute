using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja
{
    public class Warrior : Character
    {
        public int Level { get; set; } = 1;
        public int Armor { get; set; }
        /// <summary>
        /// Calculate damage coefficient value. 
        /// </summary>
        /// <param name="character"></param>
        public override void Attack(ref Character character)
        {
            Random random = new Random();
            double k = random.Next(0, 10) / 10;
            int attakPoint = Level * (int)(Strength * k);
            character.Health -= attakPoint;
            AvailablePoints += attakPoint;
        }
        /// <summary>
        /// Increase level. cost is 100 points.
        /// </summary>
        public void IncreaseLevel()
        {
            if(AvailablePoints >= 100)
            {
                Level++;
                AvailablePoints -= 100;
            }
        }
    }
}
