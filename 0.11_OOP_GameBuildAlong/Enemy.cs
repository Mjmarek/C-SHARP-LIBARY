using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_OOP_GameBuildAlong
{
    class Enemy : Character
    {
        public Enemy(string name, int level)
        {
            this.Name = name;
            this.IsAlive = true;
            this.Health = 100;
            this.Level = 1;
            this.AttackPower = 16;
            this.CritChance = 0.50;
        }

        public string TauntStrong => "I'm going to send you straight into the public void!";
        public string TauntLessStrong => "Your attacks are such CRUD!";
        public string TauntWeak => "That hit sent me FOR a LOOP!";
        public string TauntMoreWeak => "You're overloading my methods!";
        
        public string Taunt(int heroHealth)
        {
            var healthDiff = Health - heroHealth;

            if (healthDiff >= 7)
                return TauntStrong;
            if (healthDiff > 1)
                return TauntLessStrong;
            if (healthDiff >= -7 )
                return TauntWeak;
           else
                return TauntMoreWeak;
        }
    }
}
