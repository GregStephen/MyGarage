using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.Vehicles.AircraftClasses
{
    class PrivateJet : Aircraft
    {
        public PrivateJet(int fuelCapacity, Color color, int passengerOccupancy)
        {
            FuelCapacity = fuelCapacity;
            Color = color;
            PassengerOccupancy = passengerOccupancy;
            FuelLevel = fuelCapacity;
            TypeOfVehicle = "Private Jet";
        }
      
    }
}
