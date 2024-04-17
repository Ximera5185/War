namespace War
{
    internal class ArmoredSoldier : Soldier
    {
        private int _damageMultiplier = 2;

        public ArmoredSoldier(int health, int damage, int armor, string name) : base(health, damage, armor,name)
        {
        }

        public ArmoredSoldier() : base(2, 2, 2, "Бронированный")
        {
        }

        public override void Attack(Soldier target)
        {
            int defaultDamage = Damage;

            Damage *= _damageMultiplier;

            base.Attack(target);

            Damage = defaultDamage;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
        }
    }
}