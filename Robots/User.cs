using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class User
    {
        Robot robot;
        Weapon weapon;
        Specifications specifications;

        
        public User()
        {
            specifications = new Specifications();
        }
        
        public void displayWeaponSpecifications()
        {
            Console.WriteLine("Below is a list of weapons along with their specifications: \n");
            specifications.addToWeaponList();
            foreach (Weapon weapon in specifications.weaponList)
            {
                weapon.displaySpecifications();
            }
        }
       
        public void displayRobotSpecifications()
        {
            Console.WriteLine("Below is a list of robots along with their specifications: \n");
            specifications.addToRobotList();
            foreach (Robot robot in specifications.robotList)
            {
                robot.displaySpecifications();
            }             
            
        }
        public void chooseAction(Robot robot, Weapon weapon)
        {
            Console.WriteLine("What would you like to do: move, discharge weapon, or quit? /n");
            string input = Console.ReadLine();
            switch(input)
            {
                case "move":
                    robot.moveRobot();
                    this.chooseAction(robot,weapon);
                    break;
                case "discharge weapon":
                    weapon.dischargeWeapon(weapon);
                    this.chooseAction(robot,weapon);
                    break;
                case "quit":
                    Console.WriteLine("Goodbye.");
                    Console.ReadKey();
                    break;
                default:
                    this.chooseAction(robot,weapon);
                    break;
                                    
            }
        }

        public Weapon chooseWeapon()
        {
            Console.WriteLine("Choose a weapon. \n");
            string input = Console.ReadLine();
            string weaponChoice = input.ToLower();
            switch (weaponChoice)
            {
                case "acid hose":
                    weapon = new AcidHose();
                    return weapon;
                case "laser gun":
                    weapon = new LaserGun();
                    return weapon;
                case "plasma whip":
                    weapon = new PlasmaWhip();
                    return weapon;
                case "proton quad-cannon":
                    weapon = new ProtonQuadCannon();
                    return weapon;
                default:
                    return chooseWeapon();
            }
        }
        public void displayIntro()
        {
            Console.WriteLine("Welcome to BattleBots Demo. You have your choice of 4 different Robots,");
            Console.WriteLine("and your choice of 4 different weapons with which to arm them. \n");
        }
        public Robot chooseRobot()
        {
            Console.WriteLine("Choose a robot. \n");
            string input = Console.ReadLine();
            string robotChoice = input.ToLower();
            switch(robotChoice)
            {
                case "flying robot":
                    robot = new FlyingRobot();
                    return robot;
                case "swimming robot":
                    robot = new SwimmingRobot();
                    return robot;                    
                case "rolling robot":
                    robot = new RollingRobot();
                    return robot;
                case "walking robot":
                    robot = new WalkingRobot();
                    return robot;
                default:
                    return chooseRobot();
            }            
        }
        public void runGame()
        {
            this.displayIntro();
            this.displayRobotSpecifications();
            this.chooseRobot();
            this.displayWeaponSpecifications();
            this.chooseWeapon();
            this.chooseAction(robot,weapon);
        }

    }
}
