using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1
{
    public class Werewolf: Monster
    {
        public Werewolf(int health, int level, int armour) : base(
                            health, level, armour)
        {
            Console.WriteLine("Werewolf with health:" + health + " and level:" + level + " created.");
        }

        public override string ToString()
        {
            return " Monster type: Werewolf \n level: " + Level + " \nhealth: " +
                Health + "\n armour: " + Armour;
        }
    }
}