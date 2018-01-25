using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_ObjectsChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bronze
            NetflixShow show1 = new NetflixShow();
            NetflixShow show2 = new NetflixShow();
            NetflixShow show3 = new NetflixShow();

            show1.Name = "Luther";
            show1.Genre = "Drama";
            show1.Rating = 4;

            show2.Name = "Kimmy Schmit";
            show2.Genre = "Comedy";
            show2.Rating = 5;

            show3.Name = "Some Bad Show";
            show3.Genre = "Boring Stuff";
            show3.Rating = 1;

            Console.WriteLine(show1);
            Console.ReadLine();            
        }
    }
}
