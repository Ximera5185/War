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
        public Gunman(int health, int damage, int armor) : base(health, damage, armor)
        {

        }

        public Gunman() : base(100,10,5)
        {
        }

        public override void Attack()
        {
            base.Attack();
        }
    }
}
