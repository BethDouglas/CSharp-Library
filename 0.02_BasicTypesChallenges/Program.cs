using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_BasicTypesChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bronze
            string name;
            double pi;
            string firstName = "Douglas";
            double ratio = 1.54;

            Console.WriteLine(firstName);
            Console.WriteLine(ratio);

            //Silver
            Console.WriteLine($"Hello, {firstName} {ratio}");

            //Gold    
            string myCentury = "19";
            int century = Convert.ToInt32(myCentury);

            Console.WriteLine($"I was born in {myCentury}XX.");
            Console.ReadLine();
        }
    }
}
