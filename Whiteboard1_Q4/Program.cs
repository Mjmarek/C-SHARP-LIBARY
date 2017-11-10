using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiteboard1_Q4
{//Write a doMath method that takes 3 prameters called operator, numOne, numTwo.
 //The method should then return correct calculations based upon the arguments.
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(DoMath("mom", 2, 2));
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.ReadLine();
            }    
        }

        static double DoMath(string @operator, double numOne, double numTwo)
        {
            if (@operator == "add")
                return (numOne + numTwo);
            else if (@operator == "subtract")
                return (numOne - numTwo);
            else if (@operator == "multiply")
                return (numOne * numTwo);
            else if (@operator == "divide")
                return (numOne / numTwo);
            else if (@operator == "mod")
                return (numOne % numTwo);
            throw new Exception("Operator not available");
        }
    }   
}
