using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_OOP_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Player newHero = new Player();
            Enemy newEnemy = new Enemy();

            Console.WriteLine("Hello, person... \n" + "What's your name?");
            newHero.Name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Nice to meet you, {newHero.Name}.");
            Console.ReadLine();
            Console.WriteLine($"What's your specialization?\n" +
                "1: Horse Mange\n" +
                "2: Troll Cat\n" +
                "3: Knight Templator\n" +
                "4: Person\n" +
                "5: Sire Cena\n");

            Player.Specialization = int.Parse(Console.ReadLine());
            Console.ReadLine();
        }
    }
}
