using System.Collections.Generic;

namespace War
{
    internal class SpecialForcesSoldiers : Soldier
    {
        public SpecialForcesSoldiers(int health, int damage, int armor,string name) : base(health, damage, armor, name)
        {
        }

        public SpecialForcesSoldiers() : base(100, 40, 100, "Спецназ")
        {
        }

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