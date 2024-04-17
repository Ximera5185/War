using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    internal class Soldier
    {
        public Soldier(int health, int damage, int armor)
        {
            Health = health;

            Damage = damage;

            Armor = armor;
        }

        public string Name { get; protected set; }

        public int Health { get; protected set; }
        public int Damage { get; protected set; }
        public int Armor { get; protected set; }

        public void TakeDmage(int damage)
        {
            Health -= damage;
        }

        public virtual void Attack(Soldier target)
        {
            target.TakeDmage(Damage);
        }

        public virtual void Attack(List<Soldier> enemies) 
        {
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($" Солдат:{Name} Здоровье - {Health} Дамаг - {Damage} Броня - {Armor} ");
        }
    }
}
