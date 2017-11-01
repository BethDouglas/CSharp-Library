using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Override
{
    class Circle : Shape
    {
        //Constructor
        public Circle(int radius)
        {
            this.CircleRadius = radius;
        }

        //Constants
        //public const int NUM_SIDES = 4;

        //Properties
        public int CircleRadius { get; set; }

        //Methods
        public override double Area()
        {
            return Math.Pow(CircleRadius, 2) * Math.PI;
        }
    }
}
