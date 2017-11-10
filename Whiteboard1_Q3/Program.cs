using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiteboard1_Q3
{//Create a Person class with 3 properties: Firstname, LastName, and Age.
 //Person should have 2 constructors: 1 that requires all properties to be set,
 //and an overloaded constructor that only requires a firstName and age.
 //Instantiate 2 Person objects from the Person class.
    class Program
    {
        static void Main(string[] args)
        {
            Person man = new Person("John", "Smith", 35);
            Person woman = new Person("Jane", 30);

            Console.WriteLine($"This is {man.FirstName} {man.LastName}, age {man.Age}.");
            Console.WriteLine($"This is {woman.FirstName}, age {woman.Age}.");
            Console.ReadLine();            
        }        
    }
}
