using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    internal class Program
    {
        static void Main(string [] args)
        {
            Soldier soldier_1 = new Soldier(100,10,100,false,false,false,false);
            Soldier soldier_2 = new Soldier(100, 10, 100, true, false, false, false);
            Soldier soldier_3 = new Soldier(100, 10, 100, false, true, false, false);
            Soldier soldier_4 = new Soldier(100, 10, 100, false, true, false, true);

            soldier_1.ShowInfo();
            soldier_2.ShowInfo();
            soldier_3.ShowInfo();
            soldier_4.ShowInfo();
        }
    }
}
