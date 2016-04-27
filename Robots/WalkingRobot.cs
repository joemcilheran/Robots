using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class WalkingRobot : Robot
    {

        public WalkingRobot()
        {
            name = "walking robot";
            modeOfTransport = "walking";
            speed = 7;
            specialPower = "blinding flash";
            numberOfAppendages = 4;
        }
    }
}
