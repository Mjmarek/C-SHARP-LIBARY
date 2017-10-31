using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_ConstructorsChallenge
{
    class MobilePhone
    {
        public MobilePhone(string phoneMake, string phoneModel)
        {
            this.Make = phoneMake;
            this.Model = phoneModel;
        }

        public string Make { get; set; }
        public string Model { get; set; }

        //Methods
        public void PrintPhone()
        {
            Console.WriteLine($"I own a {this.Make} {this.Model}.");
        }
    }
}
