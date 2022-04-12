using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.AbstractClass
{
    abstract class Transport
    {

        public void StartTransport()
        {
            IVehicles vehicles = CreateTransport();
            Console.WriteLine(vehicles);
            vehicles.StartRoute();
        }


        protected abstract IVehicles CreateTransport();
    }
}
