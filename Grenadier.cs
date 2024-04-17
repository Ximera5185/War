using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    internal class Grenadier : Soldier
    {
        public Grenadier(int health, int damage, int armor, string name) : base(health, damage, armor, name) 
        {
        }

        public Grenadier() : base(4, 4, 4, "Гренадер")
        {
        }

        // Умение атаковать нескольких солдат
        // Атакованные солдаты могут повторятся

        public override void Attack(List<Soldier> enemies)
        {
            int quantityUnitsAttacked = 3;

            for (int i = 0; i < quantityUnitsAttacked; i++)
            {
                int index = new Random().Next(enemies.Count); // TODO сделать отдельный класс утилита для получения значения рандома

                enemies [index].TakeDmage(Damage);
            }
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
        }
    }
}
