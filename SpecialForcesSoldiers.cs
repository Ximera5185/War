using System.Collections.Generic;

namespace War
{
    internal class SpecialForcesSoldiers : Soldier
    {
        public SpecialForcesSoldiers(int health, int damage, int armor,string name) : base(health, damage, armor, name)
        {
        }

        public SpecialForcesSoldiers() : base(3, 3, 3, "Спецназ")
        {
        }

        // Умение атаковать нескольких солдат реализованно в методе атаки
        // Не могут повторятся атакованные солдаты, поэтому мы удоляем их из листа
        public override void Attack(List<Soldier> enemies)
        {
            int quantityUnitsAttacked = 3;

            for (int i = 0; i < quantityUnitsAttacked; i++)
            {
                int index = UserUtils.GetRandomNumber(enemies.Count);

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