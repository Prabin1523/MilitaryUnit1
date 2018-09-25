using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponSystems.Vehicles
{
    public class Aircraft : Vehicle

    {
        public virtual void Fly()
        {
            Console.WriteLine("Aircraft is flying.");
        }


        public override void Move()
        {

            Fly();
        }


        public override void Start()
        {
            Console.WriteLine("Aircraft engine spin up. ");
        }


        public override void Fuel()
        {
            Console.WriteLine("Aircraft Filled with JP-8.");
        }


        public override void Maintain()
        {
            Console.WriteLine("Aircraft is down for months at the intermediate maintenance center. ");
        }
    }
}
