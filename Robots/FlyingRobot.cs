using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class FlyingRobot : Robot
    {
        public FlyingRobot()
        {
            name = "flying robot";
            modeOfTransport = "Flying";
            speed = 9;
            specialPower = "Super-sight";
            numberOfAppendages = 2;
        }
    }
}
