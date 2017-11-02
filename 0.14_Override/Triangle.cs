using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Override
{
    class Triangle : Shape
    {
        //Constructor
        public Triangle(int side1, int side2, int side3)
        {
            this.Side1 = side1;
            this.Side2 = side2;
            this.Side3 = side3;
        }

        //Constants
        public const int NUM_SIDES = 3;

        //Properties
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }

        //Methods
        public override double Area()
        {
            return ((side1.Length + side2.Length + side2.Length)/2)
                Math.Pow(CircleRadius, 2) * Math.PI;
        }
    }
}
