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

        public ArmoredSoldier() : base(2, 2, 2)
        {
        }

        public override void Attack(Soldier target)
        {
            int defaultDamage = Damage;

            Damage *= _isDamageMultiplier;

            base.Attack(target);

            Damage = defaultDamage;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
        }
    }
}
