using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_Interfaces
{
    class ListClass : IEnum, ICollect, IList
    {
        public void AddStuff()
        {
            Console.WriteLine("Added stuff to the list...");
        }

        public void CheckTheCapacity()
        {
            Console.WriteLine("Checking capacity of list...");
        }

        public void CheckTheCount()
        {
            Console.WriteLine("Checking the count of the list...");
        }

        public void IterateOverCollection()
        {
            Console.WriteLine("Iterating over the list...");
        }

        public void RemoveStuff()
        {
            Console.WriteLine("Removed stuff from the list...");
        }
    }
}
