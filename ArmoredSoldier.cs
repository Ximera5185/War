using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    internal class ArmoredSoldier : Soldier
    {
        private int _isDamageMultiplier = 2;

        public ArmoredSoldier(int health, int damage, int armor) : base(health, damage, armor)
        {
            
        }

        public override void Attack()
        {
            int currentDamage = Damage * _isDamageMultiplier;

            base.Attack();
        }
    }
}
