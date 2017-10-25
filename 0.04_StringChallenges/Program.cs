using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_StringChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bronze
            //Currency
            double cash = 563.32;
            Console.WriteLine("{0:C}",cash);

            //Percentage
            double exchangeRate = 0.23;
            Console.WriteLine("{0:#0.##%}", exchangeRate);
            Console.WriteLine("{0:P}", exchangeRate);

            //Phone Number
            int phoneNumber = 1234567890;
            string number1 = phoneNumber.ToString("(###)-###-####");
            Console.WriteLine(number1);
            Console.WriteLine("{0(###) ### - ####}", phoneNumber);
            Console.ReadLine();
        }
    }
}
