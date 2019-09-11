using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.Vehicles.CarClasses
{
    interface IDriver : IDrive
    {
        void Crash();
    }
}
