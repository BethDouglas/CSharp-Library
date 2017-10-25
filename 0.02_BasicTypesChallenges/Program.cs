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
            int myYear = 1999;
            int myCentury = 19;
            string myString = "I was born in";
            string myDecade = "XX";
            bool myBool = false;
            float myFloat = 3.14f;
            double myDouble = 2.54;
            decimal myDecimal = 1.5m;
            string mySentance = myString + " " + myCentury + myDecade;
            string birthYear = "1999";
            int year = Convert.ToInt32(birthYear);
            //Console.WriteLine(myYear);
            //Console.WriteLine(myString);
            //Console.WriteLine(myBool);
            //Console.WriteLine(myFloat);
            //Console.WriteLine(myDouble);
            //Console.WriteLine(myDecimal);
            //Console.WriteLine(myYear + " " + myString + " " + myBool);
            //Console.WriteLine(myString + " " + myYear);
            //Console.WriteLine(myString + " " + myCentury + myDecade);
            //Console.WriteLine(mySentance);
            Console.WriteLine("I was born in " + year);
            Console.ReadLine();


        }
    }
}
