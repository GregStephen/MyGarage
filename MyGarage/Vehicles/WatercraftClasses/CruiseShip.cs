using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.Vehicles.WatercraftClasses
{
    class CruiseShip : Watercraft
    {
        public CruiseShip(int fuelCapacity, Color color, int passengerOccupancy)
        {
            FuelCapacity = fuelCapacity;
            Color = color;
            PassengerOccupancy = passengerOccupancy;
            FuelLevel = fuelCapacity;
            TypeOfVehicle = "cruise ship";
        }
        public void GivePassengersFoodPoisioning()
        {
            if (PassengerOccupancy > 0)
            {
                Random rnd = new Random();
                var numberOfPassengersWhoJumped = rnd.Next(1, PassengerOccupancy);
                Console.WriteLine($"You made them all sick, {numberOfPassengersWhoJumped} people jumped overboard");
                PassengerOccupancy -= numberOfPassengersWhoJumped;
            }
            else
            {
                Console.WriteLine("There's noone onboard to make sick");
            }
        }

    }
}
