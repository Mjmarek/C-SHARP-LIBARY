using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_ArraysChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bronze Challenge
            string[] foods = new string[] { "Hot Dog", "PB&J Sandwich", "Tomato Soup" };

            foreach (string i in foods)
            {
                Console.WriteLine(i);
            }

            //Silver Challenge
            int[] number1 = { 3, 4, 4, 5, 5 };//Don't need "new int[]; shorthand for line below"
            int[] number2 = new int[] { 7, 2, 43, 2, 12 };
            int[] number3 = new int[5];

            for (int i = 0; i < number3.Length; i++)
            {
                number3[i] = number1[i] + number2[i];
            }

            foreach (int number in number3)
            {
                Console.WriteLine(number);
            }

            //Gold Challenge
            int[] randomNumbers = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = rnd.Next(100);
            }

            foreach (int number in randomNumbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}
