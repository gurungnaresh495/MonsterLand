using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1
{

    //AKA the Scene MAnager for the first Game Level

    public class gamesecene1
    {
        private player aPlayer;
        //having a Concrete class in the List would Voilate SOLID
        //we would limited to only gaints
        //private List <> alistOfMonsters = new List<>();
        List<Monster> aListOfMonster = new List<Monster>();
        private MonsterFactory aFactory = new MonsterFactory();
        private EnemyFactory thefactory = new EnemyFactory(22); 

        public EnemyFactory Thefactory
        {
            get { return thefactory; }
        }

        // Constructor which acts as a gamescene and instantiate 
        public gamesecene1()
        {
            //often this would be Player.Instance;
            this.aPlayer = player.Theplayer;
            //giving a player sword 
            this.aPlayer.TheWeapon = new Sword(15, 8);
            
            //calling the spawnMonster method of MonsterFactory class 
            // according to player level
            aListOfMonster = aFactory.SpawnMonster(aPlayer.Level, thefactory);
            while (aListOfMonster.Count >= 1)
            {
                
                for (int i = 0; i < aListOfMonster.Count; i++)
                {
                    
                    Monster m = aListOfMonster[i];
                    
                    aPlayer.TheWeapon.Use(m, thefactory, aListOfMonster);
               
                }
                //checking the monsters who are alive
                foreach (var m in aListOfMonster)
                {
                    Console.WriteLine(m.ToString());
                }
                


            }
        }

    }

}
