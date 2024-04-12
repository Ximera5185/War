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
            Platoon platoon = new Platoon();

            Platoon platoon2 = new Platoon();

            platoon.ShowInfo();

            platoon2.ShowInfo();
        }
    }
}
