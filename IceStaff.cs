using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1
{
    class IceStaff: IWeapon
    {
        private int roundsParalyzed;
        private readonly int damage;

        public IceStaff(int damage, int rounds)
        {
            this.damage = damage;
            this.roundsParalyzed = rounds;
        }

        public int Damage
        {
            get { return this.damage; }
        }

        public int RoundsParalyzed
        {
            get { return this.roundsParalyzed; }
        }

        public void Use(Imonster monster)
        {
            monster.damageRecieved(this.damage, 0);
            monster.RoundsParalyzed = roundsParalyzed;
            monster.Paralyzed = true;
        }
    }
}
