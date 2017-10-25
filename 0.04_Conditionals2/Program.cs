using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much is in bank account?");
            string bankAccount = Console.ReadLine();
            int amount = Convert.ToInt32(bankAccount);
            if (amount > 10000)
            {
                Console.WriteLine("Yay!");
            }

            else if (amount <= 10000)
            {
                Console.WriteLine("Sorry");
            }
            else
            {
                Console.WriteLine("Sorry, we don't understand. Come back later.");
            }

        }
    }
}
