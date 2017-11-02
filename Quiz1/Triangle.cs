using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz1
{
    class Triangle : Shape
    {

        public Triangle(int triBase, int triHeight)
        {
            this.TBase = triBase;
            this.THeight = triHeight;
        }

        public int TBase { get; set; }
        public int THeight { get; set; }

        public override double Area()
        {
            return .5 * TBase * THeight;
        }        
    }
}
