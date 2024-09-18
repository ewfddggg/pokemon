using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static pokemon3.pokemon;

namespace pokemon3
{
    class pokemon
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpecialAttack { get; set; }
        public int SpecialDefense { get; set; }
        public int Speed { get; set; }
        public string Type { get; set; }


        public pokemon(string name, int hp, int attack, int defense, int specialAttack, int specialDefense, int speed, string type)
        {
            Name = name;
            HP = hp;
            Attack = attack;
            Defense = defense;
            SpecialAttack = specialAttack;
            SpecialDefense = specialDefense;
            Speed = speed;
            Type = type;


        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Очки здоровья: {HP}");
            Console.WriteLine($"Атака: {Attack}");
            Console.WriteLine($"Защита: {Defense}");
            Console.WriteLine($"Специальная атака: {SpecialAttack}");
            Console.WriteLine($"Специальная защита: {SpecialDefense}");
            Console.WriteLine($"Скорость: {Speed}");
            Console.WriteLine($"Тип: {Type}");

        }

        public class Tornadus : pokemon
        {
            public Tornadus() : base("Tornadus", 45, 52, 60, 43, 60, 42,"летающий" )
            {
            }
        }

 
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Tornadus tornadus = new Tornadus();


            tornadus.PrintInfo();
            Console.WriteLine();
            Console.WriteLine();
 
        }
    }

    
}
