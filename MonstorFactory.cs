using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1
{
    public class MonstorFactory
    {
        private int _areaLevel;
        private Stack<Zombie> _zombiesPool = new Stack<Zombie>();
        private Stack<Werewolf> _werewolvesPool = new Stack<Werewolf>();
        private Stack<Giant> _giantsPool = new Stack<Giant>();
		
		// gets and sets
		public int AreaLevel { get => _areaLevel; }

		// constructor
        public EnemyFactory(int areaLevel)
        {
            _areaLevel = areaLevel;
            PreLoadZombies();

        }
		
		// ***********************************************************
		// The next two methods go together but could easily be made one method
		// It is only two methods because ** in theory ** the number of zombies
		// and how tough they are could be tweaked separately
		// You yourself can just use one method that does both things
		// ***********************************************************
        private void PreLoadZombies()
        {
			// this code would be unique to you and could be much simpler
			// this method GetZombieStatus just makes the zombies tougher
			// as the level goes up
            int count;
            int health;
            int armor;
            int level;

            if (_areaLevel < 3)
            {
                count = 15;
            }
            else if (_areaLevel >= 3 && _areaLevel < 10)
            {
                count = 50;
            }
            else
            {
                count = 200;
            }
			
            (health, level, armor) = GetZombieStatus(_areaLevel);
			
            for (int i=0; i<count; i++)
            {
                _zombiesPool.Push(new Zombie(health, level, armor));
            }
        }
		
		private (int health, int level, int armor) GetZombieStatus(int areaLvl)
        {
            int health, armor, level;
			
            if (areaLvl < 3)
            {
                health = 100;
                level = 2;
                armor = 15;
            }
            else if (areaLvl >= 3 && areaLvl < 10)
            {
                health = 200;
                level = 5;
                armor = 15;
            }
            else
            {
                health = 300;
                level = 8;
                armor = 15;
            }
            return (health, level, armor);
        }
		// ***********************************************************
		// This is the method you call whenever you need a zombie
		// instead of using the New keyword
		// ***********************************************************


        public Zombie SpawnZombie(int areaLevel)
        {
            if(_zombiesPool.Count > 0)
            {
                return _zombiesPool.Pop();
            }
            else
            {
                throw new Exception("Zombies pool depleted");
            }
        }
		
		// ***********************************************************
		// This is the method you call whenever you need a "Dead" zombie
		// to be put back on the stack and reset
		// ***********************************************************



        public void ReclaimZombie(Zombie zombie)
        {
            (int health, int level, int armor) = GetZombieStatus(_areaLevel);
            zombie.Health = health;
            zombie.Armor = armor;
			zombie.Alive = true;
            _zombiesPool.Push(zombie);
        }

        public List<Imonster> SpawnMonster(int aLevel)
        {

            List<Imonster> aListOfMonsters = new List<Imonster>();

            if (aLevel < 10)
            {

                int i = 0;
                while (i < 10)
                {
                    aListOfMonsters.Add(new Zombie(100, 10, 100));
                    i++;
                        
         

                }

            } else if (aLevel < 20)
            {
                int i = 0;
                int j = 0;
        

                while (i <10)
                {
                    aListOfMonsters.Add(new Zombie(200, 20, 100));
                    i = i + 1;
                }
                while (j < 10)
                {
                    aListOfMonsters.Add(new Giant(200, 20, 100));
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
                    aListOfMonsters.Add(new Zombie(300, 30, 100));
                    i = i + 1;
                }
                while (j < 10)
                {
                    aListOfMonsters.Add(new Giant(300, 30, 100));
                    j = j + 1;
                }
                while (k < 10)
                {
                    aListOfMonsters.Add(new Werewolf(300, 30, 100));
                    k = k + 1;
                }


            }
            return aListOfMonsters;
        }

      

    }
        
}
