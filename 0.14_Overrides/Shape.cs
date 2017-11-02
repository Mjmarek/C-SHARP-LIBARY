using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Overrides
{
    public abstract class Shape
    {
        //"abstract" means it's not implemented here,
        //but it is required of subclasses/implementors of "Shape" (example: Circle, Square)
        abstract public double Area();
        abstract public double Perimeter();
    }
}
