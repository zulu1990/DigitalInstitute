using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja
{

    public interface ISkill
    {
        /// <summary>
        /// Increase armore. Cost is 20 points.
        /// </summary>
        /// <param name="availablePoints"></param>
        /// <returns></returns>
        public virtual int IncreaseArmor(ref int availablePoints)
        {
            if (availablePoints >= 20)
            {
                int k = availablePoints / 20;
                availablePoints -= k * 20;
                return k;
            }
            return 0;
        }
        /// <summary>
        /// Increase Strength. Cost is 50 points.
        /// </summary>
        /// <param name="availablePoints"></param>
        /// <returns></returns>
        public virtual int IncreaseStrength(ref int availablePoints) 
        {
            if (availablePoints >= 50)
            {
                int k = availablePoints / 50;
                availablePoints -= k * 50;
                return k;
            }
            return 0;
        }
    }

}
