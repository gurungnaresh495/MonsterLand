using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1
{
    public class MonsterFactory
    {
        public List<Imonster> SpawnMonster(int aLevel, EnemyFactory enemyFactory)
        {
            List<Imonster> aListOfMonsters = new List<Imonster>();
            // We could throw the if statement below into another class
            // and use the strategy method to replace the if statement
            // as we experimented with difficulty levels
            

            if (aLevel < 10)
            {
                int i = 0;

                while (i < 10)
                {
                    aListOfMonsters.Add(enemyFactory.SpawnZombie(aLevel));
                    i = i + 1;
                }


            }
            else if (aLevel < 20)
            {
                int i = 0;
                int j = 0;

                while (i < 10)
                {
                    aListOfMonsters.Add(enemyFactory.SpawnZombie(aLevel));
                    i = i + 1;
                }
                while (j < 10)
                {
                    aListOfMonsters.Add(enemyFactory.SpawnGiant(aLevel));
                    j = j + 1;
                }

            }
            else
            {
                int i = 0;
                int j = 0;
                int k = 0;

                while (i < 10)
                {
                    aListOfMonsters.Add(enemyFactory.SpawnZombie(aLevel));
                    i = i + 1;
                }
                while (j < 10)
                {
                    aListOfMonsters.Add(enemyFactory.SpawnGiant(aLevel));
                    j = j + 1;
                }
                while (k < 10)
                {
                    aListOfMonsters.Add(enemyFactory.SpawnWereWolf(aLevel));
                    k = k + 1;
                }

            }

            return aListOfMonsters;

        }

    }
}
