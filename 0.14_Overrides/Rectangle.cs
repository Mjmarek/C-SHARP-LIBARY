using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Overrides
{
    class Rectangle : Shape
    {
        //Constructor
        public Rectangle(int rectWidth, int rectLength)
        {
            this.SideWidth = rectWidth;
            this.SideLength = rectLength;
        }

        //Properties - set to private because square is inheriting from rectangle
        private int SideWidth { get; set; }
        private int SideLength { get; set; }

        //Methods
        public override double Area()
        {
            return ( SideLength * SideWidth);
        }

        public override double Perimeter()
        {
            return (2 * SideLength) + (2 * SideWidth);
        }
    }
}
