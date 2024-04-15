using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    internal class SpecialForcesSoldiers : Soldier
    {
        public SpecialForcesSoldiers(int health, int damage, int armor) : base(health, damage, armor)
        {
            IsMultipleUnitAttack = true;
        }

        private protected bool IsMultipleUnitAttack { get; private set; } // Умение атаковать нескольких солдат
    }
}
