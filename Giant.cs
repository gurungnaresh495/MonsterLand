using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1
{
    //Giant class inherits from parent Monster class which implements IMonster
    public class Giant : Monster
    {
        //For now Giant does not have extra features so the constructor has only
        // Console.Writeline
        public Giant(int health, int level,int armour) : base (
                            health, level, armour)
        {
            Console.WriteLine("Giant with health:" + health + " and level:" + level + " created.");
        }

        //overriding default ToString method
        public override string ToString()
        {
            return " Monster type: Giant \n level: " + Level +" \nhealth: " +
                Health + "\n armour: " + Armour +"\n" ;
        }
    }

    
    
}



 