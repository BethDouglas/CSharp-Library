using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._01_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            


            string MyName(string firstName, string lastName)
            {
                return firstName + " " + lastName;
            }
            Console.WriteLine(MyName("Beth", "Douglas"));

            Console.Write("Hello, ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("World!");
            Console.ResetColor();
        }
    }
    
}
