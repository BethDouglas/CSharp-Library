using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what's your name?");
            string inputName = Console.ReadLine();

            switch (inputName)
            {
                case "Jay":
                    Console.WriteLine("Hey Jay.");
                    break;
                case "Paul":
                    Console.WriteLine("Paul is pretty cool.");
                    break;
                default:
                    Console.WriteLine("I don't know you");
                    break;
            }
            Console.ReadLine();
        }
    }
}
