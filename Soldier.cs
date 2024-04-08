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

        public bool IsDamageMultiplier { get; private set; }    // Множитель урона
        public bool IsMultipleUnitAttack { get; private set; }  // Умение атаковать нескольких солдат
        public bool IsAttackedBy { get; private set;}           // Атакован
        public bool IsRepeatAttack {  get; private set; }       // Умение повторить атаку

        public Soldier(int health,int damage,int armor, bool isDamageMultiplier, bool isMultipleUnitAttack, bool isAttackedBy, bool isRepeatAttack)
        {
            Health = health;

            Damage = damage;

            Armor = armor;

            IsDamageMultiplier = isDamageMultiplier;

            IsMultipleUnitAttack = isMultipleUnitAttack;

            IsAttackedBy = isAttackedBy;

            IsRepeatAttack = isRepeatAttack;
        }

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
