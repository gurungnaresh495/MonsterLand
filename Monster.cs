using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1
{
    public class Monster : Imonster
    {
        private int health;
        private int fireDamage = 0;
        private int armour;
        private bool paralyzed = false;
        private int roundsParalyzed =0;
        private bool alive = true;
        private readonly int level;

        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }

        public int Level
        {
            get { return this.level; }
        }

        public int FireDamage
        {
            get { return this.fireDamage; }
            set { this.fireDamage = value; }
        }

        public int Armour
        {
            get { return this.armour; }
            set
            {
                if (value >= 0)
                { this.armour = value; }
                else
                {
                    this.armour = 0;
                }
            }
        }

        public bool Paralyzed
        {
            get { return this.paralyzed; }
            set { this.paralyzed = value; }
        }

        public int RoundsParalyzed
        {
            get { return this.roundsParalyzed; }
            set { this.roundsParalyzed = value; }
        }
        

        public bool Alive
        {
            get { return this.alive; }
            set { this.alive = value; }
        }


        public Monster(int health, int level, int armour)
        {
            this.health = health;
            this.level = level;
            this.armour = armour;

        }
        
        public void damageRecieved(int damage, int armourDamage)
        {
            if (this.armour == 0)
            {
                if (this.health <= (damage + armourDamage))
                {
                    Health = 0;
                    Alive = false;
                }
                else
                {
                    Health -= (damage + armourDamage);
                }

            }
            else
            {
                if (armourDamage <= Armour)
                {
                    Armour -= damage;
                    if (damage >= this.health)
                    {
                        this.health = 0;
                        this.alive = false;
                    }
                    else
                    {
                        this.health -= damage;
                    }
                }
                else
                {
                    damage += (armourDamage - Armour);
                    if (damage > Health)
                    {
                        Health = 0;
                    }
                    else
                    {
                        Health -= damage;
                    }
                }
            }
        }

        public void Attack(player Player)
        {
            Console.WriteLine("Giant Attacks: " + Player.Nmae);
        }



        public void Defend(player Player)
        {
            Console.WriteLine("Giant defends from " + Player.Nmae);
        }


        public virtual string toString()
        {
            return " ger";
        }

    }
}
