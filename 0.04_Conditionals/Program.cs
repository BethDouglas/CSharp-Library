using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How are you feeling from 1-5?");
            int feelingNumber = Int32.Parse(Console.ReadLine());
            if (feelingNumber <3)
            {
             Console.WriteLine("Sorry.");
            }
            else if (feelingNumber == 3)
            {
            Console.WriteLine("OK.");
            }
            else if (feelingNumber > 3)
            {
            Console.WriteLine("Yay.");
            }
            else
            {
            Console.WriteLine("Sorry, we don't understand");
            }
        }
    }
}
