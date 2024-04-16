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
            Platoon platoon1 = new Platoon("1");
            Platoon platoon2 = new Platoon("2");

            platoon1.ShowInfo();

            Console.WriteLine("+++++++++++++++++++++");

            platoon2.ShowInfo();
        }
    }
}
