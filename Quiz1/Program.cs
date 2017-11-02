using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle newTriangle1 = new Triangle(triBase: 3, triHeight: 5);
            Triangle newTriangle2 = new Triangle(triBase: 1, triHeight: 4);
            Triangle newTriangle3 = new Triangle(triBase: 5, triHeight: 8);
            Triangle newTriangle4 = new Triangle(triBase: 9, triHeight: 6);
            Triangle newTriangle5 = new Triangle(triBase: 12, triHeight: 7);

            Console.WriteLine($"Triangle 1 Area = {newTriangle1.Area()}");
            Console.WriteLine($"Triangle 2 Area = {newTriangle2.Area()}");
            Console.WriteLine($"Triangle 3 Area = {newTriangle3.Area()}");
            Console.WriteLine($"Triangle 4 Area = {newTriangle4.Area()}");
            Console.WriteLine($"Triangle 5 Area = {newTriangle5.Area()}");

            IEnumerable<Triangle> triangles = new List<Triangle>()
            {
                new Triangle {TBase=3,THeight=5,TArea=newTriangle1.Area()},
                new Triangle {TBase=1,THeight=4,TArea=newTriangle1.Area()},
                new Triangle {TBase=5,THeight=8,TArea=newTriangle1.Area()},
                new Triangle {TBase=9,THeight=6,TArea=newTriangle1.Area()},
                new Triangle {TBase=12,THeight=7,TArea=newTriangle1.Area()}
                //need to fix number of parameters accepted
            };

            IEnumerable<Triangle> query = from t in triangles
                                             where t.TArea > 10
                                             orderby t.TArea ascending
                                             select t;

            foreach (Triangle triangle in query)
            {
                Console.WriteLine(triangles);
                //need to fix what prints to console
            }

            Console.ReadLine();         
        }
    }
}
