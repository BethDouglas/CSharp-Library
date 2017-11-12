using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._03_Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5) Given an array of ints, write a method to total all the values that are even numbers.

            // Standard
            int[] numberArray = new int[] {1,2,4,6};
            int sumEvens(int[] numbers)
            {
                int total = 0;
                foreach (int n in numberArray)
                {
                    if (n % 2 == 0)
                    {
                        total += n;
                    }
                }
                return total;
            }
            Console.WriteLine(sumEvens(numberArray));

            // Using LINQ
            int sumEvensLinqOne(int[] numbers)
            {
                var evens = from n in numbers
                            where n % 2 == 0
                            select n;
                return evens.Sum();
            }
            Console.WriteLine(sumEvensLinqOne(numberArray));
            
            // One line
            int sumEvensLinqTwo(int[] numbers)
            {
                return (from n in numbers where n % 2 == 0 select n).Sum();
            }
            Console.WriteLine(sumEvensLinqTwo(numberArray));
        }
    }
}
