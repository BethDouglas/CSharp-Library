using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Override
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle newCircle = new Circle(10);
            Square newSquare = new Square(4);
            Triangle new Triangle = new Triangle(4, 3, 9)
            onsole.WriteLine($"AREA = {newSquare.Area()}");
            Console.WriteLine($"AREA = {newCircle.Area()}");
            Console.WriteLine($"AREA = {newTriangle.Area()}");

        }
    }
}
