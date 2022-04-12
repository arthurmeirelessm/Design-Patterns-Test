using FactoryMethod.AbstractClass;
using FactoryMethod.Interfaces;
using FactoryMethod.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FactoryMethod.Factories
{
    internal class MotocycleTransport : Transport
    {
        protected override IVehicles CreateTransport()
        {
            return new Motocycle();
        }
    }
}
