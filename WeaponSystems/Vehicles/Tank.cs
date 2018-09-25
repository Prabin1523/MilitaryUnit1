using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponSystems
{
    public class Tank : Vehicle
    {
        public void Shoot()
        {
            Console.WriteLine("The tank goes, \"BOOOOM\"");
        }

        public void Reload()
        {
            Console.WriteLine("The tank is full of rounds ");
        }
        public override void Move()
        {

            Console.WriteLine("Tank runs on treads");
        }


        public override void Start()
        {
            Console.WriteLine("You turn the mechanical switch. ");
        }


       

    }
}
