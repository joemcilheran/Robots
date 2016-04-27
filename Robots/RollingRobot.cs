using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class RollingRobot : Robot
    {
        
        public RollingRobot()
        {
            name = "rolling robot";
            modeOfTransport = "rolling";
            speed = 5;
            specialPower = "temporal displacement";
            numberOfAppendages = 2;
        }
    }
}
