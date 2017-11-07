using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_ConstructorsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            MobilePhone myPhone = new MobilePhone("Samsung", "Galaxy");       

            Console.WriteLine($"I own a {myPhone.Make} {myPhone.Model}.");
            myPhone.PrintPhone();
            Console.ReadLine();

        }
    }
}
