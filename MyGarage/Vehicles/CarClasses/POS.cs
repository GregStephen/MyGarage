using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.Vehicles.CarClasses
{
    class POS : Car
    {
        public POS(int fuelCapacity, Color color, int passengerOccupancy)
        {
            FuelCapacity = fuelCapacity;
            Color = color;
            PassengerOccupancy = passengerOccupancy;
            FuelLevel = fuelCapacity;
            TypeOfVehicle = "piece of shit";
        }

        public void BreakDown()
        {
            Console.WriteLine("Surprise surprise, it broke down again");
        }
    }
}
