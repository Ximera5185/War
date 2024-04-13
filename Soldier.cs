using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    internal class Soldier
    {
        public Soldier(int health, int damage, int armor, bool isDamageMultiplier, bool isMultipleUnitAttack, bool isRepeatAttack)
        {
            Health = health;

            Damage = damage;

            Armor = armor;

            IsDamageMultiplier = isDamageMultiplier;

            IsMultipleUnitAttack = isMultipleUnitAttack;

            IsRepeatAttack = isRepeatAttack;
        }

        public int Health { get; private set; }
        public int Damage { get; private set; }
        public int Armor { get; private set; }

        public bool IsDamageMultiplier { get; private set; }    // Множитель урона
        public bool IsMultipleUnitAttack { get; private set; }  // Умение атаковать нескольких солдат
        public bool IsRepeatAttack { get; private set; }       // Умение повторить атаку


        public void TakeDmage(Soldier soldier)
        {
            int minValueArmor = 0;

            if (Armor <= minValueArmor)
            {
                Health -= soldier.Damage;
            }
            else
            {
                Armor -= soldier.Damage;
            }
        }

        public void Attack()
        {

        }

        public void ShowInfo()
        {
            Console.WriteLine($" Солдат: Здоровье - {Health} Дамаг - {Damage} Броня - {Armor} Множитель урона - {IsDamageMultiplier} Атака нескольких солдат - {IsMultipleUnitAttack} Умение повторить атаку - {IsRepeatAttack}");
        }
    }
}
