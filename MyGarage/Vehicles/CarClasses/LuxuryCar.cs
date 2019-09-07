using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.Vehicles.CarClasses
{
    class LuxuryCar : Car
    {
        public LuxuryCar(int fuelCapacity, int passengerOccupancy)
        {
            FuelCapacity = fuelCapacity;
            Color = Color.Black;
            PassengerOccupancy = passengerOccupancy;
            FuelLevel = fuelCapacity;
            TypeOfVehicle = "Luxury Car";
        }

        public void SelfPark()
        {
            Console.WriteLine("The car parked itself.");
        }
    }
}
