using System.Collections.Generic;

namespace War
{
    internal class SoldierCreator
    {
        private List<Soldier> _units = new List<Soldier>();

        public SoldierCreator() 
        {
            AddUnitsList();
        }
      
        public Soldier GetRandomUnit() 
        {
            int index = UserUtils.GetRandomNumber(_units.Count);

            Soldier soldier = new Soldier(_units [index].Health, _units [index].Damage, _units [index].Armor,_units [index].Name );

            return soldier;
        }

        private void AddUnitsList() 
        {
            _units.Add(new Gunman());
            _units.Add(new ArmoredSoldier());
            _units.Add(new SpecialForcesSoldiers());
            _units.Add(new Grenadier());
        }
    }
}