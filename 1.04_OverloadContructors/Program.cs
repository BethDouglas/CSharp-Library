using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._04_OverloadContructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personOne = new Person("Beth", "Douglas", 18);
            Person personeTwo = new Person("Jane", 20);

            Console.WriteLine(personOne.FirstName + " " + personOne.LastName + " " + personOne.Age);
        }

    }
}
