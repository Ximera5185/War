using System.Collections.Generic;

namespace War
{
    internal class ArmoredSoldier : Soldier
    {
        private int _damageMultiplier = 2;

        public ArmoredSoldier(int health, int damage, int armor, string name) : base(health, damage, armor,name)
        {
        }

        public ArmoredSoldier() : base(100, 20, 100, "Бронированный")
        {
        }

        public override void Attack(List<Soldier> enemies)
        {
            int defaultDamage = Damage;

            Damage *= _damageMultiplier;

            enemies [UserUtils.GetRandomNumber(enemies.Count)].TakeDmage(Damage);

            Damage = defaultDamage;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
        }
    }
}