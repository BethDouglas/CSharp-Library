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

            newTriangle1.Area();
            newTriangle2.Area();
            newTriangle3.Area();
            newTriangle4.Area();
            newTriangle5.Area();


            IEnumerable<Triangle> triangles = new List<Triangle>()
            {
            newTriangle1,
            newTriangle2,
            newTriangle3,
            newTriangle4,
            newTriangle5,

        };

            IEnumerable<Triangle> query = from t in triangles
                                             where t.TArea > 4
                                             orderby t.TArea ascending
                                             select t;
            //Loop through
            foreach (Triangle triangle in query)
            {
                Console.WriteLine(triangle.TArea);
            }


        }


    }
}
