using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_Interfaces
{
    class ArrayClass : IEnum, IList, ICollect
    {
        public void IterateOverTheCollection()
        {
            Console.WriteLine("You are iterating over the array");
        }
        public void RemoveStuff()
        {
            Console.WriteLine("You removed stuff from the array.");
        }
        public void AddStuff()
        {
            Console.WriteLine("You added stuff from the array.");
        }
        public void CheckTheCount()
        {
            Console.WriteLine("Checking the count.");
        }
        public void CheckTheCapacity()
        {
            Console.WriteLine("You can't check capacity on an array");
        }
    }
}
