using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    internal class Soldier
    {
        public int Health { get; private set; }
        public int Damage { get; private set; }
        public int Armor { get; private set; }

        public bool isDamageMultiplier { get; private set; } // Множитель урона
        public bool isMultipleUnitAttack { get; private set; } // Умение атаковать нескольких солдат
        public bool isAttackedBy { get; private set;} // Атакован
        public Soldier() { }

        public void TakeDmage(int damage) 
        {
            int minValueArmor = 0;

            if (Armor <= minValueArmor)
            {
                Health -= damage;
            }
            else 
            {
                Armor -= damage;
            }
        }

        public void Attack() 
        {
            
        }
    }
}
