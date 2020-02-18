using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1
{
    public sealed class player
    {
        // this class is sealed so that we cannot make a subclass
        // a subclass would have its own constuctor
        // which woukd break liskoff's rule
        //i.e the subclass could have more that one instance 

        private int level = 0;
        private string name = "n/a";

        // this must be static because the constuctor is static
        // and the constuctor os static becasue we want the limit
        //what code is allowed to call this constuctor

        private static readonly player theplayer;
        private IWeapon theWeapon;

        public string Nmae
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public IWeapon TheWeapon
        {
            set { this.theWeapon = value; }
            get { return this.theWeapon; }
        }

        public int Level
        {
            get { return this.Level; }
            set { this.Level = value; }
        }

        public static player Theplayer
        {
            get
            {
                return theplayer;
            }
        }
         private player()
         {
            // This could have code in it, but is unlikely 
         }

         static player()
         {
            //if(theplayer.Equals(null))
            // we do not need if statement becasue our static object is not empty
            theplayer = new player();

            //theplayer.name = aName;
            //theplayer.level = aLevel;

         }

    }
}
