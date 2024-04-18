using System;
using System.Collections.Generic;
using System.Linq;

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

        private void Fill() 
        {
            SoldierCreator soldierCreator = new SoldierCreator();

            int countSoldiers = 7;

            for (int i = 0; i < countSoldiers; i++)
            {
                _soldiers.Add(soldierCreator.GetRandomUnit());
            }
        }

        private string GetName() 
        {
            Console.WriteLine("Введите название взвода");

            return Console.ReadLine();
        }
    }
}