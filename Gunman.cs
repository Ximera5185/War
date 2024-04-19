using System.Collections.Generic;

namespace War
{
    internal class Gunman : Soldier
    {
        public Gunman(int health, int damage, int armor, string name) : base(health, damage, armor,name)
        {
        }

        public Gunman() : base(100,20,100, "Ганмен")
        {
        }

        public override void Attack(List<Soldier> enemies)
        {
            enemies [UserUtils.GetRandomNumber(enemies.Count)].TakeDmage(Damage);
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
        }
    }
}