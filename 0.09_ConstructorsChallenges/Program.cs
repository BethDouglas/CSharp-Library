using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_ConstructorsChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone myPhone = new Phone("iPhone", "7 Plus");
            Phone person2Phone = new Phone("iPhone", "6");
            Phone person3Phone = new Phone("iPhone", "4");
            Phone person4Phone = new Phone("iPhone", "8");
            Phone person5Phone = new Phone("Motorolla", "Razor");

            Console.WriteLine("The phone I own is: " + myPhone.PhoneMake + myPhone.PhoneModel);
            Console.ReadLine();
        }

    }
}
