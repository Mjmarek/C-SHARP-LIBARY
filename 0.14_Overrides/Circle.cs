using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Overrides
{
    class Circle : Shape
    {
        //Constructor
        public Circle(int radiusLength)
        {
            this.RadiusLength = radiusLength;
        }
                
        //Properties
        public int RadiusLength { get; set; }
        public int DiameterLength { get { return RadiusLength * 2; } }
        public int DiameterLengthTwo => RadiusLength * 2;//lambda is shorthand for get/return
        
        //Methods
        public override double Area()
        {
            return 3.14 * (Math.Pow(RadiusLength, 2));
        }

        public override double Perimeter()
        {
            return Math.PI * DiameterLength;
        }
    }
}
