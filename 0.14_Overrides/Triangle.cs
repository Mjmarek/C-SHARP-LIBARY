using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Overrides
{
    //For Equilateral Triangle
    class Triangle : Shape
    {
        //Constructor
        public Triangle(int length)
        {
            this.SideLength = length;
        }

        //Properties
        public int SideLength { get; set; }

        //Methods
        public override double Area()
        {
            return ((Math.Sqrt(3))/4) * (Math.Pow(SideLength, 2));
        }

        public override double Perimeter()
        {
            return 3 * SideLength;
        }
    }
}
