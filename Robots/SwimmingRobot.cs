using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class SwimmingRobot : Robot
    {

        public SwimmingRobot()
        {
            name = "swimming robot";
            modeOfTransport = "swimming";
            speed = 2;
            specialPower = "tsunami creator";
            numberOfAppendages = 1;
        }
    }
}
