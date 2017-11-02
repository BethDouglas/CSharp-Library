using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle newTriangle1 = new Triangle(4, 3);
            Triangle newTriangle2 = new Triangle(10, 2);
            Triangle newTriangle3 = new Triangle(20, 5);
            Triangle newTriangle4 = new Triangle(2, 3);
            Triangle newTriangle5 = new Triangle(8, 2);
            Console.WriteLine($"AREA = {newTriangle1.Area()}");

            Console.ReadLine();


        }


    }
}
