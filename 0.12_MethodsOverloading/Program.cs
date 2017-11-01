using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_MethodsOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player me = new Player();
            me.Attack(2500);
            me.Attack(1000, "dusty stick");
            me.Attack(1000, "sword", 3);
           Console.ReadLine();
        }

    }

}
