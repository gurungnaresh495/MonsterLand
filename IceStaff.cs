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

        public void Use(Monster monster, EnemyFactory enemyFactory, List<Monster> aListOfMonster)
        {
            monster.damageRecieved(this.damage, 0);
            if (monster.Health == 0)
            {
                aListOfMonster.Remove(monster);
                if (monster.GetType().Name == "Zombie")
                {
                    enemyFactory.ReclaimZombie(monster);
                }
                else if (monster.GetType().Name == "Werewolf")
                {
                    enemyFactory.ReclaimWerewolf(monster);
                }
                else
                {
                    enemyFactory.ReclaimGiant(monster);
                }
            }
            else
            {
                monster.RoundsParalyzed = roundsParalyzed;
                monster.Paralyzed = true;
            }
        }
    }
}
