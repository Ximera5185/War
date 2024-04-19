using System.Collections.Generic;

namespace War
{
    internal class Grenadier : Soldier
    {
        public Grenadier(int health, int damage, int armor, string name) : base(health, damage, armor, name) 
        {
        }

        public Grenadier() : base(100, 20, 100, "Гренадер")
        {
        }

        public override void Attack(List<Soldier> enemies)
        {
            int quantityUnitsAttacked = 3;

            for (int i = 0; i < quantityUnitsAttacked; i++)
            {
                int index = UserUtils.GetRandomNumber(enemies.Count);

                enemies [index].TakeDmage(Damage);
            }
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
        }
    }
}