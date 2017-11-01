using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_MethodsOverloading
{
    class Player
    {
        public void Attack(int damage)
        {
            Console.WriteLine($"Attacked for {damage}!");
        }

        public void Attack(int damage, string weapon)
        {
            Console.WriteLine($"Attacked for {damage} with {weapon}!");
        }

        public void Attack(int damage, string weapon, int times)
        {
            Console.WriteLine($"Attacked for {damage} with {weapon} for {times} times!");
        }




    }
}
