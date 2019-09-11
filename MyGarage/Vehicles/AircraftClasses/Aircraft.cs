using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.Vehicles.AircraftClasses
{
    abstract class Aircraft : Vehicle, IFlyer
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
        public void Chemtrails()
        {
            Console.WriteLine($"The {TypeOfVehicle} is spreading a thick smoke behind it to help the citizens obey");
        }
    }
}
