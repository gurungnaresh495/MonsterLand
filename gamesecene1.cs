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

        private MonstorFactory aFactory = new MonstorFactory();
        public gamesecene1()

        {
            //often this would be Player.Instance;
            this.aPlayer = player.Theplayer;
            
            this.aPlayer.TheWeapon = new Sword(10, 5);
            
    
            aListOfMonster = aFactory.SpawnMonster(this.aPlayer.Level);

            foreach(var m in aListOfMonster)
            {
                aPlayer.TheWeapon.Use(m);
              
            }

            foreach(var m in aListOfMonster)
            {
                Console.WriteLine(m.toString());
            }

        }

    }

}
