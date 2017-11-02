using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Overrides
{
    class Program
    {
        static void Main(string[] args)
        {
            Square newSquare = new Square(4);
            Circle newCircle = new Circle(5);
            Triangle newTriangle = new Triangle(3);
            Rectangle newRectangle = new Rectangle(rectLength: 2, rectWidth: 5);

            Console.WriteLine($"Square Area = {newSquare.Area()}");
            Console.WriteLine($"Circle Area = {newCircle.Area()}");
            Console.WriteLine($"Triangle Area = {newTriangle.Area()}");
            Console.WriteLine($"Rectangle Area = {newRectangle.Area()}");

            Console.WriteLine($"Square Perimeter = {newSquare.Perimeter()}");
            Console.WriteLine($"Circle Perimeter = {newCircle.Perimeter()}");
            Console.WriteLine($"Rectangle Perimeter = {newRectangle.Perimeter()}");
            Console.WriteLine($"Triangle Perimeter = {newTriangle.Perimeter()}");

            Console.ReadLine();  
        }
    }
}
