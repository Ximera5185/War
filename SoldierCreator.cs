using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace War
{
    internal class SoldierCreator
    {
        private static Random s_random = new Random();
        public Soldier CreateMod(int health, int damage, int armor, bool isDamageMultiplier, bool isMultipleUnitAttack, bool isRepeatAttack)
        {
            return new Soldier(health, damage, armor, isDamageMultiplier, isMultipleUnitAttack, isRepeatAttack);
        }

        public Soldier Create()
        {
            int health = 100;
            int damage = 100;
            int armor = 100;

            bool isDamageMultiplier = GetRandomBoolen();
            bool isMultipleUnitAttack = GetRandomBoolen();
            bool isRepeatAttack = GetRandomBoolen();

            return new Soldier(health, damage, armor, isDamageMultiplier, isMultipleUnitAttack, isRepeatAttack);
        }

        private bool GetRandomBoolen()
        {
            bool [] bools = { true, false };

            return bools [s_random.Next(bools.Length)];
        }
    }
}
