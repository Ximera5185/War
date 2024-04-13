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
            BasicSoldier basicSoldier = new BasicSoldier(100, 50, 30);

            basicSoldier.ShowInfo();
        }
    }
}
