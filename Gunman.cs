using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace War
{
    internal class Gunman : Soldier
    {
        public Gunman(int health, int damage, int armor, string name) : base(health, damage, armor,name)
        {
        }

        public Gunman() : base(1,1,1, "Ганмен")
        {
        }

        public override void Attack(Soldier target)
        {
            base.Attack(target);
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
        }
    }
}
