using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class AcidHose : Weapon
    {
        
        public AcidHose()
        {
            name = "acid hose";
            weaponRange = 20;
            weaponStrength = 10;
            weaponSound = "hisssssssssssssss!";
        }
    }
}
