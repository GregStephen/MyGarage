using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.Vehicles.CarClasses
{
    abstract class Car : Vehicle, IDriver
    {

        public override bool Go()
        {
            var didItGo = base.Go();
            if (didItGo)
            {
                Console.WriteLine($"The {TypeOfVehicle} drove!");
                return true;
            }
            return false;
        }
        public override void Stop()
        {
            Console.WriteLine($"The {TypeOfVehicle} came to a screeching halt.");
        }
        public void Crash()
        {
            Console.WriteLine($"GOD DAMN! That parked car just came out of nowhere! The {TypeOfVehicle} is totaled");
        }
    }
}
