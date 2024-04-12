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
            Console.WriteLine($"  _________________________________\n" +
            $" |Солдат: Здоровье -\t\t{Health}|\n" +
            $" |---------------------------------|\n" +
            $" |Дамаг -\t\t\t{Damage} |\n" +
            $" |---------------------------------|\n" +
            $" |Броня -\t\t\t{Armor}|\n" +
            $" |---------------------------------|\n" +
            $" |Множитель урона -\t      {IsDamageMultiplier}|\n" +
            $" |---------------------------------|\n" +
            $" |Атака нескольких солдат -   {IsMultipleUnitAttack}|\n" +
            $" |---------------------------------|\n" +
            $" |---------------------------------|\n" +
            $" |Умение повторить атаку -    {IsRepeatAttack}|\n" +
            $" |_________________________________|");
        }
    }
}
