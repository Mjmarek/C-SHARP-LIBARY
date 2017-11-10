using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoard1_Q5
{
    class Program
    {//Given an array of ints, write a method to total all the values that are even numbers
        static void Main(string[] args)
        {
            int[] source = {4, 8, 15, 16, 23, 42};
            Console.WriteLine(EvenSum(source));
            Console.ReadLine();
        }

        static int EvenSum(int[] source)
        {
            var currentSum = 0;

            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] % 2 == 0)
                    currentSum = source[i] + currentSum;
            }

            return currentSum;
         }

        static int EvenTotal(int[] source)
        {
            return source.Where(i => i % 2 == 0).Aggregate((acc, curr) => acc + curr);
            //Aggregate also called Reduce
            //"Where" is SQL filter
        }
    }
}