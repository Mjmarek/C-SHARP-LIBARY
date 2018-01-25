using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._15_LINQpractice
{
    class Program
    {//Find the positive numbers from a list of numbers using 2 WHERE LINQ queries
        static void Main(string[] args)
        {
            int[] number = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var query = from n in number
                        where n > 0
                        orderby n ascending
                        select n;

            foreach (int n in query)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
    }
}
