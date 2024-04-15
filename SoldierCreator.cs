using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace War
{
    internal class SoldierCreator
    {
        private static Random s_random = new Random();

        private List<Soldier> units = new List<Soldier>();

        public SoldierCreator() 
        {
            AddUnitsList(units);
        }
      

        public Soldier GetUnit() 
        {
            return
        }
        private void AddUnitsList(List<Soldier> soldiers) 
        {
            soldiers.Add(new Gunman(100,10,100));
            soldiers.Add(new ArmoredSoldier(100,10,100));
            soldiers.Add(new SpecialForcesSoldiers(100,10,100));
            soldiers.Add(new MedicSoldier(100,10,100));
        }

        // массив типов солдат и из него брать солдата в platoon
        // Метод Create будет возвращать их в platoon
        // метод кланирования
    }
}
