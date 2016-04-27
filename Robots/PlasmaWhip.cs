using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class PlasmaWhip : Weapon
    {
        
        public PlasmaWhip()
        {
            name = "plasma whip";
            weaponRange = 5;
            weaponStrength = 35;
            weaponSound = "Witchaaa!";
        }
    }
}
