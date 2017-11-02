using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_Interfaces
{
    class ListClass : IEnum, IList, ICollect
    {
        public void AddStuff()
        {
            Console.WriteLine("Add stuff to list");
        }

        public void CheckTheCapacity()
        {
            Console.WriteLine("Check the capacity of the list");
        }

        public void CheckTheCount()
        {
            Console.WriteLine("Check the count of the list");
        }

        public void IterateOverTheCollection()
        {
            Console.WriteLine("Iterate over the list");
        }

        public void RemoveStuff()
        {
            Console.WriteLine("Iterating over the list");
        }
    }
}
