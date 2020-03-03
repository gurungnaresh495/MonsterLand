using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1
{
    public class Zombie:Monster
    {
        public Zombie(int health, int level, int armour) : base(
                            health, level, armour)
        {
            Console.WriteLine("Zombie with health:" + health + " and level:" + level + " created.");
        }

        public override string  ToString()
        {
            return "Monster type: Zombie, level: " + Level + ", health: " +
                Health + ", armour: " + Armour ;
        }
    }
}