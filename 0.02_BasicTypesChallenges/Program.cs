using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_BasicTypesChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bronze Challenge

            int integer1;
            int integer2 = 14;

            float float1;
            float float2 = 5.67f;

            double double1;
            double double2 = 3.45;

            decimal decimal1;
            decimal decimal2 = 1.23456M;

            string string1;
            string string2 = "Benvolio";

            bool bool1;
            bool bool2 = false;

            Console.WriteLine(integer2);
            Console.WriteLine(string2);

            // Silver Challenge

            string myCats = string2 +" and "+ "Licorice";
            
            Console.WriteLine(myCats);
            
            // Gold Challenge

            string birthYear = "1988";
            int year = Convert.ToInt32(birthYear);

            Console.WriteLine("I was born in " + year);
            Console.ReadLine();
        }
    
    }
}
