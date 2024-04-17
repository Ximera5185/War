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
        private static Random s_random = new Random();// TODO сделать отдельный класс утилита для получения значения рандома

        private List<Soldier> _units = new List<Soldier>();

        public SoldierCreator() 
        {
            AddUnitsList();
        }
      
        public Soldier GetRandomUnit() 
        {
            int index = s_random.Next(_units.Count);

            Soldier soldier = new Soldier(_units [index].Health, _units [index].Damage, _units [index].Armor,_units [index].Name );

            return soldier;
        }

        private void AddUnitsList() 
        {
            _units.Add(new Gunman());
            _units.Add(new ArmoredSoldier());
            _units.Add(new SpecialForcesSoldiers());
            _units.Add(new Grenadier());
        }

        // массив типов солдат и из него брать солдата в platoon
        // Метод Create будет возвращать их в platoon
        // метод кланирования
    }
}