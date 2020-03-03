using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1
{
    // Interface for all the possible weapons
    public interface IWeapon
    {
        int Damage { get; }
        void Use(Monster monster, EnemyFactory enemyFactory, List<Monster> aListOfMonster);
    }
}
