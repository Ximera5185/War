using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    internal class SpecialForcesSoldiers : Soldier
    {
        
        public SpecialForcesSoldiers(int health, int damage, int armor) : base(health, damage, armor)
        {
            
        }

        // Умение атаковать нескольких солдат реализованно в методе атаки

        public override void Attack(List<Soldier> enemies)
        {
            for (int i = 0; i < 3; i++)
            {
                int index = new Random().Next(enemies.Count);

                enemies [index].TakeDmage();

                enemies.RemoveAt(index);
            }
        }
    }
}
