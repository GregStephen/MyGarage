﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.Vehicles.WatercraftClasses
{
    abstract class Watercraft : Vehicle, IFloater
    {
        public override bool Go()
        { 
            var didItGo = base.Go();
            if (didItGo)
            {
                Console.WriteLine($"The {TypeOfVehicle} drives forward with {PassengerOccupancy} passengers aboard!");
                return true;
            }
            return false;
            
        }

        public override void Stop()
        {
            Console.WriteLine($"The {TypeOfVehicle} comes to a stop");
        }
        public void Sink()
        {
            Console.WriteLine($"Aw fuck the {TypeOfVehicle} is fucking sinking dude!");
        }
    }
}
