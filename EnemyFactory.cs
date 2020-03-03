using System;
using System.Collections.Generic;

namespace game1
{
    public class EnemyFactory
    {
        private int _areaLevel;

        //stacks for preloading monsters to avoid creating new object every time we need 
        // a monster
        private Stack<Monster> _zombiesPool = new Stack<Monster>();
        private Stack<Monster> _werewolvesPool = new Stack<Monster>();
        private Stack<Monster> _giantsPool = new Stack<Monster>();

        // gets and sets
        public int AreaLevel { get => _areaLevel; }

        // constructor
        public EnemyFactory(int areaLevel)
        {
            _areaLevel = areaLevel;
            PreLoadZombies();
            PreLoadGiants();
            PreLoadWerewolves();
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

            for (int i = 0; i < count; i++)
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


        public Monster SpawnZombie(int areaLevel)
        {
            if (_zombiesPool.Count > 0)
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



        public void ReclaimZombie(Monster zombie)
        {
            (int health, int level, int armor) = GetZombieStatus(_areaLevel);
            zombie.Health = health;
            zombie.Armour = armor;
            zombie.Alive = true;
            _zombiesPool.Push(zombie);
            
        }


        private void PreLoadGiants()
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

            (health, level, armor) = GetGiantStatus(_areaLevel);

            for (int i = 0; i < count; i++)
            {
                _giantsPool.Push(new Giant(health, level, armor));
            }
        }

        private (int health, int level, int armor) GetGiantStatus(int areaLvl)
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
        // This is the method you call whenever you need a giant
        // instead of using the New keyword
        // ***********************************************************


        public Monster SpawnGiant(int areaLevel)
        {
            if (_giantsPool.Count > 0)
            {
                return _giantsPool.Pop();
                
            }
            else
            {
                throw new Exception("Giant pool depleted");
            }
        }

        // ***********************************************************
        // This is the method you call whenever you need a "Dead" giant
        // to be put back on the stack and reset
        // ***********************************************************



        public void ReclaimGiant(Monster giant)
        {
            (int health, int level, int armor) = GetGiantStatus(_areaLevel);
            giant.Health = health;
            giant.Armour = armor;
            giant.Alive = true;
            _giantsPool.Push(giant);
            
        }

        // ***********************************************************
        // This is the method you call whenever you need a zombie
        // instead of using the New keyword
        // ***********************************************************

        private void PreLoadWerewolves()
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

            (health, level, armor) = GetWerewolfStatus(_areaLevel);

            for (int i = 0; i < count; i++)
            {
                _werewolvesPool.Push(new Werewolf(health, level, armor));
            }
        }

        private (int health, int level, int armor) GetWerewolfStatus(int areaLvl)
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

        public Monster SpawnWereWolf(int areaLevel)
        {
            if (_werewolvesPool.Count > 0)
            {
                return _werewolvesPool.Pop();
            }
            else
            {
                throw new Exception("Werewolves pool depleted");
            }
        }

        // ***********************************************************
        // This is the method you call whenever you need a "Dead" zombie
        // to be put back on the stack and reset
        // ***********************************************************



        public void ReclaimWerewolf(Monster werewolf)
        {
            (int health, int level, int armor) = GetWerewolfStatus(_areaLevel);
            werewolf.Health = health;
            werewolf.Armour = armor;
            werewolf.Alive = true;
            _werewolvesPool.Push(werewolf);
        }
    }
}
