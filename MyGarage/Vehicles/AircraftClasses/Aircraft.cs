using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.Vehicles.AircraftClasses
{
    abstract class Aircraft : Vehicle
    {
        public override bool Go()
        {
            var didItGo = base.Go();
            if (didItGo)
            {
                Console.WriteLine($"The {TypeOfVehicle} flew thru the air with {PassengerOccupancy} passengers aboard!");
                return true;
            }
            return false;
        }
        public override void Stop()
        {
            Console.WriteLine("The aircraft lands!");
        }
    }
}
