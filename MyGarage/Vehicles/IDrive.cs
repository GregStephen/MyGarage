using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.Vehicles
{
    interface IDrive
    {
        bool Go();
        void Stop();
        void Refuel();
    }
}
