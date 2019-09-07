using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.Vehicles.WatercraftClasses
{
    class JetSki : Watercraft
    { 
        public JetSki(int fuelCapacity, Color color, int passengerOccupancy)
        {
            FuelCapacity = fuelCapacity;
            Color = color;
            PassengerOccupancy = passengerOccupancy;
            FuelLevel = fuelCapacity;
            TypeOfVehicle = "jet ski";
        }

    }
}
