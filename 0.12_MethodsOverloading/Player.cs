using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_MethodsOverloading
{
    class Player
    {
        //Since we are not returning anything and just writing to the console, we use "void"
        //If we wanted to return something, then we would need to specify a type and not use void
        //The thing that we return is specified by a type
        public void Attack(int damage)
        {
            Console.WriteLine($"Attacked for {damage}!");
        }

        public void Attack(int damage, string weapon)
        {
            Console.WriteLine($"Attacked with {weapon} for {damage}!");
        }

        public void Attack(int damage, string weapon, int hitTimes)
        {
            int totalDamage = damage * hitTimes;
            Console.WriteLine($"Attacked with {weapon} {hitTimes} times for {totalDamage}!");
        }
    }
}
