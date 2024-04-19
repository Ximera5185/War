using System;

namespace War
{
    internal class Battlefield
    {
        Platoon platoon1 = new Platoon("Отряд 1");
        Platoon platoon2 = new Platoon("Отряд 2");

        public void Fight() 
        {
            while (platoon1.Count >0 && platoon2.Count >0)
            {
                platoon1.Attack(platoon2);

                platoon2.Attack(platoon1);

                ShowPlattons();

                Console.ReadKey();

                platoon1.RemoveDeadSoldier();

                platoon2.RemoveDeadSoldier();
            }
        }

        public void ShowWinner() 
        {
            string winner = (platoon1.Count > 0) ? platoon1.Name : platoon2.Name;

            Console.WriteLine($"Победил {winner}");
        }

        public void ShowPlattons() 
        {
            platoon1.ShowInfo();

            Console.WriteLine( "+++++++++++++++++++++++++++++" );

            platoon2.ShowInfo();
        }
    }
}