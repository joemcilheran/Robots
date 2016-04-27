using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    
    class Specifications
    {
        public List<Robot> robotList;
        public List<Weapon> weaponList;
        FlyingRobot flyingRobot;
        SwimmingRobot swimmingRobot;
        RollingRobot rollingRobot;
        WalkingRobot walkingRobot;
        AcidHose acidHose;
        LaserGun laserGun;
        PlasmaWhip plasmaWhip;
        ProtonQuadCannon protonQuadCannon;

        public Specifications()
        {
            flyingRobot = new FlyingRobot();
            swimmingRobot = new SwimmingRobot();
            rollingRobot = new RollingRobot();
            walkingRobot = new WalkingRobot();
            acidHose = new AcidHose();
            laserGun = new LaserGun();
            plasmaWhip = new PlasmaWhip();
            protonQuadCannon = new ProtonQuadCannon();
            robotList = new List<Robot>();
            weaponList = new List<Weapon>();
        }
        public void addToWeaponList()
        {
            weaponList.Add(acidHose);
            weaponList.Add(laserGun);
            weaponList.Add(plasmaWhip);
            weaponList.Add(protonQuadCannon);
        }
        public void addToRobotList()
        {
            robotList.Add(flyingRobot);
            robotList.Add(swimmingRobot);
            robotList.Add(rollingRobot);
            robotList.Add(walkingRobot);
        }
    }
}
