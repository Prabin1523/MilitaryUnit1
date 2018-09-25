using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponSystems;
using WeaponSystems.Vehicles;
using WeaponSystems.Vehicles.Aircrafts;

namespace MilitaryUnit1
{
    class Program 
    {
        private static object tanks;

        static void Main(string[] args)
        {

            Aircraft a10 = new Plane();
            Plane f22 = new Plane();
            Aircraft hh60 = new Helicoptor();
            Helicopter ah64 = new Helicoptor();

            Tank m1 = new Tank();
            Vehicle tank = new Tank();
            Firearm m1911 = new Firearm();

            m1911.Shoot();
            m1.Shoot();

            a10.Fly();
            f22.Move();
            ah64.Maintain();
            tank.Fuel();


        }
    }
}
