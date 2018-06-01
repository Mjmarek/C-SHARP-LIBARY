using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            Car.MyMethod();

            /*
            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";
            */

            Car myThirdCar = new Car("Ford", "Escape", 2005, "White");

            Car myOtherCar;
            myOtherCar = myCar;

            Console.WriteLine("{0} {1} {2} {3}",
                myOtherCar.Make,
                myOtherCar.Model,
                myOtherCar.Year,
                myOtherCar.Color);

            myOtherCar.Model = "98";

            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            myOtherCar = null;
            //code below will result in exception because we are trying to reference an object in memory
            //that no longer has the specified "handle" or pointer attached to it
            //because variable has been set to null

            /*
            Console.WriteLine("{0} {1} {2} {3}",
                myOtherCar.Make,
                myOtherCar.Model,
                myOtherCar.Year,
                myOtherCar.Color);
            */

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        //constructor - method that allows developer to execute code when new instance of a class is created;
        //will put new object in "valid state"/initialize values of the properties of given object
        public Car()
        {
            this.Make = "Nissan"; //will be set to "Nissan" by default when new instance is created
            //"this" is optional keyword here; part of declaration of class itself
        }

        //example of overloaded constructor:
        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        //static methods are available without first requiring you to create an instance of a class
        //can't reference any specific instances in a static method because it's an instance member
        public static void MyMethod()
        {
            Console.WriteLine("Called the static MyMethod");
        }

        //difference between working with classes that have static members vs instance members.
        //instance members work with specific instance of object
        //static members aren't tied to a specific instance; don't depend on state of given instance
    }
}