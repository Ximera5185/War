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

        public SpecialForcesSoldiers() : base(3, 3, 3)
        {
        }

        // Умение атаковать нескольких солдат реализованно в методе атаки
        // Не могут повторятся атакованные солдаты, поэтому мы удоляем их из листа
        public override void Attack(List<Soldier> enemies)
        {
            int quantityUnitsAttacked = 3;

            for (int i = 0; i < quantityUnitsAttacked; i++)
            {
                int index = new Random().Next(enemies.Count); // TODO сделать отдельный класс утилита для получения значения рандома

                enemies [index].TakeDmage(Damage);

                enemies.RemoveAt(index);
            }
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
        }
    }
}
