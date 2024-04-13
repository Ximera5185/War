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

        public Soldier Create(int health, int damage, int armor, bool isDamageMultiplier, bool isMultipleUnitAttack, bool isRepeatAttack)
        {
            return new Soldier(health, damage, armor, isDamageMultiplier, isMultipleUnitAttack, isRepeatAttack);
        }

       /* public Soldier Create()
        {
            int health = GetRandomValue(100,100);
            int damage = GetRandomValue(10,50);
            int armor = GetRandomValue(50,100);

            bool isDamageMultiplier = GetRandomBoolen();
            bool isMultipleUnitAttack = GetRandomBoolen();
            bool isRepeatAttack = GetRandomBoolen();

            return new Soldier(health, damage, armor, isDamageMultiplier, isMultipleUnitAttack, isRepeatAttack);
        }*/
        // Не нравится мне этот метод так как в задаче указаны конкретные пораметры каждого солдата и конкретное колличество

      /*  private bool GetRandomBoolen()
        {
            bool [] bools = { true, false };

            return bools [s_random.Next(bools.Length)];
        }*/

        /*private int GetRandomValue(int minValue,int maxValue)
        {
            return s_random.Next(minValue,maxValue);
        }*/

        // массив типов солдат и из него брать солдата в platoon
        // Метод Create будет возвращать их в platoon
        // метод кланирования
    }
}
