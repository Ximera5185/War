using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    internal class Platoon
    {
        public List<Soldier> _soldiers = new List<Soldier>();
        
        public Platoon()
        {
           /* int numberSoldiers = 4;

            SoldierCreator creatorSoldier = new SoldierCreator();

            for (int i = 0; i < numberSoldiers; i++)
            {
                _soldiers.Add(creatorSoldier.Create());
            }*/
            Name = GetName();

            SoldierCreator soldierCreator = new SoldierCreator();

            _soldiers.Add(soldierCreator.Create(100,30,100,false,false,false));
            _soldiers.Add(soldierCreator.Create(100, 15, 80, true, false, false));
            _soldiers.Add(soldierCreator.Create(100, 25, 90, false, true, false));
            _soldiers.Add(soldierCreator.Create(100, 30, 100, false, true, true));


            
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

        public void Attack(List<Soldier> soldiers) 
        {
            for (int i = 0; i < soldiers.Count; i++)
            {
                soldiers[i].Attack();
            }
        }

        private string GetName() 
        {
            Console.WriteLine("Введите название взвода");

            return Console.ReadLine();
        }
    }
}