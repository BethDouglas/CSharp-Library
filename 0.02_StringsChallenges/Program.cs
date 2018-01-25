using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_StringsChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            string occupation = "TV Personality";
            string firstName = "Beth";
            string lastName = "D";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            Console.WriteLine("Hello my name is " + fullName + ". I am a " + occupation + ".");

            //String Interpolation
            Console.WriteLine("Hello, my name is {0}. I am a {1}.", fullName, occupation);

            Console.WriteLine($"Hello, my name is {fullName}, I am a {occupation}.");

            Console.ReadLine();
        }
    }
}
