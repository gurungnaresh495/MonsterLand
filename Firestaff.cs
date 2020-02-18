using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1
{
    class Firestaff: IWeapon
    {
        private int fireDamage;
        private readonly int damage;

        public Firestaff(int damage, int fireDamage)
        {
            this.damage = damage;
            this.fireDamage = fireDamage;
        }

        public int Damage
        {
            get { return this.damage; }
        }

        public int FireDamage
        {
            get { return this.fireDamage; }
        }
        
        public void Use (Imonster monster)
        {
            monster.damageRecieved(this.damage, this.fireDamage);
        }
    }
}
