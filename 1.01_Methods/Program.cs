using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._01_Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            double doMath(string operation, double numOne, double numTwo)
            {
                switch (operation.ToLower())
                {
                    case "add":
                        return numOne + numTwo;
                    case "subtract":
                        return numOne - numTwo;
                    case "multiply":
                        return numOne * numTwo;
                    case "divide":
                        return numOne / numTwo;
                    case "mod":
                        return numOne % numTwo;
                    default:
                        Console.WriteLine("Operation not availible.");
                        return 0;
                }
            }
            Console.WriteLine(doMath("add", 5D, 6D));

            string FullName(string first, string last)
            {
                return first + " " + last;
            }
            Console.WriteLine(FullName("beth", "douglas"));

            int TwoNums(int numOne, int numTwo)
            {
                return numOne + numTwo;
            }
            Console.WriteLine(TwoNums(20,6));
        }        
    }
}
