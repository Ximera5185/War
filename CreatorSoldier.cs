using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    internal class CreatorSoldier
    {
        public Soldier CreateMod(int health, int damage, int armor, bool isDamageMultiplier, bool isMultipleUnitAttack, bool isRepeatAttack)
        {
            return new Soldier( health,  damage,  armor,  isDamageMultiplier,  isMultipleUnitAttack,  isRepeatAttack);
        }
    }
}
