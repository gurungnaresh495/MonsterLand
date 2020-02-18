using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1
{
    class Sword : IWeapon
    {
        private int armour_damage;
        private readonly int damage;

        public int Damage
        { 
              get { return this.damage; }
        }

        public int Armour_damage
        {
            get { return this.armour_damage;  }
        }

        public Sword(int damage, int armour_damage)
        {
            this.damage = damage;
            this.armour_damage = armour_damage;
        }

        public void Use(Imonster monster)
        {
            monster.damageRecieved(this.damage, this.armour_damage);

        }


    }
}
