using System;
using System.Collections.Generic;

namespace War
{
    internal class Platoon
    {
        private List<Soldier> _soldiers = new List<Soldier>();
        
        public Platoon(string name)
        {
            Name = name;

            Fill();
        }

        public string Name { get; private set; }
     
        public int Count => _soldiers.Count;

        public void ShowInfo()
        {
            Console.WriteLine($"Взвод : {Name}");

            foreach (Soldier soldier in _soldiers)
            {
                soldier.ShowInfo();
            }

            Console.WriteLine();
        }

        public void Attack(Platoon enemies) 
        {
            for (int i = 0; i < _soldiers.Count; i++)
            {
                _soldiers [i].Attack(enemies.GetSoldiers());
            } 
        }

        public Soldier GetRandomSoldier() 
        {
            return _soldiers [UserUtils.GetRandomNumber(_soldiers.Count)];
        }

        public List<Soldier> GetSoldiers() 
        {
            return new List<Soldier>(_soldiers);
        }

        public void RemoveDeadSoldier()
        {
            for (int i = _soldiers.Count - 1; i >= 0; i--)
            {
                if (_soldiers[i].Health <= 0)
                {
                    _soldiers.Remove(_soldiers[i]);
                }
            }
        }

        private void Fill() 
        {
            SoldierCreator soldierCreator = new SoldierCreator();

            int countSoldiers = 7;

            for (int i = 0; i < countSoldiers; i++)
            {
                _soldiers.Add(soldierCreator.GetRandomUnit());
            }
        }
    }
}