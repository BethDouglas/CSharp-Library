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
            string friend = "Person";

            switch (friend)
            {
                case "Jay":
                    Console.WriteLine("Hey Jay.");
                    break;
                    Console.WriteLine("I don't know you");
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
