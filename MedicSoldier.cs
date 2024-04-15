using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    internal class MedicSoldier : Soldier
    {
        public MedicSoldier(int health, int damage, int armor) : base(health, damage, armor) 
        {
            IsMultipleUnitAttack = true;

            IsRepeatAttack = true;
        }

        private protected bool IsMultipleUnitAttack { get; private set; }  // Умение атаковать нескольких солдат
        private protected bool IsRepeatAttack { get; private set; }       // Умение повторить атаку
    }
}
