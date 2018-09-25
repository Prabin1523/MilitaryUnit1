using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponSystems.Vehicles.Aircrafts
{
     public class Helicoptor : Aircraft
    {
        public override void Fly()
        {
            Console.WriteLine("Whoppa Whoppa Whoppa Whoppa");
        }


        public override void Start()
        {
            Console.WriteLine("Helicoptor turbines spin up. ");
        }


        public override void Maintain()
        {
            Console.WriteLine("Helicoptor is all over the hanger floor. ");
        }
    }
}
