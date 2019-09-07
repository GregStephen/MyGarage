using System;
using MyGarage.Vehicles;
using MyGarage.Vehicles.AircraftClasses;
using MyGarage.Vehicles.CarClasses;
using MyGarage.Vehicles.WatercraftClasses;
namespace MyGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new POS(10, Color.Black, 2);
            car.Go();
            car.Go();
            car.Go();
            car.Stop();
            car.Refuel();
            var jet = new PrivateJet(200, Color.Blue, 10);
            jet.Go();
            var bigBoy = new Boeing737(3000, Color.Orange, 235);
            bigBoy.Go();
            bigBoy.KickOffPassenger();
            bigBoy.Go();
            var disneyCruise = new CruiseShip(2500, Color.Silver, 250);
            disneyCruise.Go();
            disneyCruise.GivePassengersFoodPoisioning();
            disneyCruise.Go();
        }
    }
}
