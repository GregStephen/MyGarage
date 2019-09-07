using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.Vehicles.AircraftClasses
{
    class Boeing737 : Aircraft
    {
        public Boeing737(int fuelCapacity, Color color, int passengerOccupancy)
        {
            FuelCapacity = fuelCapacity;
            Color = color;
            PassengerOccupancy = passengerOccupancy;
            FuelLevel = fuelCapacity;
            TypeOfVehicle = "Boeing 737";
        }
       
        public void KickOffPassenger()
        {
            if (PassengerOccupancy > 0)
            {
                Console.WriteLine("Kick that disruptive mother fucker OFF");
                PassengerOccupancy -= 1;
            }
            else
            {
                Console.WriteLine("There's noone on this plane to kick off, cheif");
            }
        }
    }
}
