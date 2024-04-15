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
           

        }

          // Умение атаковать нескольких солдат
       

        public override void Attack(List<Soldier> enemies)
        {
            for (int i = 0; i < 3; i++)
            {
                int index = new Random().Next(enemies.Count);

                enemies [index].TakeDmage();
            }
        }
    }
}
