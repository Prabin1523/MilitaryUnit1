using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponSystems
{
   public class Firearms
    {
        public virtual void Shoot()
        {
            Console.WriteLine("pew pew");
        
        }

        public virtual void Clean()
        {
            Console.WriteLine("Firearm is clean enough to eat. ");

        }

        public virtual void Reload()
        {
            Console.WriteLine("Firearm is full of rounds. ");
        }
    }
}
