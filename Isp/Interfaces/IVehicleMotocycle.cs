using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isp.Interfaces
{
    internal interface IVehicleMotocycle
    {
        void ConfigureMotocycle(string color, int year, double engine);
        void StartingVehicleMotocycle();
    }
}
