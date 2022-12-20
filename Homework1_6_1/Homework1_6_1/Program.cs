using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Аркадий", 1000, 10, 50, 0);
            player1.ShowStats();
        }
    }

    class Player
    {
        private string _name;
        private int _health;
        private int _armor;
        private int _damage;
        private int _mana;

        public Player(string name, int health, int armor, int damage, int mana)
        {
            _name = name;
            _health = health;
            _armor = armor;
            _damage = damage;
            _mana = mana;
        }

        public void ShowStats()
        {
            Console.WriteLine("Игрок " + _name + ":");
            Console.WriteLine();
            Console.WriteLine("Здоровье: " + _health + "\nБроня: " + _armor + "\nУрон: " + _damage + "\nМана: " + _mana);
        }
    }
}

