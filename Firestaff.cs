using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1
{
    /*Class Firestaff 
     * implements IWeapon interface
     * has private attributes for damage and fire damage
     * currently fire damage works as a armour damage
     */
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
        
        /*
         * Use method for the fire staff
         * this method takes the monster as a parameter and
         * reduces health and armour. if the health of the 
         * monster is 0 then it takes the monster out of the 
         * list and push in the stack for reuse
         */
        public void Use (Monster monster, EnemyFactory enemyFactory, List<Monster> aListOfMonster)
        {
            monster.damageRecieved(this.damage, this.fireDamage);
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
            
        }
    }
}
