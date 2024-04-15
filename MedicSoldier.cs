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
       // Атакованные солдаты могут повторятся

        public override void Attack(List<Soldier> enemies)
        {
            int quantityUnitsAttacked = 3;

            for (int i = 0; i < quantityUnitsAttacked; i++)
            {
                int index = new Random().Next(enemies.Count);

                enemies [index].TakeDmage();
            }
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
        }
    }
}
