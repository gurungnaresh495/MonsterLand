using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1
{
    class Sword : IWeapon
    {
        /* Class Sword 
          * implements IWeapon interface
          * has private attributes for damage and fire damage
          * currently fire damage works as a armour damage
          */
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
        /*
         * Use method for the ice staff
         * this method takes the monster as a parameter and
         * reduces health and armour. if the health of the 
         * monster is 0 then it takes the monster out of the 
         * list and push in the stack for reuse
         */
        public void Use(Monster monster, EnemyFactory enemyFactory, List<Monster> aListOfMonster)
        {
            
            monster.damageRecieved(this.damage, this.armour_damage);
            
            if (monster.Health == 0)
            {
                aListOfMonster.Remove(monster);

                //pushing back to appropriate stack by checking the object type
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
