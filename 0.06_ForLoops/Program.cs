using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Silver Challenge
            //int i = 0;
            //while (i <= 100)
            //{
            //    Console.WriteLine(i); i += 5;
            //}
            //Console.ReadLine();

            //Fizz Buzz
            for (int i = 1; i < 101; i++)
            {
                if ((i % 15) == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if ((i % 3) == 0)
                {
                    Console.WriteLine("Fizz");
                }

                else if ((i % 5) == 0)
                {
                    Console.WriteLine("Buzz");
                }

                else
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
