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
            CreatorSoldier creatorSoldier = new CreatorSoldier();

            _soldiers.Add(creatorSoldier.CreateMod(_value, _value, _value, false, false, false));
            _soldiers.Add(creatorSoldier.CreateMod(_value, _value, _value, true, false, false));
            _soldiers.Add(creatorSoldier.CreateMod(_value, _value, _value, false, true, false));
            _soldiers.Add(creatorSoldier.CreateMod(_value, _value, _value, false, true, true));
        }

        public void ShowInfo()
        {
            foreach (Soldier soldier in _soldiers)
            {
                soldier.ShowInfo();
            }
        }

        private void AddSoldier(List<Soldier> soldiers)
        {

        }
    }
}
