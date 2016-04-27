using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class Weapon
    {
        public string name;
        public int weaponRange;
        public int weaponStrength;
        public string weaponSound;
       
        
        public Weapon()
        {
            
           
        }

        
        public void displaySpecifications()
        {
            Console.WriteLine(this.name);
            Console.WriteLine("Range: {0}",this.weaponRange);
            Console.WriteLine("Strenght: {0}", this.weaponStrength);
            Console.WriteLine("Sound: {0}",this.weaponSound);
            Console.WriteLine("");
        }
        public void dischargeWeapon(Weapon weapon)
        {
            string sound = weapon.weaponSound;
            Console.WriteLine(sound);
        }

        public string displayName()
        {
            return (this.name);
        }
    }
    
}
 