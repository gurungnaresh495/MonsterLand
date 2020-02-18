using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1
{
    public interface Imonster
    {

        int Health { get; set; }
        int Level { get; }
        int FireDamage { get; set; }
        bool Paralyzed { get; set; }
        int RoundsParalyzed { get; set; }
        
        bool Alive { get; set; }


        void Attack(player aPlayer);
        void Defend(player aPlayer);
        void damageRecieved(int damage, int armourDamage);
        string toString();
    }
}
