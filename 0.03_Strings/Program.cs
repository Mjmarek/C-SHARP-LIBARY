using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string occupation;

            firstName = "Fred";
            lastName = "Rogers";
            occupation = "Tv personality";

            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            Console.WriteLine("Hello, my name is " + fullName + ". I am a " + occupation +".");

            //String Interpolation
            Console.WriteLine("Hello, my name is {0}. I am a {1}.", fullName, occupation);
            Console.WriteLine($"Hello, my name is {fullName}. I am a {occupation}.");

            //BRONZE
            //Currency
            double cash = 214.78;
            Console.WriteLine("{0:C}", cash);
            //This will round up if there are more numbers after the decimal

            //Percentage
            double exchangeRate = 0.23;
            Console.WriteLine("{0:#0.##%}", exchangeRate);
            Console.WriteLine("{0:P}", exchangeRate);

            //Phone Number
            double phoneNumber = 8002345678;
            string number1 = phoneNumber.ToString("(###) ###-####");
            Console.WriteLine(number1);
            Console.WriteLine("{0:(###) ###-####}", phoneNumber);

            Console.ReadLine();

            //SILVER
            string potentialEmployer;
        }
    }
}
