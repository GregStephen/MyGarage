using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.Vehicles
{
    enum Color 
    {
        Red,
        Blue,
        White,
        Green,
        Orange,
        Silver,
        Black,
        Tan,
        Grey,
        Yellow
    }
    abstract class Vehicle
    {
        public int FuelCapacity { get; set; }
        public Color Color { get; set; }
        public int PassengerOccupancy { get; set; }
        public int FuelLevel { get; set; }
        public string TypeOfVehicle { get; set; }

        public virtual void Refuel()
        {
            FuelLevel = FuelCapacity;
            Console.WriteLine("All fueled up!");
        }

        public virtual bool Go()
        {
            if (FuelLevel >= 5)
            {
                FuelLevel -= 5;
                return true;
            }
            else
            {
                Console.WriteLine("You don't have enough gas. Maybe try refueling first");
                return false;
            }
            
        }
        public abstract void Stop();
    }
}
