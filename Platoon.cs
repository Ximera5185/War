using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    internal class Platoon
    {
        private List<Soldier> _soldiers = new List<Soldier>();

        private int _value = 100;

        public Platoon()
        {
            SoldierCreator creatorSoldier = new SoldierCreator();
           

            for (int i = 0; i < 10; i++)
            {
                _soldiers.Add(creatorSoldier.Create());
            }
        }

        public void ShowInfo()
        {
            foreach (Soldier soldier in _soldiers)
            {
                soldier.ShowInfo();
            }
        }
    }
}