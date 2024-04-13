using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    internal class Battlefield
    {
        public Battlefield()
        {

        }

        public void Run()
        {
            Platoon platoon = new Platoon();

            Platoon platoon2 = new Platoon();

            Console.Clear();

            platoon.ShowInfo();

            platoon2.ShowInfo();    
        }

        private void StartBattle(Platoon platoon1,Platoon platoon2) 
        {
            while (platoon1._soldiers.Count > 0 || platoon2._soldiers.Count > 0)
            {
                
            }
        }
    }
}
