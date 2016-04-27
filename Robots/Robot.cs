using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class Robot
    {
        public string name;
        public string modeOfTransport;
        public int speed;
        public string specialPower;
        public int numberOfAppendages;


        public Robot()
        {

        }

        public void displaySpecifications()
        {

            Console.WriteLine(this.name);
            Console.WriteLine("Mode of Transport: {0}", this.modeOfTransport);
            Console.WriteLine("Speed: {0}", this.speed);
            Console.WriteLine("Special Power: {0}", this.specialPower);
            Console.WriteLine("Number of Appendages: {0}", this.numberOfAppendages);
            Console.WriteLine("");
        }

        public void moveRobot()
        {
            Console.WriteLine("Robot is {0}", this.modeOfTransport);

        }
        public string displayName()
        {
            return (this.name);
        }
       

        
    }
}
