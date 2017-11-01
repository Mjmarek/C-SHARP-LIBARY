using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_MethodsOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Player class with 1 Attack() method that accept 3 different sets of parameters
            //Example:
            //Attack(100) -> "Attacked for 100!"
            //Attack(100, "Weapon") -> "Attacked with Weapon for 100"
            //Attack(100, "Weapon", #ofTimes) -> "Attacked with Weapon for 100 #ofTimes, dealing totalDamage."

            Player me = new Player();
            me.Attack(2500);
            me.Attack(1000, "dusty stick");
            me.Attack(500, "Katana", 3);

            Console.ReadLine();
        }
    }
}
