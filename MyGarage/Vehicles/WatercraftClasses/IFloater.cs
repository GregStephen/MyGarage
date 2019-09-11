using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.Vehicles.WatercraftClasses
{
    interface IFloater : IDrive
    {
        void Sink();
    }
}
