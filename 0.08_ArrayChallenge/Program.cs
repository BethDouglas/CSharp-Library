using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_ArrayChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bronze
            string[] favoriteFoods = new string[] { "Food 1", "Food 2", "Food 3" };

            for (int i = 0; i < favoriteFoods.Length; i++)
            {
                Console.WriteLine(favoriteFoods[i]);
            }

            //Silver
            //int[] numbers1 = new int[] { 1, 2, 3, 4, 5 };
            //int[] numbers2 = new int[] { 6, 7, 8, 9, 0 };

            //int[] numbers3 = new int[5];
            ////int[] numbers3 = new int[] { numbers1[0] + numbers2[0], numbers1[1] + numbers2[1], numbers1[2] + numbers2[2],
            //                             //numbers1[3] + numbers2[3], numbers1[4] + numbers2[4] };

            //for (int i = 0; i < numbers3.Length; i++)
            //{
            //    numbers3[i] = numbers1[i] + numbers2[i];             
            //}
            //Console.WriteLine(numbers3[i]);


            //Gold
            int[] randomNumbers = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = rnd.Next(100);
            }

            foreach (int number in randomNumbers)
            {
                Console.WriteLine(number);

            }
            Console.ReadLine();
        }
    }
}
