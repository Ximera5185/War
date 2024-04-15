using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    internal class ArmoredSoldier : Soldier
    {
        public ArmoredSoldier(int health, int damage, int armor) : base(health, damage, armor)
        {
            IsDamageMultiplier = true;
        }

        private protected bool IsDamageMultiplier { get; private set; } // Множитель урона
    }
}
