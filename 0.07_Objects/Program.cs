using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Donut jellyDonut = new Donut();
            Donut plainDonut = new Donut();

            jellyDonut.Filling = "Cherry Jelly";
            jellyDonut.Price = 7.99m;
            jellyDonut.Type = "Jelly";
            jellyDonut.IsSpecial = true;

            plainDonut.Filling = "NA";
            plainDonut.Price = 0.99m;
            plainDonut.Type = "Plain";
            plainDonut.IsSpecial = false;

            Console.WriteLine(jellyDonut);
            Console.WriteLine(jellyDonut.Filling);
            Console.WriteLine(plainDonut);
            Console.WriteLine(plainDonut.Filling);
            Console.ReadLine();
        }
    }
}
