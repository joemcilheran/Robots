using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class ProtonQuadCannon : Weapon
    {

        public ProtonQuadCannon()
        {
            name = "proton quad-cannon";
            weaponRange = 80;
            weaponStrength = 20;
            weaponSound = "Boom! Boom! Boom! Boom!";
        }
    }
}
