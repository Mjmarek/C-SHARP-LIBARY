using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_Interfaces
{
    class ArrayClass : IEnum, ICollect, IList //multiple interfaces can be inherited
    {
        public void AddStuff()
        {
            Console.WriteLine("Added stuff to the array...");
        }

        public void CheckTheCapacity()
        {
            Console.WriteLine("You can't check the capacity of an array...");
        }

        public void CheckTheCount()
        {
            Console.WriteLine("Checking the count of the array...");
        }

        public void IterateOverCollection() //implementation of the interface
        {
            Console.WriteLine("Iterating over the array...");
        }

        public void RemoveStuff()
        {
            Console.WriteLine("Removed stuff from the array...");
        }        
    }
}
