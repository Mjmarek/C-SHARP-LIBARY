using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        //{
        //    Console.Write("How are you feeling today from 1-5?: ");
        //    string userValue = Console.ReadLine();

        //    string message = "";

        //    if (userValue == "1")
        //        message = "Tomorrow will be a better day.";
        //    else if (userValue == "2")
        //        message = "I'm sorry to hear that.";
        //    else if (userValue == "3")
        //        message = "Not too bad.";
        //    else if (userValue == "4")
        //        message = "That's fantastic!";
        //    else if (userValue == "5")
        //        message = "Super wonderful!";
        //    else
        //        message = "I'm sorry, that didn't make sense. Good bye.";

        //    Console.WriteLine(message);
        //    Console.ReadLine();
        //}

        //Bank Excercise
        {
            int bankAccount = 15000;

            string message = "";

            if (bankAccount > 10000)
                message = "Awesome!";
            else
                message = "Ouch.";

            Console.WriteLine(message);
            Console.ReadLine();
        }
    }   
}
