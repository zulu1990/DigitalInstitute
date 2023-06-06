using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja
{
    public class Mage : Character, ISkill
    {
        public int Mana { get; set; }

        public override void Attack(ref Character Character)
        {
            throw new NotImplementedException();
        }
    }
}
