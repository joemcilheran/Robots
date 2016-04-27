using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class LaserGun : Weapon
    {
        
        public LaserGun()
        {
            name = "laser gun";
            weaponRange = 50;
            weaponStrength = 10;
            weaponSound = "Pew! Pew! Pew!";
        }
    }
}
