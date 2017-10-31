using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_OOP_Game
{
    //Player inherited properties from Character with ":"
    class Player: Character
    {
        //Enums
        public enum Specialization
        {
            HorseMange = 1,
            TrollCat = 2,
            KnightTemplatetor = 3,
            Demogorg = 4,
            SireCena = 5
        }
    }
}
