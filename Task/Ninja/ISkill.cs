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
        abstract int IncreaseArmor(ref int availablePoints);
        
        /// <summary>
        /// Increase Strength. Cost is 50 points.
        /// </summary>
        /// <param name="availablePoints"></param>
        /// <returns></returns>
        abstract int IncreaseStrength(ref int availablePoints);
          
        
    }

}
